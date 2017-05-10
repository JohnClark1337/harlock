using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Arcadia5
{
    public partial class BatchCommander : Form
    {
        public BatchCommander()
        {
            InitializeComponent();

            //Initialize combo-boxes to detected drive letters
            cbxdbs.DataSource = System.IO.DriveInfo.GetDrives();
            cbxdbs.DisplayMember = "Drives";
            cbxdbd.DataSource = System.IO.DriveInfo.GetDrives();
            cbxdbd.DisplayMember = "Drives";
            cbxChkDrives.DataSource = System.IO.DriveInfo.GetDrives();
            cbxChkDrives.DisplayMember = "Drives";

            resetBoxes();
        }

        //Process creator
        private void pcreator(string fname, string arg)
        {
            startInfo.FileName = fname;
            startInfo.Arguments = arg;
            process.StartInfo = startInfo;
            process.Start();
        }

        //File backup procedure using robocopy
        private void fbackup(string source, string dest)
        {
            string FileName = "cmd.exe";
            string Arguments = "/K " + "robocopy \"" + source + "\" \"" + dest + "\" /e /z /R:1 /W:1 /xj /MT:32";
            pcreator(FileName, Arguments);
        }

        //Driver backup procedure using robocopy
        private void dbackup(string source, string dest)
        {
            string arguments = "/e /z /R:1 /W:1 /xj /MT:8";
            pcreator("cmd.exe", "/K " + "robocopy " + source + @"Windows\system32\drivers " + dest + @"drivers\drivers " + arguments);
            pcreator("cmd.exe", "/K " + "robocopy " + source + @"Windows\system32\driverstore " + dest + @"drivers\driverstore " + arguments);
            pcreator("cmd.exe", "/K " + "robocopy " + source + @"Windows\inf " + dest + @"drivers\inf " + arguments);


        }

        //Run Check Disk with repair options on selected drive
        private void chkdsknow(string drive)
        {
            pcreator("cmd.exe", "/K " + "chkdsk /r " + drive[0] + ":");
        }

        //Scan Filesystem
        private void scanfs()
        {
            pcreator("cmd.exe", "/K " + "sfc /scannow");
        }

        // Master Run button. Uses combobox to determine process to start.
        private void btnRun_Click(object sender, EventArgs e)
        {
            try {
                if (cbxOpSel.SelectedIndex == 0)
                {
                    fbackup(tbxfbs.Text, tbxfbd.Text);
                }
                else if (cbxOpSel.SelectedIndex == 1)
                {
                    dbackup(cbxdbs.Text, cbxdbd.Text);
                }
                else if (cbxOpSel.SelectedIndex == 2)
                {
                    chkdsknow(cbxChkDrives.Text);
                }
                else if (cbxOpSel.SelectedIndex == 3)
                {
                    scanfs();
                }
            }
            catch (Exception r)
            { MessageBox.Show(r.Message); }
        }

       //Master process initialization
        System.Diagnostics.Process process = new System.Diagnostics.Process();
        System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();

        //Opens SysInternals Suite folder
        private void btnsys_Click(object sender, EventArgs e)
        {
            if (System.IO.Directory.Exists(@"SysinternalsSuite"))
                Process.Start(@"SysinternalsSuite");
            else
                MessageBox.Show("Programs missing. Update application before proceeding.");
        }

        //Exit form
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Make change to form based on selected scan type
        private void cbxOpSel_SelectedIndexChanged(object sender, EventArgs e)
        {
            resetBoxes();
           switch(cbxOpSel.SelectedIndex)
            {
                case 0:
                    tbxfbd.Enabled = true;
                    tbxfbs.Enabled = true;
                    btnDest.Enabled = true;
                    btnSource.Enabled = true;
                    gbxFileBackup.BackColor = Color.LightBlue;
                    break;
                case 1:
                    cbxdbd.Enabled = true;
                    cbxdbs.Enabled = true;
                    gbxDriverBackup.BackColor = Color.LightBlue;
                    break;
                case 2:
                    cbxChkDrives.Enabled = true;
                    break;
            }
        }

        //Resets all items to default (disabled) state
        private void resetBoxes()
        {
            cbxChkDrives.Enabled = false;
            tbxfbs.Enabled = false;
            tbxfbd.Enabled = false;
            cbxdbs.Enabled = false;
            cbxdbd.Enabled = false;
            btnDest.Enabled = false;
            btnSource.Enabled = false;
            gbxFileBackup.BackColor = Color.LightGray;
            gbxDriverBackup.BackColor = Color.LightGray;
        }

        private FolderBrowserDialog searcher = new FolderBrowserDialog();

        private void btnSource_Click(object sender, EventArgs e)
        { 
            if (searcher.ShowDialog() == DialogResult.OK)
                tbxfbs.Text = searcher.SelectedPath;
        }

        private void btnDest_Click(object sender, EventArgs e)
        {
            if (searcher.ShowDialog() == DialogResult.OK)
                tbxfbd.Text = searcher.SelectedPath;
        }
    }
}
