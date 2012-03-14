namespace CAConL
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.label1 = new System.Windows.Forms.Label();
            this.txtLicNum = new System.Windows.Forms.TextBox();
            this.btnGetInfo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtEntity = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtIssueDate = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtExpDate = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtLicStatus = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtAddInfo = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lvClassifications = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.linkWorkrComp = new System.Windows.Forms.LinkLabel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.bwGetLicInfo = new System.ComponentModel.BackgroundWorker();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCurrentRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.getLicenseInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "License Number";
            // 
            // txtLicNum
            // 
            this.txtLicNum.Location = new System.Drawing.Point(102, 34);
            this.txtLicNum.Name = "txtLicNum";
            this.txtLicNum.Size = new System.Drawing.Size(100, 20);
            this.txtLicNum.TabIndex = 1;
            this.txtLicNum.Text = "835113";
            // 
            // btnGetInfo
            // 
            this.btnGetInfo.Location = new System.Drawing.Point(208, 32);
            this.btnGetInfo.Name = "btnGetInfo";
            this.btnGetInfo.Size = new System.Drawing.Size(240, 23);
            this.btnGetInfo.TabIndex = 2;
            this.btnGetInfo.Text = "&Get Info";
            this.btnGetInfo.UseVisualStyleBackColor = true;
            this.btnGetInfo.Click += new System.EventHandler(this.btnGetInfo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Location = new System.Drawing.Point(15, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Business Information";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(6, 19);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAddress.Size = new System.Drawing.Size(264, 75);
            this.txtAddress.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtEntity);
            this.groupBox2.Location = new System.Drawing.Point(15, 167);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(89, 47);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Entity";
            // 
            // txtEntity
            // 
            this.txtEntity.Location = new System.Drawing.Point(6, 19);
            this.txtEntity.Name = "txtEntity";
            this.txtEntity.Size = new System.Drawing.Size(75, 20);
            this.txtEntity.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtIssueDate);
            this.groupBox3.Location = new System.Drawing.Point(110, 167);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(89, 47);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Issue Date";
            // 
            // txtIssueDate
            // 
            this.txtIssueDate.Location = new System.Drawing.Point(6, 19);
            this.txtIssueDate.Name = "txtIssueDate";
            this.txtIssueDate.Size = new System.Drawing.Size(75, 20);
            this.txtIssueDate.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtExpDate);
            this.groupBox4.Location = new System.Drawing.Point(208, 167);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(83, 47);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Exp. Date";
            // 
            // txtExpDate
            // 
            this.txtExpDate.Location = new System.Drawing.Point(6, 19);
            this.txtExpDate.Name = "txtExpDate";
            this.txtExpDate.Size = new System.Drawing.Size(71, 20);
            this.txtExpDate.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtLicStatus);
            this.groupBox7.Location = new System.Drawing.Point(12, 220);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(279, 100);
            this.groupBox7.TabIndex = 7;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Lic. Status";
            // 
            // txtLicStatus
            // 
            this.txtLicStatus.Location = new System.Drawing.Point(6, 19);
            this.txtLicStatus.Multiline = true;
            this.txtLicStatus.Name = "txtLicStatus";
            this.txtLicStatus.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLicStatus.Size = new System.Drawing.Size(267, 75);
            this.txtLicStatus.TabIndex = 0;
            this.txtLicStatus.TextChanged += new System.EventHandler(this.txtLicStatus_TextChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtAddInfo);
            this.groupBox5.Location = new System.Drawing.Point(297, 220);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(276, 100);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Additional Information";
            // 
            // txtAddInfo
            // 
            this.txtAddInfo.Location = new System.Drawing.Point(6, 19);
            this.txtAddInfo.Multiline = true;
            this.txtAddInfo.Name = "txtAddInfo";
            this.txtAddInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAddInfo.Size = new System.Drawing.Size(264, 75);
            this.txtAddInfo.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lvClassifications);
            this.groupBox6.Location = new System.Drawing.Point(297, 61);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(276, 100);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Classifications";
            // 
            // lvClassifications
            // 
            this.lvClassifications.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvClassifications.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvClassifications.FullRowSelect = true;
            this.lvClassifications.GridLines = true;
            this.lvClassifications.Location = new System.Drawing.Point(3, 16);
            this.lvClassifications.Name = "lvClassifications";
            this.lvClassifications.Size = new System.Drawing.Size(270, 81);
            this.lvClassifications.TabIndex = 0;
            this.lvClassifications.UseCompatibleStateImageBehavior = false;
            this.lvClassifications.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Class";
            this.columnHeader1.Width = 58;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Description";
            this.columnHeader2.Width = 191;
            // 
            // linkWorkrComp
            // 
            this.linkWorkrComp.Location = new System.Drawing.Point(313, 168);
            this.linkWorkrComp.Name = "linkWorkrComp";
            this.linkWorkrComp.Size = new System.Drawing.Size(226, 18);
            this.linkWorkrComp.TabIndex = 12;
            this.linkWorkrComp.TabStop = true;
            this.linkWorkrComp.Text = "View Workers Compensation Information";
            this.linkWorkrComp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkWorkrComp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkWorkrComp_LinkClicked);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(454, 32);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(55, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(515, 32);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(55, 23);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // bwGetLicInfo
            // 
            this.bwGetLicInfo.WorkerReportsProgress = true;
            this.bwGetLicInfo.WorkerSupportsCancellation = true;
            this.bwGetLicInfo.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwGetLicInfo_DoWork);
            this.bwGetLicInfo.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwGetLicInfo_ProgressChanged);
            this.bwGetLicInfo.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwGetLicInfo_RunWorkerCompleted);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 333);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(583, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // status
            // 
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(54, 17);
            this.status.Text = "Waiting..";
            // 
            // linkLabel1
            // 
            this.linkLabel1.Location = new System.Drawing.Point(313, 186);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(226, 18);
            this.linkLabel1.TabIndex = 16;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "View Bonding Information";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(583, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getLicenseInfoToolStripMenuItem,
            this.saveCurrentRecordToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // saveCurrentRecordToolStripMenuItem
            // 
            this.saveCurrentRecordToolStripMenuItem.Name = "saveCurrentRecordToolStripMenuItem";
            this.saveCurrentRecordToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.saveCurrentRecordToolStripMenuItem.Text = "&Save Current Record";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(178, 6);
            // 
            // getLicenseInfoToolStripMenuItem
            // 
            this.getLicenseInfoToolStripMenuItem.Name = "getLicenseInfoToolStripMenuItem";
            this.getLicenseInfoToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.getLicenseInfoToolStripMenuItem.Text = "&Get License Info";
            this.getLicenseInfoToolStripMenuItem.Click += new System.EventHandler(this.getLicenseInfoToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 355);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.linkWorkrComp);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGetInfo);
            this.Controls.Add(this.txtLicNum);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CA Contractor Lookup";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLicNum;
        private System.Windows.Forms.Button btnGetInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtEntity;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtIssueDate;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtExpDate;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txtLicStatus;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtAddInfo;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ListView lvClassifications;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.LinkLabel linkWorkrComp;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.ComponentModel.BackgroundWorker bwGetLicInfo;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel status;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getLicenseInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveCurrentRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    }
}

