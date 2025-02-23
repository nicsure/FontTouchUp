namespace FontTouchUp
{
    partial class UI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MainGrid = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            NUD_CharIndex = new NumericUpDown();
            SaveFontButton = new Button();
            LoadFontButton = new Button();
            PatchFirmwareButton = new Button();
            StatusLabel = new Label();
            tabControl1 = new TabControl();
            FontsTab = new TabPage();
            LogoTab = new TabPage();
            LogoGrid = new TableLayoutPanel();
            StatusLabel2 = new Label();
            LogoPreview = new PictureBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            LoadLogoImageButton = new Button();
            label2 = new Label();
            ContrastControl = new TrackBar();
            InvertLogoControl = new CheckBox();
            MainGrid.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NUD_CharIndex).BeginInit();
            tabControl1.SuspendLayout();
            FontsTab.SuspendLayout();
            LogoTab.SuspendLayout();
            LogoGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LogoPreview).BeginInit();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ContrastControl).BeginInit();
            SuspendLayout();
            // 
            // MainGrid
            // 
            MainGrid.ColumnCount = 17;
            MainGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4.938272F));
            MainGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4.938272F));
            MainGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4.938272F));
            MainGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4.938272F));
            MainGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4.938272F));
            MainGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4.938272F));
            MainGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4.938272F));
            MainGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4.938272F));
            MainGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4.938272F));
            MainGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4.938272F));
            MainGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4.938272F));
            MainGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4.938272F));
            MainGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4.938272F));
            MainGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4.938272F));
            MainGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4.938272F));
            MainGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4.938272F));
            MainGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.9876537F));
            MainGrid.Controls.Add(flowLayoutPanel1, 16, 0);
            MainGrid.Controls.Add(StatusLabel, 0, 16);
            MainGrid.Dock = DockStyle.Fill;
            MainGrid.Location = new Point(3, 3);
            MainGrid.Name = "MainGrid";
            MainGrid.RowCount = 17;
            MainGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 4.938271F));
            MainGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 4.938271F));
            MainGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 4.938271F));
            MainGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 4.938271F));
            MainGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 4.938271F));
            MainGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 4.938271F));
            MainGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 4.938271F));
            MainGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 4.938271F));
            MainGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 4.938271F));
            MainGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 4.938271F));
            MainGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 4.938271F));
            MainGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 4.938271F));
            MainGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 4.938271F));
            MainGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 4.938271F));
            MainGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 4.938271F));
            MainGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 4.938271F));
            MainGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 20.9876556F));
            MainGrid.Size = new Size(1518, 1108);
            MainGrid.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(NUD_CharIndex);
            flowLayoutPanel1.Controls.Add(SaveFontButton);
            flowLayoutPanel1.Controls.Add(LoadFontButton);
            flowLayoutPanel1.Controls.Add(PatchFirmwareButton);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(1187, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.RightToLeft = RightToLeft.Yes;
            MainGrid.SetRowSpan(flowLayoutPanel1, 12);
            flowLayoutPanel1.Size = new Size(328, 642);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(134, 32);
            label1.Margin = new Padding(0, 30, 10, 0);
            label1.Name = "label1";
            label1.Size = new Size(194, 32);
            label1.TabIndex = 1;
            label1.Text = "Character Index";
            // 
            // NUD_CharIndex
            // 
            NUD_CharIndex.Anchor = AnchorStyles.Right;
            NUD_CharIndex.AutoSize = true;
            flowLayoutPanel1.SetFlowBreak(NUD_CharIndex, true);
            NUD_CharIndex.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NUD_CharIndex.Location = new Point(61, 30);
            NUD_CharIndex.Margin = new Padding(0, 30, 10, 0);
            NUD_CharIndex.Maximum = new decimal(new int[] { 94, 0, 0, 0 });
            NUD_CharIndex.Name = "NUD_CharIndex";
            NUD_CharIndex.Size = new Size(63, 37);
            NUD_CharIndex.TabIndex = 0;
            NUD_CharIndex.TextAlign = HorizontalAlignment.Right;
            NUD_CharIndex.ValueChanged += NUD_CharIndex_ValueChanged;
            // 
            // SaveFontButton
            // 
            SaveFontButton.AutoSize = true;
            SaveFontButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            SaveFontButton.BackColor = Color.FromArgb(40, 60, 40);
            SaveFontButton.FlatStyle = FlatStyle.Flat;
            SaveFontButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SaveFontButton.Location = new Point(200, 97);
            SaveFontButton.Margin = new Padding(3, 30, 3, 30);
            SaveFontButton.Name = "SaveFontButton";
            SaveFontButton.Size = new Size(125, 42);
            SaveFontButton.TabIndex = 2;
            SaveFontButton.Text = "Save Font";
            SaveFontButton.UseVisualStyleBackColor = false;
            SaveFontButton.Click += SaveFontButton_Click;
            // 
            // LoadFontButton
            // 
            LoadFontButton.AutoSize = true;
            LoadFontButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            LoadFontButton.BackColor = Color.FromArgb(40, 60, 40);
            LoadFontButton.FlatStyle = FlatStyle.Flat;
            flowLayoutPanel1.SetFlowBreak(LoadFontButton, true);
            LoadFontButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoadFontButton.Location = new Point(67, 97);
            LoadFontButton.Margin = new Padding(3, 30, 3, 30);
            LoadFontButton.Name = "LoadFontButton";
            LoadFontButton.Size = new Size(127, 42);
            LoadFontButton.TabIndex = 2;
            LoadFontButton.Text = "Load Font";
            LoadFontButton.UseVisualStyleBackColor = false;
            LoadFontButton.Click += LoadFontButton_Click;
            // 
            // PatchFirmwareButton
            // 
            PatchFirmwareButton.AutoSize = true;
            PatchFirmwareButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PatchFirmwareButton.BackColor = Color.FromArgb(40, 60, 40);
            PatchFirmwareButton.FlatStyle = FlatStyle.Flat;
            PatchFirmwareButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PatchFirmwareButton.Location = new Point(139, 172);
            PatchFirmwareButton.Name = "PatchFirmwareButton";
            PatchFirmwareButton.Size = new Size(186, 42);
            PatchFirmwareButton.TabIndex = 2;
            PatchFirmwareButton.Text = "Patch Firmware";
            PatchFirmwareButton.UseVisualStyleBackColor = false;
            PatchFirmwareButton.Click += PatchFirmwareButton_Click;
            // 
            // StatusLabel
            // 
            StatusLabel.Anchor = AnchorStyles.None;
            StatusLabel.AutoSize = true;
            MainGrid.SetColumnSpan(StatusLabel, 16);
            StatusLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StatusLabel.Location = new Point(592, 971);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(0, 30);
            StatusLabel.TabIndex = 4;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(FontsTab);
            tabControl1.Controls.Add(LogoTab);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1532, 1152);
            tabControl1.TabIndex = 1;
            // 
            // FontsTab
            // 
            FontsTab.BackColor = Color.Black;
            FontsTab.Controls.Add(MainGrid);
            FontsTab.Location = new Point(4, 34);
            FontsTab.Name = "FontsTab";
            FontsTab.Padding = new Padding(3);
            FontsTab.Size = new Size(1524, 1114);
            FontsTab.TabIndex = 0;
            FontsTab.Text = "Fonts";
            // 
            // LogoTab
            // 
            LogoTab.BackColor = Color.Black;
            LogoTab.Controls.Add(LogoGrid);
            LogoTab.Location = new Point(4, 34);
            LogoTab.Name = "LogoTab";
            LogoTab.Padding = new Padding(3);
            LogoTab.Size = new Size(1524, 1114);
            LogoTab.TabIndex = 1;
            LogoTab.Text = "Logo";
            // 
            // LogoGrid
            // 
            LogoGrid.ColumnCount = 2;
            LogoGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            LogoGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            LogoGrid.Controls.Add(StatusLabel2, 0, 1);
            LogoGrid.Controls.Add(LogoPreview, 0, 0);
            LogoGrid.Controls.Add(flowLayoutPanel2, 1, 0);
            LogoGrid.Dock = DockStyle.Fill;
            LogoGrid.Location = new Point(3, 3);
            LogoGrid.Name = "LogoGrid";
            LogoGrid.RowCount = 2;
            LogoGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            LogoGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            LogoGrid.Size = new Size(1518, 1108);
            LogoGrid.TabIndex = 0;
            // 
            // StatusLabel2
            // 
            StatusLabel2.Anchor = AnchorStyles.None;
            StatusLabel2.AutoSize = true;
            LogoGrid.SetColumnSpan(StatusLabel2, 16);
            StatusLabel2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StatusLabel2.Location = new Point(759, 926);
            StatusLabel2.Name = "StatusLabel2";
            StatusLabel2.Size = new Size(0, 30);
            StatusLabel2.TabIndex = 5;
            // 
            // LogoPreview
            // 
            LogoPreview.BackgroundImageLayout = ImageLayout.Zoom;
            LogoPreview.Dock = DockStyle.Fill;
            LogoPreview.Location = new Point(3, 3);
            LogoPreview.Name = "LogoPreview";
            LogoPreview.Size = new Size(904, 769);
            LogoPreview.TabIndex = 0;
            LogoPreview.TabStop = false;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(LoadLogoImageButton);
            flowLayoutPanel2.Controls.Add(label2);
            flowLayoutPanel2.Controls.Add(ContrastControl);
            flowLayoutPanel2.Controls.Add(InvertLogoControl);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel2.Location = new Point(913, 3);
            flowLayoutPanel2.Margin = new Padding(3, 3, 30, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(575, 769);
            flowLayoutPanel2.TabIndex = 6;
            // 
            // LoadLogoImageButton
            // 
            LoadLogoImageButton.AutoSize = true;
            LoadLogoImageButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            LoadLogoImageButton.BackColor = Color.FromArgb(40, 60, 40);
            LoadLogoImageButton.FlatStyle = FlatStyle.Flat;
            flowLayoutPanel2.SetFlowBreak(LoadLogoImageButton, true);
            LoadLogoImageButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoadLogoImageButton.Location = new Point(369, 30);
            LoadLogoImageButton.Margin = new Padding(3, 30, 3, 30);
            LoadLogoImageButton.Name = "LoadLogoImageButton";
            LoadLogoImageButton.RightToLeft = RightToLeft.No;
            LoadLogoImageButton.Size = new Size(203, 42);
            LoadLogoImageButton.TabIndex = 3;
            LoadLogoImageButton.Text = "Load Logo Image";
            LoadLogoImageButton.UseVisualStyleBackColor = false;
            LoadLogoImageButton.Click += LoadLogoImageButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            flowLayoutPanel2.SetFlowBreak(label2, true);
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(461, 132);
            label2.Margin = new Padding(3, 30, 3, 0);
            label2.Name = "label2";
            label2.Size = new Size(111, 32);
            label2.TabIndex = 4;
            label2.Text = "Contrast";
            // 
            // ContrastControl
            // 
            flowLayoutPanel2.SetFlowBreak(ContrastControl, true);
            ContrastControl.Location = new Point(218, 180);
            ContrastControl.Maximum = 700;
            ContrastControl.Minimum = 100;
            ContrastControl.Name = "ContrastControl";
            ContrastControl.Size = new Size(354, 69);
            ContrastControl.TabIndex = 5;
            ContrastControl.Value = 382;
            ContrastControl.Scroll += ContrastControl_Scroll;
            // 
            // InvertLogoControl
            // 
            InvertLogoControl.AutoSize = true;
            InvertLogoControl.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InvertLogoControl.Location = new Point(470, 282);
            InvertLogoControl.Margin = new Padding(3, 30, 3, 3);
            InvertLogoControl.Name = "InvertLogoControl";
            InvertLogoControl.RightToLeft = RightToLeft.Yes;
            InvertLogoControl.Size = new Size(102, 34);
            InvertLogoControl.TabIndex = 6;
            InvertLogoControl.Text = "Invert";
            InvertLogoControl.UseVisualStyleBackColor = true;
            InvertLogoControl.CheckedChanged += InvertLogoControl_CheckedChanged;
            // 
            // UI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1532, 1152);
            Controls.Add(tabControl1);
            ForeColor = Color.White;
            Name = "UI";
            Text = "nicFW2.5 Font Touch Up (2.51.xx)";
            MainGrid.ResumeLayout(false);
            MainGrid.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NUD_CharIndex).EndInit();
            tabControl1.ResumeLayout(false);
            FontsTab.ResumeLayout(false);
            LogoTab.ResumeLayout(false);
            LogoGrid.ResumeLayout(false);
            LogoGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LogoPreview).EndInit();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ContrastControl).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel MainGrid;
        private NumericUpDown NUD_CharIndex;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button SaveFontButton;
        private Button LoadFontButton;
        private Button PatchFirmwareButton;
        private Label StatusLabel;
        private TabControl tabControl1;
        private TabPage FontsTab;
        private TabPage LogoTab;
        private TableLayoutPanel LogoGrid;
        private PictureBox LogoPreview;
        private Label StatusLabel2;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button LoadLogoImageButton;
        private Label label2;
        private TrackBar ContrastControl;
        private CheckBox InvertLogoControl;
    }
}
