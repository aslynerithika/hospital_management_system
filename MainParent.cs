using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class MainParent : Form
    {

        public static Boolean AdmLog = false, MgrLog = false, RcpLog =false, RcpLogAd=false, DocLogAd = false;
        public MainParent()
        {
            InitializeComponent();
        }

        private void receptionistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RcpLog = true;
            frmLogin hm = new frmLogin();
            hm.MdiParent = this;
            hm.Show();
        }

        private void tSMIExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dIAGNOSISToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // For Out Patient
            DocLogAd = true;
            frmLogin hm = new frmLogin();
            hm.MdiParent = this;
            hm.Show();
        }

        private void aDMISSIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RcpLogAd = true;
            frmLogin hm = new frmLogin();
            hm.MdiParent = this;
            hm.Show();
        }

        private void MainParent_Load(object sender, EventArgs e)
        {
            //Nothing
        }

        private void administartionToolStripMenuItem_Click(object sender, EventArgs e)
        {
           AdmLog = true;
           frmLogin hm = new frmLogin();
           hm.MdiParent = this;
           hm.Show(); 
        }
    }
}
