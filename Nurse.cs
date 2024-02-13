using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class Nurse : Form
    {
        public string dbfile = "URI=file:HospitalManagement.db";
        public SQLiteConnection ARSqlconn;
        public SQLiteCommand ARCmd;
        public SQLiteDataReader ARDataReader;
        public SQLiteDataAdapter ARDap;
        public DataTable ARTbl;
        public static string NrsID, NrsPos;

        public Nurse()
        {
            InitializeComponent();
            ARSqlconn = new SQLiteConnection(dbfile);
        }

        private void Nurse_Load(object sender, EventArgs e)
        {
            FillNurseGridbox();
            ClearFields();
            cBxPos.Focus();

        }

        public void FillNurseGridbox()
        {
            //Create a SQL Query Variable
            ARSqlconn.Open();
            SQLiteCommand command = new SQLiteCommand(ARSqlconn);

            ARDap = new SQLiteDataAdapter("select * from Nurse", ARSqlconn);
            ARSqlconn.Close();
            SQLiteCommandBuilder ARCdB1 = new SQLiteCommandBuilder(ARDap);
            ARTbl = new DataTable();
            ARDap.Fill(ARTbl);
            dGVNrs.DataSource = ARTbl;

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

        private void txtNmc_Leave(object sender, EventArgs e)
        {
            if (txtNmc.TextLength == 0)
            {
                MessageBox.Show("Nmc box is Blank. Please provide an Nmc.");
                txtNmc.Focus();
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
        private void cBxPos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // get the new Position from Combo Box
            NrsPos = cBxPos.Text.Trim();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // To add new Nurse details
            ARSqlconn.Open();
            SQLiteCommand command = new SQLiteCommand(ARSqlconn);
            int Nrsid;
            string NNrsid = "";
            string fn = txtFnm.Text.Trim(), ln = txtLnm.Text.Trim();
            string cnt = txtPhone.Text.Trim(), db = txtDoB.Text.Trim();
            string add = txtAdd.Text.Trim(), mail = txtEmail.Text.Trim();
            string qual = txtQual.Text.Trim();
            string gen = "", Nmc = txtNmc.Text.Trim();
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

            // get the next Count for new Nurse to be added
            command.CommandText = "SELECT Nnum from Counter";
            command.Prepare();
            command.ExecuteNonQuery();
            Nrsid = (Int32)command.ExecuteScalar();
            Nrsid = Nrsid + 1;
            if (Nrsid <= 9)
            {
                NNrsid = "NRS00" + Nrsid.ToString().Trim();
            }
            else
            {
                NNrsid = "NRS0" + Nrsid.ToString().Trim();
            }
            ARSqlconn.Close();

            // Add new Doctor in Doctor table
            ARSqlconn.Open();
            command.CommandText = ("INSERT INTO Nurse VALUES(@N1, @N2, @N3, @N4, @N5, @N6, @N7, @N8, @N9, @N10, @N11, @N12)");
            command.Parameters.AddWithValue("@N1", NNrsid);
            command.Parameters.AddWithValue("@N2", fn);
            command.Parameters.AddWithValue("@N3", ln);
            command.Parameters.AddWithValue("@N4", NrsPos);
            command.Parameters.AddWithValue("@N5", Nmc);
            command.Parameters.AddWithValue("@N6", db);
            command.Parameters.AddWithValue("@N7", gen);
            command.Parameters.AddWithValue("@N8", add);
            command.Parameters.AddWithValue("@N9", cnt);
            command.Parameters.AddWithValue("@N10", mail);
            command.Parameters.AddWithValue("@N11", qual);
            command.Parameters.AddWithValue("@N12", "Active");

            command.ExecuteNonQuery();
            // Update the Counter Table
            command.CommandText = ("UPDATE Counter SET Nnum=@NN");
            command.Parameters.AddWithValue("@NN", Nrsid);
            command.ExecuteNonQuery();

            ARSqlconn.Close();
            MessageBox.Show("The New Nurse " + fn + " - " + NNrsid + " has been added");

            // Referesh the Nurse data Grid View- Populate the latest data
            FillNurseGridbox();
            ClearFields();


        }
        //Define a variable to get the Customer Data grid view Row count
        int RwId;

        private void dGVNrs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // When we double click the selected row in Nurse Data Grid box fetch the values in the above text box for show or edit
            RwId = e.RowIndex;
            DataGridViewRow DocRowId = dGVNrs.Rows[RwId];
            //File the textbox / label box and radio button values with the row selected

            lblNrsID.Text = DocRowId.Cells[0].Value.ToString().Trim();
            txtFnm.Text = DocRowId.Cells[1].Value.ToString().Trim();
            txtLnm.Text = DocRowId.Cells[2].Value.ToString().Trim();

            string Splt = DocRowId.Cells[3].Value.ToString().Trim();
            // Speacialist Combo Box Selection

            if (Splt == "Nurse Practitioner")
                cBxPos.SelectedIndex = cBxPos.FindStringExact("Nurse Practitioner");
            else if (Splt == "Clinical Nurse Midwife")
                cBxPos.SelectedIndex = cBxPos.FindStringExact("Clinical Nurse Midwife");
            else if (Splt == "Clinical Nurse Speacialist")
                cBxPos.SelectedIndex = cBxPos.FindStringExact("Clinical Nurse Speacialist");

            txtNmc.Text = DocRowId.Cells[4].Value.ToString().Trim();
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
            lblStat.Text = DocRowId.Cells[11].Value.ToString().Trim();
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            // To update the edited values in the Nurse table against the selected Nurse ID
            ARSqlconn.Open();
            SQLiteCommand command = new SQLiteCommand(ARSqlconn);
            string NNrsid = lblNrsID.Text.Trim();
            string fn = txtFnm.Text.Trim(), ln = txtLnm.Text.Trim();
            string cnt = txtPhone.Text.Trim(), db = txtDoB.Text.Trim();
            string add = txtAdd.Text.Trim(), mail = txtEmail.Text.Trim();
            string qual = txtQual.Text.Trim();
            string gen = "", Nmc = txtNmc.Text.Trim();
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


            // Modify the existing nurse detail and update the nurse table
            command.CommandText = ("UPDATE Nurse SET FirstName=@N1, LastName=@N2, Position=@N3, NMC=@N4, DateOfBirth=@N5, Gender=@N6, Address=@N7, PhoneNumber=@N8, EmailID=@N9, Qualification=@N10, Status=@N11 WHERE Nurse_ID=@N12");
            command.Parameters.AddWithValue("@N1", fn);
            command.Parameters.AddWithValue("@N2", ln);
            command.Parameters.AddWithValue("@N3", NrsPos);
            command.Parameters.AddWithValue("@N4", Nmc);
            command.Parameters.AddWithValue("@N5", db);
            command.Parameters.AddWithValue("@N6", gen);
            command.Parameters.AddWithValue("@N7", add);
            command.Parameters.AddWithValue("@N8", cnt);
            command.Parameters.AddWithValue("@N9", mail);
            command.Parameters.AddWithValue("@N10", qual);
            command.Parameters.AddWithValue("@N11", act);
            command.Parameters.AddWithValue("@N12", NNrsid);


            command.ExecuteNonQuery();

            ARSqlconn.Close();
            MessageBox.Show("The Nurse " + fn + " - " + NNrsid + " has been successfully Updated");


            // Referesh the Nurse data Grid View- Populate the latest data
            FillNurseGridbox();
            ClearFields();


        }

        private void btnDact_Click(object sender, EventArgs e)
        {
            // To deactivate an active nurse
            string Sta = lblStat.Text.Trim();

            if (Sta == "InActive")
            {
                MessageBox.Show("The nurse " + txtFnm.Text + " is already inactive");
            }
            else if (Sta == "Active")
            {
                //Currently the nurse is active so we can deactivate
                string NrsId = lblNrsID.Text.Trim();
                // Open nurse table
                ARSqlconn.Open();
                SQLiteCommand command = new SQLiteCommand(ARSqlconn);
                // Update the existing nurse in nurse table

                command.CommandText = ("UPDATE Nurse SET Status=@N1 WHERE Nurse_ID=@N2");

                command.Parameters.AddWithValue("@N1", "InActive");
                command.Parameters.AddWithValue("@N2", NrsId);
                command.ExecuteNonQuery();

                ARSqlconn.Close();
                MessageBox.Show("The nurse " + txtFnm.Text + " - " + NrsId + " has been successfully Deactivated");

                // Refresh the Nurse data Grid View- Populate the latest data
                FillNurseGridbox();
                ClearFields();

            }

        }

        private void btnAct_Click(object sender, EventArgs e)
        {
            // To Activate a deactivated nurse staff
            string Sta = lblStat.Text.Trim();

            if (Sta == "Active")
            {
                MessageBox.Show("The nurse " + txtFnm.Text + " is already active");
            }
            else if (Sta == "InActive")
            {
                //Currently the nurse is inactive so we can activate
                string NrsId = lblNrsID.Text.Trim();
                // Open Nurse table
                ARSqlconn.Open();
                SQLiteCommand command = new SQLiteCommand(ARSqlconn);
                // Update the existing Nurse in Nurse table

                command.CommandText = ("UPDATE Nurse SET Status=@N1 WHERE Nurse_ID=@N2");

                command.Parameters.AddWithValue("@N1", "Active");
                command.Parameters.AddWithValue("@N2", NrsId);
                command.ExecuteNonQuery();

                ARSqlconn.Close();
                MessageBox.Show("The Nurse " + txtFnm.Text + " - " + NrsId + " has been successfully Activated");

                // Refresh the Nurse data Grid View- Populate the latest data
                FillNurseGridbox();
                ClearFields();

            }

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (prnPrvwDlog4.ShowDialog() == DialogResult.OK)
            {
                prnPrvwDlog4.Document = PrnDoc4;
                PrnDoc4.DefaultPageSettings.Landscape = true;
                prnPrvwDlog4.ShowDialog();

            }
        }

        private void PrnDoc4_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(label4.Text, new Font("Rockwell", 18, FontStyle.Bold), Brushes.DarkBlue, new Point(130, 5));
            e.Graphics.DrawString("NURSE DETAILS", new Font("Ariel", 16, FontStyle.Bold), Brushes.DarkBlue, new Point(230, 60));

            // Fetch all nurse details from the database table
            ARSqlconn.Open();
            SQLiteCommand command = new SQLiteCommand(ARSqlconn);
            command.CommandText = ("Select * from nurse");
            var reader = command.ExecuteReader();
            int y = 100;
            while (reader.Read())
            {
                e.Graphics.DrawString("NURSE ID                  - " + reader["Nurse_ID"].ToString().Trim(), new Font("Ariel", 15, FontStyle.Bold), Brushes.DarkBlue, new Point(5, y));
                y = y + 30;
                e.Graphics.DrawString("NURSE NAME                - " + reader["FirstName"].ToString().Trim() + " " + reader["LastName"].ToString().Trim(), new Font("Ariel", 15, FontStyle.Bold), Brushes.DarkBlue, new Point(5, y));
                y = y + 30;
                e.Graphics.DrawString("POSITION                  - " + reader["Position"].ToString().Trim(), new Font("Ariel", 15, FontStyle.Bold), Brushes.DarkBlue, new Point(5, y));
                y = y + 30;
                e.Graphics.DrawString("NMC                       - " + reader["NMC"].ToString().Trim(), new Font("Ariel", 15, FontStyle.Bold), Brushes.DarkBlue, new Point(5, y));
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
                e.Graphics.DrawString("STATUS                    - " + reader["Status"].ToString().Trim(), new Font("Ariel", 15, FontStyle.Bold), Brushes.DarkBlue, new Point(5, y));
                y = y + 30;
                e.Graphics.DrawString("--------------------------------------------------------", new Font("Ariel", 15, FontStyle.Bold), Brushes.DarkBlue, new Point(5, y));
                y = y + 30;

            }
            reader.Close(); // <- too easy to forget
            reader.Dispose(); // <- too easy to forget
            ARSqlconn.Close();

        }

        private void ExitNrsPage_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ClearFields()
        {
            // To Clear All the textbox, Label Box and Radio Buttons
            lblNrsID.Text = "";
            txtFnm.Text = "";
            txtLnm.Text = "";
            txtAdd.Text = "";
            txtDoB.Text = "";
            txtEmail.Text = "";
            txtQual.Text = "";
            txtPhone.Text = "";
            txtNmc.Text = "";
            rdBF.Checked = false;
            rdBM.Checked = false;
            rdBO.Checked = false;
            cBxPos.Text = null;
            lblStat.Text = "";

        }

    }
}
