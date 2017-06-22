namespace Arcadia5
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
            this.btnAV = new System.Windows.Forms.Button();
            this.btnAM = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnSetup = new System.Windows.Forms.Button();
            this.btnTools = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbxProgs = new System.Windows.Forms.ListBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.pbxIcon = new System.Windows.Forms.PictureBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.rtbDescribe = new System.Windows.Forms.RichTextBox();
            this.btnBC = new System.Windows.Forms.Button();
            this.btnSafe = new System.Windows.Forms.Button();
            this.btnNormal = new System.Windows.Forms.Button();
            this.btnAuto = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAV
            // 
            this.btnAV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAV.Location = new System.Drawing.Point(8, 23);
            this.btnAV.Margin = new System.Windows.Forms.Padding(4);
            this.btnAV.Name = "btnAV";
            this.btnAV.Size = new System.Drawing.Size(177, 71);
            this.btnAV.TabIndex = 0;
            this.btnAV.Text = "Antivirus";
            this.btnAV.UseVisualStyleBackColor = true;
            this.btnAV.Click += new System.EventHandler(this.btnAV_Click);
            // 
            // btnAM
            // 
            this.btnAM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAM.Location = new System.Drawing.Point(8, 102);
            this.btnAM.Margin = new System.Windows.Forms.Padding(4);
            this.btnAM.Name = "btnAM";
            this.btnAM.Size = new System.Drawing.Size(177, 71);
            this.btnAM.TabIndex = 1;
            this.btnAM.Text = "Antimalware";
            this.btnAM.UseVisualStyleBackColor = true;
            this.btnAM.Click += new System.EventHandler(this.btnAM_Click);
            // 
            // btnClean
            // 
            this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClean.Location = new System.Drawing.Point(8, 181);
            this.btnClean.Margin = new System.Windows.Forms.Padding(4);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(177, 71);
            this.btnClean.TabIndex = 2;
            this.btnClean.Text = "Clean";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnSetup
            // 
            this.btnSetup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetup.Location = new System.Drawing.Point(8, 260);
            this.btnSetup.Margin = new System.Windows.Forms.Padding(4);
            this.btnSetup.Name = "btnSetup";
            this.btnSetup.Size = new System.Drawing.Size(177, 71);
            this.btnSetup.TabIndex = 3;
            this.btnSetup.Text = "Setup";
            this.btnSetup.UseVisualStyleBackColor = true;
            this.btnSetup.Click += new System.EventHandler(this.btnSetup_Click);
            // 
            // btnTools
            // 
            this.btnTools.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTools.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTools.Location = new System.Drawing.Point(8, 338);
            this.btnTools.Margin = new System.Windows.Forms.Padding(4);
            this.btnTools.Name = "btnTools";
            this.btnTools.Size = new System.Drawing.Size(177, 71);
            this.btnTools.TabIndex = 4;
            this.btnTools.Text = "Tools";
            this.btnTools.UseVisualStyleBackColor = true;
            this.btnTools.Click += new System.EventHandler(this.btnTools_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTools);
            this.groupBox1.Controls.Add(this.btnAV);
            this.groupBox1.Controls.Add(this.btnSetup);
            this.groupBox1.Controls.Add(this.btnAM);
            this.groupBox1.Controls.Add(this.btnClean);
            this.groupBox1.Location = new System.Drawing.Point(17, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(193, 418);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Category";
            // 
            // lbxProgs
            // 
            this.lbxProgs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxProgs.FormattingEnabled = true;
            this.lbxProgs.ItemHeight = 29;
            this.lbxProgs.Location = new System.Drawing.Point(219, 39);
            this.lbxProgs.Margin = new System.Windows.Forms.Padding(4);
            this.lbxProgs.Name = "lbxProgs";
            this.lbxProgs.Size = new System.Drawing.Size(524, 381);
            this.lbxProgs.TabIndex = 6;
            this.lbxProgs.SelectedIndexChanged += new System.EventHandler(this.lbxProgs_SelectedIndexChanged);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(761, 500);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(204, 41);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pbxIcon
            // 
            this.pbxIcon.Image = ((System.Drawing.Image)(resources.GetObject("pbxIcon.Image")));
            this.pbxIcon.Location = new System.Drawing.Point(791, 39);
            this.pbxIcon.Margin = new System.Windows.Forms.Padding(4);
            this.pbxIcon.Name = "pbxIcon";
            this.pbxIcon.Size = new System.Drawing.Size(153, 132);
            this.pbxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxIcon.TabIndex = 8;
            this.pbxIcon.TabStop = false;
            this.pbxIcon.Click += new System.EventHandler(this.pbxIcon_Click);
            // 
            // btnRun
            // 
            this.btnRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.Location = new System.Drawing.Point(761, 318);
            this.btnRun.Margin = new System.Windows.Forms.Padding(4);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(204, 58);
            this.btnRun.TabIndex = 10;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // rtbDescribe
            // 
            this.rtbDescribe.Location = new System.Drawing.Point(761, 178);
            this.rtbDescribe.Margin = new System.Windows.Forms.Padding(4);
            this.rtbDescribe.Name = "rtbDescribe";
            this.rtbDescribe.Size = new System.Drawing.Size(203, 112);
            this.rtbDescribe.TabIndex = 11;
            this.rtbDescribe.Text = "";
            // 
            // btnBC
            // 
            this.btnBC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBC.Location = new System.Drawing.Point(219, 443);
            this.btnBC.Margin = new System.Windows.Forms.Padding(4);
            this.btnBC.Name = "btnBC";
            this.btnBC.Size = new System.Drawing.Size(185, 84);
            this.btnBC.TabIndex = 12;
            this.btnBC.Text = "Batch Commander";
            this.btnBC.UseVisualStyleBackColor = true;
            this.btnBC.Click += new System.EventHandler(this.btnBC_Click);
            // 
            // btnSafe
            // 
            this.btnSafe.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnSafe.Location = new System.Drawing.Point(761, 401);
            this.btnSafe.Margin = new System.Windows.Forms.Padding(4);
            this.btnSafe.Name = "btnSafe";
            this.btnSafe.Size = new System.Drawing.Size(204, 25);
            this.btnSafe.TabIndex = 13;
            this.btnSafe.Text = "Safe Mode";
            this.btnSafe.UseVisualStyleBackColor = true;
            this.btnSafe.Click += new System.EventHandler(this.btnSafe_Click);
            // 
            // btnNormal
            // 
            this.btnNormal.ForeColor = System.Drawing.Color.Red;
            this.btnNormal.Location = new System.Drawing.Point(761, 443);
            this.btnNormal.Margin = new System.Windows.Forms.Padding(4);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(204, 25);
            this.btnNormal.TabIndex = 14;
            this.btnNormal.Text = "Normal Mode";
            this.btnNormal.UseVisualStyleBackColor = true;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // btnAuto
            // 
            this.btnAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuto.Location = new System.Drawing.Point(25, 444);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(177, 47);
            this.btnAuto.TabIndex = 15;
            this.btnAuto.Text = "Auto Run";
            this.btnAuto.UseVisualStyleBackColor = true;
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
            // 
            // btnLog
            // 
            this.btnLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLog.Location = new System.Drawing.Point(624, 443);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(119, 83);
            this.btnLog.TabIndex = 16;
            this.btnLog.Text = "Log";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 546);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.btnAuto);
            this.Controls.Add(this.btnNormal);
            this.Controls.Add(this.btnSafe);
            this.Controls.Add(this.btnBC);
            this.Controls.Add(this.rtbDescribe);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.pbxIcon);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lbxProgs);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "Arcadia";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAV;
        private System.Windows.Forms.Button btnAM;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnSetup;
        private System.Windows.Forms.Button btnTools;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbxProgs;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pbxIcon;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.RichTextBox rtbDescribe;
        private System.Windows.Forms.Button btnBC;
        private System.Windows.Forms.Button btnSafe;
        private System.Windows.Forms.Button btnNormal;
        private System.Windows.Forms.Button btnAuto;
        private System.Windows.Forms.Button btnLog;
    }
}

