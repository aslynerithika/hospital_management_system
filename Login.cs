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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace HospitalManagementSystem
{
    public partial class frmLogin : Form
    {
        public string dbfile = "URI=file:HospitalManagement.db";
        public SQLiteConnection ARSqlconn;
        public SQLiteCommand ARCmd;
        public SQLiteDataReader ARDataReader;
        public SQLiteDataAdapter ARDap;
        public DataTable ARTbl;
        public static string AdID, RcpnstID;

        public frmLogin()
        {
            InitializeComponent();
            ARSqlconn = new SQLiteConnection(dbfile);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Open the Login Form
            string Aid = "";
            string Anm = "";
            string stat = "Active";
            //Create a SQL Query Variable
            ARSqlconn.Open();
            SQLiteCommand command = new SQLiteCommand(ARSqlconn);
            // Check Which Menu called this Login form
            if (MainParent.AdmLog == true)
            {
                // Only take Admin IDs
                MainParent.RcpLog = false;
                MainParent.MgrLog = false;
                MainParent.DocLogAd = false;
                command.CommandText = ("select * from Administration where Status = @A1 and Role = @A2");
            command.Parameters.AddWithValue("@A1", stat);
            command.Parameters.AddWithValue("@A2", "Admin");
            }
            if (MainParent.RcpLog == true || MainParent.RcpLogAd == true)
            {
                MainParent.AdmLog = false;
                MainParent.MgrLog = false;
                MainParent.DocLogAd = false;
                // Only take Admin IDs
                command.CommandText = ("select * from Administration where Status = @A1 and Role = @A2");
                command.Parameters.AddWithValue("@A1", stat);
                command.Parameters.AddWithValue("@A2", "Receptionist");
            }
            if (MainParent.MgrLog == true)
            {
                MainParent.AdmLog = false;
                MainParent.RcpLog = false;
                MainParent.DocLogAd = false;
                // Only take Admin IDs
                command.CommandText = ("select * from Administration where Status = @A1 and Role = @A2");
                command.Parameters.AddWithValue("@A1", stat);
                command.Parameters.AddWithValue("@A2", "Manager");
            }
            if (MainParent.DocLogAd == true)
            {
                MainParent.AdmLog = false;
                MainParent.RcpLog = false;
                MainParent.MgrLog = false;
                // Only take Admin IDs
                command.CommandText = ("select * from Doctor where Status = @D1");
                command.Parameters.AddWithValue("@D1", stat);
            }

            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (MainParent.DocLogAd == true)
                { 
                    Aid = reader["Doctor_ID"].ToString().Trim();
                    Anm = reader["FirstName"].ToString().Trim() + " " + reader["LastName"].ToString().Trim();
                    cBxLogIn.Items.Add(Aid.Trim() + " -- " + Anm.Trim());
                }

                if (MainParent.AdmLog == true || MainParent.RcpLog == true || MainParent.RcpLogAd == true || MainParent.MgrLog == true)
                {
                    Aid = reader["Admin_ID"].ToString().Trim();
                    Anm = reader["Role"].ToString().Trim();
                    cBxLogIn.Items.Add(Aid.Trim() + " -- " + Anm.Trim());
                }
            }
            reader.Close(); // <- too easy to forget
            reader.Dispose(); // <- too easy to forget
            ARSqlconn.Close();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            ARSqlconn.Open();
            SQLiteCommand command = new SQLiteCommand(ARSqlconn);
            string pswd = txtPassW.Text.Trim();
            string Apass = "", Rol = "";

            if (MainParent.AdmLog == true || MainParent.RcpLog == true || MainParent.RcpLogAd == true || MainParent.MgrLog == true)
            { 
            // Open Administration table and verify login ID & Password
            command.CommandText = "select Role, Pass from Administration Where Admin_ID = @LiD";
            command.Parameters.AddWithValue("@LiD", AdID);
                SQLiteDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    Apass = reader["Pass"].ToString().Trim();
                    Rol = reader["Role"].ToString().Trim();
                }
                reader.Close(); // <- too easy to forget
                reader.Dispose(); // <- too easy to forget
                ARSqlconn.Close();
            }

            if (MainParent.DocLogAd == true)
            {
                // Open Doctor table and verify login ID & Password
                command.CommandText = "select Pass from Doctor Where Doctor_ID = @DiD";
                command.Parameters.AddWithValue("@DiD", AdID);
                SQLiteDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    Apass = reader["Pass"].ToString().Trim();
                }
                reader.Close(); // <- too easy to forget
                reader.Dispose(); // <- too easy to forget
                ARSqlconn.Close();
            }
            
    
            // Check the credentials if matched allow Application to work
            if (Apass.Length == 0)
            {
                MessageBox.Show("Please enter Password");
                txtPassW.Focus();
            }
            else
            {
                if (Apass.Equals(pswd))
                {
                    // Credentials Matched for Admin works
                    if (MainParent.AdmLog == true)
                    {
                        Home H = new Home();
                        H.MdiParent = MainParent.ActiveForm;
                        H.Show();
                        this.Close();
                    }
                    // Credentials Matched for Appointment works 
                    if (MainParent.RcpLog == true)
                    {
                        Reception R = new Reception();
                        R.MdiParent = MainParent.ActiveForm;
                        R.Show();
                        this.Close();
                    }
                    // Credentials Matched for Admission works - In Patient
                    if (MainParent.RcpLogAd == true)
                    {
                        Reception R = new Reception();
                        R.MdiParent = MainParent.ActiveForm;
           
                        R.Show();
                        this.Close();
                    }
                    // Credentials Matched for Diagnosis works - Out Patient
                    if (MainParent.DocLogAd == true)
                    {
                        Diagnosis DS = new Diagnosis();
                        DS.MdiParent = MainParent.ActiveForm;
                        DS.Show();
                        this.Close();
                    }
                    // Credentials Matched for Appointment works
                    if (MainParent.MgrLog == true)
                    {
                        //Home H = new Home();
                        //H.MdiParent = MainParent.ActiveForm;
                        //H.Show();
                        //this.Close();
                        MessageBox.Show(" Manager can able to give daily Duty schedules to Doctor and Nurse");
                    }
                }
                else
                {
                    MessageBox.Show("Password Wrong... Enter Correct Password for " + AdID);
                    txtPassW.Focus();
                }
            }
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            txtPassW.Text = "";
        }

        private void cBxLogIn_SelectedIndexChanged(object sender, EventArgs e)
        {
            AdID = cBxLogIn.Text.Trim().Substring(0,6);
            RcpnstID = cBxLogIn.Text.Trim().Substring(0, 6);
        }

        private void ExitLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}