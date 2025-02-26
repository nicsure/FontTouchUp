using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace FontTouchUp
{
    public partial class UI : Form
    {

        private readonly PixelPanel[][] panels = new PixelPanel[16][];
        private int currentChar = 0;
        private Bitmap loadedLogoFile = new(128, 64);
        private readonly Bitmap appliedLogo = new(128, 64);
        private readonly byte[] logoData = new byte[1024];
        private bool clickSet = true;
        PixelPanel? mousePanel = null;

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
                    p.MouseDown += PixelPanel_MouseDown;
                    p.MouseUp += PixelPanel_MouseUp;
                    p.MouseMove += PixelPanel_MouseMove;
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
            LogoPreview.BackgroundImage = appliedLogo;
            LoadFont("default.nicfont");
            RenderCharacter(0);
            if (LoadLogoImage("defaultlogo.png"))
                ApplyLogoImage();
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

        private void PixelPanel_SetPixel(PixelPanel panel, bool setState)
        {
            panel.Status = setState ? 1 : 0;
            panel.BackColor = setState ? Color.SkyBlue : Color.Black;
            BigChar.Chars[currentChar].SetPixel(panel.X, panel.Y, setState);
        }

        private void PixelPanel_MouseDown(object? sender, MouseEventArgs e)
        {
            if (sender is not PixelPanel panel) return;
            clickSet = panel.Status == 0;
            PixelPanel_SetPixel(panel, clickSet);
            mousePanel = panel;
        }

        private void PixelPanel_MouseUp(object? sender, MouseEventArgs e)
        {
            mousePanel = null;
        }

        private void PixelPanel_MouseMove(object? sender, MouseEventArgs e)
        {
            if (mousePanel == null) return;
            Point cp = Point.Add(mousePanel.Location, (Size)e.Location);
            if (GetDeepestChildAtPoint(MainGrid, cp) is PixelPanel newPanel)
            {
                PixelPanel_SetPixel(newPanel, clickSet);
            }
        }

        private static Control? GetDeepestChildAtPoint(Control parent, Point point)
        {
            Control? child = parent.GetChildAtPoint(point);
            if (child == null) return parent;
            return GetDeepestChildAtPoint(child, child.PointToClient(Cursor.Position));
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

        private bool LoadLogoImage(string fileName)
        {
            Bitmap? image = null;
            try
            {
                image = (Bitmap)Image.FromFile(fileName);
                if (image.Width < 128 || image.Height < 64)
                {
                    SetStatus("Logo must be at least 128x64 pixels.");
                    image.Dispose();
                    return false;
                }
                if (image.Width != 128 || image.Height != 64)
                {
                    SetStatus("Only the top left 128x64 pixels of the image will be used.");
                }
                loadedLogoFile.Dispose();
                loadedLogoFile = image;
                return true;
            }
            catch { }
            SetStatus("Error loading image file.");
            image?.Dispose();
            return false;
        }

        private void ContrastControl_Scroll(object sender, EventArgs e)
        {
            ApplyLogoImage();
        }

        private void ApplyLogoImage()
        {
            for (int x = 0; x < 128; x++)
            {
                for (int y = 0; y < 64; y++)
                {
                    Color col = loadedLogoFile.GetPixel(x, y);
                    int brightness = col.R + col.G + col.B;
                    bool isSet = brightness > ContrastControl.Value;
                    if (InvertLogoControl.Checked) isSet = !isSet;
                    appliedLogo.SetPixel(x, y, isSet ? Color.White : Color.Black);
                    int addr = (x * 8) + (y / 8);
                    int mask = 1 << (y % 8);
                    if (isSet)
                        logoData[addr] |= (byte)mask;
                    else
                        logoData[addr] &= (byte)~mask;
                }
            }
            LogoPreview.Refresh();
        }

        private void InvertLogoControl_CheckedChanged(object sender, EventArgs e)
        {
            ApplyLogoImage();
        }

        private void LoadLogoImageButton_Click(object sender, EventArgs e)
        {
            using var ofd = new OpenFileDialog()
            {
                Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.gif;*.tiff;*.tif;*.webp|All Files|*.*",
                Title = "Select an Image File",
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (LoadLogoImage(ofd.FileName))
                    ApplyLogoImage();
            }
        }

        private void SetStatus(string status)
        {
            StatusLabel.Text = StatusLabel2.Text = status;
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
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    byte[] tmp = File.ReadAllBytes(ofd.FileName);
                    if (tmp.Length < 2144 || tmp.Length > 0xf800)
                        SetStatus("Incorrect file length");
                    else
                    {
                        byte[] fw = new byte[0xf800];
                        Array.Copy(tmp, 0, fw, 0, 0xf800);
                        ulong srchfont = 0x0f09ff007989898eUL;
                        ulong srchlogo = 0x55e5d1c566a61c87UL;
                        bool fontPatched = false, logoPatched = false;
                        for (int i = 0; i < fw.Length - 10; i++)
                        {
                            var match = BitConverter.ToUInt64(fw, i);
                            if (!fontPatched && srchfont == match)
                            {
                                i += 8;
                                i += Patch16x16('0', '9', fw, i);
                                i += Patch16x16('A', 'Z', fw, i);
                                i += Patch16x16('a', 'z', fw, i);
                                Patch8x16(fw, i);
                                fontPatched = true;
                            }
                            if (!logoPatched && srchlogo == match)
                            {
                                i += 8;
                                Array.Copy(logoData, 0, fw, i, 1024);
                                logoPatched = true;
                            }
                            if (logoPatched && fontPatched)
                                break;
                        }
                        if (logoPatched && fontPatched)
                        {
                            uint crc = ComputeCrc32(fw[..0xf7fc]);
                            crc ^= 0xffffffffu;
                            BitConverter.GetBytes(crc).CopyTo(fw, 0xf7fc);
                            using var sfd = new SaveFileDialog()
                            {
                                Title = "Save Patched nicFW V2.5X.XX Firmware File",
                                Filter = "nicFW Files|*.bin|All Files|*.*"
                            };
                            if (sfd.ShowDialog() == DialogResult.OK)
                            {
                                File.WriteAllBytes(sfd.FileName, fw);
                                SetStatus("Patched Firmware Saved");
                            }
                            else
                                SetStatus("Patched Firmware Save Canceled");
                        }
                        else
                            SetStatus("Incompatible firmware binary");
                    }
                }
                catch
                {
                    SetStatus("Error patching firmware binary");
                }
            }
        }

        private BigChar? clipped = null;

        private void CopyButton_Click(object sender, EventArgs e)
        {
            clipped = BigChar.Chars[currentChar];
        }

        private void PasteButton_Click(object sender, EventArgs e)
        {
            BigChar current = BigChar.Chars[currentChar];
            if (clipped != null && current != clipped)
            {
                for (int i = 0; i < 4; i++)
                {
                    Array.Copy(clipped.Panes[i], 0, current.Panes[i], 0, 8);
                }
                current.Save();
                RenderCharacter(currentChar);
            }
        }

        private void NUD_CharIndex_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                NUD_CharIndex.Value += NUD_CharIndex.Value >= 64 ? -32 : 32;
            }
        }

        public static uint ComputeCrc32(byte[] data)
        {
            var crc32 = new System.IO.Hashing.Crc32();
            crc32.Append(data);
            byte[] hash = crc32.GetCurrentHash();
            return BitConverter.ToUInt32(hash, 0);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            BigChar current = BigChar.Chars[currentChar];
            for (int i = 0; i < 4; i++)
            {
                Array.Fill<byte>(current.Panes[i], 0);
            }
            current.Save();
            RenderCharacter(currentChar);
        }

        private void NudgeButtons_Click(object sender, EventArgs e)
        {
            BigChar current = BigChar.Chars[currentChar];
            if (sender == UpButton)
            {
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        int cb0 = current.Panes[j][i] & 1;
                        int cb1 = current.Panes[j + 2][i] & 1;
                        current.Panes[j][i] >>= 1;
                        current.Panes[j + 2][i] >>= 1;
                        current.Panes[j][i] |= (byte)(cb1 << 7);
                        current.Panes[j + 2][i] |= (byte)(cb0 << 7);
                    }
                }
            }
            else
            if (sender == DownButton)
            {
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        int cb0 = current.Panes[j][i] & 0x80;
                        int cb1 = current.Panes[j + 2][i] & 0x80;
                        current.Panes[j][i] <<= 1;
                        current.Panes[j + 2][i] <<= 1;
                        current.Panes[j][i] |= (byte)(cb1 >> 7);
                        current.Panes[j + 2][i] |= (byte)(cb0 >> 7);
                    }
                }
            }
            else
            if (sender == LeftButton)
            {
                for (int j = 0; j < 4; j += 2)
                {
                    byte cb0 = current.Panes[j][0];
                    byte cb1 = current.Panes[j + 1][0];
                    var l0 = current.Panes[j].ToList();
                    l0.RemoveAt(0);
                    l0.Add(cb1);
                    var l1 = current.Panes[j + 1].ToList();
                    l1.RemoveAt(0);
                    l1.Add(cb0);
                    l0.ToArray().CopyTo(current.Panes[j], 0);
                    l1.ToArray().CopyTo(current.Panes[j + 1], 0);
                }
            }
            else
            if (sender == RightButton)
            {
                for (int j = 0; j < 4; j += 2)
                {
                    byte cb0 = current.Panes[j][7];
                    byte cb1 = current.Panes[j + 1][7];
                    var l0 = current.Panes[j].ToList();
                    l0.RemoveAt(7);
                    l0.Insert(0, cb1);
                    var l1 = current.Panes[j + 1].ToList();
                    l1.RemoveAt(7);
                    l1.Insert(0, cb0);
                    l0.ToArray().CopyTo(current.Panes[j], 0);
                    l1.ToArray().CopyTo(current.Panes[j + 1], 0);
                }
            }
            current.Save();
            RenderCharacter(currentChar);
        }

        private void ShortcutCharacter_MenuClick(object sender, ToolStripItemClickedEventArgs e)
        {
            if( e.ClickedItem is ToolStripMenuItem mi &&
                mi.Tag is string index_s && 
                int.TryParse(index_s, out int index))
            {
                NUD_CharIndex.Value = index;
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
