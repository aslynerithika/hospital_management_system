namespace HospitalManagementSystem
{
    partial class Reception
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reception));
            this.pBxNewPat = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pBxApp = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ExitRecepPage = new System.Windows.Forms.PictureBox();
            this.pBxAdm = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBxNewPat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBxApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitRecepPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBxAdm)).BeginInit();
            this.SuspendLayout();
            // 
            // pBxNewPat
            // 
            this.pBxNewPat.Image = ((System.Drawing.Image)(resources.GetObject("pBxNewPat.Image")));
            this.pBxNewPat.Location = new System.Drawing.Point(161, 225);
            this.pBxNewPat.Name = "pBxNewPat";
            this.pBxNewPat.Size = new System.Drawing.Size(165, 154);
            this.pBxNewPat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBxNewPat.TabIndex = 0;
            this.pBxNewPat.TabStop = false;
            this.pBxNewPat.Click += new System.EventHandler(this.pBxNewPat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(185, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "NEW PATIENT";
            // 
            // pBxApp
            // 
            this.pBxApp.Image = ((System.Drawing.Image)(resources.GetObject("pBxApp.Image")));
            this.pBxApp.Location = new System.Drawing.Point(1121, 225);
            this.pBxApp.Name = "pBxApp";
            this.pBxApp.Size = new System.Drawing.Size(165, 154);
            this.pBxApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBxApp.TabIndex = 3;
            this.pBxApp.TabStop = false;
            this.pBxApp.Click += new System.EventHandler(this.pBxApp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1137, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "APPOINTMENT";
            // 
            // ExitRecepPage
            // 
            this.ExitRecepPage.BackColor = System.Drawing.Color.Transparent;
            this.ExitRecepPage.BackgroundImage = global::HospitalManagementSystem.Properties.Resources.exit11;
            this.ExitRecepPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitRecepPage.ErrorImage = global::HospitalManagementSystem.Properties.Resources.exit1;
            this.ExitRecepPage.Location = new System.Drawing.Point(1314, 12);
            this.ExitRecepPage.Name = "ExitRecepPage";
            this.ExitRecepPage.Size = new System.Drawing.Size(40, 36);
            this.ExitRecepPage.TabIndex = 12;
            this.ExitRecepPage.TabStop = false;
            this.ExitRecepPage.Click += new System.EventHandler(this.ExitRecepPage_Click);
            // 
            // pBxAdm
            // 
            this.pBxAdm.Image = ((System.Drawing.Image)(resources.GetObject("pBxAdm.Image")));
            this.pBxAdm.Location = new System.Drawing.Point(665, 225);
            this.pBxAdm.Name = "pBxAdm";
            this.pBxAdm.Size = new System.Drawing.Size(165, 154);
            this.pBxAdm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBxAdm.TabIndex = 13;
            this.pBxAdm.TabStop = false;
            this.pBxAdm.Click += new System.EventHandler(this.pBxAdm_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(636, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "ADMISSION/DISCHARGE";
            // 
            // Reception
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1376, 739);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pBxAdm);
            this.Controls.Add(this.ExitRecepPage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pBxApp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pBxNewPat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reception";
            this.Text = "Reception";
            this.Load += new System.EventHandler(this.Reception_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBxNewPat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBxApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitRecepPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBxAdm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pBxNewPat;
        private Label label1;
        private PictureBox pBxApp;
        private Label label2;
        private PictureBox ExitRecepPage;
        private PictureBox pBxAdm;
        private Label label3;
    }
}