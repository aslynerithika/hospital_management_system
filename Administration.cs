using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace HospitalManagementSystem
{
    public partial class Administration : Form
    {

        public string dbfile = "URI=file:HospitalManagement.db";
        public SQLiteConnection ARSqlconn;
        public SQLiteCommand ARCmd;
        public SQLiteDataReader ARDataReader;
        public SQLiteDataAdapter ARDap;
        public DataTable ARTbl;
        public static string AdID, Arole;
        public Administration()
        {
            InitializeComponent();
            ARSqlconn = new SQLiteConnection(dbfile);
        }

        private void Administration_Load(object sender, EventArgs e)
        {
            FillAdminGridbox();
            ClearFields();
            cBxRol.Focus();
        }

        private void cBxRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            // get the new Role from Combo Box
            Arole = cBxRol.Text.Trim();
        }


        public void FillAdminGridbox()
        {
            //Create a SQL Query Variable
            ARSqlconn.Open();
            SQLiteCommand command = new SQLiteCommand(ARSqlconn);

            ARDap = new SQLiteDataAdapter("select * from Administration", ARSqlconn);
            ARSqlconn.Close();
            SQLiteCommandBuilder ARCdB1 = new SQLiteCommandBuilder(ARDap);
            ARTbl = new DataTable();
            ARDap.Fill(ARTbl);
            dGVAdm.DataSource = ARTbl;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Open SQLite DB
            ARSqlconn.Open();
            SQLiteCommand command = new SQLiteCommand(ARSqlconn);
            int Adid;
            string NAdid = "";
            // 1st get all Inputs in a variables
            string fn = txtFnm.Text.Trim(), ln = txtLnm.Text.Trim();
            string cnt = txtPhone.Text.Trim(), db = txtDoB.Text.Trim();
            string add = txtAdd.Text.Trim(), mail = txtEmail.Text.Trim();
            string qual = txtQual.Text.Trim() , Pas = txtPass.Text.Trim();
            string gen = "";
            if (rdBM.Checked)
            {
                gen = "Male";
            }
            else if (rdBF.Checked)
            {
                gen = "Female";
            }
            else
                gen = "Other";

            // get the next Count for new Adminstration staff to be added
                command.CommandText = "SELECT Anum from Counter";
                command.Prepare();
                command.ExecuteNonQuery();
                Adid = (Int32)command.ExecuteScalar();
                Adid = Adid + 1;
                if (Adid <= 9)
                {
                     NAdid = "ADM00" + Adid.ToString().Trim();
                }
                else
                {
                     NAdid = "ADM0" + Adid.ToString().Trim();
                }
                ARSqlconn.Close();

            // Add new Admin staff in Administartion table
            ARSqlconn.Open();
            command.CommandText = ("INSERT INTO Administration VALUES(@R1, @R2, @R3, @R4, @R5, @R6, @R7, @R8, @R9, @R10, @R11, @R12)");
            command.Parameters.AddWithValue("@R1", NAdid);
            command.Parameters.AddWithValue("@R2", fn);
            command.Parameters.AddWithValue("@R3", ln);
            command.Parameters.AddWithValue("@R4", Arole);
            command.Parameters.AddWithValue("@R5", db);
            command.Parameters.AddWithValue("@R6", gen);
            command.Parameters.AddWithValue("@R7", add);
            command.Parameters.AddWithValue("@R8", cnt);
            command.Parameters.AddWithValue("@R9", mail);
            command.Parameters.AddWithValue("@R10", qual);
            command.Parameters.AddWithValue("@R11", Pas);
            command.Parameters.AddWithValue("@R12", "Active");

            command.ExecuteNonQuery();
            // Update the Counter Table
            command.CommandText = ("UPDATE Counter SET Anum=@RD");
            command.Parameters.AddWithValue("@RD", Adid);
            command.ExecuteNonQuery();

            ARSqlconn.Close();
            MessageBox.Show("The New Admin Staff " + fn + " - " + NAdid + " has been added");

            // Referesh the Administration data Grid View- Populate the latest data
            FillAdminGridbox();
            ClearFields();

        }

        //Define a variable to get the Customer Data grid view Row count
        int RwId;
        private void dGVAdm_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // When we double click the selected row in Administration Dat Grid box fetch the values in the above text box for show or edit
            RwId = e.RowIndex;
            DataGridViewRow AdmRowId = dGVAdm.Rows[RwId];
            //File the textbox / label box and radio button values with the row selected

            lblID.Text = AdmRowId.Cells[0].Value.ToString().Trim();
            txtFnm.Text = AdmRowId.Cells[1].Value.ToString().Trim();
            txtLnm.Text = AdmRowId.Cells[2].Value.ToString().Trim();
            string rl = AdmRowId.Cells[3].Value.ToString().Trim();
            // Role Combo Box Selection
            if (rl == "Admin")
                cBxRol.SelectedIndex = cBxRol.FindStringExact("Admin");
            else if (rl == "Manager")
                cBxRol.SelectedIndex = cBxRol.FindStringExact("Manager");
            else if (rl == "Receptionist")
                cBxRol.SelectedIndex = cBxRol.FindStringExact("Receptionist");

            txtDoB.Text = AdmRowId.Cells[4].Value.ToString().Trim();
            string gn = AdmRowId.Cells[5].Value.ToString().Trim();
            // Set the gender selection
            if (gn=="Male")
            {
                rdBM.Checked = true;
            }
            else if (gn == "Female")
            {
                rdBF.Checked = true;
            }
            else if (gn == "Others")
            {
                rdBO.Checked = true;
            }

            txtAdd.Text = AdmRowId.Cells[6].Value.ToString().Trim();
            txtPhone.Text = AdmRowId.Cells[7].Value.ToString().Trim();
            txtEmail.Text = AdmRowId.Cells[8].Value.ToString().Trim();
            txtQual.Text = AdmRowId.Cells[9].Value.ToString().Trim();
            txtPass.Text = AdmRowId.Cells[10].Value.ToString().Trim();
            lblStat.Text = AdmRowId.Cells[11].Value.ToString().Trim();

        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            // get all the values into variables
            //Open SQLite DB
            ARSqlconn.Open();
            SQLiteCommand command = new SQLiteCommand(ARSqlconn);

            // 1st get all Inputs in a variables
            string fn = txtFnm.Text.Trim(), ln = txtLnm.Text.Trim() , NAdid = lblID.Text.Trim();
            string cnt = txtPhone.Text.Trim(), db = txtDoB.Text.Trim();
            string add = txtAdd.Text.Trim(), mail = txtEmail.Text.Trim();
            string qual = txtQual.Text.Trim(), Pas = txtPass.Text.Trim(); 
            string gen = "";
            if (rdBM.Checked)
            {
                gen = "Male";
            }
            else if (rdBF.Checked)
            {
                gen = "Female";
            }
            else
                gen = "Other";

            string act = lblStat.Text.Trim();

            // Update the existing Admin staff in Administartion table

            command.CommandText = ("UPDATE Administration SET FirstName=@R1, LastName=@R2, Role=@R3, DateOfBirth=@R4, Gender=@R5, Address=@R6, PhoneNumber=@R7, EmailID=@R8, Qualification=@R9, Pass=@R10, Status=@R11 WHERE Admin_ID=@R12");

            command.Parameters.AddWithValue("@R1", fn);
            command.Parameters.AddWithValue("@R2", ln);
            command.Parameters.AddWithValue("@R3", Arole);
            command.Parameters.AddWithValue("@R4", db);
            command.Parameters.AddWithValue("@R5", gen);
            command.Parameters.AddWithValue("@R6", add);
            command.Parameters.AddWithValue("@R7", cnt);
            command.Parameters.AddWithValue("@R8", mail);
            command.Parameters.AddWithValue("@R9", qual);
            command.Parameters.AddWithValue("@R10", Pas);
            command.Parameters.AddWithValue("@R11", act);
            command.Parameters.AddWithValue("@R12", NAdid);

            command.ExecuteNonQuery();

            ARSqlconn.Close();
            MessageBox.Show("The Admin Staff " + fn + " - " + NAdid + " has been successfully Updated");

            // Refresh the Administration data Grid View- Populate the latest data
            FillAdminGridbox();
            ClearFields();
        }

        private void txtFnm_Leave(object sender, EventArgs e)
        {
            if (txtFnm.TextLength == 0)
            {
                MessageBox.Show("First Name box is Blank. Please provide first name.");
                txtFnm.Focus();
            }
        }

        private void txtLnm_Leave(object sender, EventArgs e)
        {
            if (txtLnm.TextLength == 0)
            {
                MessageBox.Show("Last Name box is Blank. Please provide Last name.");
                txtLnm.Focus();
            }

        }

        private void txtPhone_Leave(object sender, EventArgs e)
        {
            if (txtPhone.TextLength == 0)
            {
                MessageBox.Show("Contact box is Blank. Please provide contact number.");
                txtPhone.Focus();
            }
            if (txtPhone.TextLength != 10)
            {
                MessageBox.Show("Contact should be 10 digit phone number. Please provide correct contact number.");
                txtPhone.Focus();
            }

        }

        private void txtDoB_Leave(object sender, EventArgs e)
        {
            if (txtDoB.TextLength == 0)
            {
                MessageBox.Show("DOB box is Blank. Please provide date of birth.");
                txtDoB.Focus();
            }

        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.TextLength == 0)
            {
                MessageBox.Show("Email box is Blank. Please provide an emailID.");
                txtEmail.Focus();
            }

        }

        private void txtAdd_Leave(object sender, EventArgs e)
        {
            if (txtAdd.TextLength == 0)
            {
                MessageBox.Show("Address box is Blank. Please provide an address.");
                txtAdd.Focus();
            }

        }

        private void txtQual_Leave(object sender, EventArgs e)
        {
            if (txtQual.TextLength == 0)
            {
                MessageBox.Show("Qualification box is Blank. Please provide qualification.");
                txtQual.Focus();
            }

        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.TextLength == 0)
            {
                MessageBox.Show("Password box is Blank. Please provide password.");
                txtPass.Focus();
            }

        }

        private void btnDact_Click(object sender, EventArgs e)
        {
            // To deactivate an active admin staff
            string Sta = lblStat.Text.Trim();

            if (Sta == "InActive")
            {
                MessageBox.Show("The admin staff " + txtFnm.Text + " is already inactive");
            }
            else if (Sta == "Active")
            {
                //Currently the admin staff is active so we can deactivate
                string AdId = lblID.Text.Trim();
                // Open administration table
                ARSqlconn.Open();
                SQLiteCommand command = new SQLiteCommand(ARSqlconn);
                // Update the existing Admin staff in Administartion table

                command.CommandText = ("UPDATE Administration SET Status=@A1 WHERE Admin_ID=@A2");

                command.Parameters.AddWithValue("@A1", "InActive");
                command.Parameters.AddWithValue("@A2", AdId);
                command.ExecuteNonQuery();

                ARSqlconn.Close();
                MessageBox.Show("The Admin Staff " + txtFnm.Text + " - " + AdId + " has been successfully Deactivated");

                // Refresh the Administration data Grid View- Populate the latest data
                FillAdminGridbox();
                ClearFields();

            }
        }

        private void btnAct_Click(object sender, EventArgs e)
        {
            // To Activate a deactivated admin staff
            string Sta = lblStat.Text.Trim();

            if (Sta == "Active")
            {
                MessageBox.Show("The admin staff " + txtFnm.Text + " is already active");
            }
            else if (Sta == "InActive")
            {
                //Currently the admin staff is inactive so we can activate
                string AdId = lblID.Text.Trim();
                // Open administration table
                ARSqlconn.Open();
                SQLiteCommand command = new SQLiteCommand(ARSqlconn);
                // Update the existing Admin staff in Administartion table

                command.CommandText = ("UPDATE Administration SET Status=@A1 WHERE Admin_ID=@A2");

                command.Parameters.AddWithValue("@A1", "Active");
                command.Parameters.AddWithValue("@A2", AdId);
                command.ExecuteNonQuery();

                ARSqlconn.Close();
                MessageBox.Show("The Admin Staff " + txtFnm.Text + " - " + AdId + " has been successfully Activated");

                // Refresh the Administration data Grid View- Populate the latest data
                FillAdminGridbox();
                ClearFields();

            }

        }

        private void PrnDoc2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(label4.Text, new Font("Rockwell", 18, FontStyle.Bold), Brushes.DarkBlue, new Point(130, 5));
            e.Graphics.DrawString("ADMINISTRATION DETAILS", new Font("Ariel", 16, FontStyle.Bold), Brushes.DarkBlue, new Point(230, 60));

            // Fetch all administration details from the database table
            ARSqlconn.Open();
            SQLiteCommand command = new SQLiteCommand(ARSqlconn);
            command.CommandText = ("Select * from administration");
            var reader = command.ExecuteReader();
            int y = 100;
            while (reader.Read())
            {
                e.Graphics.DrawString("ADMIN ID                   - " + reader["Admin_ID"].ToString().Trim(), new Font("Ariel", 15, FontStyle.Bold), Brushes.DarkBlue, new Point(5, y));
                y = y + 30;
                e.Graphics.DrawString("ADMIN NAME                 - " + reader["FirstName"].ToString().Trim() + " " + reader["LastName"].ToString().Trim(), new Font("Ariel", 15, FontStyle.Bold), Brushes.DarkBlue, new Point(5, y));
                y = y + 30;
                e.Graphics.DrawString("ROLE                       - " + reader["Role"].ToString().Trim(), new Font("Ariel", 15, FontStyle.Bold), Brushes.DarkBlue, new Point(5, y));
                y = y + 30;
                e.Graphics.DrawString("DATE OF BIRTH              - " + reader["DateOfBirth"].ToString().Trim(), new Font("Ariel", 15, FontStyle.Bold), Brushes.DarkBlue, new Point(5, y));
                y = y + 30;
                e.Graphics.DrawString("GENDER                     - " + reader["Gender"].ToString().Trim(), new Font("Ariel", 15, FontStyle.Bold), Brushes.DarkBlue, new Point(5, y));
                y = y + 30;
                e.Graphics.DrawString("ADDRESS                    - " + reader["Address"].ToString().Trim(), new Font("Ariel", 15, FontStyle.Bold), Brushes.DarkBlue, new Point(5, y));
                y = y + 30;
                e.Graphics.DrawString("PHONE NUMBER               - " + reader["PhoneNumber"].ToString().Trim(), new Font("Ariel", 15, FontStyle.Bold), Brushes.DarkBlue, new Point(5, y));
                y = y + 30;
                e.Graphics.DrawString("EMAIL ID                   - " + reader["EmailID"].ToString().Trim(), new Font("Ariel", 15, FontStyle.Bold), Brushes.DarkBlue, new Point(5, y));
                y = y + 30;
                e.Graphics.DrawString("QUALIFICATION              - " + reader["Qualification"].ToString().Trim(), new Font("Ariel", 15, FontStyle.Bold), Brushes.DarkBlue, new Point(5, y));
                y = y + 30;
                e.Graphics.DrawString("PASSWORD                   - " + reader["Pass"].ToString().Trim(), new Font("Ariel", 15, FontStyle.Bold), Brushes.DarkBlue, new Point(5, y));
                y = y + 30;
                e.Graphics.DrawString("STATUS                     - " + reader["Status"].ToString().Trim(), new Font("Ariel", 15, FontStyle.Bold), Brushes.DarkBlue, new Point(5, y));
                y = y + 30;
                e.Graphics.DrawString("--------------------------------------------------------", new Font("Ariel", 15, FontStyle.Bold), Brushes.DarkBlue, new Point(5, y));
                y = y + 30;

            }
            reader.Close(); // <- too easy to forget
            reader.Dispose(); // <- too easy to forget
            ARSqlconn.Close();

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (prnPrvwDlog2.ShowDialog() == DialogResult.OK)
            {
                prnPrvwDlog2.Document = PrnDoc2;
                PrnDoc2.DefaultPageSettings.Landscape = true;
                prnPrvwDlog2.ShowDialog();

            }
        }

        private void ExitAdmPage_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        public void ClearFields()
        {
            // To Clear All the textbox, Label Box and Radio Buttons
            lblID.Text = "";
            txtFnm.Text = "";
            txtLnm.Text = "";
            txtAdd.Text = "";
            txtDoB.Text = "";
            txtEmail.Text = "";
            txtQual.Text = "";
            txtPass.Text = "";
            txtPhone.Text = "";
            rdBF.Checked = false;
            rdBM.Checked = false;
            rdBO.Checked = false;
            lblStat.Text = "";
            cBxRol.Text = null; 
        }


    }
}
