namespace HospitalManagementSystem
{
    partial class Patient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patient));
            this.txtLnm = new System.Windows.Forms.TextBox();
            this.txtFnm = new System.Windows.Forms.TextBox();
            this.cBxTyp = new System.Windows.Forms.ComboBox();
            this.txtNin = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.ExitPatPage = new System.Windows.Forms.PictureBox();
            this.lblPatID = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dGVPat = new System.Windows.Forms.DataGridView();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gBxGend = new System.Windows.Forms.GroupBox();
            this.rdBO = new System.Windows.Forms.RadioButton();
            this.rdBF = new System.Windows.Forms.RadioButton();
            this.rdBM = new System.Windows.Forms.RadioButton();
            this.txtDoB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPatPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVPat)).BeginInit();
            this.gBxGend.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLnm
            // 
            this.txtLnm.BackColor = System.Drawing.Color.Bisque;
            this.txtLnm.Location = new System.Drawing.Point(211, 242);
            this.txtLnm.Name = "txtLnm";
            this.txtLnm.Size = new System.Drawing.Size(301, 27);
            this.txtLnm.TabIndex = 10027;
            this.txtLnm.Leave += new System.EventHandler(this.txtLnm_Leave);
            // 
            // txtFnm
            // 
            this.txtFnm.BackColor = System.Drawing.Color.Bisque;
            this.txtFnm.Location = new System.Drawing.Point(211, 198);
            this.txtFnm.Name = "txtFnm";
            this.txtFnm.Size = new System.Drawing.Size(301, 27);
            this.txtFnm.TabIndex = 10026;
            this.txtFnm.Leave += new System.EventHandler(this.txtFnm_Leave);
            // 
            // cBxTyp
            // 
            this.cBxTyp.BackColor = System.Drawing.Color.Bisque;
            this.cBxTyp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cBxTyp.FormattingEnabled = true;
            this.cBxTyp.Items.AddRange(new object[] {
            "InPatient",
            "OutPatient"});
            this.cBxTyp.Location = new System.Drawing.Point(211, 149);
            this.cBxTyp.Name = "cBxTyp";
            this.cBxTyp.Size = new System.Drawing.Size(301, 28);
            this.cBxTyp.TabIndex = 10025;
            this.cBxTyp.SelectedIndexChanged += new System.EventHandler(this.cBxTyp_SelectedIndexChanged);
            // 
            // txtNin
            // 
            this.txtNin.BackColor = System.Drawing.Color.Bisque;
            this.txtNin.Location = new System.Drawing.Point(1113, 129);
            this.txtNin.Name = "txtNin";
            this.txtNin.Size = new System.Drawing.Size(301, 27);
            this.txtNin.TabIndex = 10034;
            this.txtNin.Leave += new System.EventHandler(this.txtNin_Leave);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1014, 136);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 20);
            this.label13.TabIndex = 10024;
            this.label13.Text = "NIN";
            // 
            // ExitPatPage
            // 
            this.ExitPatPage.BackColor = System.Drawing.Color.Transparent;
            this.ExitPatPage.BackgroundImage = global::HospitalManagementSystem.Properties.Resources.exit11;
            this.ExitPatPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitPatPage.ErrorImage = global::HospitalManagementSystem.Properties.Resources.exit1;
            this.ExitPatPage.Location = new System.Drawing.Point(1494, 20);
            this.ExitPatPage.Name = "ExitPatPage";
            this.ExitPatPage.Size = new System.Drawing.Size(40, 36);
            this.ExitPatPage.TabIndex = 10023;
            this.ExitPatPage.TabStop = false;
            this.ExitPatPage.Click += new System.EventHandler(this.ExitPatPage_Click);
            // 
            // lblPatID
            // 
            this.lblPatID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblPatID.Location = new System.Drawing.Point(211, 105);
            this.lblPatID.MaximumSize = new System.Drawing.Size(250, 20);
            this.lblPatID.Name = "lblPatID";
            this.lblPatID.Size = new System.Drawing.Size(150, 20);
            this.lblPatID.TabIndex = 10033;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(136, 105);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 20);
            this.label12.TabIndex = 10022;
            this.label12.Text = "ID";
            // 
            // dGVPat
            // 
            this.dGVPat.BackgroundColor = System.Drawing.Color.Bisque;
            this.dGVPat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dGVPat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVPat.Location = new System.Drawing.Point(97, 388);
            this.dGVPat.Name = "dGVPat";
            this.dGVPat.RowHeadersWidth = 51;
            this.dGVPat.RowTemplate.Height = 29;
            this.dGVPat.Size = new System.Drawing.Size(1404, 401);
            this.dGVPat.TabIndex = 10021;
            this.dGVPat.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVPat_CellDoubleClick_1);
            // 
            // btnMod
            // 
            this.btnMod.BackColor = System.Drawing.Color.Transparent;
            this.btnMod.FlatAppearance.BorderSize = 0;
            this.btnMod.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnMod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnMod.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMod.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMod.Location = new System.Drawing.Point(840, 353);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(137, 29);
            this.btnMod.TabIndex = 10019;
            this.btnMod.Text = "MODIFY";
            this.btnMod.UseVisualStyleBackColor = false;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(503, 353);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(115, 29);
            this.btnAdd.TabIndex = 10018;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Bisque;
            this.txtEmail.Location = new System.Drawing.Point(657, 287);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(301, 27);
            this.txtEmail.TabIndex = 10031;
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(571, 287);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 20);
            this.label10.TabIndex = 10016;
            this.label10.Text = "Email";
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.Bisque;
            this.txtPhone.Location = new System.Drawing.Point(211, 287);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(301, 27);
            this.txtPhone.TabIndex = 10030;
            this.txtPhone.Leave += new System.EventHandler(this.txtPhone_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(125, 287);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 20);
            this.label9.TabIndex = 10015;
            this.label9.Text = "Contact";
            // 
            // txtAdd
            // 
            this.txtAdd.BackColor = System.Drawing.Color.Bisque;
            this.txtAdd.Location = new System.Drawing.Point(1113, 172);
            this.txtAdd.Multiline = true;
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(365, 92);
            this.txtAdd.TabIndex = 10013;
            this.txtAdd.Leave += new System.EventHandler(this.txtAdd_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1014, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 10012;
            this.label7.Text = "Address";
            // 
            // gBxGend
            // 
            this.gBxGend.Controls.Add(this.rdBO);
            this.gBxGend.Controls.Add(this.rdBF);
            this.gBxGend.Controls.Add(this.rdBM);
            this.gBxGend.Location = new System.Drawing.Point(556, 196);
            this.gBxGend.Name = "gBxGend";
            this.gBxGend.Size = new System.Drawing.Size(405, 66);
            this.gBxGend.TabIndex = 10011;
            this.gBxGend.TabStop = false;
            this.gBxGend.Text = "Gender";
            // 
            // rdBO
            // 
            this.rdBO.AutoSize = true;
            this.rdBO.Location = new System.Drawing.Point(302, 26);
            this.rdBO.Name = "rdBO";
            this.rdBO.Size = new System.Drawing.Size(73, 24);
            this.rdBO.TabIndex = 2;
            this.rdBO.TabStop = true;
            this.rdBO.Text = "Others";
            this.rdBO.UseVisualStyleBackColor = true;
            // 
            // rdBF
            // 
            this.rdBF.AutoSize = true;
            this.rdBF.Location = new System.Drawing.Point(159, 26);
            this.rdBF.Name = "rdBF";
            this.rdBF.Size = new System.Drawing.Size(78, 24);
            this.rdBF.TabIndex = 1;
            this.rdBF.TabStop = true;
            this.rdBF.Text = "Female";
            this.rdBF.UseVisualStyleBackColor = true;
            // 
            // rdBM
            // 
            this.rdBM.AutoSize = true;
            this.rdBM.Location = new System.Drawing.Point(20, 26);
            this.rdBM.Name = "rdBM";
            this.rdBM.Size = new System.Drawing.Size(63, 24);
            this.rdBM.TabIndex = 0;
            this.rdBM.TabStop = true;
            this.rdBM.Text = "Male";
            this.rdBM.UseVisualStyleBackColor = true;
            // 
            // txtDoB
            // 
            this.txtDoB.BackColor = System.Drawing.Color.Bisque;
            this.txtDoB.Location = new System.Drawing.Point(657, 133);
            this.txtDoB.Name = "txtDoB";
            this.txtDoB.PlaceholderText = "YYYY/MM/DD";
            this.txtDoB.Size = new System.Drawing.Size(301, 27);
            this.txtDoB.TabIndex = 10028;
            this.txtDoB.Leave += new System.EventHandler(this.txtDoB_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(557, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 10010;
            this.label6.Text = "Date of Birth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(125, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 10009;
            this.label5.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 10008;
            this.label3.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(715, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 38);
            this.label2.TabIndex = 10007;
            this.label2.Text = "PATIENT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 10006;
            this.label1.Text = "Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(495, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(610, 38);
            this.label4.TabIndex = 10005;
            this.label4.Text = "A R HOSPITAL MANAGEMENT SYSTEM";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Transparent;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrint.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPrint.Location = new System.Drawing.Point(1140, 353);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(115, 29);
            this.btnPrint.TabIndex = 10035;
            this.btnPrint.Text = "PRINT";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // pageSetupDialog1
            // 
            this.pageSetupDialog1.Document = this.printDocument1;
            // 
            // Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1631, 808);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.txtLnm);
            this.Controls.Add(this.txtFnm);
            this.Controls.Add(this.cBxTyp);
            this.Controls.Add(this.txtNin);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.ExitPatPage);
            this.Controls.Add(this.lblPatID);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dGVPat);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.gBxGend);
            this.Controls.Add(this.txtDoB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Patient";
            this.Text = "Patient";
            this.Load += new System.EventHandler(this.Patient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ExitPatPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVPat)).EndInit();
            this.gBxGend.ResumeLayout(false);
            this.gBxGend.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtLnm;
        private TextBox txtFnm;
        private ComboBox cBxTyp;
        private TextBox txtNin;
        private Label label13;
        private PictureBox ExitPatPage;
        private Label lblPatID;
        private Label label12;
        private DataGridView dGVPat;
        private Button btnMod;
        private Button btnAdd;
        private TextBox txtEmail;
        private Label label10;
        private TextBox txtPhone;
        private Label label9;
        private TextBox txtAdd;
        private Label label7;
        private GroupBox gBxGend;
        private RadioButton rdBO;
        private RadioButton rdBF;
        private RadioButton rdBM;
        private TextBox txtDoB;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private Button btnPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private PageSetupDialog pageSetupDialog1;
    }
}