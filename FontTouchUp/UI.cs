using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;

namespace FontTouchUp
{
    public partial class UI : Form
    {

        private readonly PixelPanel[][] panels = new PixelPanel[16][];
        private int currentChar = 0;

        public UI()
        {
            InitializeComponent();
            for (int x = 0; x < 16; x++)
            {
                panels[x] = new PixelPanel[16];
                for (int y = 0; y < 16; y++)
                {
                    PixelPanel p = new()
                    {
                        Dock = DockStyle.Fill,
                        BackColor = Color.Black,
                        BorderStyle = BorderStyle.FixedSingle
                    };
                    p.Click += PixelPanel_Click;
                    MainGrid.SetColumn(p, x);
                    MainGrid.SetRow(p, y);
                    MainGrid.Controls.Add(p);
                    p.X = x;
                    p.Y = y;
                    p.Status = 0;
                    panels[x][y] = p;
                }
            }
            for (int i = 32; i < 127; i++)
            {
                _ = new BigChar(i - 32);
            }
            LoadFont("default.nicfont");
            RenderCharacter(0);
        }

        private void RenderCharacter(int c)
        {
            currentChar = c;
            BigChar.Chars[c].Refresh();
            for (int x = 0; x < 16; x++)
            {
                for (int y = 0; y < 16; y++)
                {
                    bool on = BigChar.Chars[c].GetPixel(x, y);
                    panels[x][y].Status = on ? 1 : 0;
                    panels[x][y].BackColor = on ? Color.SkyBlue : Color.Black;
                }
            }
        }

        private void PixelPanel_Click(object? sender, EventArgs e)
        {
            if (sender is not PixelPanel panel) return;
            switch (panel.Status)
            {
                case 0:
                    panel.Status = 1;
                    panel.BackColor = Color.SkyBlue;
                    BigChar.Chars[currentChar].SetPixel(panel.X, panel.Y, true);
                    break;
                case 1:
                    panel.Status = 0;
                    panel.BackColor = Color.Black;
                    BigChar.Chars[currentChar].SetPixel(panel.X, panel.Y, false);
                    break;
            }
        }

        private void NUD_CharIndex_ValueChanged(object sender, EventArgs e)
        {
            RenderCharacter((int)NUD_CharIndex.Value);
        }

        private void LoadFont(string fontFileName)
        {
            try
            {
                byte[] data = File.ReadAllBytes(fontFileName);
                if (data.Length != 3040)
                    SetStatus("File length is not correct");
                else
                {
                    Array.Copy(data, 0, BigChar.RawFont, 0, data.Length);
                    RenderCharacter((int)NUD_CharIndex.Value);
                    SetStatus("Font Loaded");
                    BigChar.RefreshAll();
                }
            }
            catch
            {
                SetStatus("Error opening font file");
            }
        }

        private void LoadFontButton_Click(object sender, EventArgs e)
        {
            using var ofd = new OpenFileDialog()
            {
                Title = "Load nicFW Font File",
                Filter = "nicFont Files|*.nicfont|All Files|*.*"
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                LoadFont(ofd.FileName);
            }
        }

        private void SaveFontButton_Click(object sender, EventArgs e)
        {
            using var sfd = new SaveFileDialog()
            {
                Title = "Save nicFW Font File",
                Filter = "nicFont Files|*.nicfont|All Files|*.*"
            };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllBytes(sfd.FileName, BigChar.RawFont);
                    SetStatus("Font Saved");
                }
                catch
                {
                    SetStatus("Error saving font file");
                }
            }
        }

        private void SetStatus(string status)
        {
            StatusLabel.Text = status;
        }

        private static int Patch16x16(char start, char end, byte[] fw, int offset)
        {
            int size = ((end - start) + 1) * 32;
            for (int i = start - 32; i <= end - 32; i++)
            {
                var bc = BigChar.Chars[i];
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 8; k++)
                    {
                        fw[offset++] = bc.Panes[j][k];
                        fw[offset++] = bc.Panes[j + 2][k];
                    }
                }
            }
            return size;
        }

        private static void Patch8x16(byte[] fw, int offset)
        {
            for (int i = 0; i <= 4; i++)
            {
                var bc = BigChar.Chars[i];
                for (int j = 0; j < 3; j += 2)
                {
                    for (int k = 0; k < 8; k++)
                    {
                        fw[offset++] = bc.Panes[j][k];
                    }
                }
                for (int j = 1; j < 4; j += 2)
                {
                    for (int k = 0; k < 8; k++)
                    {
                        fw[offset++] = bc.Panes[j][k];
                    }
                }
            }
        }

        private void PatchFirmwareButton_Click(object sender, EventArgs e)
        {
            using var ofd = new OpenFileDialog()
            {
                Title = "Load nicFW V2.5X.XX Firmware File",
                Filter = "nicFW Files|*.bin|All Files|*.*"
            };
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    byte[] fw = File.ReadAllBytes(ofd.FileName);
                    if (fw.Length < 2144 || fw.Length > 0xf800)
                        SetStatus("Incorrect file length");
                    else
                    {
                        ulong srch = 0x007e7e00007e7e00UL;
                        for (int i = 0; i < fw.Length - 2144; i++)
                        {
                            if (srch == BitConverter.ToUInt64(fw, i))
                            {
                                i += 8;
                                i += Patch16x16('0', '9', fw, i);
                                i += Patch16x16('A', 'Z', fw, i);
                                i += Patch16x16('a', 'z', fw, i);
                                Patch8x16(fw, i);
                                using var sfd = new SaveFileDialog()
                                {
                                    Title = "Save Patched nicFW V2.5X.XX Firmware File",
                                    Filter = "nicFW Files|*.bin|All Files|*.*"
                                };
                                if(sfd.ShowDialog() == DialogResult.OK)
                                {
                                    File.WriteAllBytes(sfd.FileName, fw);
                                    SetStatus("Patched Firmware Saved");
                                }
                                else
                                    SetStatus("Patched Firmware Save Canceled");
                                return;
                            }
                        }
                        SetStatus("Incompatible firmware binary");
                    }
                }
                catch
                {
                    SetStatus("Error patching firmware binary");
                }
            }
        }
    }

    public class BigChar
    {
        public static byte[] RawFont { get; } = new byte[3040];
        public static Dictionary<int, BigChar> Chars { get; } = [];
        public List<byte[]> Panes { get; } = [];
        public int Ascii { get; }

        public BigChar(int ascii)
        {
            Panes.Add(new byte[8]);
            Panes.Add(new byte[8]);
            Panes.Add(new byte[8]);
            Panes.Add(new byte[8]);
            Chars[ascii] = this;
            Ascii = ascii;
            Save();
        }

        public static void RefreshAll()
        {
            for (int i = 0; i < 95; i++)
            {
                Chars[i].Refresh();
            }
        }

        public void Refresh()
        {
            int addr = Ascii * 32;
            Array.Copy(RawFont, addr, Panes[0], 0, 8);
            Array.Copy(RawFont, addr + 8, Panes[1], 0, 8);
            Array.Copy(RawFont, addr + 16, Panes[2], 0, 8);
            Array.Copy(RawFont, addr + 24, Panes[3], 0, 8);
        }

        public void Save()
        {
            int addr = Ascii * 32;
            Array.Copy(Panes[0], 0, RawFont, addr, 8);
            Array.Copy(Panes[1], 0, RawFont, addr + 8, 8);
            Array.Copy(Panes[2], 0, RawFont, addr + 16, 8);
            Array.Copy(Panes[3], 0, RawFont, addr + 24, 8);
        }

        public void SetPixel(int x, int y, bool on)
        {
            int pane = x >= 8 ? 1 : 0;
            pane += y >= 8 ? 2 : 0;
            x %= 8;
            y %= 8;
            y = (int)Math.Pow(2, y);
            if(on)
                Panes[pane][x] |= (byte)y;
            else
                Panes[pane][x] &= (byte)~y;
            Save();
        }

        public bool GetPixel(int x, int y)
        {
            int pane = x >= 8 ? 1 : 0;
            pane += y >= 8 ? 2 : 0;
            x %= 8;
            y %= 8;
            y = (int)Math.Pow(2, y);
            return (Panes[pane][x] & y) != 0;
        }

    }
}
