using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class Admission : Form
    {
        public string dbfile = "URI=file:HospitalManagement.db";
        public SQLiteConnection ARSqlconn;
        public SQLiteCommand ARCmd;
        public SQLiteDataReader ARDataReader;
        public SQLiteDataAdapter ARDapA, ARDapD, ARDapApP, ARDapN, ARDapR;
        public DataTable ARTbl;
        public static string AdmsID, AdmID, PatientTyp, ApointiD;

        private void Admission_Load(object sender, EventArgs e)
        {
            FillAdmissionGridbox();
            FillPatientGridbox();
            FillNurseGridbox();
            FillRoomGridbox();
            ClearFields();
            AdmID = Reception.RcpnstID;
            //MessageBox.Show("The Rceptionist Admin ID is " + AdmID);
        }

        private void FillAdmissionGridbox()
        {
            //Create a SQL Query Variable
            ARSqlconn.Open();
            SQLiteCommand command = new SQLiteCommand(ARSqlconn);

            ARDapA = new SQLiteDataAdapter("select * from Admission", ARSqlconn);
            ARSqlconn.Close();
            SQLiteCommandBuilder ARCdB1 = new SQLiteCommandBuilder(ARDapA);
            ARTbl = new DataTable();
            ARDapA.Fill(ARTbl);
            dGVAdm.DataSource = ARTbl;
        }
        private void FillPatientGridbox()
        {
            //Create a SQL Query Variable
            ARSqlconn.Open();
            SQLiteCommand command = new SQLiteCommand(ARSqlconn);
            //ARDapA = new SQLiteDataAdapter("select * from Appointment where Type = '" + tpy + "'", ARSqlconn);
            ARDapA = new SQLiteDataAdapter("select * from Appointment where Type = @Ap1 and Admitted =@Ap2", ARSqlconn);
            ARDapA.SelectCommand.Parameters.AddWithValue("@Ap1", "InPatient");
            ARDapA.SelectCommand.Parameters.AddWithValue("@Ap2", "NO");
            ARSqlconn.Close();
            SQLiteCommandBuilder ARCdB1 = new SQLiteCommandBuilder(ARDapA);
            ARTbl = new DataTable();
            ARDapA.Fill(ARTbl);
            dGVPat.DataSource = ARTbl;
        }

        //Define a variable to get the Patient Data grid view Row count
        int RwId;
        private void dGVPat_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // When we double click the selected row in Appointment Data Grid box fetch the values in the above text box for show or edit
            RwId = e.RowIndex;
            DataGridViewRow PatRowId = dGVPat.Rows[RwId];
            //Fill the label box and radio button values with the row selected
            ApointiD = PatRowId.Cells[0].Value.ToString().Trim();
            lblPatID.Text = PatRowId.Cells[1].Value.ToString().Trim();
            lblDocID.Text = PatRowId.Cells[2].Value.ToString().Trim();

            // Get Patient details with Patient ID from Patient DB

            ARSqlconn.Open();
            SQLiteCommand command = new SQLiteCommand(ARSqlconn);
            // get the Patient details
            command.CommandText = "SELECT FirstName, LastName from Patient where Patient_ID=@P1";
            command.Parameters.AddWithValue("@P1", lblPatID.Text.Trim());

            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                lblPfn.Text = reader["FirstName"].ToString().Trim();
                lblPln.Text = reader["LastName"].ToString().Trim();
            }
            reader.Close(); // <- too easy to forget
            reader.Dispose(); // <- too easy to forget
            ARSqlconn.Close();

            // Get Doctor details with Doctor ID from Doctor DB
            ARSqlconn.Open();
            // get the Doctor details
            command.CommandText = "SELECT FirstName, LastName, Specialist from Doctor where Doctor_ID=@D1";
            command.Parameters.AddWithValue("@D1", lblDocID.Text.Trim());

            reader = command.ExecuteReader();
            while (reader.Read())
            {
                lblDfn.Text = reader["FirstName"].ToString().Trim();
                lblDln.Text = reader["LastName"].ToString().Trim();
                lblSpl.Text = reader["Specialist"].ToString().Trim();
            }
            reader.Close(); // <- too easy to forget
            reader.Dispose(); // <- too easy to forget
            ARSqlconn.Close();
        }

        //Define a variable to get the Nurse Data grid view Row count
        int NRwId;

        private void dGVNrs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // When we double click the selected row in Nurse Dat Grid box fetch the values in the above text box for show or edit
            NRwId = e.RowIndex;
            DataGridViewRow NrsRowId = dGVNrs.Rows[NRwId];
            //Fill the label box and radio button values with the row selected

            lblNrsID.Text = NrsRowId.Cells[0].Value.ToString().Trim();
            lblNrsFn.Text = NrsRowId.Cells[1].Value.ToString().Trim();
            lblNrsLn.Text = NrsRowId.Cells[2].Value.ToString().Trim();
            lblPos.Text = NrsRowId.Cells[3].Value.ToString().Trim();

        }

        //Define a variable to get the Room Data grid view Row count
        int RRwId;
        private void dGVRom_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // When we double click the selected row in Room Dat Grid box fetch the values in the above text box for show or edit
            RRwId = e.RowIndex;
            DataGridViewRow RomRowId = dGVRom.Rows[RRwId];
            //Fill the label box values with the row selected

            lblRomNo.Text = RomRowId.Cells[0].Value.ToString().Trim() + "-" + RomRowId.Cells[1].Value.ToString().Trim() + "-" + RomRowId.Cells[3].Value.ToString().Trim();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        //Define a variable to get the Patient Data from Admission grid box row count
        int AdmRwId;

        private void dGVAdm_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // When we double click the selected row in Admission Grid box fetch the values in the above text box for show
            AdmRwId = e.RowIndex;
            DataGridViewRow AdmRowId = dGVAdm.Rows[AdmRwId];
            //Fill the label box, Text box and date field values with the row selected
            lblAdmsID.Text = AdmRowId.Cells[0].Value.ToString().Trim();
            lblPatID.Text = AdmRowId.Cells[1].Value.ToString().Trim();
            lblDocID.Text = AdmRowId.Cells[2].Value.ToString().Trim();
            lblNrsID.Text = AdmRowId.Cells[3].Value.ToString().Trim();
            lblRomNo.Text = AdmRowId.Cells[4].Value.ToString().Trim();

            // Get Patient details with Patient ID from Patient DB

            ARSqlconn.Open();
            SQLiteCommand command = new SQLiteCommand(ARSqlconn);
            // get the Patient details
            command.CommandText = "SELECT FirstName, LastName from Patient where Patient_ID=@P1";
            command.Parameters.AddWithValue("@P1", lblPatID.Text.Trim());

            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                lblPfn.Text = reader["FirstName"].ToString().Trim();
                lblPln.Text = reader["LastName"].ToString().Trim();
            }
            reader.Close(); // <- too easy to forget
            reader.Dispose(); // <- too easy to forget

            // get the Doctor details
            command.CommandText = "SELECT FirstName, LastName, Specialist from Doctor where Doctor_ID=@D1";
            command.Parameters.AddWithValue("@D1", lblDocID.Text.Trim());

            reader = command.ExecuteReader();
            while (reader.Read())
            {
                lblDfn.Text = reader["FirstName"].ToString().Trim();
                lblDln.Text = reader["LastName"].ToString().Trim();
                lblSpl.Text = reader["Specialist"].ToString().Trim();
            }
            reader.Close(); // <- too easy to forget
            reader.Dispose(); // <- too easy to forget

            // get the Nurse details
            command.CommandText = "SELECT FirstName, LastName, Position from Nurse where Nurse_ID=@N1";
            command.Parameters.AddWithValue("@N1", lblNrsID.Text.Trim());

            reader = command.ExecuteReader();
            while (reader.Read())
            {
                lblNrsFn.Text = reader["FirstName"].ToString().Trim();
                lblNrsLn.Text = reader["LastName"].ToString().Trim();
                lblPos.Text = reader["Position"].ToString().Trim();
            }
            reader.Close(); // <- too easy to forget
            reader.Dispose(); // <- too easy to forget
            ARSqlconn.Close();

        }

        private void btnDisCh_Click(object sender, EventArgs e)
        {
            //Convert date Picker value into String
            string dcdt = DtPAdm.Value.ToString("yyyy/MM/dd");

            //Open admission database
            ARSqlconn.Open();
            SQLiteCommand command = new SQLiteCommand(ARSqlconn);
            command.CommandText = ("UPDATE Admission SET Admitted = @AD1, Discharged = @AD2, Discharged_Date = @AD3 where Admission_ID = @AD4");
            command.Parameters.AddWithValue("@AD1", "CLOSED");
            command.Parameters.AddWithValue("@AD2", "YES");
            command.Parameters.AddWithValue("@AD3", dcdt);
            command.Parameters.AddWithValue("@AD4", lblAdmsID.Text.Trim());

            command.ExecuteNonQuery();
            // update appointmnent details

            command.CommandText = ("UPDATE Appointment SET Admitted = @AP1 where Patient_ID = @AP2");
            command.Parameters.AddWithValue("@AP1", "CLOSED");
            command.Parameters.AddWithValue("@AP2", lblPatID.Text.Trim());
            command.ExecuteNonQuery();

            ARSqlconn.Close();
            MessageBox.Show("Patient " + lblPfn.Text + lblPln.Text + " has been discharged ");

            // Referesh the Admission data Grid View- Populate the latest data
            FillAdmissionGridbox();
            ClearFields();

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (prnPrvwDlog7.ShowDialog() == DialogResult.OK)
            {
                prnPrvwDlog7.Document = PrnDoc7;
                PrnDoc7.DefaultPageSettings.Landscape = true;
                prnPrvwDlog7.ShowDialog();
            }
        }

        private void PrnDoc7_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(label4.Text, new Font("Rockwell", 18, FontStyle.Bold), Brushes.DarkBlue, new Point(130, 5));
            e.Graphics.DrawString("ADMISSION DETAILS", new Font("Ariel", 16, FontStyle.Bold), Brushes.DarkBlue, new Point(230, 60));

            // Fetch all admission details from the database table
            ARSqlconn.Open();
            SQLiteCommand command = new SQLiteCommand(ARSqlconn);
            command.CommandText = ("Select * from admission");
            var reader = command.ExecuteReader();
            int y = 100;
            while (reader.Read())
            {
                e.Graphics.DrawString("ADMISSION ID            - " + reader["Admission_ID"].ToString().Trim(), new Font("Ariel", 15, FontStyle.Bold), Brushes.DarkBlue, new Point(5, y));
                y = y + 30;
                e.Graphics.DrawString("PATIENT ID              - " + reader["Patient_ID"].ToString().Trim(), new Font("Ariel", 15, FontStyle.Bold), Brushes.DarkBlue, new Point(5, y));
                y = y + 30;
                e.Graphics.DrawString("DOCTOR ID               - " + reader["Doctor_ID"].ToString().Trim(), new Font("Ariel", 15, FontStyle.Bold), Brushes.DarkBlue, new Point(5, y));
                y = y + 30;
                e.Graphics.DrawString("NURSE ID                - " + reader["Nurse_ID"].ToString().Trim(), new Font("Ariel", 15, FontStyle.Bold), Brushes.DarkBlue, new Point(5, y));
                y = y + 30;
                e.Graphics.DrawString("ROOM NO                 - " + reader["Room_No"].ToString().Trim(), new Font("Ariel", 15, FontStyle.Bold), Brushes.DarkBlue, new Point(5, y));
                y = y + 30;
                e.Graphics.DrawString("ADMIN ID                - " + reader["Admin_ID"].ToString().Trim(), new Font("Ariel", 15, FontStyle.Bold), Brushes.DarkBlue, new Point(5, y));
                y = y + 30;
                e.Graphics.DrawString("ADMISSION DATE          - " + reader["AdmissionDate"].ToString().Trim(), new Font("Ariel", 15, FontStyle.Bold), Brushes.DarkBlue, new Point(5, y));
                y = y + 30;
                e.Graphics.DrawString("ADMITTED                - " + reader["Admitted"].ToString().Trim(), new Font("Ariel", 15, FontStyle.Bold), Brushes.DarkBlue, new Point(5, y));
                y = y + 30;
                e.Graphics.DrawString("DISCHARGED              - " + reader["Discharged"].ToString().Trim(), new Font("Ariel", 15, FontStyle.Bold), Brushes.DarkBlue, new Point(5, y));
                y = y + 30;
                e.Graphics.DrawString("DISCHARGED DATE         - " + reader["Discharged_Date"].ToString().Trim(), new Font("Ariel", 15, FontStyle.Bold), Brushes.DarkBlue, new Point(5, y));
                y = y + 30;

                e.Graphics.DrawString("--------------------------------------------------------", new Font("Ariel", 15, FontStyle.Bold), Brushes.DarkBlue, new Point(5, y));
                y = y + 30;

            }
            reader.Close(); // <- too easy to forget
            reader.Dispose(); // <- too easy to forget
            ARSqlconn.Close();

        }

        private void ExitAdmisnPage_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdm_Click(object sender, EventArgs e)
        {
            //Convert date Picker value into String
            string addt = DtPAdm.Value.ToString("yyyy/MM/dd");

            ARSqlconn.Open();
            SQLiteCommand command = new SQLiteCommand(ARSqlconn);
            string NAdid;

            //Get counter value for Admission
            command.CommandText = "SELECT Adnum from Counter";
            command.Prepare();
            command.ExecuteNonQuery();
            int Admcnt = (Int32)command.ExecuteScalar();
            Admcnt = Admcnt + 1;
            if (Admcnt <= 9)
            {
                NAdid = "AMS000" + Admcnt.ToString().Trim();
            }
            else if (Admcnt <= 99 && Admcnt > 9)
            {
                NAdid = "AMS00" + Admcnt.ToString().Trim();
            }
            else if (Admcnt <= 999 && Admcnt > 99)
            {
                NAdid = "AMS0" + Admcnt.ToString().Trim();
            }
            else
            {
                NAdid = "AMS" + Admcnt.ToString().Trim();
            }

            lblAdmsID.Text = NAdid;

            //Open admission database

            command.CommandText = ("INSERT INTO Admission VALUES(@AD1, @AD2, @AD3, @AD4, @AD5, @AD6, @AD7, @AD8, @AD9, @AD10)");
            command.Parameters.AddWithValue("@AD1", NAdid);
            command.Parameters.AddWithValue("@AD2", lblPatID.Text.Trim());
            command.Parameters.AddWithValue("@AD3", lblDocID.Text.Trim());
            command.Parameters.AddWithValue("@AD4", lblNrsID.Text.Trim());
            command.Parameters.AddWithValue("@AD5", lblRomNo.Text.Trim());
            command.Parameters.AddWithValue("@AD6", AdmID);
            command.Parameters.AddWithValue("@AD7", addt);
            command.Parameters.AddWithValue("@AD8", "YES");
            command.Parameters.AddWithValue("@AD9", "NO");
            command.Parameters.AddWithValue("@AD10", "");

            command.ExecuteNonQuery();
            // Update Appointment table for Admitted column
            command.CommandText = ("UPDATE Appointment SET Admitted=@Apt1 WHERE ApppintmentID=@Apt2");
            command.Parameters.AddWithValue("@Apt1", "YES");
            command.Parameters.AddWithValue("@Apt2", ApointiD);

            // Update the Counter Table
            command.CommandText = ("UPDATE Counter SET Adnum=@AD");
            command.Parameters.AddWithValue("@AD", Admcnt);
            command.ExecuteNonQuery();

            ARSqlconn.Close();
            MessageBox.Show("Admission " + NAdid + " has been created for " + lblPfn.Text + lblPln.Text);

            // Referesh the Admission data Grid View- Populate the latest data
            FillAdmissionGridbox();
            ClearFields();

        }

        private void FillNurseGridbox()
        {
            //Create a SQL Query Variable
            ARSqlconn.Open();
            SQLiteCommand command = new SQLiteCommand(ARSqlconn);

            ARDapN = new SQLiteDataAdapter("select * from Nurse", ARSqlconn);
            ARSqlconn.Close();
            SQLiteCommandBuilder ARCdB1 = new SQLiteCommandBuilder(ARDapN);
            ARTbl = new DataTable();
            ARDapN.Fill(ARTbl);
            dGVNrs.DataSource = ARTbl;
        }
        private void FillRoomGridbox()
        {
            //Create a SQL Query Variable
            ARSqlconn.Open();
            SQLiteCommand command = new SQLiteCommand(ARSqlconn);

            ARDapR = new SQLiteDataAdapter("select * from Room", ARSqlconn);
            ARSqlconn.Close();
            SQLiteCommandBuilder ARCdB1 = new SQLiteCommandBuilder(ARDapR);
            ARTbl = new DataTable();
            ARDapR.Fill(ARTbl);
            dGVRom.DataSource = ARTbl;
        }

        public Admission()
        {
            InitializeComponent();
            ARSqlconn = new SQLiteConnection(dbfile);

        }

        private void ClearFields()
        {
            lblAdmsID.Text = "";

            lblPatID.Text = "";
            lblPfn.Text = "";
            lblPln.Text = "";
            lblDocID.Text = "";
            lblDfn.Text = "";
            lblDln.Text = "";
            lblSpl.Text = "";
            lblNrsID.Text = "";
            lblNrsFn.Text = "";
            lblNrsLn.Text = "";
            lblPos.Text = "";
            lblRomNo.Text = "";

        }

    }
}
