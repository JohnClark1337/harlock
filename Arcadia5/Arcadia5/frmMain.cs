﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Xml;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Management;
using System.IO;



namespace Arcadia5
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            reset();
            try
            {
                doc.Load("Programs.xml");
               

              
            }
            catch (Exception x)
            {
                MessageBox.Show("Cannot Load Program List.");
                Application.Exit();
            };
            MessageBox.Show("This program is designed to launch software created by many other hard working programmers. By continuing to use this software you are confirming that you have a knowledge of how and when to use these tools, and understand that each tool may have its own licensing agreement. I cannot be held responsible for any damage that may occur to your machine either through use or misuse of these tools.", "Arcadia Legalese");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAV_Click(object sender, EventArgs e)
        {
            reset();
            lbxProgs.Items.Clear();

            foreach (XmlNode node in doc.DocumentElement)
            {
                if (node.Attributes[0].InnerText == "Antivirus")
                {
                    lbxProgs.Items.Add(node.Attributes[1].InnerText);
                }
            }
        
        }

        private void lbxProgs_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lbxProgs.SelectedItem != null)
            {
                try
                {
                    foreach (XmlNode node in doc.DocumentElement)
                    {
                        if (node.Attributes[1].InnerText == lbxProgs.SelectedItem.ToString())
                        {
                            rtbDescribe.Text = node.FirstChild.InnerText;
                            progSite = node.LastChild.PreviousSibling.InnerText;
                            pbxIcon.ImageLocation = node.LastChild.InnerText;
                        }
                        if (btnAR.Checked)
                            newAuto.addProg(node);
                    }
                }
                catch (Exception r)
                {
                    MessageBox.Show("whaa?");
                }
            }
        }

        XmlDocument doc = new XmlDocument();
        

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (lbxProgs.SelectedItem != null)
            {
                try
                {
                    foreach (XmlNode node in doc.DocumentElement)
                    {
                        if (node.Attributes[1].InnerText == lbxProgs.SelectedItem.ToString())
                        {
                            ProcessStartInfo startInfo = new ProcessStartInfo();
                            startInfo.FileName = node.FirstChild.NextSibling.InnerText;
                            System.Diagnostics.Process.Start(startInfo);
                        }
                    }
                }
                catch (Exception r)
                {
                    MessageBox.Show("whaa?");
                }
            }
        }

        private void btnAM_Click(object sender, EventArgs e)
        {
            reset();
            lbxProgs.Items.Clear();

            foreach (XmlNode node in doc.DocumentElement)
            {
                if (node.Attributes[0].InnerText == "Antimalware")
                {
                    lbxProgs.Items.Add(node.Attributes[1].InnerText);
                }
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            reset();
            lbxProgs.Items.Clear();

            foreach (XmlNode node in doc.DocumentElement)
            {
                if (node.Attributes[0].InnerText == "Clean")
                {
                    lbxProgs.Items.Add(node.Attributes[1].InnerText);
                }
            }
        }

        private void btnSetup_Click(object sender, EventArgs e)
        {
            reset();
            lbxProgs.Items.Clear();

            foreach (XmlNode node in doc.DocumentElement)
            {
                if (node.Attributes[0].InnerText == "Setup")
                {
                    lbxProgs.Items.Add(node.Attributes[1].InnerText);
                }
            }
        }

        private void btnTools_Click(object sender, EventArgs e)
        {
            reset();
            lbxProgs.Items.Clear();

            foreach (XmlNode node in doc.DocumentElement)
            {
                if (node.Attributes[0].InnerText == "Tools")
                {
                    lbxProgs.Items.Add(node.Attributes[1].InnerText);
                }
            }
        }

        private void pbxIcon_Click(object sender, EventArgs e)
        {
            try
            { Process.Start(progSite); }
            catch(Exception w)
            {
                MessageBox.Show("Arcadia5");
            }

        }

        string progSite = "http://harlocktech.com";

        private void reset()
        {
            progSite = "http://harlocktech.com";
            rtbDescribe.Text = "Welcome to Arcadia!";
            pbxIcon.ImageLocation = "Icons\\wheel.jpg";
        }

        private void btnBC_Click(object sender, EventArgs e)
        {
            BatchCommander batch = new BatchCommander();
            batch.Visible = true;

        }
        //Going to Safe Mode and Normal Mode
        private void btnSafe_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("About to reboot into Safe Mode. Are you sure?", "Safe Mode", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                connectionOptions = new ConnectionOptions();
                connectionOptions.Impersonation = ImpersonationLevel.Impersonate;
                connectionOptions.EnablePrivileges = true;

                managementScope = new ManagementScope("root\\WMI", connectionOptions);

                managementPath = new ManagementPath("root\\WMI:BcdObject.Id=\"{fa926493-6f1c-4193-a414-58f0b2456d1e}\",StoreFilePath=\"\"");
                try
                {
                    ManagementObject currentBootloader = new ManagementObject(managementScope, managementPath, null);
                    currentBootloader.InvokeMethod("SetIntegerElement", new object[] { BcdOSLoaderInteger_SafeBoot, BcdLibrary_SafeBoot.SafemodeMinimal });
                    System.Diagnostics.Process.Start("shutdown", "/r");
                }
                catch (Exception j)
                {
                    MessageBox.Show("Can't modify boot config.");
                }
            }
        }
        public const int BcdOSLoaderInteger_SafeBoot = 0x25000080;
        private ConnectionOptions connectionOptions;
        private ManagementScope managementScope;
        private ManagementPath managementPath;
        public enum BcdLibrary_SafeBoot
        {
            SafemodeMinimal = 0,
            SafemodeNetwork = 1,
            SafemodeDsRepair = 2
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("About to reboot into Normal Mode. Are you sure?", "Normal Mode", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                connectionOptions = new ConnectionOptions();
                connectionOptions.Impersonation = ImpersonationLevel.Impersonate;
                connectionOptions.EnablePrivileges = true;

                managementScope = new ManagementScope("root\\WMI", connectionOptions);

                managementPath = new ManagementPath("root\\WMI:BcdObject.Id=\"{fa926493-6f1c-4193-a414-58f0b2456d1e}\",StoreFilePath=\"\"");
                try
                {
                    ManagementObject currentBootloader = new ManagementObject(managementScope, managementPath, null);
                    currentBootloader.InvokeMethod("DeleteElement", new object[] { BcdOSLoaderInteger_SafeBoot });
                    System.Diagnostics.Process.Start("shutdown", "/r");
                }
                catch (Exception j)
                {
                    MessageBox.Show("Can't modify boot config.");
                }
            }
        }
        private bool autoMode;
        frmAuto newAuto = new frmAuto();

        private void btnAR_CheckedChanged(object sender, EventArgs e)
        {
            if(btnAR.Checked)
            {
                newAuto.Visible = true;
            }
            else
            {
                newAuto.Visible = false;
            }
        }
    }
}
