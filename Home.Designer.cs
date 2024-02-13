namespace HospitalManagementSystem
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.picBxAdm = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picBxDoc = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.picBxNrs = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.picBxRoom = new System.Windows.Forms.PictureBox();
            this.ExitPage = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBxAdm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxDoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxNrs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPage)).BeginInit();
            this.SuspendLayout();
            // 
            // picBxAdm
            // 
            this.picBxAdm.BackgroundImage = global::HospitalManagementSystem.Properties.Resources.manager1;
            this.picBxAdm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBxAdm.Location = new System.Drawing.Point(480, 232);
            this.picBxAdm.Name = "picBxAdm";
            this.picBxAdm.Size = new System.Drawing.Size(125, 109);
            this.picBxAdm.TabIndex = 0;
            this.picBxAdm.TabStop = false;
            this.picBxAdm.Click += new System.EventHandler(this.picBxAdm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(467, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "ADMINISTRATION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(823, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "DOCTOR";
            // 
            // picBxDoc
            // 
            this.picBxDoc.BackgroundImage = global::HospitalManagementSystem.Properties.Resources.Doctor3;
            this.picBxDoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBxDoc.Location = new System.Drawing.Point(801, 232);
            this.picBxDoc.Name = "picBxDoc";
            this.picBxDoc.Size = new System.Drawing.Size(125, 109);
            this.picBxDoc.TabIndex = 2;
            this.picBxDoc.TabStop = false;
            this.picBxDoc.Click += new System.EventHandler(this.picBxDoc_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1128, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "NURSE";
            // 
            // picBxNrs
            // 
            this.picBxNrs.BackgroundImage = global::HospitalManagementSystem.Properties.Resources.Nurse1;
            this.picBxNrs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBxNrs.Location = new System.Drawing.Point(1106, 232);
            this.picBxNrs.Name = "picBxNrs";
            this.picBxNrs.Size = new System.Drawing.Size(125, 109);
            this.picBxNrs.TabIndex = 4;
            this.picBxNrs.TabStop = false;
            this.picBxNrs.Click += new System.EventHandler(this.picBxNrs_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(832, 443);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "ROOMS";
            // 
            // picBxRoom
            // 
            this.picBxRoom.BackgroundImage = global::HospitalManagementSystem.Properties.Resources.Room1;
            this.picBxRoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBxRoom.Location = new System.Drawing.Point(810, 469);
            this.picBxRoom.Name = "picBxRoom";
            this.picBxRoom.Size = new System.Drawing.Size(125, 109);
            this.picBxRoom.TabIndex = 8;
            this.picBxRoom.TabStop = false;
            this.picBxRoom.Click += new System.EventHandler(this.picBxRoom_Click);
            // 
            // ExitPage
            // 
            this.ExitPage.BackColor = System.Drawing.Color.Transparent;
            this.ExitPage.BackgroundImage = global::HospitalManagementSystem.Properties.Resources.exit11;
            this.ExitPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitPage.ErrorImage = global::HospitalManagementSystem.Properties.Resources.exit1;
            this.ExitPage.Location = new System.Drawing.Point(1465, 3);
            this.ExitPage.Name = "ExitPage";
            this.ExitPage.Size = new System.Drawing.Size(40, 36);
            this.ExitPage.TabIndex = 10;
            this.ExitPage.TabStop = false;
            this.ExitPage.Click += new System.EventHandler(this.ExitPage_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(558, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(610, 38);
            this.label4.TabIndex = 11;
            this.label4.Text = "A R HOSPITAL MANAGEMENT SYSTEM";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1508, 787);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ExitPage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.picBxRoom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.picBxNrs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picBxDoc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBxAdm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.picBxAdm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxDoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxNrs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox picBxAdm;
        private Label label1;
        private Label label2;
        private PictureBox picBxDoc;
        private Label label3;
        private PictureBox picBxNrs;
        private Label label5;
        private PictureBox picBxRoom;
        private PictureBox ExitPage;
        private Label label4;
    }
}