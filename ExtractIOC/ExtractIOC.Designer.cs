namespace ExtractIOC
{
    partial class ExtractIOC
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExtractIOC));
            this.statusBar = new System.Windows.Forms.Label();
            this.tFixLink = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.extractProgressBar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.fileListingBox = new System.Windows.Forms.GroupBox();
            this.fileListingListBox = new System.Windows.Forms.ListBox();
            this.fileSelectGroupBox = new System.Windows.Forms.GroupBox();
            this.fileSelectBtn = new System.Windows.Forms.Button();
            this.extractButton = new System.Windows.Forms.Button();
            this.threatBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iocCountBox = new System.Windows.Forms.GroupBox();
            this.iocCountListBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.loadWListBtn = new System.Windows.Forms.Button();
            this.modifyWListBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.newLineRadio = new System.Windows.Forms.RadioButton();
            this.csvRadio = new System.Windows.Forms.RadioButton();
            this.exportGroupBox = new System.Windows.Forms.GroupBox();
            this.emailCheckBox = new System.Windows.Forms.CheckBox();
            this.domainCheckBox = new System.Windows.Forms.CheckBox();
            this.ipv4CheckBox = new System.Windows.Forms.CheckBox();
            this.md5CheckBox = new System.Windows.Forms.CheckBox();
            this.exportBox = new System.Windows.Forms.GroupBox();
            this.safeIOCBox = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel2.SuspendLayout();
            this.fileListingBox.SuspendLayout();
            this.fileSelectGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.threatBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.iocCountBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.exportGroupBox.SuspendLayout();
            this.exportBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusBar
            // 
            this.statusBar.AutoSize = true;
            this.statusBar.ForeColor = System.Drawing.Color.Gray;
            this.statusBar.Location = new System.Drawing.Point(18, 3);
            this.statusBar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(0, 15);
            this.statusBar.TabIndex = 19;
            // 
            // tFixLink
            // 
            this.tFixLink.AutoSize = true;
            this.tFixLink.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tFixLink.Location = new System.Drawing.Point(376, 13);
            this.tFixLink.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tFixLink.Name = "tFixLink";
            this.tFixLink.Size = new System.Drawing.Size(75, 15);
            this.tFixLink.TabIndex = 17;
            this.tFixLink.TabStop = true;
            this.tFixLink.Text = "ThreatFix.com";
            this.tFixLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.tFixLink_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(336, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Visit us:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.extractProgressBar);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.statusBar);
            this.panel2.Controls.Add(this.tFixLink);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(-5, 518);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(466, 36);
            this.panel2.TabIndex = 28;
            // 
            // extractProgressBar
            // 
            this.extractProgressBar.Location = new System.Drawing.Point(3, -2);
            this.extractProgressBar.Name = "extractProgressBar";
            this.extractProgressBar.Size = new System.Drawing.Size(461, 12);
            this.extractProgressBar.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(11, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "ExtractIOC 1.0";
            // 
            // fileListingBox
            // 
            this.fileListingBox.Controls.Add(this.fileListingListBox);
            this.fileListingBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileListingBox.Location = new System.Drawing.Point(181, 85);
            this.fileListingBox.Margin = new System.Windows.Forms.Padding(2);
            this.fileListingBox.Name = "fileListingBox";
            this.fileListingBox.Padding = new System.Windows.Forms.Padding(2);
            this.fileListingBox.Size = new System.Drawing.Size(269, 186);
            this.fileListingBox.TabIndex = 25;
            this.fileListingBox.TabStop = false;
            this.fileListingBox.Text = "File Listing";
            // 
            // fileListingListBox
            // 
            this.fileListingListBox.BackColor = System.Drawing.SystemColors.Control;
            this.fileListingListBox.FormattingEnabled = true;
            this.fileListingListBox.HorizontalScrollbar = true;
            this.fileListingListBox.ItemHeight = 15;
            this.fileListingListBox.Location = new System.Drawing.Point(6, 22);
            this.fileListingListBox.Name = "fileListingListBox";
            this.fileListingListBox.Size = new System.Drawing.Size(258, 154);
            this.fileListingListBox.Sorted = true;
            this.fileListingListBox.TabIndex = 0;
            // 
            // fileSelectGroupBox
            // 
            this.fileSelectGroupBox.Controls.Add(this.fileSelectBtn);
            this.fileSelectGroupBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileSelectGroupBox.Location = new System.Drawing.Point(11, 85);
            this.fileSelectGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.fileSelectGroupBox.Name = "fileSelectGroupBox";
            this.fileSelectGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.fileSelectGroupBox.Size = new System.Drawing.Size(165, 102);
            this.fileSelectGroupBox.TabIndex = 23;
            this.fileSelectGroupBox.TabStop = false;
            this.fileSelectGroupBox.Text = "File Selection";
            // 
            // fileSelectBtn
            // 
            this.fileSelectBtn.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileSelectBtn.Location = new System.Drawing.Point(17, 22);
            this.fileSelectBtn.Name = "fileSelectBtn";
            this.fileSelectBtn.Size = new System.Drawing.Size(136, 65);
            this.fileSelectBtn.TabIndex = 0;
            this.fileSelectBtn.Text = "Select File(s)";
            this.fileSelectBtn.UseVisualStyleBackColor = true;
            this.fileSelectBtn.Click += new System.EventHandler(this.fileSelectBtn_Click);
            // 
            // extractButton
            // 
            this.extractButton.Enabled = false;
            this.extractButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extractButton.Location = new System.Drawing.Point(5, 23);
            this.extractButton.Name = "extractButton";
            this.extractButton.Size = new System.Drawing.Size(254, 28);
            this.extractButton.TabIndex = 3;
            this.extractButton.Text = "Extract";
            this.extractButton.UseVisualStyleBackColor = true;
            this.extractButton.Click += new System.EventHandler(this.extractButton_Click);
            // 
            // threatBox
            // 
            this.threatBox.BackColor = System.Drawing.Color.Gainsboro;
            this.threatBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.threatBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.threatBox.Image = ((System.Drawing.Image)(resources.GetObject("threatBox.Image")));
            this.threatBox.Location = new System.Drawing.Point(-5, 3);
            this.threatBox.Margin = new System.Windows.Forms.Padding(2);
            this.threatBox.Name = "threatBox";
            this.threatBox.Size = new System.Drawing.Size(476, 84);
            this.threatBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.threatBox.TabIndex = 12;
            this.threatBox.TabStop = false;
            this.threatBox.Click += new System.EventHandler(this.threatBox_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.threatBox);
            this.panel1.Location = new System.Drawing.Point(-5, -7);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 87);
            this.panel1.TabIndex = 22;
            // 
            // iocCountBox
            // 
            this.iocCountBox.Controls.Add(this.iocCountListBox);
            this.iocCountBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iocCountBox.Location = new System.Drawing.Point(181, 278);
            this.iocCountBox.Margin = new System.Windows.Forms.Padding(2);
            this.iocCountBox.Name = "iocCountBox";
            this.iocCountBox.Padding = new System.Windows.Forms.Padding(2);
            this.iocCountBox.Size = new System.Drawing.Size(269, 165);
            this.iocCountBox.TabIndex = 26;
            this.iocCountBox.TabStop = false;
            this.iocCountBox.Text = "IOC Count";
            // 
            // iocCountListBox
            // 
            this.iocCountListBox.BackColor = System.Drawing.SystemColors.Control;
            this.iocCountListBox.FormattingEnabled = true;
            this.iocCountListBox.ItemHeight = 15;
            this.iocCountListBox.Location = new System.Drawing.Point(5, 20);
            this.iocCountListBox.Name = "iocCountListBox";
            this.iocCountListBox.Size = new System.Drawing.Size(259, 139);
            this.iocCountListBox.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.extractButton);
            this.groupBox1.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(186, 449);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(264, 65);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Extract";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.loadWListBtn);
            this.groupBox2.Controls.Add(this.modifyWListBtn);
            this.groupBox2.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(11, 449);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(165, 65);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Whitelist";
            // 
            // loadWListBtn
            // 
            this.loadWListBtn.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadWListBtn.Location = new System.Drawing.Point(7, 23);
            this.loadWListBtn.Name = "loadWListBtn";
            this.loadWListBtn.Size = new System.Drawing.Size(68, 28);
            this.loadWListBtn.TabIndex = 1;
            this.loadWListBtn.Text = "Load";
            this.loadWListBtn.UseVisualStyleBackColor = true;
            this.loadWListBtn.Click += new System.EventHandler(this.loadWListBtn_Click);
            // 
            // modifyWListBtn
            // 
            this.modifyWListBtn.Enabled = false;
            this.modifyWListBtn.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyWListBtn.Location = new System.Drawing.Point(90, 23);
            this.modifyWListBtn.Name = "modifyWListBtn";
            this.modifyWListBtn.Size = new System.Drawing.Size(57, 28);
            this.modifyWListBtn.TabIndex = 0;
            this.modifyWListBtn.Text = "Modify";
            this.modifyWListBtn.UseVisualStyleBackColor = true;
            this.modifyWListBtn.Click += new System.EventHandler(this.modifyWListBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.newLineRadio);
            this.groupBox3.Controls.Add(this.csvRadio);
            this.groupBox3.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(11, 278);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(165, 75);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Export Type";
            // 
            // newLineRadio
            // 
            this.newLineRadio.AutoSize = true;
            this.newLineRadio.Checked = true;
            this.newLineRadio.Location = new System.Drawing.Point(7, 25);
            this.newLineRadio.Name = "newLineRadio";
            this.newLineRadio.Size = new System.Drawing.Size(67, 19);
            this.newLineRadio.TabIndex = 1;
            this.newLineRadio.TabStop = true;
            this.newLineRadio.Text = "Flat Text";
            this.newLineRadio.UseVisualStyleBackColor = true;
            // 
            // csvRadio
            // 
            this.csvRadio.AutoSize = true;
            this.csvRadio.Location = new System.Drawing.Point(6, 50);
            this.csvRadio.Name = "csvRadio";
            this.csvRadio.Size = new System.Drawing.Size(43, 19);
            this.csvRadio.TabIndex = 0;
            this.csvRadio.Text = "CSV";
            this.csvRadio.UseVisualStyleBackColor = true;
            // 
            // exportGroupBox
            // 
            this.exportGroupBox.Controls.Add(this.emailCheckBox);
            this.exportGroupBox.Controls.Add(this.domainCheckBox);
            this.exportGroupBox.Controls.Add(this.ipv4CheckBox);
            this.exportGroupBox.Controls.Add(this.md5CheckBox);
            this.exportGroupBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportGroupBox.Location = new System.Drawing.Point(11, 192);
            this.exportGroupBox.Name = "exportGroupBox";
            this.exportGroupBox.Size = new System.Drawing.Size(165, 79);
            this.exportGroupBox.TabIndex = 4;
            this.exportGroupBox.TabStop = false;
            this.exportGroupBox.Text = "IOC Types";
            // 
            // emailCheckBox
            // 
            this.emailCheckBox.AutoSize = true;
            this.emailCheckBox.Checked = true;
            this.emailCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.emailCheckBox.Location = new System.Drawing.Point(65, 22);
            this.emailCheckBox.Name = "emailCheckBox";
            this.emailCheckBox.Size = new System.Drawing.Size(53, 19);
            this.emailCheckBox.TabIndex = 4;
            this.emailCheckBox.Text = "Email";
            this.emailCheckBox.UseVisualStyleBackColor = true;
            // 
            // domainCheckBox
            // 
            this.domainCheckBox.AutoSize = true;
            this.domainCheckBox.Checked = true;
            this.domainCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.domainCheckBox.Location = new System.Drawing.Point(65, 50);
            this.domainCheckBox.Name = "domainCheckBox";
            this.domainCheckBox.Size = new System.Drawing.Size(63, 19);
            this.domainCheckBox.TabIndex = 3;
            this.domainCheckBox.Text = "Domain";
            this.domainCheckBox.UseVisualStyleBackColor = true;
            // 
            // ipv4CheckBox
            // 
            this.ipv4CheckBox.AutoSize = true;
            this.ipv4CheckBox.Checked = true;
            this.ipv4CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ipv4CheckBox.Location = new System.Drawing.Point(6, 50);
            this.ipv4CheckBox.Name = "ipv4CheckBox";
            this.ipv4CheckBox.Size = new System.Drawing.Size(47, 19);
            this.ipv4CheckBox.TabIndex = 1;
            this.ipv4CheckBox.Text = "IPv4";
            this.ipv4CheckBox.UseVisualStyleBackColor = true;
            // 
            // md5CheckBox
            // 
            this.md5CheckBox.AutoSize = true;
            this.md5CheckBox.Checked = true;
            this.md5CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.md5CheckBox.Location = new System.Drawing.Point(7, 23);
            this.md5CheckBox.Name = "md5CheckBox";
            this.md5CheckBox.Size = new System.Drawing.Size(48, 19);
            this.md5CheckBox.TabIndex = 0;
            this.md5CheckBox.Text = "MD5";
            this.md5CheckBox.UseVisualStyleBackColor = true;
            // 
            // exportBox
            // 
            this.exportBox.Controls.Add(this.safeIOCBox);
            this.exportBox.Location = new System.Drawing.Point(11, 360);
            this.exportBox.Name = "exportBox";
            this.exportBox.Size = new System.Drawing.Size(165, 83);
            this.exportBox.TabIndex = 30;
            this.exportBox.TabStop = false;
            this.exportBox.Text = "Export Options";
            // 
            // safeIOCBox
            // 
            this.safeIOCBox.AutoSize = true;
            this.safeIOCBox.Checked = true;
            this.safeIOCBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.safeIOCBox.Location = new System.Drawing.Point(7, 23);
            this.safeIOCBox.Name = "safeIOCBox";
            this.safeIOCBox.Size = new System.Drawing.Size(144, 19);
            this.safeIOCBox.TabIndex = 0;
            this.safeIOCBox.Text = "Safe IOCs (Use Brackets)";
            this.safeIOCBox.UseVisualStyleBackColor = true;
            // 
            // ExtractIOC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 551);
            this.Controls.Add(this.exportBox);
            this.Controls.Add(this.exportGroupBox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.iocCountBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.fileListingBox);
            this.Controls.Add(this.fileSelectGroupBox);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExtractIOC";
            this.Text = "ExtractIOC";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.fileListingBox.ResumeLayout(false);
            this.fileSelectGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.threatBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.iocCountBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.exportGroupBox.ResumeLayout(false);
            this.exportGroupBox.PerformLayout();
            this.exportBox.ResumeLayout(false);
            this.exportBox.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Label statusBar;
        private System.Windows.Forms.LinkLabel tFixLink;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox fileListingBox;
        private System.Windows.Forms.GroupBox fileSelectGroupBox;
        private System.Windows.Forms.Button fileSelectBtn;
        private System.Windows.Forms.Button extractButton;
        private System.Windows.Forms.PictureBox threatBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox fileListingListBox;
        private System.Windows.Forms.GroupBox iocCountBox;
        private System.Windows.Forms.ListBox iocCountListBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button modifyWListBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton newLineRadio;
        private System.Windows.Forms.RadioButton csvRadio;
        private System.Windows.Forms.GroupBox exportGroupBox;
        private System.Windows.Forms.CheckBox emailCheckBox;
        private System.Windows.Forms.CheckBox domainCheckBox;
        private System.Windows.Forms.CheckBox ipv4CheckBox;
        private System.Windows.Forms.CheckBox md5CheckBox;
        private System.Windows.Forms.GroupBox exportBox;
        private System.Windows.Forms.CheckBox safeIOCBox;
        private System.Windows.Forms.Button loadWListBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar extractProgressBar;

    }
}