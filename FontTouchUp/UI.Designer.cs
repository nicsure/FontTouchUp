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
            MainGrid.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NUD_CharIndex).BeginInit();
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
            MainGrid.Location = new Point(0, 0);
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
            MainGrid.Size = new Size(1532, 1152);
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
            flowLayoutPanel1.Location = new Point(1203, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.RightToLeft = RightToLeft.Yes;
            MainGrid.SetRowSpan(flowLayoutPanel1, 12);
            flowLayoutPanel1.Size = new Size(326, 666);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(132, 32);
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
            NUD_CharIndex.Location = new Point(59, 30);
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
            SaveFontButton.Location = new Point(198, 97);
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
            LoadFontButton.Location = new Point(65, 97);
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
            PatchFirmwareButton.Location = new Point(137, 172);
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
            StatusLabel.Location = new Point(600, 1009);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(0, 30);
            StatusLabel.TabIndex = 4;
            // 
            // UI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1532, 1152);
            Controls.Add(MainGrid);
            ForeColor = Color.White;
            Name = "UI";
            Text = "nicFW2.5 Font Touch Up";
            MainGrid.ResumeLayout(false);
            MainGrid.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NUD_CharIndex).EndInit();
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
    }
}
