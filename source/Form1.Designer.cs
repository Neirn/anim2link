namespace anim2link
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxBinPath = new System.Windows.Forms.TextBox();
            this.buttonOpenSelectBinDialogue = new System.Windows.Forms.Button();
            this.labelBinPath = new System.Windows.Forms.Label();
            this.buttonOpenSelectAnimDialogue = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxAnimPath = new System.Windows.Forms.TextBox();
            this.labelAnimPath = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxExtractLinkAnime = new System.Windows.Forms.CheckBox();
            this.buttonExportAll = new System.Windows.Forms.Button();
            this.listBoxRomVersionSelector = new System.Windows.Forms.ListBox();
            this.buttonExport = new System.Windows.Forms.Button();
            this.checkBoxInjectToRom = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelGameplayKeepRomOffset = new System.Windows.Forms.Label();
            this.textBoxGamePlayKeepRomOffset = new System.Windows.Forms.TextBox();
            this.labelLinkAnimetionRomOffset = new System.Windows.Forms.Label();
            this.textBoxLinkAnimetionRomOffset = new System.Windows.Forms.TextBox();
            this.labelAnimTableEntryGameplayKeepOffset = new System.Windows.Forms.Label();
            this.textBoxAnimTableEntryGameplayKeepOffset = new System.Windows.Forms.TextBox();
            this.buttonOpenSelectRomDialogue = new System.Windows.Forms.Button();
            this.textBoxRomPath = new System.Windows.Forms.TextBox();
            this.checkBoxFloorPlaneComp = new System.Windows.Forms.CheckBox();
            this.buttonRefreshAnimList = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxBinPath);
            this.groupBox1.Controls.Add(this.buttonOpenSelectBinDialogue);
            this.groupBox1.Controls.Add(this.labelBinPath);
            this.groupBox1.Controls.Add(this.buttonOpenSelectAnimDialogue);
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Controls.Add(this.textBoxAnimPath);
            this.groupBox1.Controls.Add(this.labelAnimPath);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 250);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Source";
            // 
            // textBoxBinPath
            // 
            this.textBoxBinPath.Location = new System.Drawing.Point(102, 39);
            this.textBoxBinPath.Name = "textBoxBinPath";
            this.textBoxBinPath.Size = new System.Drawing.Size(122, 20);
            this.textBoxBinPath.TabIndex = 7;
            // 
            // buttonOpenSelectBinDialogue
            // 
            this.buttonOpenSelectBinDialogue.Location = new System.Drawing.Point(230, 37);
            this.buttonOpenSelectBinDialogue.Name = "buttonOpenSelectBinDialogue";
            this.buttonOpenSelectBinDialogue.Size = new System.Drawing.Size(35, 23);
            this.buttonOpenSelectBinDialogue.TabIndex = 6;
            this.buttonOpenSelectBinDialogue.Text = "...";
            this.buttonOpenSelectBinDialogue.UseVisualStyleBackColor = true;
            this.buttonOpenSelectBinDialogue.Click += new System.EventHandler(this.buttonOpenSelectBinDialogue_Click);
            // 
            // labelBinPath
            // 
            this.labelBinPath.AutoSize = true;
            this.labelBinPath.Location = new System.Drawing.Point(6, 42);
            this.labelBinPath.Name = "labelBinPath";
            this.labelBinPath.Size = new System.Drawing.Size(95, 13);
            this.labelBinPath.TabIndex = 4;
            this.labelBinPath.Text = "Binary (.bin) File(s):";
            // 
            // buttonOpenSelectAnimDialogue
            // 
            this.buttonOpenSelectAnimDialogue.Location = new System.Drawing.Point(230, 11);
            this.buttonOpenSelectAnimDialogue.Name = "buttonOpenSelectAnimDialogue";
            this.buttonOpenSelectAnimDialogue.Size = new System.Drawing.Size(35, 23);
            this.buttonOpenSelectAnimDialogue.TabIndex = 3;
            this.buttonOpenSelectAnimDialogue.Text = "...";
            this.buttonOpenSelectAnimDialogue.UseVisualStyleBackColor = true;
            this.buttonOpenSelectAnimDialogue.Click += new System.EventHandler(this.openSelectAnimDialogue_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(9, 66);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(256, 174);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Animation";
            this.columnHeader1.Width = 128;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Frame Count";
            this.columnHeader2.Width = 123;
            // 
            // textBoxAnimPath
            // 
            this.textBoxAnimPath.Location = new System.Drawing.Point(102, 13);
            this.textBoxAnimPath.Name = "textBoxAnimPath";
            this.textBoxAnimPath.Size = new System.Drawing.Size(122, 20);
            this.textBoxAnimPath.TabIndex = 2;
            // 
            // labelAnimPath
            // 
            this.labelAnimPath.AutoSize = true;
            this.labelAnimPath.Location = new System.Drawing.Point(6, 16);
            this.labelAnimPath.Name = "labelAnimPath";
            this.labelAnimPath.Size = new System.Drawing.Size(90, 13);
            this.labelAnimPath.TabIndex = 1;
            this.labelAnimPath.Text = "Animation (.anim):";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxExtractLinkAnime);
            this.groupBox2.Controls.Add(this.buttonExportAll);
            this.groupBox2.Controls.Add(this.listBoxRomVersionSelector);
            this.groupBox2.Controls.Add(this.buttonExport);
            this.groupBox2.Controls.Add(this.checkBoxInjectToRom);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(291, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(205, 288);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Export";
            // 
            // checkBoxExtractLinkAnime
            // 
            this.checkBoxExtractLinkAnime.AutoSize = true;
            this.checkBoxExtractLinkAnime.Enabled = false;
            this.checkBoxExtractLinkAnime.Location = new System.Drawing.Point(6, 42);
            this.checkBoxExtractLinkAnime.Name = "checkBoxExtractLinkAnime";
            this.checkBoxExtractLinkAnime.Size = new System.Drawing.Size(158, 17);
            this.checkBoxExtractLinkAnime.TabIndex = 6;
            this.checkBoxExtractLinkAnime.Text = "Extract link_animetion.zdata";
            this.checkBoxExtractLinkAnime.UseVisualStyleBackColor = true;
            // 
            // buttonExportAll
            // 
            this.buttonExportAll.Location = new System.Drawing.Point(43, 256);
            this.buttonExportAll.Name = "buttonExportAll";
            this.buttonExportAll.Size = new System.Drawing.Size(75, 23);
            this.buttonExportAll.TabIndex = 5;
            this.buttonExportAll.Text = "Export All";
            this.buttonExportAll.UseVisualStyleBackColor = true;
            this.buttonExportAll.Click += new System.EventHandler(this.buttonExportAll_Click);
            // 
            // listBoxRomVersionSelector
            // 
            this.listBoxRomVersionSelector.FormattingEnabled = true;
            this.listBoxRomVersionSelector.Items.AddRange(new object[] {
            "1.0 (Oot)",
            "Debug (Oot)",
            "1.0 (MM)"});
            this.listBoxRomVersionSelector.Location = new System.Drawing.Point(6, 207);
            this.listBoxRomVersionSelector.Name = "listBoxRomVersionSelector";
            this.listBoxRomVersionSelector.Size = new System.Drawing.Size(120, 43);
            this.listBoxRomVersionSelector.TabIndex = 4;
            this.listBoxRomVersionSelector.SelectedIndexChanged += new System.EventHandler(this.listBoxRomVersionSelector_SelectedIndexChanged);
            // 
            // buttonExport
            // 
            this.buttonExport.Location = new System.Drawing.Point(124, 256);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(75, 23);
            this.buttonExport.TabIndex = 2;
            this.buttonExport.Text = "Export";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // checkBoxInjectToRom
            // 
            this.checkBoxInjectToRom.AutoSize = true;
            this.checkBoxInjectToRom.Location = new System.Drawing.Point(6, 19);
            this.checkBoxInjectToRom.Name = "checkBoxInjectToRom";
            this.checkBoxInjectToRom.Size = new System.Drawing.Size(111, 17);
            this.checkBoxInjectToRom.TabIndex = 1;
            this.checkBoxInjectToRom.Text = "Inject File to ROM";
            this.checkBoxInjectToRom.UseVisualStyleBackColor = true;
            this.checkBoxInjectToRom.CheckedChanged += new System.EventHandler(this.checkBoxInjectToRom_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelGameplayKeepRomOffset);
            this.groupBox3.Controls.Add(this.textBoxGamePlayKeepRomOffset);
            this.groupBox3.Controls.Add(this.labelLinkAnimetionRomOffset);
            this.groupBox3.Controls.Add(this.textBoxLinkAnimetionRomOffset);
            this.groupBox3.Controls.Add(this.labelAnimTableEntryGameplayKeepOffset);
            this.groupBox3.Controls.Add(this.textBoxAnimTableEntryGameplayKeepOffset);
            this.groupBox3.Controls.Add(this.buttonOpenSelectRomDialogue);
            this.groupBox3.Controls.Add(this.textBoxRomPath);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(6, 71);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(193, 130);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ROM";
            // 
            // labelGameplayKeepRomOffset
            // 
            this.labelGameplayKeepRomOffset.AutoSize = true;
            this.labelGameplayKeepRomOffset.Location = new System.Drawing.Point(6, 74);
            this.labelGameplayKeepRomOffset.Name = "labelGameplayKeepRomOffset";
            this.labelGameplayKeepRomOffset.Size = new System.Drawing.Size(85, 13);
            this.labelGameplayKeepRomOffset.TabIndex = 11;
            this.labelGameplayKeepRomOffset.Text = "gameplay_keep:";
            // 
            // textBoxGamePlayKeepRomOffset
            // 
            this.textBoxGamePlayKeepRomOffset.Location = new System.Drawing.Point(94, 72);
            this.textBoxGamePlayKeepRomOffset.Name = "textBoxGamePlayKeepRomOffset";
            this.textBoxGamePlayKeepRomOffset.Size = new System.Drawing.Size(93, 20);
            this.textBoxGamePlayKeepRomOffset.TabIndex = 10;
            this.textBoxGamePlayKeepRomOffset.Text = "0x00F5E000";
            // 
            // labelLinkAnimetionRomOffset
            // 
            this.labelLinkAnimetionRomOffset.AutoSize = true;
            this.labelLinkAnimetionRomOffset.Location = new System.Drawing.Point(6, 48);
            this.labelLinkAnimetionRomOffset.Name = "labelLinkAnimetionRomOffset";
            this.labelLinkAnimetionRomOffset.Size = new System.Drawing.Size(77, 13);
            this.labelLinkAnimetionRomOffset.TabIndex = 9;
            this.labelLinkAnimetionRomOffset.Text = "link_animetion:";
            // 
            // textBoxLinkAnimetionRomOffset
            // 
            this.textBoxLinkAnimetionRomOffset.Location = new System.Drawing.Point(94, 46);
            this.textBoxLinkAnimetionRomOffset.Name = "textBoxLinkAnimetionRomOffset";
            this.textBoxLinkAnimetionRomOffset.Size = new System.Drawing.Size(93, 20);
            this.textBoxLinkAnimetionRomOffset.TabIndex = 8;
            this.textBoxLinkAnimetionRomOffset.Text = "0x004E5C00";
            // 
            // labelAnimTableEntryGameplayKeepOffset
            // 
            this.labelAnimTableEntryGameplayKeepOffset.AutoSize = true;
            this.labelAnimTableEntryGameplayKeepOffset.Location = new System.Drawing.Point(6, 100);
            this.labelAnimTableEntryGameplayKeepOffset.Name = "labelAnimTableEntryGameplayKeepOffset";
            this.labelAnimTableEntryGameplayKeepOffset.Size = new System.Drawing.Size(56, 13);
            this.labelAnimTableEntryGameplayKeepOffset.TabIndex = 7;
            this.labelAnimTableEntryGameplayKeepOffset.Text = "Animation:";
            // 
            // textBoxAnimTableEntryGameplayKeepOffset
            // 
            this.textBoxAnimTableEntryGameplayKeepOffset.Location = new System.Drawing.Point(94, 98);
            this.textBoxAnimTableEntryGameplayKeepOffset.Name = "textBoxAnimTableEntryGameplayKeepOffset";
            this.textBoxAnimTableEntryGameplayKeepOffset.Size = new System.Drawing.Size(93, 20);
            this.textBoxAnimTableEntryGameplayKeepOffset.TabIndex = 6;
            this.textBoxAnimTableEntryGameplayKeepOffset.Text = "0x2310";
            // 
            // buttonOpenSelectRomDialogue
            // 
            this.buttonOpenSelectRomDialogue.Location = new System.Drawing.Point(152, 17);
            this.buttonOpenSelectRomDialogue.Name = "buttonOpenSelectRomDialogue";
            this.buttonOpenSelectRomDialogue.Size = new System.Drawing.Size(35, 23);
            this.buttonOpenSelectRomDialogue.TabIndex = 5;
            this.buttonOpenSelectRomDialogue.Text = "...";
            this.buttonOpenSelectRomDialogue.UseVisualStyleBackColor = true;
            this.buttonOpenSelectRomDialogue.Click += new System.EventHandler(this.buttonOpenSelectRomDialogue_Click);
            // 
            // textBoxRomPath
            // 
            this.textBoxRomPath.Location = new System.Drawing.Point(6, 19);
            this.textBoxRomPath.Name = "textBoxRomPath";
            this.textBoxRomPath.Size = new System.Drawing.Size(140, 20);
            this.textBoxRomPath.TabIndex = 4;
            // 
            // checkBoxFloorPlaneComp
            // 
            this.checkBoxFloorPlaneComp.AutoSize = true;
            this.checkBoxFloorPlaneComp.Location = new System.Drawing.Point(136, 272);
            this.checkBoxFloorPlaneComp.Name = "checkBoxFloorPlaneComp";
            this.checkBoxFloorPlaneComp.Size = new System.Drawing.Size(149, 17);
            this.checkBoxFloorPlaneComp.TabIndex = 3;
            this.checkBoxFloorPlaneComp.Text = "Floor Plane Compensation";
            this.checkBoxFloorPlaneComp.UseVisualStyleBackColor = true;
            this.checkBoxFloorPlaneComp.CheckedChanged += new System.EventHandler(this.checkBoxFloorPlaneComp_CheckedChanged);
            // 
            // buttonRefreshAnimList
            // 
            this.buttonRefreshAnimList.Location = new System.Drawing.Point(12, 268);
            this.buttonRefreshAnimList.Name = "buttonRefreshAnimList";
            this.buttonRefreshAnimList.Size = new System.Drawing.Size(123, 23);
            this.buttonRefreshAnimList.TabIndex = 2;
            this.buttonRefreshAnimList.Text = "Refresh Animation List";
            this.buttonRefreshAnimList.UseVisualStyleBackColor = true;
            this.buttonRefreshAnimList.Click += new System.EventHandler(this.buttonRefreshAnimList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 302);
            this.Controls.Add(this.buttonRefreshAnimList);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.checkBoxFloorPlaneComp);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Link Animation Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonOpenSelectAnimDialogue;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox textBoxAnimPath;
        private System.Windows.Forms.Label labelAnimPath;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxInjectToRom;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Button buttonOpenSelectRomDialogue;
        private System.Windows.Forms.TextBox textBoxRomPath;
        private System.Windows.Forms.Label labelAnimTableEntryGameplayKeepOffset;
        private System.Windows.Forms.TextBox textBoxAnimTableEntryGameplayKeepOffset;
        private System.Windows.Forms.Label labelGameplayKeepRomOffset;
        private System.Windows.Forms.TextBox textBoxGamePlayKeepRomOffset;
        private System.Windows.Forms.Label labelLinkAnimetionRomOffset;
        private System.Windows.Forms.TextBox textBoxLinkAnimetionRomOffset;
        private System.Windows.Forms.CheckBox checkBoxFloorPlaneComp;
        private System.Windows.Forms.ListBox listBoxRomVersionSelector;
        private System.Windows.Forms.Button buttonExportAll;
        private System.Windows.Forms.Button buttonRefreshAnimList;
        private System.Windows.Forms.Button buttonOpenSelectBinDialogue;
        private System.Windows.Forms.Label labelBinPath;
        private System.Windows.Forms.TextBox textBoxBinPath;
        private System.Windows.Forms.CheckBox checkBoxExtractLinkAnime;
    }
}

