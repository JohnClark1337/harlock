using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arcadia5
{
    public partial class frmLogs : Form
    {
        public frmLogs()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private string proglog = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Arcadia.txt";

        private void frmLogs_Load(object sender, EventArgs e)
        {
            if (File.Exists(proglog));
            {
                using (StreamReader sr = File.OpenText(proglog))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        rtbLogs.AppendText(s);
                        rtbLogs.AppendText("\n");
                    }
                }
            }
        }
    }
}
