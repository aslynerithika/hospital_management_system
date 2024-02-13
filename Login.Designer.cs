namespace HospitalManagementSystem
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.txtPassW = new System.Windows.Forms.TextBox();
            this.btnClr = new System.Windows.Forms.Button();
            this.cBxLogIn = new System.Windows.Forms.ComboBox();
            this.ExitLogin = new System.Windows.Forms.PictureBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 64);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(130, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "A R HMS";
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogIn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogIn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogIn.Location = new System.Drawing.Point(150, 294);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(108, 43);
            this.btnLogIn.TabIndex = 1;
            this.btnLogIn.Text = "Login";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // txtPassW
            // 
            this.txtPassW.Location = new System.Drawing.Point(117, 232);
            this.txtPassW.Name = "txtPassW";
            this.txtPassW.PasswordChar = '*';
            this.txtPassW.Size = new System.Drawing.Size(197, 27);
            this.txtPassW.TabIndex = 3;
            // 
            // btnClr
            // 
            this.btnClr.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnClr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClr.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClr.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClr.Location = new System.Drawing.Point(150, 366);
            this.btnClr.Name = "btnClr";
            this.btnClr.Size = new System.Drawing.Size(108, 43);
            this.btnClr.TabIndex = 4;
            this.btnClr.Text = "Clear";
            this.btnClr.UseVisualStyleBackColor = false;
            this.btnClr.Click += new System.EventHandler(this.btnClr_Click);
            // 
            // cBxLogIn
            // 
            this.cBxLogIn.FormattingEnabled = true;
            this.cBxLogIn.Location = new System.Drawing.Point(117, 166);
            this.cBxLogIn.Name = "cBxLogIn";
            this.cBxLogIn.Size = new System.Drawing.Size(197, 28);
            this.cBxLogIn.TabIndex = 5;
            this.cBxLogIn.SelectedIndexChanged += new System.EventHandler(this.cBxLogIn_SelectedIndexChanged);
            // 
            // ExitLogin
            // 
            this.ExitLogin.BackColor = System.Drawing.Color.Transparent;
            this.ExitLogin.BackgroundImage = global::HospitalManagementSystem.Properties.Resources.exit11;
            this.ExitLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitLogin.ErrorImage = global::HospitalManagementSystem.Properties.Resources.exit1;
            this.ExitLogin.Location = new System.Drawing.Point(175, 458);
            this.ExitLogin.Name = "ExitLogin";
            this.ExitLogin.Size = new System.Drawing.Size(40, 36);
            this.ExitLogin.TabIndex = 11;
            this.ExitLogin.TabStop = false;
            this.ExitLogin.Click += new System.EventHandler(this.ExitLogin_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUsername.Location = new System.Drawing.Point(12, 169);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(88, 20);
            this.lblUsername.TabIndex = 12;
            this.lblUsername.Text = "Username :";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.Location = new System.Drawing.Point(12, 235);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(84, 20);
            this.lblPassword.TabIndex = 13;
            this.lblPassword.Text = "Password :";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(416, 506);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.ExitLogin);
            this.Controls.Add(this.cBxLogIn);
            this.Controls.Add(this.btnClr);
            this.Controls.Add(this.txtPassW);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btnLogIn;
        private TextBox txtPassW;
        private Button btnClr;
        private ComboBox cBxLogIn;
        private PictureBox ExitLogin;
        private Label lblUsername;
        private Label lblPassword;
    }
}