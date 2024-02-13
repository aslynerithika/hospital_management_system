using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class Doctor : Form
    {
        public string dbfile = "URI=file:HospitalManagement.db";
        public SQLiteConnection ARSqlconn;
        public SQLiteCommand ARCmd;
        public SQLiteDataReader ARDataReader;
        public SQLiteDataAdapter ARDap;
        public DataTable ARTbl;
        public static string DcID, Dtyp;

        public Doctor()
        {
            InitializeComponent();
            ARSqlconn = new SQLiteConnection(dbfile);

        }

        private void Doctor_Load(object sender, EventArgs e)
        {
            FillDoctorGridbox();
            ClearFields();
            cBxTyp.Focus();
        }


        public void FillDoctorGridbox()
        {
            //Create a SQL Query Variable
            ARSqlconn.Open();
            SQLiteCommand command = new SQLiteCommand(ARSqlconn);

            ARDap = new SQLiteDataAdapter("select * from Doctor", ARSqlconn);
            ARSqlconn.Close();
            SQLiteCommandBuilder ARCdB1 = new SQLiteCommandBuilder(ARDap);
            ARTbl = new DataTable();
            ARDap.Fill(ARTbl);
            dGVDoc.DataSource = ARTbl;

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

        private void txtGmcn_Leave(object sender, EventArgs e)
        {
            if (txtGmcn.TextLength == 0)
            {
                MessageBox.Show("Gmcn box is Blank. Please provide an Gmcn.");
                txtGmcn.Focus();
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



        private void cBxTyp_SelectedIndexChanged(object sender, EventArgs e)
        {
            // get the new Type from Combo Box
            Dtyp = cBxTyp.Text.Trim();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // To add new doctor details
            ARSqlconn.Open();
            SQLiteCommand command = new SQLiteCommand(ARSqlconn);
            int Docid;
            string NDcid = "";
            string fn = txtFnm.Text.Trim(), ln = txtLnm.Text.Trim();
            string cnt = txtPhone.Text.Trim(), db = txtDoB.Text.Trim();
            string add = txtAdd.Text.Trim(), mail = txtEmail.Text.Trim();
            string qual = txtQual.Text.Trim(), Pas = txtPass.Text.Trim();
            string gen = "", Gmcn = txtGmcn.Text.Trim();
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

            // get the next Count for new Doctor to be added
            command.CommandText = "SELECT Dnum from Counter";
            command.Prepare();
            command.ExecuteNonQuery();
            Docid = (Int32)command.ExecuteScalar();
            Docid = Docid + 1;
            if (Docid <= 9)
            {
                NDcid = "DOC00" + Docid.ToString().Trim();
            }
            else
            {
                NDcid = "DOC0" + Docid.ToString().Trim();
            }
            ARSqlconn.Close();

            // Add new Doctor in Doctor table
            ARSqlconn.Open();
            command.CommandText = ("INSERT INTO Doctor VALUES(@D1, @D2, @D3, @D4, @D5, @D6, @D7, @D8, @D9, @D10, @D11, @D12, @D13)");
            command.Parameters.AddWithValue("@D1", NDcid);
            command.Parameters.AddWithValue("@D2", fn);
            command.Parameters.AddWithValue("@D3", ln);
            command.Parameters.AddWithValue("@D4", Dtyp);
            command.Parameters.AddWithValue("@D5", Gmcn);
            command.Parameters.AddWithValue("@D6", db);
            command.Parameters.AddWithValue("@D7", gen);
            command.Parameters.AddWithValue("@D8", add);
            command.Parameters.AddWithValue("@D9", cnt);
            command.Parameters.AddWithValue("@D10", mail);
            command.Parameters.AddWithValue("@D11", qual);
            command.Parameters.AddWithValue("@D12", Pas);
            command.Parameters.AddWithValue("@D13", "Active");

            command.ExecuteNonQuery();
            // Update the Counter Table
            command.CommandText = ("UPDATE Counter SET Dnum=@DD");
            command.Parameters.AddWithValue("@DD", Docid);
            command.ExecuteNonQuery();

            ARSqlconn.Close();
            MessageBox.Show("The New Doctor " + fn + " - " + NDcid + " has been added");

            // Referesh the Doctor data Grid View- Populate the latest data
            FillDoctorGridbox();
            ClearFields();

        }

        //Define a variable to get the Doctor Data grid view Row count
        int RwId;
        private void dGVDoc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // When we double click the selected row in Doctor Dat Grid box fetch the values in the above text box for show or edit
            RwId = e.RowIndex;
            DataGridViewRow DocRowId = dGVDoc.Rows[RwId];
            //File the textbox / label box and radio button values with the row selected

            lblDocID.Text = DocRowId.Cells[0].Value.ToString().Trim();
            txtFnm.Text = DocRowId.Cells[1].Value.ToString().Trim();
            txtLnm.Text = DocRowId.Cells[2].Value.ToString().Trim();

            string Splt = DocRowId.Cells[3].Value.ToString().Trim();
            // Speacialist Combo Box Selection
     
            if (Splt == "General Practitioners")
                cBxTyp.SelectedIndex = cBxTyp.FindStringExact("General Practitioners");
            else if (Splt == "Gynaecologist")
                cBxTyp.SelectedIndex = cBxTyp.FindStringExact("Gynaecologist");
            else if (Splt == "Foundation Doctor")
                cBxTyp.SelectedIndex = cBxTyp.FindStringExact("Foundation Doctor");
            else if (Splt == "Paediatricians")
                cBxTyp.SelectedIndex = cBxTyp.FindStringExact("Paediatricians");
            else if (Splt == "Psychiatrists")
                cBxTyp.SelectedIndex = cBxTyp.FindStringExact("Psychiatrists");

            txtGmcn.Text = DocRowId.Cells[4].Value.ToString().Trim();
            txtDoB.Text = DocRowId.Cells[5].Value.ToString().Trim();
            string gn = DocRowId.Cells[6].Value.ToString().Trim();
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

            txtAdd.Text = DocRowId.Cells[7].Value.ToString().Trim();
            txtPhone.Text = DocRowId.Cells[8].Value.ToString().Trim();
            txtEmail.Text = DocRowId.Cells[9].Value.ToString().Trim();
            txtQual.Text = DocRowId.Cells[10].Value.ToString().Trim();
            txtPass.Text = DocRowId.Cells[11].Value.ToString().Trim();
            lblStat.Text = DocRowId.Cells[12].Value.ToString().Trim();

        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            // To update the edited values in the Doctor table against the selected Doctor ID
            ARSqlconn.Open();
            SQLiteCommand command = new SQLiteCommand(ARSqlconn);
            int Docid;
            string NDcid = lblDocID.Text.Trim();
            string fn = txtFnm.Text.Trim(), ln = txtLnm.Text.Trim();
            string cnt = txtPhone.Text.Trim(), db = txtDoB.Text.Trim();
            string add = txtAdd.Text.Trim(), mail = txtEmail.Text.Trim();
            string qual = txtQual.Text.Trim(), Pas = txtPass.Text.Trim();
            string gen = "", Gmcn = txtGmcn.Text.Trim();
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

            // Modify the existing doctor detail and update the doctor table
            command.CommandText = ("UPDATE Doctor SET FirstName=@D1, LastName=@D2, Specialist=@D3, GMCN=@D4, DateOfBirth=@D5, Gender=@D6, Address=@D7, PhoneNumber=@D8, EmailID=@D9, Qualification=@D10, Pass=@D11, Status=@D12 WHERE Doctor_ID=@D13");

            command.Parameters.AddWithValue("@D1", fn);
            command.Parameters.AddWithValue("@D2", ln);
            command.Parameters.AddWithValue("@D3", Dtyp);
            command.Parameters.AddWithValue("@D4", Gmcn);
            command.Parameters.AddWithValue("@D5", db);
            command.Parameters.AddWithValue("@D6", gen);
            command.Parameters.AddWithValue("@D7", add);
            command.Parameters.AddWithValue("@D8", cnt);
            command.Parameters.AddWithValue("@D9", mail);
            command.Parameters.AddWithValue("@D10", qual);
            command.Parameters.AddWithValue("@D11", Pas);
            command.Parameters.AddWithValue("@D12", act);
            command.Parameters.AddWithValue("@D13", NDcid);

            command.ExecuteNonQuery();

            ARSqlconn.Close();
            MessageBox.Show("The Doctor " + fn + " - " + NDcid + " has been successfully Updated");

            // Refresh the Doctor data Grid View- Populate the latest data
            FillDoctorGridbox();
            ClearFields();

        }

        private void btnDact_Click(object sender, EventArgs e)
        {
            // To deactivate an active doctor
            string Sta = lblStat.Text.Trim();

            if (Sta == "InActive")
            {
                MessageBox.Show("The doctor " + txtFnm.Text + " is already inactive");
            }
            else if (Sta == "Active")
            {
                //Currently the doctor is active so we can deactivate
                string DocId = lblDocID.Text.Trim();
                // Open doctor table
                ARSqlconn.Open();
                SQLiteCommand command = new SQLiteCommand(ARSqlconn);
                // Update the existing doctor in Doctor table

                command.CommandText = ("UPDATE Doctor SET Status=@D1 WHERE Doctor_ID=@D2");

                command.Parameters.AddWithValue("@D1", "InActive");
                command.Parameters.AddWithValue("@D2", DocId);
                command.ExecuteNonQuery();

                ARSqlconn.Close();
                MessageBox.Show("The doctor " + txtFnm.Text + " - " + DocId + " has been successfully Deactivated");

                // Refresh the Doctor data Grid View- Populate the latest data
                FillDoctorGridbox();
                ClearFields();

            }

        }

        private void btnAct_Click(object sender, EventArgs e)
        {
            // To Activate a deactivated doctor
            string Sta = lblStat.Text.Trim();

            if (Sta == "Active")
            {
                MessageBox.Show("The doctor " + txtFnm.Text + " is already active");
            }
            else if (Sta == "InActive")
            {
                //Currently the doctor is inactive so we can activate
                string DocId = lblDocID.Text.Trim();
                // Open Doctor table
                ARSqlconn.Open();
                SQLiteCommand command = new SQLiteCommand(ARSqlconn);
                // Update the existing Doctor in Doctor table

                command.CommandText = ("UPDATE Doctor SET Status=@D1 WHERE Doctor_ID=@D2");

                command.Parameters.AddWithValue("@D1", "Active");
                command.Parameters.AddWithValue("@D2", DocId);
                command.ExecuteNonQuery();

                ARSqlconn.Close();
                MessageBox.Show("The Doctor " + txtFnm.Text + " - " + DocId + " has been successfully Activated");

                // Refresh the Doctor data Grid View- Populate the latest data
                FillDoctorGridbox();
                ClearFields();

            }

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (prnPrvwDlog3.ShowDialog() == DialogResult.OK)
            {
                prnPrvwDlog3.Document = PrnDoc3;
                PrnDoc3.DefaultPageSettings.Landscape = true;
                prnPrvwDlog3.ShowDialog();

            }
        }

        private void PrnDoc3_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(label4.Text, new Font("Rockwell", 18, FontStyle.Bold), Brushes.DarkBlue, new Point(130, 5));
            e.Graphics.DrawString("DOCTOR DETAILS", new Font("Ariel", 16, FontStyle.Bold), Brushes.DarkBlue, new Point(230, 60));

            // Fetch all doctor details from the database table
            ARSqlconn.Open();
            SQLiteCommand command = new SQLiteCommand(ARSqlconn);
            command.CommandText = ("Select * from doctor");
            var reader = command.ExecuteReader();
            int y = 100;
            while (reader.Read())
            {
                e.Graphics.DrawString("DOCTOR ID                 - " + reader["Doctor_ID"].ToString().Trim(), new Font("Ariel", 15, FontStyle.Bold), Brushes.DarkBlue, new Point(5, y));
                y = y + 30;
                e.Graphics.DrawString("DOCTOR NAME               - " + reader["FirstName"].ToString().Trim() + " " + reader["LastName"].ToString().Trim(), new Font("Ariel", 15, FontStyle.Bold), Brushes.DarkBlue, new Point(5, y));
                y = y + 30;
                e.Graphics.DrawString("SPECIALIST                - " + reader["Specialist"].ToString().Trim(), new Font("Ariel", 15, FontStyle.Bold), Brushes.DarkBlue, new Point(5, y));
                y = y + 30;
                e.Graphics.DrawString("GMCN                      - " + reader["GMCN"].ToString().Trim(), new Font("Ariel", 15, FontStyle.Bold), Brushes.DarkBlue, new Point(5, y));
                y = y + 30;
                e.Graphics.DrawString("DATE OF BIRTH             - " + reader["DateOfBirth"].ToString().Trim(), new Font("Ariel", 15, FontStyle.Bold), Brushes.DarkBlue, new Point(5, y));
                y = y + 30;
                e.Graphics.DrawString("GENDER                    - " + reader["Gender"].ToString().Trim(), new Font("Ariel", 15, FontStyle.Bold), Brushes.DarkBlue, new Point(5, y));
                y = y + 30;
                e.Graphics.DrawString("ADDRESS                   - " + reader["Address"].ToString().Trim(), new Font("Ariel", 15, FontStyle.Bold), Brushes.DarkBlue, new Point(5, y));
                y = y + 30;
                e.Graphics.DrawString("PHONE NUMBER              - " + reader["PhoneNumber"].ToString().Trim(), new Font("Ariel", 15, FontStyle.Bold), Brushes.DarkBlue, new Point(5, y));
                y = y + 30;
                e.Graphics.DrawString("EMAIL ID                  - " + reader["EmailID"].ToString().Trim(), new Font("Ariel", 15, FontStyle.Bold), Brushes.DarkBlue, new Point(5, y));
                y = y + 30;
                e.Graphics.DrawString("QUALIFICATION             - " + reader["Qualification"].ToString().Trim(), new Font("Ariel", 15, FontStyle.Bold), Brushes.DarkBlue, new Point(5, y));
                y = y + 30;
                e.Graphics.DrawString("PASSWORD                  - " + reader["Pass"].ToString().Trim(), new Font("Ariel", 15, FontStyle.Bold), Brushes.DarkBlue, new Point(5, y));
                y = y + 30;
                e.Graphics.DrawString("STATUS                    - " + reader["Status"].ToString().Trim(), new Font("Ariel", 15, FontStyle.Bold), Brushes.DarkBlue, new Point(5, y));
                y = y + 30;
                e.Graphics.DrawString("--------------------------------------------------------", new Font("Ariel", 15, FontStyle.Bold), Brushes.DarkBlue, new Point(5, y));
                y = y + 30;

            }
            reader.Close(); // <- too easy to forget
            reader.Dispose(); // <- too easy to forget
            ARSqlconn.Close();

        }

        private void ExitPage_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ClearFields()
        {
            // To Clear All the textbox, Label Box and Radio Buttons
            lblDocID.Text = "";
            txtFnm.Text = "";
            txtLnm.Text = "";
            txtAdd.Text = "";
            txtDoB.Text = "";
            txtEmail.Text = "";
            txtQual.Text = "";
            txtPass.Text = "";
            txtPhone.Text = "";
            txtGmcn.Text = "";
            rdBF.Checked = false;
            rdBM.Checked = false;
            rdBO.Checked = false;
            cBxTyp.Text = null;
            lblStat.Text = "";

        }

    }
}
