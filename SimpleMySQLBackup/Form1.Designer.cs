namespace SimpleMySQLBackup
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DtlsGroup = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ServerPortTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.PasswdTextBox = new System.Windows.Forms.TextBox();
            this.UserIdTextBox = new System.Windows.Forms.TextBox();
            this.DatabaseTextBox = new System.Windows.Forms.TextBox();
            this.ServerTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.VerifyButtonTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.BackpGroup = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.ConvertDateTimeCheckBox = new System.Windows.Forms.CheckBox();
            this.BckpCharSetBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnBackp = new System.Windows.Forms.Button();
            this.BtnBckpBrowse = new System.Windows.Forms.Button();
            this.SavePathBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PortTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.RestorGroup = new System.Windows.Forms.GroupBox();
            this.BtnRestor = new System.Windows.Forms.Button();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.RestorConvertDateTimeCheckBox = new System.Windows.Forms.CheckBox();
            this.RestorCharSetBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.BtnCr = new System.Windows.Forms.Button();
            this.RestorNewCharSetBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.RstorDatabaseNameBox = new System.Windows.Forms.TextBox();
            this.BtnRestoreBrowse = new System.Windows.Forms.Button();
            this.RestorePathBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnExit = new System.Windows.Forms.Button();
            this.NewDbaseToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.NewDbaseNameToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.NewCharSetToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.CnvrtToZeroToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.CnvtToZeroInfoToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DtlsGroup.SuspendLayout();
            this.BackpGroup.SuspendLayout();
            this.RestorGroup.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DtlsGroup
            // 
            this.DtlsGroup.Controls.Add(this.label5);
            this.DtlsGroup.Controls.Add(this.ServerPortTextBox);
            this.DtlsGroup.Controls.Add(this.button1);
            this.DtlsGroup.Controls.Add(this.PasswdTextBox);
            this.DtlsGroup.Controls.Add(this.UserIdTextBox);
            this.DtlsGroup.Controls.Add(this.DatabaseTextBox);
            this.DtlsGroup.Controls.Add(this.ServerTextBox);
            this.DtlsGroup.Controls.Add(this.label3);
            this.DtlsGroup.Controls.Add(this.label4);
            this.DtlsGroup.Controls.Add(this.label2);
            this.DtlsGroup.Controls.Add(this.label1);
            this.DtlsGroup.Location = new System.Drawing.Point(24, 30);
            this.DtlsGroup.Name = "DtlsGroup";
            this.DtlsGroup.Size = new System.Drawing.Size(578, 173);
            this.DtlsGroup.TabIndex = 0;
            this.DtlsGroup.TabStop = false;
            this.DtlsGroup.Text = "Details";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(152, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Port :";
            this.VerifyButtonTooltip.SetToolTip(this.label5, "if this is blank it will connect to default port (port : 3360)");
            // 
            // ServerPortTextBox
            // 
            this.ServerPortTextBox.Location = new System.Drawing.Point(195, 129);
            this.ServerPortTextBox.Name = "ServerPortTextBox";
            this.ServerPortTextBox.Size = new System.Drawing.Size(100, 20);
            this.ServerPortTextBox.TabIndex = 9;
            this.ServerPortTextBox.Text = "3306";
            this.PortTooltip.SetToolTip(this.ServerPortTextBox, "if this is blank it will connect to default port (port : 3360)");
            this.ServerPortTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ServerPortTextBox_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(313, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 36);
            this.button1.TabIndex = 8;
            this.button1.Text = "Test Connection";
            this.VerifyButtonTooltip.SetToolTip(this.button1, "Clieck here to test your connection");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PasswdTextBox
            // 
            this.PasswdTextBox.Location = new System.Drawing.Point(409, 72);
            this.PasswdTextBox.Name = "PasswdTextBox";
            this.PasswdTextBox.PasswordChar = '*';
            this.PasswdTextBox.Size = new System.Drawing.Size(128, 20);
            this.PasswdTextBox.TabIndex = 7;
            // 
            // UserIdTextBox
            // 
            this.UserIdTextBox.Location = new System.Drawing.Point(409, 37);
            this.UserIdTextBox.Name = "UserIdTextBox";
            this.UserIdTextBox.Size = new System.Drawing.Size(128, 20);
            this.UserIdTextBox.TabIndex = 6;
            // 
            // DatabaseTextBox
            // 
            this.DatabaseTextBox.Location = new System.Drawing.Point(111, 72);
            this.DatabaseTextBox.Name = "DatabaseTextBox";
            this.DatabaseTextBox.Size = new System.Drawing.Size(128, 20);
            this.DatabaseTextBox.TabIndex = 5;
            // 
            // ServerTextBox
            // 
            this.ServerTextBox.Location = new System.Drawing.Point(111, 37);
            this.ServerTextBox.Name = "ServerTextBox";
            this.ServerTextBox.Size = new System.Drawing.Size(128, 20);
            this.ServerTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(354, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "User ID :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(344, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Password :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Database :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server :";
            // 
            // BackpGroup
            // 
            this.BackpGroup.Controls.Add(this.linkLabel1);
            this.BackpGroup.Controls.Add(this.ConvertDateTimeCheckBox);
            this.BackpGroup.Controls.Add(this.BckpCharSetBox);
            this.BackpGroup.Controls.Add(this.label10);
            this.BackpGroup.Controls.Add(this.BtnBackp);
            this.BackpGroup.Controls.Add(this.BtnBckpBrowse);
            this.BackpGroup.Controls.Add(this.SavePathBox);
            this.BackpGroup.Controls.Add(this.label6);
            this.BackpGroup.Location = new System.Drawing.Point(24, 209);
            this.BackpGroup.Name = "BackpGroup";
            this.BackpGroup.Size = new System.Drawing.Size(578, 162);
            this.BackpGroup.TabIndex = 1;
            this.BackpGroup.TabStop = false;
            this.BackpGroup.Text = "Backup Database";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(44, 100);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(13, 13);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "?";
            this.CnvtToZeroInfoToolTip.SetToolTip(this.linkLabel1, "Click here to know more about convertzerodatetime.");
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // ConvertDateTimeCheckBox
            // 
            this.ConvertDateTimeCheckBox.AutoSize = true;
            this.ConvertDateTimeCheckBox.Checked = true;
            this.ConvertDateTimeCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ConvertDateTimeCheckBox.Location = new System.Drawing.Point(60, 101);
            this.ConvertDateTimeCheckBox.Name = "ConvertDateTimeCheckBox";
            this.ConvertDateTimeCheckBox.Size = new System.Drawing.Size(140, 17);
            this.ConvertDateTimeCheckBox.TabIndex = 9;
            this.ConvertDateTimeCheckBox.Text = "Convert Zero Date Time";
            this.CnvrtToZeroToolTip.SetToolTip(this.ConvertDateTimeCheckBox, "This checked by default to avoid connection problems on some database");
            this.ConvertDateTimeCheckBox.UseVisualStyleBackColor = true;
            // 
            // BckpCharSetBox
            // 
            this.BckpCharSetBox.FormattingEnabled = true;
            this.BckpCharSetBox.Items.AddRange(new object[] {
            "utf8",
            "ucs2",
            "utf8mb4",
            "utf16",
            "utf32"});
            this.BckpCharSetBox.Location = new System.Drawing.Point(296, 99);
            this.BckpCharSetBox.Name = "BckpCharSetBox";
            this.BckpCharSetBox.Size = new System.Drawing.Size(116, 21);
            this.BckpCharSetBox.TabIndex = 7;
            this.BckpCharSetBox.Text = "utf8";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(221, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Char Set :";
            // 
            // BtnBackp
            // 
            this.BtnBackp.Enabled = false;
            this.BtnBackp.Location = new System.Drawing.Point(439, 114);
            this.BtnBackp.Name = "BtnBackp";
            this.BtnBackp.Size = new System.Drawing.Size(101, 36);
            this.BtnBackp.TabIndex = 3;
            this.BtnBackp.Text = "Backup";
            this.BtnBackp.UseVisualStyleBackColor = true;
            this.BtnBackp.Click += new System.EventHandler(this.BtnBackp_Click);
            // 
            // BtnBckpBrowse
            // 
            this.BtnBckpBrowse.Location = new System.Drawing.Point(444, 48);
            this.BtnBckpBrowse.Name = "BtnBckpBrowse";
            this.BtnBckpBrowse.Size = new System.Drawing.Size(86, 31);
            this.BtnBckpBrowse.TabIndex = 2;
            this.BtnBckpBrowse.Text = "Browse";
            this.BtnBckpBrowse.UseVisualStyleBackColor = true;
            this.BtnBckpBrowse.Click += new System.EventHandler(this.BtnBckpBrowse_Click);
            // 
            // SavePathBox
            // 
            this.SavePathBox.Location = new System.Drawing.Point(113, 54);
            this.SavePathBox.Name = "SavePathBox";
            this.SavePathBox.Size = new System.Drawing.Size(315, 20);
            this.SavePathBox.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Save to :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Name :";
            this.PortTooltip.SetToolTip(this.label8, "Name for the new database when restore");
            // 
            // RestorGroup
            // 
            this.RestorGroup.Controls.Add(this.BtnRestor);
            this.RestorGroup.Controls.Add(this.linkLabel2);
            this.RestorGroup.Controls.Add(this.RestorConvertDateTimeCheckBox);
            this.RestorGroup.Controls.Add(this.RestorCharSetBox);
            this.RestorGroup.Controls.Add(this.label7);
            this.RestorGroup.Controls.Add(this.groupBox4);
            this.RestorGroup.Controls.Add(this.BtnRestoreBrowse);
            this.RestorGroup.Controls.Add(this.RestorePathBox);
            this.RestorGroup.Controls.Add(this.label9);
            this.RestorGroup.Location = new System.Drawing.Point(24, 378);
            this.RestorGroup.Name = "RestorGroup";
            this.RestorGroup.Size = new System.Drawing.Size(578, 212);
            this.RestorGroup.TabIndex = 2;
            this.RestorGroup.TabStop = false;
            this.RestorGroup.Text = "Restore Database";
            // 
            // BtnRestor
            // 
            this.BtnRestor.Enabled = false;
            this.BtnRestor.Location = new System.Drawing.Point(439, 161);
            this.BtnRestor.Name = "BtnRestor";
            this.BtnRestor.Size = new System.Drawing.Size(101, 36);
            this.BtnRestor.TabIndex = 13;
            this.BtnRestor.Text = "Restore";
            this.BtnRestor.UseVisualStyleBackColor = true;
            this.BtnRestor.Click += new System.EventHandler(this.BtnRestor_Click);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(534, 135);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(13, 13);
            this.linkLabel2.TabIndex = 12;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "?";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // RestorConvertDateTimeCheckBox
            // 
            this.RestorConvertDateTimeCheckBox.AutoSize = true;
            this.RestorConvertDateTimeCheckBox.Checked = true;
            this.RestorConvertDateTimeCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RestorConvertDateTimeCheckBox.Location = new System.Drawing.Point(400, 134);
            this.RestorConvertDateTimeCheckBox.Name = "RestorConvertDateTimeCheckBox";
            this.RestorConvertDateTimeCheckBox.Size = new System.Drawing.Size(140, 17);
            this.RestorConvertDateTimeCheckBox.TabIndex = 11;
            this.RestorConvertDateTimeCheckBox.Text = "Convert Zero Date Time";
            this.RestorConvertDateTimeCheckBox.UseVisualStyleBackColor = true;
            // 
            // RestorCharSetBox
            // 
            this.RestorCharSetBox.FormattingEnabled = true;
            this.RestorCharSetBox.Items.AddRange(new object[] {
            "utf8",
            "ucs2",
            "utf8mb4",
            "utf16",
            "utf32"});
            this.RestorCharSetBox.Location = new System.Drawing.Point(441, 100);
            this.RestorCharSetBox.Name = "RestorCharSetBox";
            this.RestorCharSetBox.Size = new System.Drawing.Size(116, 21);
            this.RestorCharSetBox.TabIndex = 9;
            this.RestorCharSetBox.Text = "utf8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(377, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Char Set :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBox1);
            this.groupBox4.Controls.Add(this.BtnCr);
            this.groupBox4.Controls.Add(this.RestorNewCharSetBox);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.RstorDatabaseNameBox);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(19, 94);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(345, 109);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "New Database";
            this.NewDbaseToolTip.SetToolTip(this.groupBox4, "This option only needed to restore to non-exist database");
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(227, 23);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckStateChanged += new System.EventHandler(this.checkBox1_CheckStateChanged);
            // 
            // BtnCr
            // 
            this.BtnCr.Enabled = false;
            this.BtnCr.Location = new System.Drawing.Point(227, 46);
            this.BtnCr.Name = "BtnCr";
            this.BtnCr.Size = new System.Drawing.Size(101, 42);
            this.BtnCr.TabIndex = 10;
            this.BtnCr.Text = "Create && Restore";
            this.BtnCr.UseVisualStyleBackColor = true;
            this.BtnCr.Click += new System.EventHandler(this.BtnCr_Click);
            // 
            // RestorNewCharSetBox
            // 
            this.RestorNewCharSetBox.FormattingEnabled = true;
            this.RestorNewCharSetBox.Items.AddRange(new object[] {
            "utf8",
            "ucs2",
            "utf8mb4",
            "utf16",
            "utf32"});
            this.RestorNewCharSetBox.Location = new System.Drawing.Point(77, 66);
            this.RestorNewCharSetBox.Name = "RestorNewCharSetBox";
            this.RestorNewCharSetBox.Size = new System.Drawing.Size(124, 21);
            this.RestorNewCharSetBox.TabIndex = 9;
            this.RestorNewCharSetBox.Text = "utf8";
            this.NewCharSetToolTip.SetToolTip(this.RestorNewCharSetBox, "Charset for the new database");
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Char Set :";
            this.NewCharSetToolTip.SetToolTip(this.label11, "Charset for the new database");
            // 
            // RstorDatabaseNameBox
            // 
            this.RstorDatabaseNameBox.Location = new System.Drawing.Point(77, 30);
            this.RstorDatabaseNameBox.Name = "RstorDatabaseNameBox";
            this.RstorDatabaseNameBox.Size = new System.Drawing.Size(124, 20);
            this.RstorDatabaseNameBox.TabIndex = 1;
            this.NewDbaseNameToolTip.SetToolTip(this.RstorDatabaseNameBox, "Name for the new database when restore");
            // 
            // BtnRestoreBrowse
            // 
            this.BtnRestoreBrowse.Location = new System.Drawing.Point(445, 48);
            this.BtnRestoreBrowse.Name = "BtnRestoreBrowse";
            this.BtnRestoreBrowse.Size = new System.Drawing.Size(86, 31);
            this.BtnRestoreBrowse.TabIndex = 5;
            this.BtnRestoreBrowse.Text = "Browse";
            this.BtnRestoreBrowse.UseVisualStyleBackColor = true;
            this.BtnRestoreBrowse.Click += new System.EventHandler(this.BtnRestoreBrowse_Click);
            // 
            // RestorePathBox
            // 
            this.RestorePathBox.Location = new System.Drawing.Point(113, 54);
            this.RestorePathBox.Name = "RestorePathBox";
            this.RestorePathBox.Size = new System.Drawing.Size(315, 20);
            this.RestorePathBox.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Restore from :";
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(463, 605);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(101, 36);
            this.BtnExit.TabIndex = 14;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(625, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 657);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.RestorGroup);
            this.Controls.Add(this.BackpGroup);
            this.Controls.Add(this.DtlsGroup);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MySql Tools";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.DtlsGroup.ResumeLayout(false);
            this.DtlsGroup.PerformLayout();
            this.BackpGroup.ResumeLayout(false);
            this.BackpGroup.PerformLayout();
            this.RestorGroup.ResumeLayout(false);
            this.RestorGroup.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox DtlsGroup;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip VerifyButtonTooltip;
        private System.Windows.Forms.TextBox PasswdTextBox;
        private System.Windows.Forms.TextBox UserIdTextBox;
        private System.Windows.Forms.TextBox DatabaseTextBox;
        private System.Windows.Forms.TextBox ServerTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ServerPortTextBox;
        private System.Windows.Forms.GroupBox BackpGroup;
        private System.Windows.Forms.ToolTip PortTooltip;
        private System.Windows.Forms.CheckBox ConvertDateTimeCheckBox;
        private System.Windows.Forms.ComboBox BckpCharSetBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BtnBackp;
        private System.Windows.Forms.Button BtnBckpBrowse;
        private System.Windows.Forms.TextBox SavePathBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox RestorGroup;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox RstorDatabaseNameBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnRestoreBrowse;
        private System.Windows.Forms.TextBox RestorePathBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox RestorNewCharSetBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BtnRestor;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.CheckBox RestorConvertDateTimeCheckBox;
        private System.Windows.Forms.ComboBox RestorCharSetBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnCr;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.ToolTip NewDbaseToolTip;
        private System.Windows.Forms.ToolTip NewDbaseNameToolTip;
        private System.Windows.Forms.ToolTip NewCharSetToolTip;
        private System.Windows.Forms.ToolTip CnvtToZeroInfoToolTip;
        private System.Windows.Forms.ToolTip CnvrtToZeroToolTip;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

