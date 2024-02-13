using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class Diagnosis : Form
    {
        public string dbfile = "URI=file:HospitalManagement.db";
        public SQLiteConnection ARSqlconn;
        public SQLiteCommand ARCmd;
        public SQLiteDataReader ARDataReader;
        public SQLiteDataAdapter ARDapA, ARDapD, ARDapApP, ARDapN, ARDapR;
        public DataTable ARTbl;
        public static string[,] Psteps = new string[10, 4];
        public static string ApntID, DgnID, AdmID, Pid, Did;
        public static int nct, Tx1 = 0, Tx2 = 0, Tx3 = 0;
        public static string Ptnid, Ptnam, Ptsym, DocID, DocNam, DocDiag, prescriptionID, diagnosisID, prescripdt;

        private void txtDgn_Leave(object sender, EventArgs e)
        {
            if (txtDgn.TextLength == 0)
            {
                MessageBox.Show("Doctor Diagnosis detail box is Blank. Please provide Doctors Diagnsis feedback of the Patient.");
                txtDgn.Focus();
            }
        }

        int DRwID;
        private void dGVDgn_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Clear the Prescripton Array values
            //Psteps = new string[10, 4];
            for (int k=0; k<10; k++)
            {
                Psteps[k, 1] = "";
                Psteps[k, 2] = "";
                Psteps[k, 3] = "";
            }

            // When we double click the selected row in Diagnosis Data Grid box fetch the values in the above text box for show
            DRwID = e.RowIndex;
            DataGridViewRow DiagsisRowId = dGVDgn.Rows[DRwID];
            ApntID = DiagsisRowId.Cells[7].Value.ToString().Trim();
            prescripdt = DiagsisRowId.Cells[1].Value.ToString().Trim();
            lblPatID.Text = DiagsisRowId.Cells[2].Value.ToString().Trim();
            lblDocID.Text = DiagsisRowId.Cells[3].Value.ToString().Trim();
            lblSymt.Text = DiagsisRowId.Cells[4].Value.ToString().Trim();
            //Get in variables
            diagnosisID = DiagsisRowId.Cells[0].Value.ToString().Trim(); 
            Ptnid = lblPatID.Text.Trim();
            //Ptnam = lblPn.Text.Trim();
            Ptsym = lblSymt.Text.Trim();
            DocID = lblDocID.Text.Trim();
            //DocNam = lblDn.Text.Trim();
            DocDiag = DiagsisRowId.Cells[5].Value.ToString().Trim();
            txtDgn.Text = DocDiag;
            prescriptionID = DiagsisRowId.Cells[6].Value.ToString().Trim();
            lblPresc.Text = prescriptionID;
            // Get Patient details with Patient ID from Patient DB
            ARSqlconn.Open();
            SQLiteCommand command = new SQLiteCommand(ARSqlconn);
            // get the Patient details
            command.CommandText = "SELECT FirstName, LastName from Patient where Patient_ID=@P1";
            command.Parameters.AddWithValue("@P1", lblPatID.Text.Trim());

            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                lblPn.Text = reader["FirstName"].ToString().Trim() + " " + reader["LastName"].ToString().Trim();
                Ptnam = lblPn.Text.Trim();
            }
            reader.Close(); // <- too easy to forget
            reader.Dispose(); // <- too easy to forget

            // get the Doctor details
            command.CommandText = "SELECT FirstName, LastName, Specialist from Doctor where Doctor_ID=@D1";
            command.Parameters.AddWithValue("@D1", lblDocID.Text.Trim());

            reader = command.ExecuteReader();
            while (reader.Read())
            {
                lblDn.Text = reader["FirstName"].ToString().Trim() + " " + reader["LastName"].ToString().Trim();
                lblSpl.Text = reader["Specialist"].ToString().Trim();
                DocNam = lblDn.Text.Trim();
            }
            reader.Close(); // <- too easy to forget
            reader.Dispose(); // <- too easy to forget

            // Get Prescription details from the table
            command.CommandText = "SELECT MedicineName, Dosage, NoOfDose from Prescription where Prescription_ID=@Prs1";
            command.Parameters.AddWithValue("@Prs1", prescriptionID);
            reader = command.ExecuteReader();
            int i=0;

            while (reader.Read())
            {
                Psteps[i, 1] = reader["MedicineName"].ToString().Trim();
                Psteps[i, 2] = reader["Dosage"].ToString().Trim();
                Psteps[i, 3] = reader["NoOfDose"].ToString().Trim();
                i=i+1;
            }
            Tx3 = i;
            reader.Close(); // <- too easy to forget
            reader.Dispose(); // <- too easy to forget

            ARSqlconn.Close();
        }

        private void pBxExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDgn_Click(object sender, EventArgs e)
        {
            // Open Diagnosis and Presciption Table and add the details

            // Counter table - get the next Diagnosis ID
            //Convert date Picker value into String
            string Dgdt = DtPDgn.Value.ToString("yyyy/MM/dd");

            ARSqlconn.Open();
            SQLiteCommand command = new SQLiteCommand(ARSqlconn);
            string NDgdid;

            //Get counter value for Diagnosis 
            command.CommandText = "SELECT Dgnum from Counter";
            command.Prepare();
            command.ExecuteNonQuery();
            int Dgscnt = (Int32)command.ExecuteScalar();
            Dgscnt = Dgscnt + 1;
            if (Dgscnt <= 9)
            {
                NDgdid = "DGN000" + Dgscnt.ToString().Trim();
            }
            else if (Dgscnt <= 99 && Dgscnt > 9)
            {
                NDgdid = "DGN00" + Dgscnt.ToString().Trim();
            }
            else if (Dgscnt <= 999 && Dgscnt > 99)
            {
                NDgdid = "DGN0" + Dgscnt.ToString().Trim();
            }
            else
            {
                NDgdid = "DGN" + Dgscnt.ToString().Trim();
            }

            lblDgnID.Text = NDgdid;

            string NPrcid;

            //Get counter value for Prescription 
            command.CommandText = "SELECT Prnum from Counter";
            command.Prepare();
            command.ExecuteNonQuery();
            int Prscnt = (Int32)command.ExecuteScalar();
            Prscnt = Prscnt + 1;
            if (Prscnt <= 9)
            {
                NPrcid = "PRC000" + Prscnt.ToString().Trim();
            }
            else if (Prscnt <= 99 && Prscnt > 9)
            {
                NPrcid = "PRC00" + Prscnt.ToString().Trim();
            }
            else if (Prscnt <= 999 && Prscnt > 99)
            {
                NPrcid = "PRC0" + Prscnt.ToString().Trim();
            }
            else
            {
                NPrcid = "PRC" + Prscnt.ToString().Trim();
            }

            lblPresc.Text = NPrcid;

            // Get data in variable for printing
            diagnosisID = NDgdid;
            Ptnid = lblPatID.Text.Trim();
            Ptnam = lblPn.Text.Trim() ;
            Ptsym = lblSymt.Text.Trim();
            DocID = lblDocID.Text.Trim();
            DocNam = lblDn.Text.Trim();
            DocDiag = txtDgn.Text.Trim();
            prescriptionID = NPrcid;


            // Diagnos Table
            command.CommandText = (" INSERT INTO Diagnosis VALUES (@DG1, @DG2, @DG3, @DG4, @DG5, @DG6, @DG7, @DG8)");
            command.Parameters.AddWithValue("@DG1", NDgdid);
            command.Parameters.AddWithValue("@DG2", Dgdt);
            command.Parameters.AddWithValue("@DG3", lblPatID.Text.Trim());
            command.Parameters.AddWithValue("@DG4", lblDocID.Text.Trim());
            command.Parameters.AddWithValue("@DG5", lblSymt.Text.Trim());
            command.Parameters.AddWithValue("@DG6", txtDgn.Text.Trim());
            command.Parameters.AddWithValue("@DG7", NPrcid);
            command.Parameters.AddWithValue("@DG8", ApntID);

            command.ExecuteNonQuery();

            // To check How many boxes are filled and get the values in a array
            // To get Medicine details in the Array
            List<TextBox> listI = PnlPresc.Controls.Cast<Control>().Where(i => i.GetType() == typeof(TextBox)).Cast<TextBox>().ToList();
            foreach (TextBox tb1 in listI)
            {
                if (tb1.Name.Contains("txtMed"))
                {
                    if (String.IsNullOrEmpty(tb1.Text.Trim()))
                    {
                        //Text Box is not empty
                    }
                    else
                    {
                        Psteps[Tx1, 1] = tb1.Text;
                        Tx1 = Tx1 + 1;
                    }
                }

            }

            // To get the Dosage details in the array
            List<TextBox> listII = PnlPresc.Controls.Cast<Control>().Where(i => i.GetType() == typeof(TextBox)).Cast<TextBox>().ToList();
            foreach (TextBox tb2 in listII)
            {
                if (tb2.Name.Contains("txtDos"))
                {
                    if (String.IsNullOrEmpty(tb2.Text.Trim()))
                    {
                        //Text Box is not empty
                    }
                    else
                    {
                        Psteps[Tx2, 2] = tb2.Text;
                        Tx2 = Tx2 + 1;
                    }
                }
            }

            // To get the No of Dosage details in the array
            List<TextBox> listIII = PnlPresc.Controls.Cast<Control>().Where(i => i.GetType() == typeof(TextBox)).Cast<TextBox>().ToList();
            foreach (TextBox tb3 in listIII)
            {
                if (tb3.Name.Contains("txtNDos"))
                {
                    if (String.IsNullOrEmpty(tb3.Text.Trim()))
                    {
                        //Text Box is not empty
                    }
                    else
                    {
                        Psteps[Tx3, 3] = tb3.Text;
                        Tx3 = Tx3 + 1;
                    }
                }
            }

            // To Insert the gathered values into Prescription table
            for (int i = 0; i < Tx3; i++)
            {
                command.CommandText = ("INSERT INTO Prescription VALUES(@P1, @P2, @P3, @P4, @P5, @P6, @P7, @P8, @P9)");
                command.Parameters.AddWithValue("@P1", NPrcid);
                command.Parameters.AddWithValue("@P2", lblPatID.Text.Trim());
                command.Parameters.AddWithValue("@P3", lblDocID.Text.Trim());
                command.Parameters.AddWithValue("@P4", ApntID);
                command.Parameters.AddWithValue("@P5", NDgdid);
                command.Parameters.AddWithValue("@P6", Dgdt);

                command.Parameters.AddWithValue("@P7", Psteps[i, 1]);
                command.Parameters.AddWithValue("@P8", Psteps[i, 2]);
                command.Parameters.AddWithValue("@P9", Psteps[i, 3]);
                command.ExecuteNonQuery();

            }

            // Update the Appointment Table for the Particular Patient
            command.CommandText = ("UPDATE Appointment SET Admitted=@Apt1 WHERE Appointment_ID=@Apt2");
            command.Parameters.AddWithValue("@Apt1", "DIAGNOSED");
            command.Parameters.AddWithValue("@Apt2", ApntID);
            command.ExecuteNonQuery();

            // Update the Counter New Values number for Diagnosis ID & Prescription ID
            command.CommandText = ("UPDATE Counter SET Dgnum=@DG, Prnum=@PD");
            command.Parameters.AddWithValue("@DG", Dgscnt);
            command.Parameters.AddWithValue("@PD", Prscnt);
            command.ExecuteNonQuery();

            ARSqlconn.Close();
            MessageBox.Show("Diaognised the Patient " + lblPatID.Text.Trim() + " and Prescription given " + NPrcid);

            if (prnPrvwDlog1.ShowDialog() == DialogResult.OK)
            {
                PrnDoc1.PrintPage += new PrintPageEventHandler(prnDoc1_PrintPage);
                PrnDoc1.DefaultPageSettings.Landscape = false;
                PrnDoc1.Print();
            }

            // Referesh the Diganosis data Grid View- Populate the latest data
            FillDiagnosisGridbox();
            FillAppointmentGridbox();
            ClearFields();

            ARSqlconn.Close();

        }

        private void prnDoc1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs h)
        {
            h.Graphics.DrawString("A R HOSPITAL MANAGEMENT SYSTEM", new Font("Rockwell", 18, FontStyle.Bold), Brushes.DarkBlue, new Point(130, 5));
            h.Graphics.DrawString("DIAGNOSIS DETAILS" + "\n", new Font("Ariel", 16, FontStyle.Bold), Brushes.DarkBlue, new Point(230, 60));
            h.Graphics.DrawString("Patient ID     - " + Ptnid, new Font("Ariel", 15, FontStyle.Bold), Brushes.DarkBlue, new Point(5, 90));
            h.Graphics.DrawString("Patient Name   - " + Ptnam, new Font("Ariel", 15, FontStyle.Bold), Brushes.DarkBlue, new Point(5, 120));
            h.Graphics.DrawString("Illness        - " + Ptsym, new Font("Ariel", 15, FontStyle.Bold), Brushes.DarkBlue, new Point(5, 150));

            h.Graphics.DrawString("Doctor ID      - " + DocID, new Font("Ariel", 15, FontStyle.Bold), Brushes.DarkBlue, new Point(5, 180));
            h.Graphics.DrawString("Doctor Name    - " + DocNam, new Font("Ariel", 15, FontStyle.Bold), Brushes.DarkBlue, new Point(5, 210));

            h.Graphics.DrawString("Diagnosis Details :  " + DocDiag, new Font("Ariel",14, FontStyle.Bold), Brushes.DarkBlue, new Point(5, 240));
            h.Graphics.DrawString("PRESCRIPTION DETAILS - " + prescriptionID, new Font("Ariel", 16, FontStyle.Bold), Brushes.DarkBlue, new Point(230, 280));

            h.Graphics.DrawString("                 Medicine                 |           Dosage           |       No.Dose       ", new Font("Ariel", 15, FontStyle.Bold), Brushes.DarkBlue, new Point(5, 310));

            int y = 340;
            for (int i = 0; i < Tx3; i++)
            {
                h.Graphics.DrawString(Psteps[i, 1], new Font("Ariel", 14, FontStyle.Bold), Brushes.DarkBlue, new Point(5, y));
                h.Graphics.DrawString(Psteps[i, 2], new Font("Ariel", 14, FontStyle.Bold), Brushes.DarkBlue, new Point(360, y));
                h.Graphics.DrawString(Psteps[i, 3], new Font("Ariel", 14, FontStyle.Bold), Brushes.DarkBlue, new Point(580, y));
                y = y + 30;

            }

            h.Graphics.DrawString("\n\n\n" + "~~~~~~~~~~~~~~~~~~~~~~~ Thank you ~~~~~~~~~~~~~~~~~~~~~~~",new Font("Ariel", 15, FontStyle.Bold), Brushes.DarkBlue, new Point(15, y+10));



            //h.Graphics.DrawString("A R HOSPITAL MANAGEMENT SYSTEM", new Font("Rockwell", 18, FontStyle.Bold), Brushes.DarkBlue, new Point(10, 5));
        }
        private void BtnPrint_Click(object sender, EventArgs e)
        {
            if (prnPrvwDlog1.ShowDialog() == DialogResult.OK)
            {
                PrnDoc1.PrintPage += new PrintPageEventHandler(prnDoc1_PrintPage);
                PrnDoc1.DefaultPageSettings.Landscape = false;
                PrnDoc1.Print();
            }
        }

        //Define a variable to get the Patient Data grid view Row count
        int RwId;
        private void dGVApp_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // When we double click the selected row in Appointment Data Grid box fetch the values in the above text box for show
            RwId = e.RowIndex;
            DataGridViewRow PatRowId = dGVApp.Rows[RwId];
            ApntID = PatRowId.Cells[0].Value.ToString().Trim();
            lblPatID.Text = PatRowId.Cells[1].Value.ToString().Trim();
            lblDocID.Text = PatRowId.Cells[2].Value.ToString().Trim();
            lblSymt.Text = PatRowId.Cells[8].Value.ToString().Trim();
            // Get Patient details with Patient ID from Patient DB
            ARSqlconn.Open();
            SQLiteCommand command = new SQLiteCommand(ARSqlconn);
            // get the Patient details
            command.CommandText = "SELECT FirstName, LastName from Patient where Patient_ID=@P1";
            command.Parameters.AddWithValue("@P1", lblPatID.Text.Trim());

            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                lblPn.Text = reader["FirstName"].ToString().Trim() + " " + reader["LastName"].ToString().Trim();
            }
            reader.Close(); // <- too easy to forget
            reader.Dispose(); // <- too easy to forget

            // get the Doctor details
            command.CommandText = "SELECT FirstName, LastName, Specialist from Doctor where Doctor_ID=@D1";
            command.Parameters.AddWithValue("@D1", lblDocID.Text.Trim());

            reader = command.ExecuteReader();
            while (reader.Read())
            {
                lblDn.Text = reader["FirstName"].ToString().Trim() + " " + reader["LastName"].ToString().Trim();
                lblSpl.Text = reader["Specialist"].ToString().Trim();
            }
            reader.Close(); // <- too easy to forget
            reader.Dispose(); // <- too easy to forget
            ARSqlconn.Close();
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        public Diagnosis()
        {
            InitializeComponent();
            ARSqlconn = new SQLiteConnection(dbfile);
            PrnDoc1.PrintPage += new PrintPageEventHandler(prnDoc1_PrintPage);

        }

        private void Diagnosis_Load(object sender, EventArgs e)
        {
            FillDiagnosisGridbox();
            FillAppointmentGridbox();
            ClearFields();
            AdmID = Reception.RcpnstID;

            int i = 0;
            int Px1 = 5, Px2 = 185, Px3 = 355;
            int Py = 5;

            // Add Dynamic Input boxes
            TextBox[] M = new TextBox[11];
            TextBox[] C = new TextBox[11];
            TextBox[] NC = new TextBox[11];

            for (i = 0; i < 10; i++)
            {
                // Add new text box for Medicine input
                M[i] = new TextBox();
                M[i].AutoSize = false;
                M[i].Location = new Point(Px1, Py);
                M[i].Size = new System.Drawing.Size(125, 30);
                M[i].Name = "txtMed" + i.ToString();
                PnlPresc.Controls.Add(M[i]);

                // Add new text box for Dosage input
                C[i] = new TextBox();
                C[i].AutoSize = false;
                C[i].Location = new Point(Px2, Py);
                C[i].Size = new System.Drawing.Size(125, 30);
                C[i].Name = "txtDos" + i.ToString();
                PnlPresc.Controls.Add(C[i]);

                // Add new text box for Dosage input
                NC[i] = new TextBox();
                NC[i].AutoSize = false;
                NC[i].Location = new Point(Px3, Py);
                NC[i].Size = new System.Drawing.Size(125, 30);
                NC[i].Name = "txtNDos" + i.ToString();
                PnlPresc.Controls.Add(NC[i]);

                Py = Py + 60;

            }
        }

        private void FillDiagnosisGridbox() 
        {
            //Create a SQL Query Variable
            ARSqlconn.Open();
            SQLiteCommand command = new SQLiteCommand(ARSqlconn);

            ARDapA = new SQLiteDataAdapter("select * from Diagnosis", ARSqlconn);
            ARSqlconn.Close();
            SQLiteCommandBuilder ARCdB1 = new SQLiteCommandBuilder(ARDapA);
            ARTbl = new DataTable();
            ARDapA.Fill(ARTbl);
            dGVDgn.DataSource = ARTbl;

        }

        private void FillAppointmentGridbox()
        {
            //Create a SQL Query Variable
            ARSqlconn.Open();
            SQLiteCommand command = new SQLiteCommand(ARSqlconn);

            ARDapA = new SQLiteDataAdapter("select * from Appointment where Type = @AP1 and Admitted = @AP2", ARSqlconn);
            ARDapA.SelectCommand.Parameters.AddWithValue("@AP1", "OutPatient");
            ARDapA.SelectCommand.Parameters.AddWithValue("@AP2", "NA");
            ARSqlconn.Close();
            SQLiteCommandBuilder ARCdB1 = new SQLiteCommandBuilder(ARDapA);
            ARTbl = new DataTable();
            ARDapA.Fill(ARTbl);
            dGVApp.DataSource = ARTbl;
        }

        private void ClearFields()
        {
            lblDgnID.Text = "";
            lblPatID.Text = "";
            lblPn.Text = "";
            lblDocID.Text = "";
            lblDn.Text = "";
            lblSpl.Text = "";
            txtDgn.Text = "";
            //Clear The Prescription data
            List<TextBox> CLlist = PnlPresc.Controls.Cast<Control>().Where(i => i.GetType() == typeof(TextBox)).Cast<TextBox>().ToList();
            foreach (TextBox tb1 in CLlist)
            {
                    if (!String.IsNullOrEmpty(tb1.Text.Trim()))
                    {
                      tb1.Text = "";
                    }
            }

        }
    }
}
