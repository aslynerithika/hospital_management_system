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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }



        private void picBxAdm_Click(object sender, EventArgs e)
        {
            // Open Adminstration form to add Admin Staffs
            Administration Adm = new Administration();
            Adm.MdiParent = MainParent.ActiveForm;
            Adm.Show();

        }

        private void picBxDoc_Click(object sender, EventArgs e)
        {
            // Open Doctor add/mod/del form
            Doctor Doc = new Doctor();
            Doc.MdiParent = MainParent.ActiveForm;
            Doc.Show();

        }

        private void picBxNrs_Click(object sender, EventArgs e)
        {
            // nurse form
            Nurse Nrs = new Nurse();
            Nrs.MdiParent = MainParent.ActiveForm;
            Nrs.Show();

        }

        private void picBxRoom_Click(object sender, EventArgs e)
        {
            // room form
            Rooms Rooms = new Rooms();
            Rooms.MdiParent = MainParent.ActiveForm;
            Rooms.Show();

        }

        private void ExitPage_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
