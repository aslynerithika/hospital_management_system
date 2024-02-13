using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class Patient : Form
    {
        public string dbfile = "URI=file:HospitalManagement.db";
        public SQLiteConnection ARSqlconn;
        public SQLiteCommand ARCmd;
        public SQLiteDataReader ARDataReader;
        public SQLiteDataAdapter ARDap;
        public DataTable ARTbl;
        public static string PtID, Ptyp;

        public Patient()
        {
            InitializeComponent();
            ARSqlconn = new SQLiteConnection(dbfile);

        }

        private void Patient_Load(object sender, EventArgs e)
        {
            FillPatientGridbox();
            ClearFields();
            cBxTyp.Focus();

        }

        public void FillPatientGridbox()
        {
            //Create a SQL Query Variable
            ARSqlconn.Open();
            SQLiteCommand command = new SQLiteCommand(ARSqlconn);

            ARDap = new SQLiteDataAdapter("select * from Patient", ARSqlconn);
            ARSqlconn.Close();
            SQLiteCommandBuilder ARCdB1 = new SQLiteCommandBuilder(ARDap);
            ARTbl = new DataTable();
            ARDap.Fill(ARTbl);
            dGVPat.DataSource = ARTbl;

        }

        private void cBxTyp_SelectedIndexChanged(object sender, EventArgs e)
        {
            // get the new Type from Combo Box
            Ptyp = cBxTyp.Text.Trim();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // To add new patient details
            ARSqlconn.Open();
            SQLiteCommand command = new SQLiteCommand(ARSqlconn);
            int Patid;
            string NPtid = "";
            string fn = txtFnm.Text.Trim(), ln = txtLnm.Text.Trim();
            string cnt = txtPhone.Text.Trim(), db = txtDoB.Text.Trim();
            string add = txtAdd.Text.Trim(), mail = txtEmail.Text.Trim();
            string gen = "", Nin = txtNin.Text.Trim();
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

            // get the next Count for new Patient to be added
            command.CommandText = "SELECT Ptnum from Counter";
            command.Prepare();
            command.ExecuteNonQuery();
            Patid = (Int32)command.ExecuteScalar();
            Patid = Patid + 1;
            if (Patid <= 9)
            {
                NPtid = "PAT00" + Patid.ToString().Trim();
            }
            else if (Patid <= 99 && Patid > 9)
            {
                NPtid = "PAT0" + Patid.ToString().Trim();
            }
            else
            {
                NPtid = "PAT" + Patid.ToString().Trim();

            }
            ARSqlconn.Close();

            // Add new Patient in Patient table
            ARSqlconn.Open();
            command.CommandText = ("INSERT INTO Patient VALUES(@P1, @P2, @P3, @P4, @P5, @P6, @P7, @P8, @P9, @P10)");
            command.Parameters.AddWithValue("@P1", NPtid);
            command.Parameters.AddWithValue("@P2", fn);
            command.Parameters.AddWithValue("@P3", ln);
            command.Parameters.AddWithValue("@P4", db);
            command.Parameters.AddWithValue("@P5", gen);
            command.Parameters.AddWithValue("@P6", add);
            command.Parameters.AddWithValue("@P7", cnt);
            command.Parameters.AddWithValue("@P8", mail);
            command.Parameters.AddWithValue("@P9", Ptyp);
            command.Parameters.AddWithValue("@P10", Nin);

            command.ExecuteNonQuery();
            // Update the Counter Table
            command.CommandText = ("UPDATE Counter SET Ptnum=@PP");
            command.Parameters.AddWithValue("@PP", Patid);
            command.ExecuteNonQuery();

            ARSqlconn.Close();
            MessageBox.Show("The New Patient " + fn + " - " + NPtid + " has been added");

            // Referesh the Patient data Grid View- Populate the latest data
            FillPatientGridbox();
            ClearFields();

        }

        //Define a variable to get the Patient Data grid view Row count
        int RwId;


        private void dGVPat_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // When we double click the selected row in Patient Dat Grid box fetch the values in the above text box for show or edit
            RwId = e.RowIndex;
            DataGridViewRow PatRowId = dGVPat.Rows[RwId];
            //File the textbox / label box and radio button values with the row selected

            lblPatID.Text = PatRowId.Cells[0].Value.ToString().Trim();
            txtFnm.Text = PatRowId.Cells[1].Value.ToString().Trim();
            txtLnm.Text = PatRowId.Cells[2].Value.ToString().Trim();

            string Typ = PatRowId.Cells[8].Value.ToString().Trim();
            // Type Combo Box Selection

            if (Typ == "InPatient")
                cBxTyp.SelectedIndex = cBxTyp.FindStringExact("InPatient");
            else if (Typ == "OutPatient")
                cBxTyp.SelectedIndex = cBxTyp.FindStringExact("OutPatient");

            txtNin.Text = PatRowId.Cells[9].Value.ToString().Trim();
            txtDoB.Text = PatRowId.Cells[3].Value.ToString().Trim();
            string gn = PatRowId.Cells[4].Value.ToString().Trim();
            // Set the gender selection
            if (gn == "Male")
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

            txtAdd.Text = PatRowId.Cells[5].Value.ToString().Trim();
            txtPhone.Text = PatRowId.Cells[6].Value.ToString().Trim();
            txtEmail.Text = PatRowId.Cells[7].Value.ToString().Trim();


        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            // To update the edited values in the Patient table against the selected Patient ID
            ARSqlconn.Open();
            SQLiteCommand command = new SQLiteCommand(ARSqlconn);
            int Patid;
            string NPtid = lblPatID.Text.Trim();
            string fn = txtFnm.Text.Trim(), ln = txtLnm.Text.Trim();
            string cnt = txtPhone.Text.Trim(), db = txtDoB.Text.Trim();
            string add = txtAdd.Text.Trim(), mail = txtEmail.Text.Trim();
            string gen = "", Nin = txtNin.Text.Trim();
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

            // Modify the existing patient detail and update the patient table
            command.CommandText = ("UPDATE Patient SET FirstName=@P1, LastName=@P2, DateOfBirth=@P3, Gender=@P4, Address=@P5, PhoneNumber=@P6, EmailID=@P7, Type=@P8, NIN=@P9 WHERE Patient_ID=@P10");
            command.Parameters.AddWithValue("@P1", fn);
            command.Parameters.AddWithValue("@P2", ln);
            command.Parameters.AddWithValue("@P3", db);
            command.Parameters.AddWithValue("@P4", gen);
            command.Parameters.AddWithValue("@P5", add);
            command.Parameters.AddWithValue("@P6", cnt);
            command.Parameters.AddWithValue("@P7", mail);
            command.Parameters.AddWithValue("@P8", Ptyp);
            command.Parameters.AddWithValue("@P9", Nin);
            command.Parameters.AddWithValue("@P10", NPtid);

            command.ExecuteNonQuery();

            ARSqlconn.Close();
            MessageBox.Show("The Patient " + fn + " - " + NPtid + " has been successfully Updated");

            // Refresh the Patient data Grid View- Populate the latest data
            FillPatientGridbox();
            ClearFields();

        } 

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(label4.Text, new Font("Rockwell", 18, FontStyle.Bold), Brushes.DarkBlue,new Point(130,5));
            e.Graphics.DrawString("PATIENT DETAILS", new Font("Ariel", 16, FontStyle.Bold), Brushes.DarkBlue,new Point(230,60));

            // Fetch all patient details from the database table
            ARSqlconn.Open();
            SQLiteCommand command = new SQLiteCommand(ARSqlconn);
            command.CommandText = ("Select * from patient");
            var reader = command.ExecuteReader();
            int y = 100;
            while (reader.Read())
            {
                e.Graphics.DrawString("PATIENT ID                 - " + reader["Patient_ID"].ToString().Trim(), new Font("Ariel", 15, FontStyle.Bold), Brushes.DarkBlue, new Point(5, y));
                y = y + 30;
                e.Graphics.DrawString("PATIENT NAME               - " + reader["FirstName"].ToString().Trim() + " " + reader["LastName"].ToString().Trim(), new Font("Ariel", 15, FontStyle.Bold), Brushes.DarkBlue, new Point(5, y));
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
                e.Graphics.DrawString("TYPE                       - " + reader["Type"].ToString().Trim(), new Font("Ariel", 15, FontStyle.Bold), Brushes.DarkBlue, new Point(5, y));
                y = y + 30;
                e.Graphics.DrawString("NATIONAL INSURANCE NUMBER  - " + reader["NIN"].ToString().Trim(), new Font("Ariel", 15, FontStyle.Bold), Brushes.DarkBlue, new Point(5, y));
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
            if(printPreviewDialog1.ShowDialog() == DialogResult.OK) 
            {
                printPreviewDialog1.Document = printDocument1;
                printDocument1.DefaultPageSettings.Landscape = true;
                printPreviewDialog1.ShowDialog();

            }
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

        private void txtNin_Leave(object sender, EventArgs e)
        {
            if (txtNin.TextLength == 0)
            {
                MessageBox.Show("NIN box is Blank. Please provide a nin number.");
                txtAdd.Focus();
            }

        }

        private void ExitPatPage_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ClearFields()
        {
            lblPatID.Text = "";
            txtFnm.Text = "";
            txtLnm.Text = "";
            txtAdd.Text = "";
            txtDoB.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            txtNin.Text = "";
            rdBF.Checked = false;
            rdBM.Checked = false;
            rdBO.Checked = false;
            cBxTyp.Text = null;

        }
    }
}
