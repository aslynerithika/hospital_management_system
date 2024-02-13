namespace HospitalManagementSystem
{
    partial class Administration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administration));
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cBxRol = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFnm = new System.Windows.Forms.TextBox();
            this.txtLnm = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDoB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gBxGend = new System.Windows.Forms.GroupBox();
            this.rdBO = new System.Windows.Forms.RadioButton();
            this.rdBF = new System.Windows.Forms.RadioButton();
            this.rdBM = new System.Windows.Forms.RadioButton();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtQual = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnAct = new System.Windows.Forms.Button();
            this.dGVAdm = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.ExitAdmPage = new System.Windows.Forms.PictureBox();
            this.btnDact = new System.Windows.Forms.Button();
            this.lblStat = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.PrnDoc2 = new System.Drawing.Printing.PrintDocument();
            this.prnPrvwDlog2 = new System.Windows.Forms.PrintPreviewDialog();
            this.btnPrint = new System.Windows.Forms.Button();
            this.gBxGend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVAdm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitAdmPage)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(410, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(610, 38);
            this.label4.TabIndex = 12;
            this.label4.Text = "A R HOSPITAL MANAGEMENT SYSTEM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "ROLE";
            // 
            // cBxRol
            // 
            this.cBxRol.BackColor = System.Drawing.Color.Bisque;
            this.cBxRol.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cBxRol.FormattingEnabled = true;
            this.cBxRol.Items.AddRange(new object[] {
            "Admin",
            "Receptionist"});
            this.cBxRol.Location = new System.Drawing.Point(126, 143);
            this.cBxRol.Name = "cBxRol";
            this.cBxRol.Size = new System.Drawing.Size(301, 28);
            this.cBxRol.TabIndex = 14;
            this.cBxRol.SelectedIndexChanged += new System.EventHandler(this.cBxRol_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(524, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 38);
            this.label2.TabIndex = 15;
            this.label2.Text = "ADMINISTRATION";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "First Name";
            // 
            // txtFnm
            // 
            this.txtFnm.BackColor = System.Drawing.Color.Bisque;
            this.txtFnm.Location = new System.Drawing.Point(126, 187);
            this.txtFnm.Name = "txtFnm";
            this.txtFnm.Size = new System.Drawing.Size(301, 27);
            this.txtFnm.TabIndex = 17;
            this.txtFnm.Leave += new System.EventHandler(this.txtFnm_Leave);
            // 
            // txtLnm
            // 
            this.txtLnm.BackColor = System.Drawing.Color.Bisque;
            this.txtLnm.Location = new System.Drawing.Point(126, 231);
            this.txtLnm.Name = "txtLnm";
            this.txtLnm.Size = new System.Drawing.Size(301, 27);
            this.txtLnm.TabIndex = 19;
            this.txtLnm.Leave += new System.EventHandler(this.txtLnm_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Last Name";
            // 
            // txtDoB
            // 
            this.txtDoB.BackColor = System.Drawing.Color.Bisque;
            this.txtDoB.Location = new System.Drawing.Point(572, 151);
            this.txtDoB.Name = "txtDoB";
            this.txtDoB.PlaceholderText = "YYYY/MM/DD";
            this.txtDoB.Size = new System.Drawing.Size(301, 27);
            this.txtDoB.TabIndex = 21;
            this.txtDoB.Leave += new System.EventHandler(this.txtDoB_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(472, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Date of Birth";
            // 
            // gBxGend
            // 
            this.gBxGend.Controls.Add(this.rdBO);
            this.gBxGend.Controls.Add(this.rdBF);
            this.gBxGend.Controls.Add(this.rdBM);
            this.gBxGend.Location = new System.Drawing.Point(471, 185);
            this.gBxGend.Name = "gBxGend";
            this.gBxGend.Size = new System.Drawing.Size(405, 66);
            this.gBxGend.TabIndex = 22;
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
            // txtAdd
            // 
            this.txtAdd.BackColor = System.Drawing.Color.Bisque;
            this.txtAdd.Location = new System.Drawing.Point(1018, 158);
            this.txtAdd.Multiline = true;
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(360, 49);
            this.txtAdd.TabIndex = 24;
            this.txtAdd.Leave += new System.EventHandler(this.txtAdd_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(919, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Address";
            // 
            // txtQual
            // 
            this.txtQual.BackColor = System.Drawing.Color.Bisque;
            this.txtQual.Location = new System.Drawing.Point(1018, 224);
            this.txtQual.Name = "txtQual";
            this.txtQual.Size = new System.Drawing.Size(360, 27);
            this.txtQual.TabIndex = 26;
            this.txtQual.Leave += new System.EventHandler(this.txtQual_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(918, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 20);
            this.label8.TabIndex = 25;
            this.label8.Text = "Qualification";
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.Bisque;
            this.txtPhone.Location = new System.Drawing.Point(126, 276);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(301, 27);
            this.txtPhone.TabIndex = 28;
            this.txtPhone.Leave += new System.EventHandler(this.txtPhone_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 276);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 20);
            this.label9.TabIndex = 27;
            this.label9.Text = "Contact";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Bisque;
            this.txtEmail.Location = new System.Drawing.Point(572, 276);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(301, 27);
            this.txtEmail.TabIndex = 30;
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(486, 276);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 20);
            this.label10.TabIndex = 29;
            this.label10.Text = "Email";
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.Bisque;
            this.txtPass.Location = new System.Drawing.Point(1018, 273);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(360, 27);
            this.txtPass.TabIndex = 32;
            this.txtPass.Leave += new System.EventHandler(this.txtPass_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(919, 276);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 20);
            this.label11.TabIndex = 31;
            this.label11.Text = "Password";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(211, 336);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(115, 29);
            this.btnAdd.TabIndex = 33;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnMod
            // 
            this.btnMod.BackColor = System.Drawing.Color.Transparent;
            this.btnMod.FlatAppearance.BorderSize = 0;
            this.btnMod.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnMod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnMod.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMod.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMod.Location = new System.Drawing.Point(389, 336);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(137, 29);
            this.btnMod.TabIndex = 34;
            this.btnMod.Text = "MODIFY";
            this.btnMod.UseVisualStyleBackColor = false;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // btnAct
            // 
            this.btnAct.BackColor = System.Drawing.Color.Transparent;
            this.btnAct.FlatAppearance.BorderSize = 0;
            this.btnAct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnAct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAct.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAct.Location = new System.Drawing.Point(611, 336);
            this.btnAct.Name = "btnAct";
            this.btnAct.Size = new System.Drawing.Size(163, 29);
            this.btnAct.TabIndex = 35;
            this.btnAct.Text = "ACTIVATE";
            this.btnAct.UseVisualStyleBackColor = false;
            this.btnAct.Click += new System.EventHandler(this.btnAct_Click);
            // 
            // dGVAdm
            // 
            this.dGVAdm.BackgroundColor = System.Drawing.Color.Bisque;
            this.dGVAdm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dGVAdm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVAdm.Location = new System.Drawing.Point(12, 377);
            this.dGVAdm.Name = "dGVAdm";
            this.dGVAdm.RowHeadersWidth = 51;
            this.dGVAdm.RowTemplate.Height = 29;
            this.dGVAdm.Size = new System.Drawing.Size(1404, 401);
            this.dGVAdm.TabIndex = 36;
            this.dGVAdm.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVAdm_CellDoubleClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(51, 94);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 20);
            this.label12.TabIndex = 37;
            this.label12.Text = "ID";
            // 
            // lblID
            // 
            this.lblID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblID.Location = new System.Drawing.Point(126, 94);
            this.lblID.MaximumSize = new System.Drawing.Size(250, 20);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(150, 20);
            this.lblID.TabIndex = 38;
            // 
            // ExitAdmPage
            // 
            this.ExitAdmPage.BackColor = System.Drawing.Color.Transparent;
            this.ExitAdmPage.BackgroundImage = global::HospitalManagementSystem.Properties.Resources.exit11;
            this.ExitAdmPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitAdmPage.ErrorImage = global::HospitalManagementSystem.Properties.Resources.exit1;
            this.ExitAdmPage.Location = new System.Drawing.Point(1376, -1);
            this.ExitAdmPage.Name = "ExitAdmPage";
            this.ExitAdmPage.Size = new System.Drawing.Size(40, 36);
            this.ExitAdmPage.TabIndex = 39;
            this.ExitAdmPage.TabStop = false;
            this.ExitAdmPage.Click += new System.EventHandler(this.ExitAdmPage_Click);
            // 
            // btnDact
            // 
            this.btnDact.BackColor = System.Drawing.Color.Transparent;
            this.btnDact.FlatAppearance.BorderSize = 0;
            this.btnDact.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnDact.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDact.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDact.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDact.Location = new System.Drawing.Point(880, 336);
            this.btnDact.Name = "btnDact";
            this.btnDact.Size = new System.Drawing.Size(181, 29);
            this.btnDact.TabIndex = 40;
            this.btnDact.Text = "DEACTIVATE";
            this.btnDact.UseVisualStyleBackColor = false;
            this.btnDact.Click += new System.EventHandler(this.btnDact_Click);
            // 
            // lblStat
            // 
            this.lblStat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblStat.Location = new System.Drawing.Point(1018, 109);
            this.lblStat.MaximumSize = new System.Drawing.Size(250, 20);
            this.lblStat.Name = "lblStat";
            this.lblStat.Size = new System.Drawing.Size(150, 20);
            this.lblStat.TabIndex = 41;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(919, 109);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 20);
            this.label14.TabIndex = 42;
            this.label14.Text = "Status";
            // 
            // PrnDoc2
            // 
            this.PrnDoc2.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrnDoc2_PrintPage);
            // 
            // prnPrvwDlog2
            // 
            this.prnPrvwDlog2.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.prnPrvwDlog2.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.prnPrvwDlog2.ClientSize = new System.Drawing.Size(400, 300);
            this.prnPrvwDlog2.Document = this.PrnDoc2;
            this.prnPrvwDlog2.Enabled = true;
            this.prnPrvwDlog2.Icon = ((System.Drawing.Icon)(resources.GetObject("prnPrvwDlog2.Icon")));
            this.prnPrvwDlog2.Name = "printPreviewDialog1";
            this.prnPrvwDlog2.Visible = false;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Transparent;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrint.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPrint.Location = new System.Drawing.Point(1127, 336);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(137, 29);
            this.btnPrint.TabIndex = 43;
            this.btnPrint.Text = "PRINT";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // Administration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1428, 790);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblStat);
            this.Controls.Add(this.btnDact);
            this.Controls.Add(this.ExitAdmPage);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dGVAdm);
            this.Controls.Add(this.btnAct);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtQual);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.gBxGend);
            this.Controls.Add(this.txtDoB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtLnm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFnm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cBxRol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Administration";
            this.Text = "Administration";
            this.Load += new System.EventHandler(this.Administration_Load);
            this.gBxGend.ResumeLayout(false);
            this.gBxGend.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVAdm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitAdmPage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label4;
        private Label label1;
        private ComboBox cBxRol;
        private Label label2;
        private Label label3;
        private TextBox txtFnm;
        private TextBox txtLnm;
        private Label label5;
        private TextBox txtDoB;
        private Label label6;
        private GroupBox gBxGend;
        private RadioButton rdBO;
        private RadioButton rdBF;
        private RadioButton rdBM;
        private TextBox txtAdd;
        private Label label7;
        private TextBox txtQual;
        private Label label8;
        private TextBox txtPhone;
        private Label label9;
        private TextBox txtEmail;
        private Label label10;
        private TextBox txtPass;
        private Label label11;
        private Button btnAdd;
        private Button btnMod;
        private Button btnAct;
        private DataGridView dGVAdm;
        private Label label12;
        private Label lblID;
        private PictureBox ExitAdmPage;
        private Button btnDact;
        private Label lblStat;
        private Label label14;
        private System.Drawing.Printing.PrintDocument PrnDoc2;
        private PrintPreviewDialog prnPrvwDlog2;
        private Button btnPrint;
    }
}