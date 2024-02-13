using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class Rooms : Form
    {
        public string dbfile = "URI=file:HospitalManagement.db";
        public SQLiteConnection ARSqlconn;
        public SQLiteCommand ARCmd;
        public SQLiteDataReader ARDataReader;
        public SQLiteDataAdapter ARDap;
        public DataTable ARTbl;
        public static string RomID, RomTyp, RomWrd;

        public Rooms()
        {
            InitializeComponent();
            ARSqlconn = new SQLiteConnection(dbfile);

        }

        private void txtNoBds_Leave(object sender, EventArgs e)
        {
            // Number of beds box should not be Blank
            if (txtNoBds.TextLength == 0)
            {
                MessageBox.Show("Number of beds box is Blank. Please provide number of bedss.");
                txtNoBds.Focus();
            }

            // To check if the textbox value is numeric or not
            try
            {
                int bed = Convert.ToInt32(txtNoBds.Text);
                // Number of bed value should be between 1 to 4
                if (bed == 0 || bed > 4)
                {
                    MessageBox.Show("No of bed should be between 1 to 4 ");
                    txtNoBds.Focus();

                }
            }
            catch (Exception h)
            {
                MessageBox.Show("Please provide number only");
                txtNoBds.Focus();

            }            
        }

        private void cBxTyp_SelectedIndexChanged(object sender, EventArgs e)
        {
            // get the new room type from Combo box
            RomTyp = cBxTyp.Text.Trim();
        }

        private void cBxWard_SelectedIndexChanged(object sender, EventArgs e)
        {
            // get the new ward from Combo box
            RomWrd = cBxWard.Text.Trim();
        }

        private void Rooms_Load(object sender, EventArgs e)
        {
            FillRoomsGridbox();
            ClearFields();
            cBxTyp.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // To add new Room details
            ARSqlconn.Open();
            SQLiteCommand command = new SQLiteCommand(ARSqlconn);
            int Romid;
            string RRomid = "";
            int NOB = Convert.ToInt32(txtNoBds.Text);

            // get the next Count for new Room to be added
            command.CommandText = "SELECT Rnum from Counter";
            command.Prepare();
            command.ExecuteNonQuery();
            Romid = (Int32)command.ExecuteScalar();
            Romid = Romid + 1;
            if (Romid <= 9)
            {
                RRomid = "ROM00" + Romid.ToString().Trim();
            }
            else
            {
                RRomid = "ROM0" + Romid.ToString().Trim();
            }
            ARSqlconn.Close();

            // Add new room in Room table
            ARSqlconn.Open();
            command.CommandText = ("INSERT INTO Room VALUES(@R1, @R2, @R3, @R4, @R5)");
            command.Parameters.AddWithValue("@R1", RRomid);
            command.Parameters.AddWithValue("@R2", RomTyp);
            command.Parameters.AddWithValue("@R3", NOB);
            command.Parameters.AddWithValue("@R4", RomWrd);
            command.Parameters.AddWithValue("@R5", "Active");

            command.ExecuteNonQuery();
            // Update the Counter Table
            command.CommandText = ("UPDATE Counter SET Rnum=@RR");
            command.Parameters.AddWithValue("@RR", Romid);
            command.ExecuteNonQuery();

            ARSqlconn.Close();
            MessageBox.Show("The New Room " + RRomid + " has been added");

            // Referesh the Nurse data Grid View- Populate the latest data
            FillRoomsGridbox();
            ClearFields();

        }

        private void btnDact_Click(object sender, EventArgs e)
        {
            // To deactivate an active room
            string Sta = lblStat.Text.Trim();

            if (Sta == "InActive")
            {
                MessageBox.Show("The room " + lblRmNo.Text + " is already inactive");
            }
            else if (Sta == "Active")
            {
                //Currently the room is active so we can deactivate
                string RomId = lblRmNo.Text.Trim();
                // Open Room table
                ARSqlconn.Open();
                SQLiteCommand command = new SQLiteCommand(ARSqlconn);
                // Update the existing room in room table

                command.CommandText = ("UPDATE Room SET Status=@R1 WHERE Room_No=@R2");

                command.Parameters.AddWithValue("@R1", "InActive");
                command.Parameters.AddWithValue("@R2", RomId);
                command.ExecuteNonQuery();

                ARSqlconn.Close();
                MessageBox.Show("The room " + RomId + " has been successfully Deactivated");

                // Refresh the Nurse data Grid View- Populate the latest data
                FillRoomsGridbox();
                ClearFields();


            }
        }
        //Define a variable to get the Customer Data grid view Row count
        int RwId;

        private void DGVRooms_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // When we double click the selected row in room Data Grid box fetch the values in the above text box for show or edit
            RwId = e.RowIndex;
            DataGridViewRow RomRowId = DGVRooms.Rows[RwId];
            //File the textbox / label box and combo box values with the row selected
            lblRmNo.Text = RomRowId.Cells[0].Value.ToString().Trim();
            string RTyp = RomRowId.Cells[1].Value.ToString().Trim();
           // MessageBox.Show("The Room type in database is "+ RTyp);
            // Type Combo Box Selection
            if (RTyp == "Casuality")
                cBxTyp.SelectedIndex = cBxTyp.FindStringExact("Casuality");
            else if (RTyp == "Common")
                cBxTyp.SelectedIndex = cBxTyp.FindStringExact("Common");
            else if (RTyp == "Consulting")
                cBxTyp.SelectedIndex = cBxTyp.FindStringExact("Consulting");
            else if (RTyp == "Maternity")
                cBxTyp.SelectedIndex = cBxTyp.FindStringExact("Maternity");
            else if (RTyp == "Private")
                cBxTyp.SelectedIndex = cBxTyp.FindStringExact("Private");
            else if (RTyp == "Semi Private")
                cBxTyp.SelectedIndex = cBxTyp.FindStringExact("Semi Private");
            else if (RTyp == "Sick room")
                cBxTyp.SelectedIndex = cBxTyp.FindStringExact("Sick room");

            txtNoBds.Text = RomRowId.Cells[2].Value.ToString().Trim();

            string Wrd = RomRowId.Cells[3].Value.ToString().Trim();
           // MessageBox.Show("The Ward in database is " + Wrd);
            // Ward Combo Box Selection
            if (Wrd == "A")
                cBxWard.SelectedIndex = cBxWard.FindStringExact("A");
            else if (Wrd == "B")
                cBxWard.SelectedIndex = cBxWard.FindStringExact("B");
            else if (Wrd == "C")
                cBxWard.SelectedIndex = cBxWard.FindStringExact("C");
            else if (Wrd == "D")
                cBxWard.SelectedIndex = cBxWard.FindStringExact("D");
            else if (Wrd == "E")
                cBxWard.SelectedIndex = cBxWard.FindStringExact("E");
            else if (Wrd == "F")
                cBxWard.SelectedIndex = cBxWard.FindStringExact("F");

            lblStat.Text = RomRowId.Cells[4].Value.ToString().Trim();

        }

        private void btnAct_Click(object sender, EventArgs e)
        {
            // To Activate a deactivated room
            string Sta = lblStat.Text.Trim();
            if (Sta == "Active")
            {
                MessageBox.Show("The room " + lblRmNo.Text + " is already active");
            }
            else if (Sta == "InActive")
            {
                //Currently the room is inactive so we can activate
                string RomId = lblRmNo.Text.Trim();
                // Open room table
                ARSqlconn.Open();
                SQLiteCommand command = new SQLiteCommand(ARSqlconn);
                // Update the existing room in room table

                command.CommandText = ("UPDATE Room SET Status=@R1 WHERE Room_No=@R2");

                command.Parameters.AddWithValue("@R1", "Active");
                command.Parameters.AddWithValue("@R2", RomId);
                command.ExecuteNonQuery();

                ARSqlconn.Close();
                MessageBox.Show("The room " + RomId + " has been successfully Activated");

                // Refresh the Room data Grid View- Populate the latest data
                FillRoomsGridbox();
                ClearFields();

            }


        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            // To update the edited values in the Room table against the selected Room No
            ARSqlconn.Open();
            SQLiteCommand command = new SQLiteCommand(ARSqlconn);
            string RRomid = lblRmNo.Text.Trim();
            int NOB = Convert.ToInt32(txtNoBds.Text);
            string act = lblStat.Text.Trim();

            // Modify the existing room detail and update the room table
            command.CommandText = ("UPDATE Room SET Room_Type=@R1, NoOfBed=@R2, WardType=@R3, Status=@R4 WHERE Room_No=@R5");
            command.Parameters.AddWithValue("@R1", RomTyp);
            command.Parameters.AddWithValue("@R2", NOB);
            command.Parameters.AddWithValue("@R3", RomWrd);
            command.Parameters.AddWithValue("@R4", act);
            command.Parameters.AddWithValue("@R5", RRomid);

            command.ExecuteNonQuery();

            ARSqlconn.Close();
            MessageBox.Show("The Room " + RRomid + " has been updated");

            // Referesh the Nurse data Grid View- Populate the latest data
            FillRoomsGridbox();
            ClearFields();

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (prnPrvwDlog5.ShowDialog() == DialogResult.OK)
            {
                PrnDoc5.PrintPage += new PrintPageEventHandler(this.PrnDoc5_PrintPage);
                prnPrvwDlog5.Document = PrnDoc5;
                PrnDoc5.DefaultPageSettings.Landscape = true;
                prnPrvwDlog5.ShowDialog();

            }
        }

        public static int Rnum=0, PatCnt=0;

        private void ExitRoomPage_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PrnDoc5_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
            e.Graphics.DrawString(label4.Text, new Font("Rockwell", 18, FontStyle.Bold), Brushes.DarkBlue, new Point(130, 5));
            e.Graphics.DrawString("ROOM DETAILS", new Font("Ariel", 16, FontStyle.Bold), Brushes.DarkBlue, new Point(230, 60));

            // Fetch all patient details from the database table
            ConnectionState state = ARSqlconn.State;
            if (state == ConnectionState.Closed)
            {
                ARSqlconn.Open();
            }
            
            SQLiteCommand command = new SQLiteCommand(ARSqlconn);
            command.CommandText = "Select * from Room";
            var red = command.ExecuteReader();
            int y = 100;
                while (red.Read())
                {
                    e.Graphics.DrawString("ROOM NO    - " + red["Room_No"].ToString().Trim(), new Font("Ariel", 15, FontStyle.Bold), Brushes.DarkBlue, new Point(5, y));
                    y = y + 30;
                    e.Graphics.DrawString("ROOM TYPE  - " + red["Room_Type"].ToString().Trim(), new Font("Ariel", 15, FontStyle.Bold), Brushes.DarkBlue, new Point(5, y));
                    y = y + 30;
                    e.Graphics.DrawString("NO OF BED  - " + red["NoOfBed"].ToString().Trim(), new Font("Ariel", 15, FontStyle.Bold), Brushes.DarkBlue, new Point(5, y));
                    y = y + 30;
                    e.Graphics.DrawString("WARD TYPE  - " + red["WardType"].ToString().Trim(), new Font("Ariel", 15, FontStyle.Bold), Brushes.DarkBlue, new Point(5, y));
                    y = y + 30;
                    e.Graphics.DrawString("STATUS     - " + red["Status"].ToString().Trim(), new Font("Ariel", 15, FontStyle.Bold), Brushes.DarkBlue, new Point(5, y));
                    y = y + 30;
                    e.Graphics.DrawString("--------------------------------------------------------", new Font("Ariel", 15, FontStyle.Bold), Brushes.DarkBlue, new Point(5, y));
                    y = y + 30;
                }
            if (state == ConnectionState.Open)
            {
                ARSqlconn.Close();
            }
        }

        public void FillRoomsGridbox()
        {
            //Create a SQL Query Variable
            ARSqlconn.Open();
            SQLiteCommand command = new SQLiteCommand(ARSqlconn);

            ARDap = new SQLiteDataAdapter("select * from Room", ARSqlconn);
            ARSqlconn.Close();
            SQLiteCommandBuilder ARCdB1 = new SQLiteCommandBuilder(ARDap);
            ARTbl = new DataTable();
            ARDap.Fill(ARTbl);
            DGVRooms.DataSource = ARTbl;

        }

        public void ClearFields()
        {
            lblRmNo.Text = "";
            lblStat.Text = "";
            txtNoBds.Text = "";
            cBxTyp.Text = null;
            cBxWard.Text = null;
            
        }
    }
}
