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
    public partial class Reception : Form
    {
        public static string RcpnstID;
        public Reception()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //
        }

        private void pBxNewPat_Click(object sender, EventArgs e)
        {
            //Open Patient Add Form
            Patient Pat = new Patient();
            Pat.MdiParent = MainParent.ActiveForm;
            Pat.Show();
            this.Close();
        }

        private void pBxApp_Click(object sender, EventArgs e)
        {
            //Open Appointment Form
            Appointment App = new Appointment();
            App.MdiParent = MainParent.ActiveForm;
            App.Show();
            this.Close();
        }

        private void Reception_Load(object sender, EventArgs e)
        {
            RcpnstID = frmLogin.RcpnstID;
            //Boolean what = MainParent.RcpLogAd
            if (MainParent.RcpLogAd == false)
            {
                label3.Visible = false;
                pBxAdm.Visible = false;
            }
            else if (MainParent.RcpLogAd == true)
            {
                label1.Visible = false;
                pBxApp.Visible = false;
                label2.Visible = false;
                pBxNewPat.Visible = false;
            }

        }


        private void pBxAdm_Click(object sender, EventArgs e)
        {
            // Open Admission Form
            Admission Adm = new Admission();
            Adm.MdiParent = MainParent.ActiveForm;
            Adm.Show();
            this.Close();

        }

        private void ExitRecepPage_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
