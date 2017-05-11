using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Arcadia5
{
    public partial class frmAuto : Form
    {
        public frmAuto()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {

        }
        public void addProg(XmlNode prog)
        {
            progList.AddLast(prog);
        }
        public void popList()
        {
            lbxScans.Items.Clear();
            foreach (XmlNode nodey in progList)
            {
                lbxScans.Items.Add(nodey.Attributes[1].InnerText.ToString());
            }
        }

        private LinkedList<XmlNode> progList = new LinkedList<XmlNode>();
    }
}
