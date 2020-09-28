namespace TilePaint
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TilePanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.PalettePanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtHeight = new System.Windows.Forms.NumericUpDown();
            this.TxtWidth = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnReplace = new System.Windows.Forms.Button();
            this.BtnDuplicate = new System.Windows.Forms.Button();
            this.BtnFillWhite = new System.Windows.Forms.Button();
            this.BtnSwap = new System.Windows.Forms.Button();
            this.BtnFillR = new System.Windows.Forms.Button();
            this.BtnFillL = new System.Windows.Forms.Button();
            this.RightBtnPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.LeftBtnPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnLoad = new System.Windows.Forms.Button();
            this.TxtFilename = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.TxtPath = new System.Windows.Forms.TextBox();
            this.BtnOpenFolder = new System.Windows.Forms.Button();
            this.LstFiles = new System.Windows.Forms.ListBox();
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtWidth)).BeginInit();
            this.RightBtnPanel.SuspendLayout();
            this.LeftBtnPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(752, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 468);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(752, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(67, 17);
            this.StatusLabel.Text = "StatusLabel";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.625F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.375F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 156F));
            this.tableLayoutPanel1.Controls.Add(this.TilePanel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LstFiles, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(752, 444);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // TilePanel
            // 
            this.TilePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TilePanel.Location = new System.Drawing.Point(209, 8);
            this.TilePanel.Name = "TilePanel";
            this.TilePanel.Size = new System.Drawing.Size(383, 400);
            this.TilePanel.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.PalettePanel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 8);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.7789F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.2211F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 400);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // PalettePanel
            // 
            this.PalettePanel.Location = new System.Drawing.Point(3, 3);
            this.PalettePanel.Name = "PalettePanel";
            this.PalettePanel.Size = new System.Drawing.Size(192, 216);
            this.PalettePanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TxtHeight);
            this.panel1.Controls.Add(this.TxtWidth);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.BtnReplace);
            this.panel1.Controls.Add(this.BtnDuplicate);
            this.panel1.Controls.Add(this.BtnFillWhite);
            this.panel1.Controls.Add(this.BtnSwap);
            this.panel1.Controls.Add(this.BtnFillR);
            this.panel1.Controls.Add(this.BtnFillL);
            this.panel1.Controls.Add(this.RightBtnPanel);
            this.panel1.Controls.Add(this.LeftBtnPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 226);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 171);
            this.panel1.TabIndex = 2;
            // 
            // TxtHeight
            // 
            this.TxtHeight.Location = new System.Drawing.Point(137, 144);
            this.TxtHeight.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.TxtHeight.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.TxtHeight.Name = "TxtHeight";
            this.TxtHeight.Size = new System.Drawing.Size(49, 20);
            this.TxtHeight.TabIndex = 4;
            this.TxtHeight.TabStop = false;
            this.TxtHeight.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // TxtWidth
            // 
            this.TxtWidth.Location = new System.Drawing.Point(83, 144);
            this.TxtWidth.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.TxtWidth.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.TxtWidth.Name = "TxtWidth";
            this.TxtWidth.Size = new System.Drawing.Size(49, 20);
            this.TxtWidth.TabIndex = 3;
            this.TxtWidth.TabStop = false;
            this.TxtWidth.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Output size:";
            // 
            // BtnReplace
            // 
            this.BtnReplace.Location = new System.Drawing.Point(3, 112);
            this.BtnReplace.Name = "BtnReplace";
            this.BtnReplace.Size = new System.Drawing.Size(90, 23);
            this.BtnReplace.TabIndex = 9;
            this.BtnReplace.TabStop = false;
            this.BtnReplace.Text = "Replace Color";
            this.BtnReplace.UseVisualStyleBackColor = true;
            this.BtnReplace.Click += new System.EventHandler(this.BtnReplace_Click);
            // 
            // BtnDuplicate
            // 
            this.BtnDuplicate.Location = new System.Drawing.Point(98, 112);
            this.BtnDuplicate.Name = "BtnDuplicate";
            this.BtnDuplicate.Size = new System.Drawing.Size(90, 23);
            this.BtnDuplicate.TabIndex = 8;
            this.BtnDuplicate.TabStop = false;
            this.BtnDuplicate.UseVisualStyleBackColor = true;
            // 
            // BtnFillWhite
            // 
            this.BtnFillWhite.Location = new System.Drawing.Point(2, 88);
            this.BtnFillWhite.Name = "BtnFillWhite";
            this.BtnFillWhite.Size = new System.Drawing.Size(90, 23);
            this.BtnFillWhite.TabIndex = 5;
            this.BtnFillWhite.TabStop = false;
            this.BtnFillWhite.Text = "Clear";
            this.BtnFillWhite.UseVisualStyleBackColor = true;
            this.BtnFillWhite.Click += new System.EventHandler(this.BtnFillWhite_Click);
            // 
            // BtnSwap
            // 
            this.BtnSwap.Location = new System.Drawing.Point(97, 88);
            this.BtnSwap.Name = "BtnSwap";
            this.BtnSwap.Size = new System.Drawing.Size(90, 23);
            this.BtnSwap.TabIndex = 4;
            this.BtnSwap.TabStop = false;
            this.BtnSwap.Text = "Swap L/R";
            this.BtnSwap.UseVisualStyleBackColor = true;
            this.BtnSwap.Click += new System.EventHandler(this.BtnSwap_Click);
            // 
            // BtnFillR
            // 
            this.BtnFillR.Location = new System.Drawing.Point(98, 64);
            this.BtnFillR.Name = "BtnFillR";
            this.BtnFillR.Size = new System.Drawing.Size(90, 23);
            this.BtnFillR.TabIndex = 3;
            this.BtnFillR.TabStop = false;
            this.BtnFillR.Text = "Fill with R";
            this.BtnFillR.UseVisualStyleBackColor = true;
            this.BtnFillR.Click += new System.EventHandler(this.BtnFillR_Click);
            // 
            // BtnFillL
            // 
            this.BtnFillL.Location = new System.Drawing.Point(3, 64);
            this.BtnFillL.Name = "BtnFillL";
            this.BtnFillL.Size = new System.Drawing.Size(90, 23);
            this.BtnFillL.TabIndex = 2;
            this.BtnFillL.TabStop = false;
            this.BtnFillL.Text = "Fill with L";
            this.BtnFillL.UseVisualStyleBackColor = true;
            this.BtnFillL.Click += new System.EventHandler(this.BtnFillL_Click);
            // 
            // RightBtnPanel
            // 
            this.RightBtnPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RightBtnPanel.Controls.Add(this.label2);
            this.RightBtnPanel.Location = new System.Drawing.Point(98, 3);
            this.RightBtnPanel.Name = "RightBtnPanel";
            this.RightBtnPanel.Size = new System.Drawing.Size(90, 55);
            this.RightBtnPanel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 53);
            this.label2.TabIndex = 0;
            this.label2.Text = "R";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LeftBtnPanel
            // 
            this.LeftBtnPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LeftBtnPanel.Controls.Add(this.label1);
            this.LeftBtnPanel.Location = new System.Drawing.Point(3, 3);
            this.LeftBtnPanel.Name = "LeftBtnPanel";
            this.LeftBtnPanel.Size = new System.Drawing.Size(90, 55);
            this.LeftBtnPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "L";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel3, 3);
            this.panel3.Controls.Add(this.BtnLoad);
            this.panel3.Controls.Add(this.TxtFilename);
            this.panel3.Controls.Add(this.BtnSave);
            this.panel3.Controls.Add(this.TxtPath);
            this.panel3.Controls.Add(this.BtnOpenFolder);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 414);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(746, 27);
            this.panel3.TabIndex = 5;
            // 
            // BtnLoad
            // 
            this.BtnLoad.Location = new System.Drawing.Point(578, 2);
            this.BtnLoad.Name = "BtnLoad";
            this.BtnLoad.Size = new System.Drawing.Size(53, 24);
            this.BtnLoad.TabIndex = 14;
            this.BtnLoad.Text = "Load";
            this.BtnLoad.UseVisualStyleBackColor = true;
            this.BtnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // TxtFilename
            // 
            this.TxtFilename.Location = new System.Drawing.Point(404, 4);
            this.TxtFilename.Name = "TxtFilename";
            this.TxtFilename.Size = new System.Drawing.Size(116, 20);
            this.TxtFilename.TabIndex = 12;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(523, 2);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(53, 24);
            this.BtnSave.TabIndex = 13;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // TxtPath
            // 
            this.TxtPath.Location = new System.Drawing.Point(3, 4);
            this.TxtPath.Name = "TxtPath";
            this.TxtPath.Size = new System.Drawing.Size(397, 20);
            this.TxtPath.TabIndex = 11;
            // 
            // BtnOpenFolder
            // 
            this.BtnOpenFolder.Location = new System.Drawing.Point(633, 2);
            this.BtnOpenFolder.Name = "BtnOpenFolder";
            this.BtnOpenFolder.Size = new System.Drawing.Size(110, 24);
            this.BtnOpenFolder.TabIndex = 15;
            this.BtnOpenFolder.Text = "Open output folder";
            this.BtnOpenFolder.UseVisualStyleBackColor = true;
            this.BtnOpenFolder.Click += new System.EventHandler(this.BtnOpenFolder_Click);
            // 
            // LstFiles
            // 
            this.LstFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LstFiles.FormattingEnabled = true;
            this.LstFiles.Location = new System.Drawing.Point(598, 8);
            this.LstFiles.Margin = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.LstFiles.Name = "LstFiles";
            this.LstFiles.ScrollAlwaysVisible = true;
            this.LstFiles.Size = new System.Drawing.Size(147, 400);
            this.LstFiles.TabIndex = 6;
            this.LstFiles.DoubleClick += new System.EventHandler(this.LstFiles_DoubleClick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 490);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tile Paint";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtWidth)).EndInit();
            this.RightBtnPanel.ResumeLayout(false);
            this.LeftBtnPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel TilePanel;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel PalettePanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel RightBtnPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel LeftBtnPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnReplace;
        private System.Windows.Forms.Button BtnDuplicate;
        private System.Windows.Forms.Button BtnFillWhite;
        private System.Windows.Forms.Button BtnSwap;
        private System.Windows.Forms.Button BtnFillR;
        private System.Windows.Forms.Button BtnFillL;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtnOpenFolder;
        private System.Windows.Forms.NumericUpDown TxtHeight;
        private System.Windows.Forms.NumericUpDown TxtWidth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnLoad;
        private System.Windows.Forms.TextBox TxtFilename;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.TextBox TxtPath;
        private System.Windows.Forms.ListBox LstFiles;
    }
}

