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
    public partial class Appointment : Form
    {
        public string dbfile = "URI=file:HospitalManagement.db";
        public SQLiteConnection ARSqlconn;
        public SQLiteCommand ARCmd;
        public SQLiteDataReader ARDataReader;
        public SQLiteDataAdapter ARDapA, ARDapD, ARDapP;
        public DataTable ARTbl;
        public static string ApID, AdmID, PatientTyp;

        public Appointment()
        {
            InitializeComponent();
            ARSqlconn = new SQLiteConnection(dbfile);
        }

        private void Appointment_Load(object sender, EventArgs e)
        {
            FillAppointmentGridbox();
            FillDoctorGridbox();
            FillPatientGridbox();
            ClearFields();
            lbliss.Text = DateTime.Now.ToString("yyyy/MM/dd");
            AdmID = Reception.RcpnstID;
            //MessageBox.Show("The Rceptionist Admin ID is "+ AdmID);
        }

        private void FillAppointmentGridbox()
        {
            //Create a SQL Query Variable
            ARSqlconn.Open();
            SQLiteCommand command = new SQLiteCommand(ARSqlconn);

            ARDapA = new SQLiteDataAdapter("select * from Appointment", ARSqlconn);
            ARSqlconn.Close();
            SQLiteCommandBuilder ARCdB1 = new SQLiteCommandBuilder(ARDapA);
            ARTbl = new DataTable();
            ARDapA.Fill(ARTbl);
            dGVApp.DataSource = ARTbl;
        }

        private void FillDoctorGridbox()
        {
            //Create a SQL Query Variable
            ARSqlconn.Open();
            SQLiteCommand command = new SQLiteCommand(ARSqlconn);
            string sts = "Active";
            ARDapD = new SQLiteDataAdapter("select Doctor_ID, FirstName, LastName, Specialist from Doctor where Status = '" + sts + "'", ARSqlconn);
            //ARDap = new SqlDataAdapter("select Cust_ID, Cust_First_Name, Cust_SurName, Cust_Contact_Number, Cust_DrivingLicNo, Cust_Address, Cust_Location, Cust_PostalCode from Customer where Cust_Status = '" + Custst + "'", ARSqlconn);
            ARSqlconn.Close();
            SQLiteCommandBuilder ARCdB1 = new SQLiteCommandBuilder(ARDapD);
            ARTbl = new DataTable();
            ARDapD.Fill(ARTbl);
            dGVDoc.DataSource = ARTbl;
        }

        //Define a variable to get the Patient Data grid view Row count
        int RwId;
        private void dGVPat_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // When we double click the selected row in Patient Data Grid box fetch the values in the above text box for show or edit
            RwId = e.RowIndex;
            DataGridViewRow PatRowId = dGVPat.Rows[RwId];

            // Check the Selected Patient has already an open appointment/Admission
            string pid = PatRowId.Cells[0].Value.ToString().Trim();
            string Alrdy = "NO";
            //Create a SQL Query Variable
            ARSqlconn.Open();
            SQLiteCommand command = new SQLiteCommand(ARSqlconn);
            // get the Patient details
            command.CommandText = "SELECT Admitted from Appointment where Patient_ID=@P1";
            command.Parameters.AddWithValue("@P1", pid);
            //command.Parameters.AddWithValue("@P2", "NO");

            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                //MessageBox.Show("Patient already had previous appointment");
                if (reader["Admitted"].ToString().Trim() == "NO") Alrdy = "YES";
                else if (reader["Admitted"].ToString().Trim() == "YES") Alrdy = "YES";
                else if (reader["Admitted"].ToString().Trim() == "CLOSED") Alrdy = "NO";
                else if (reader["Admitted"].ToString().Trim() == "NA") Alrdy = "YES";
                else if (reader["Admitted"].ToString().Trim() == "DIAGNOSED") Alrdy = "NO";
            }
            reader.Close(); // <- too easy to forget
            reader.Dispose(); // <- too easy to forget
            ARSqlconn.Close();
            if (Alrdy == "NO")
            {
                //File the textbox / label box and radio button values with the row selected
                lblPatID.Text = PatRowId.Cells[0].Value.ToString().Trim();
                lblPfn.Text = PatRowId.Cells[1].Value.ToString().Trim();
                lblPln.Text = PatRowId.Cells[2].Value.ToString().Trim();
                PatientTyp = PatRowId.Cells[8].Value.ToString().Trim();
            }
            else
                MessageBox.Show("Patient Already have Active Appointment. Cannot create Another Appointment");
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (prnPrvwDlog6.ShowDialog() == DialogResult.OK)
            {
                prnPrvwDlog6.Document = PrnDoc6;
                PrnDoc6.DefaultPageSettings.Landscape = true;
                prnPrvwDlog6.ShowDialog();

            }

        }

        private void PrnDoc6_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(label4.Text, new Font("Rockwell", 18, FontStyle.Bold), Brushes.DarkBlue, new Point(130, 5));
            e.Graphics.DrawString("APPOINTMENT DETAILS", new Font("Ariel", 16, FontStyle.Bold), Brushes.DarkBlue, new Point(230, 60));

            // Fetch all appointment details from the database table
            ARSqlconn.Open();
            SQLiteCommand command = new SQLiteCommand(ARSqlconn);
            command.CommandText = ("Select * from appointment");
            var reader = command.ExecuteReader();
            int y = 100;
            while (reader.Read())
            {
                e.Graphics.DrawString("APPOINTMENT ID            - " + reader["Appointment_ID"].ToString().Trim(), new Font("Ariel", 15, FontStyle.Bold), Brushes.DarkBlue, new Point(5, y));
                y = y + 30;
                e.Graphics.DrawString("PATIENT ID                - " + reader["Patient_ID"].ToString().Trim(), new Font("Ariel", 15, FontStyle.Bold), Brushes.DarkBlue, new Point(5, y));
                y = y + 30;
                e.Graphics.DrawString("DOCTOR ID                 - " + reader["Doctor_ID"].ToString().Trim(), new Font("Ariel", 15, FontStyle.Bold), Brushes.DarkBlue, new Point(5, y));
                y = y + 30;
                e.Graphics.DrawString("ADMIN ID                  - " + reader["Admin_ID"].ToString().Trim(), new Font("Ariel", 15, FontStyle.Bold), Brushes.DarkBlue, new Point(5, y));
                y = y + 30;
                e.Graphics.DrawString("TYPE                      - " + reader["Type"].ToString().Trim(), new Font("Ariel", 15, FontStyle.Bold), Brushes.DarkBlue, new Point(5, y));
                y = y + 30;
                e.Graphics.DrawString("ISSUED DATE               - " + reader["Issued_Date"].ToString().Trim(), new Font("Ariel", 15, FontStyle.Bold), Brushes.DarkBlue, new Point(5, y));
                y = y + 30;
                e.Graphics.DrawString("APPOINTMENT DATE          - " + reader["Appointment_Date"].ToString().Trim(), new Font("Ariel", 15, FontStyle.Bold), Brushes.DarkBlue, new Point(5, y));
                y = y + 30;
                e.Graphics.DrawString("APPOINTMENT TIME          - " + reader["Appointment_Time"].ToString().Trim(), new Font("Ariel", 15, FontStyle.Bold), Brushes.DarkBlue, new Point(5, y));
                y = y + 30;
                e.Graphics.DrawString("DESCRIPTION               - " + reader["Description"].ToString().Trim(), new Font("Ariel", 15, FontStyle.Bold), Brushes.DarkBlue, new Point(5, y));
                y = y + 30;
                e.Graphics.DrawString("ADMITTED                  - " + reader["Admitted"].ToString().Trim(), new Font("Ariel", 15, FontStyle.Bold), Brushes.DarkBlue, new Point(5, y));
                y = y + 30;

                e.Graphics.DrawString("--------------------------------------------------------", new Font("Ariel", 15, FontStyle.Bold), Brushes.DarkBlue, new Point(5, y));
                y = y + 30;

            }
            reader.Close(); // <- too easy to forget
            reader.Dispose(); // <- too easy to forget
            ARSqlconn.Close();

        }

        private void txtDisc_Leave(object sender, EventArgs e)
        {
            if (txtDisc.TextLength == 0)
            {
                MessageBox.Show("Illness Description box is Blank. Please provide illnress details of the Patient.");
                txtDisc.Focus();
            }
        }

        private void ExitAppointPage_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dGVDoc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // When we double click the selected row in Doctor Dat Grid box fetch the values in the above text box for show or edit
            RwId = e.RowIndex;
            DataGridViewRow DocRowId = dGVDoc.Rows[RwId];
            //File the textbox / label box and radio button values with the row selected

            lblDocID.Text = DocRowId.Cells[0].Value.ToString().Trim();
            lblDfn.Text = DocRowId.Cells[1].Value.ToString().Trim();
            lblDln.Text = DocRowId.Cells[2].Value.ToString().Trim();
            lblSpl.Text = DocRowId.Cells[3].Value.ToString().Trim();

        }

        // to add appointment in appointment table
        private void btnApp_Click(object sender, EventArgs e)
        {
            //Convert date Picker value into String
            string apdt = DtPApp.Value.ToString("yyyy/MM/dd");
            string Admdt="";

            // Select Admitted value as per Patient Type
            if (PatientTyp.Trim() == "InPatient") Admdt = "NO";
            if (PatientTyp.Trim() == "OutPatient") Admdt = "NA";

            // Check the Counter number for Appointment
            ARSqlconn.Open();
            SQLiteCommand command = new SQLiteCommand(ARSqlconn);
            int Appid;
            string NApid = "";

            // get the next Count for new Appointment to be added
            command.CommandText = "SELECT Appnum from Counter";
            command.Prepare();
            command.ExecuteNonQuery();
            Appid = (Int32)command.ExecuteScalar();
            Appid = Appid + 1;
            if (Appid <= 9)
            {
                NApid = "APP000" + Appid.ToString().Trim();
            }
            else if (Appid <= 99 && Appid > 9)
            {
                NApid = "APP00" + Appid.ToString().Trim();
            }
            else if (Appid <= 999 && Appid > 99)
            {
                NApid = "APP0" + Appid.ToString().Trim();
            }
            else
            {
                NApid = "APP" + Appid.ToString().Trim();
            }

            ARSqlconn.Close();

            // Add new Appointment in Appointment table
            ARSqlconn.Open();
            command.CommandText = ("INSERT INTO Appointment VALUES(@A1, @A2, @A3, @A4, @A5, @A6, @A7, @A8, @A9, @A10)");
            command.Parameters.AddWithValue("@A1", NApid);
            command.Parameters.AddWithValue("@A2", lblPatID.Text.Trim());
            command.Parameters.AddWithValue("@A3", lblDocID.Text.Trim());
            command.Parameters.AddWithValue("@A4", AdmID);
            command.Parameters.AddWithValue("@A5", PatientTyp);
            command.Parameters.AddWithValue("@A6", lbliss.Text.Trim());
            command.Parameters.AddWithValue("@A7", apdt);
            command.Parameters.AddWithValue("@A8", txtTime.Text.Trim());
            command.Parameters.AddWithValue("@A9", txtDisc.Text.Trim());
            command.Parameters.AddWithValue("@A10", Admdt);

            command.ExecuteNonQuery();
            // Update the Counter Table
            command.CommandText = ("UPDATE Counter SET Appnum=@AA");
            command.Parameters.AddWithValue("@AA", Appid);
            command.ExecuteNonQuery();

            ARSqlconn.Close();
            MessageBox.Show("Appointment " + NApid + " has been created for " + lblPfn.Text + lblPln.Text);

            // Referesh the Appointment data Grid View- Populate the latest data
            FillAppointmentGridbox();
            ClearFields();
        }

        private void FillPatientGridbox()
        {
            //Create a SQL Query Variable
            ARSqlconn.Open();
            SQLiteCommand command = new SQLiteCommand(ARSqlconn);

            ARDapP = new SQLiteDataAdapter("select * from Patient", ARSqlconn);
            ARSqlconn.Close();
            SQLiteCommandBuilder ARCdB1 = new SQLiteCommandBuilder(ARDapP);
            ARTbl = new DataTable();
            ARDapP.Fill(ARTbl);
            dGVPat.DataSource = ARTbl;
        }

        public void ClearFields()
        {
            lblAppID.Text = "";
            lblPatID.Text = "";
            lblPfn.Text = "";
            lblPln.Text = "";
            txtTime.Text = "";
            txtDisc.Text = "";
            lblDocID.Text = "";
            lblDfn.Text = "";
            lblDln.Text = "";
            lblSpl.Text = "";
        }

    }
}
