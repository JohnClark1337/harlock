namespace Arcadia5
{
    partial class BatchCommander
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BatchCommander));
            this.gbxDriverBackup = new System.Windows.Forms.GroupBox();
            this.cbxdbd = new System.Windows.Forms.ComboBox();
            this.cbxdbs = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbxFileBackup = new System.Windows.Forms.GroupBox();
            this.btnDest = new System.Windows.Forms.Button();
            this.btnSource = new System.Windows.Forms.Button();
            this.tbxfbd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxfbs = new System.Windows.Forms.TextBox();
            this.lblFBSource = new System.Windows.Forms.Label();
            this.btnsys = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.cbxOpSel = new System.Windows.Forms.ComboBox();
            this.cbxChkDrives = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbxDriverBackup.SuspendLayout();
            this.gbxFileBackup.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxDriverBackup
            // 
            this.gbxDriverBackup.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gbxDriverBackup.Controls.Add(this.cbxdbd);
            this.gbxDriverBackup.Controls.Add(this.cbxdbs);
            this.gbxDriverBackup.Controls.Add(this.label2);
            this.gbxDriverBackup.Controls.Add(this.label3);
            this.gbxDriverBackup.Location = new System.Drawing.Point(21, 182);
            this.gbxDriverBackup.Name = "gbxDriverBackup";
            this.gbxDriverBackup.Size = new System.Drawing.Size(327, 140);
            this.gbxDriverBackup.TabIndex = 4;
            this.gbxDriverBackup.TabStop = false;
            this.gbxDriverBackup.Text = "Driver Backup";
            // 
            // cbxdbd
            // 
            this.cbxdbd.FormattingEnabled = true;
            this.cbxdbd.Location = new System.Drawing.Point(122, 80);
            this.cbxdbd.Name = "cbxdbd";
            this.cbxdbd.Size = new System.Drawing.Size(121, 21);
            this.cbxdbd.TabIndex = 6;
            // 
            // cbxdbs
            // 
            this.cbxdbs.FormattingEnabled = true;
            this.cbxdbs.Location = new System.Drawing.Point(122, 20);
            this.cbxdbs.Name = "cbxdbs";
            this.cbxdbs.Size = new System.Drawing.Size(121, 21);
            this.cbxdbs.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Destination:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Source:";
            // 
            // gbxFileBackup
            // 
            this.gbxFileBackup.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gbxFileBackup.Controls.Add(this.btnDest);
            this.gbxFileBackup.Controls.Add(this.btnSource);
            this.gbxFileBackup.Controls.Add(this.tbxfbd);
            this.gbxFileBackup.Controls.Add(this.label1);
            this.gbxFileBackup.Controls.Add(this.tbxfbs);
            this.gbxFileBackup.Controls.Add(this.lblFBSource);
            this.gbxFileBackup.Location = new System.Drawing.Point(21, 22);
            this.gbxFileBackup.Name = "gbxFileBackup";
            this.gbxFileBackup.Size = new System.Drawing.Size(436, 140);
            this.gbxFileBackup.TabIndex = 1;
            this.gbxFileBackup.TabStop = false;
            this.gbxFileBackup.Text = "File Backup";
            // 
            // btnDest
            // 
            this.btnDest.Location = new System.Drawing.Point(344, 80);
            this.btnDest.Name = "btnDest";
            this.btnDest.Size = new System.Drawing.Size(75, 23);
            this.btnDest.TabIndex = 3;
            this.btnDest.Text = "Select";
            this.btnDest.UseVisualStyleBackColor = true;
            this.btnDest.Click += new System.EventHandler(this.btnDest_Click);
            // 
            // btnSource
            // 
            this.btnSource.Location = new System.Drawing.Point(344, 19);
            this.btnSource.Name = "btnSource";
            this.btnSource.Size = new System.Drawing.Size(75, 23);
            this.btnSource.TabIndex = 2;
            this.btnSource.Text = "Select";
            this.btnSource.UseVisualStyleBackColor = true;
            this.btnSource.Click += new System.EventHandler(this.btnSource_Click);
            // 
            // tbxfbd
            // 
            this.tbxfbd.Location = new System.Drawing.Point(119, 80);
            this.tbxfbd.Name = "tbxfbd";
            this.tbxfbd.Size = new System.Drawing.Size(208, 20);
            this.tbxfbd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Destination:";
            // 
            // tbxfbs
            // 
            this.tbxfbs.Location = new System.Drawing.Point(119, 19);
            this.tbxfbs.Name = "tbxfbs";
            this.tbxfbs.Size = new System.Drawing.Size(208, 20);
            this.tbxfbs.TabIndex = 0;
            this.tbxfbs.Text = "C:\\users";
            // 
            // lblFBSource
            // 
            this.lblFBSource.AutoSize = true;
            this.lblFBSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFBSource.Location = new System.Drawing.Point(7, 20);
            this.lblFBSource.Name = "lblFBSource";
            this.lblFBSource.Size = new System.Drawing.Size(71, 20);
            this.lblFBSource.TabIndex = 0;
            this.lblFBSource.Text = "Source:";
            // 
            // btnsys
            // 
            this.btnsys.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsys.Location = new System.Drawing.Point(506, 22);
            this.btnsys.Name = "btnsys";
            this.btnsys.Size = new System.Drawing.Size(168, 80);
            this.btnsys.TabIndex = 9;
            this.btnsys.Text = "SysInternals";
            this.btnsys.UseVisualStyleBackColor = true;
            this.btnsys.Click += new System.EventHandler(this.btnsys_Click);
            // 
            // btnRun
            // 
            this.btnRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.Location = new System.Drawing.Point(357, 386);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(208, 40);
            this.btnRun.TabIndex = 8;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // cbxOpSel
            // 
            this.cbxOpSel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxOpSel.FormattingEnabled = true;
            this.cbxOpSel.ItemHeight = 25;
            this.cbxOpSel.Items.AddRange(new object[] {
            "File Backup",
            "Driver Backup",
            "Check Disk",
            "Scan Filesystem"});
            this.cbxOpSel.Location = new System.Drawing.Point(21, 389);
            this.cbxOpSel.Name = "cbxOpSel";
            this.cbxOpSel.Size = new System.Drawing.Size(212, 33);
            this.cbxOpSel.TabIndex = 0;
            this.cbxOpSel.SelectedIndexChanged += new System.EventHandler(this.cbxOpSel_SelectedIndexChanged);
            // 
            // cbxChkDrives
            // 
            this.cbxChkDrives.Enabled = false;
            this.cbxChkDrives.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxChkDrives.FormattingEnabled = true;
            this.cbxChkDrives.ItemHeight = 25;
            this.cbxChkDrives.Items.AddRange(new object[] {
            "File Backup",
            "Driver Backup",
            "Check Disk",
            "Scan Filesystem"});
            this.cbxChkDrives.Location = new System.Drawing.Point(250, 389);
            this.cbxChkDrives.Name = "cbxChkDrives";
            this.cbxChkDrives.Size = new System.Drawing.Size(78, 33);
            this.cbxChkDrives.TabIndex = 7;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(571, 386);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(103, 40);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // BatchCommander
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 448);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.cbxChkDrives);
            this.Controls.Add(this.btnsys);
            this.Controls.Add(this.gbxDriverBackup);
            this.Controls.Add(this.cbxOpSel);
            this.Controls.Add(this.gbxFileBackup);
            this.Controls.Add(this.btnRun);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BatchCommander";
            this.Text = "Batch Commander";
            this.gbxDriverBackup.ResumeLayout(false);
            this.gbxDriverBackup.PerformLayout();
            this.gbxFileBackup.ResumeLayout(false);
            this.gbxFileBackup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbxFileBackup;
        private System.Windows.Forms.Button btnDest;
        private System.Windows.Forms.Button btnSource;
        private System.Windows.Forms.TextBox tbxfbd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxfbs;
        private System.Windows.Forms.Label lblFBSource;
        private System.Windows.Forms.GroupBox gbxDriverBackup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.ComboBox cbxOpSel;
        private System.Windows.Forms.ComboBox cbxdbd;
        private System.Windows.Forms.ComboBox cbxdbs;
        private System.Windows.Forms.Button btnsys;
        private System.Windows.Forms.ComboBox cbxChkDrives;
        private System.Windows.Forms.Button btnExit;
    }
}