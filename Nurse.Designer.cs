namespace HospitalManagementSystem
{
    partial class Nurse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nurse));
            this.label14 = new System.Windows.Forms.Label();
            this.lblStat = new System.Windows.Forms.Label();
            this.btnDact = new System.Windows.Forms.Button();
            this.txtLnm = new System.Windows.Forms.TextBox();
            this.txtFnm = new System.Windows.Forms.TextBox();
            this.cBxPos = new System.Windows.Forms.ComboBox();
            this.txtNmc = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.ExitNrsPage = new System.Windows.Forms.PictureBox();
            this.lblNrsID = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dGVNrs = new System.Windows.Forms.DataGridView();
            this.btnAct = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtQual = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
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
            this.PrnDoc4 = new System.Drawing.Printing.PrintDocument();
            this.prnPrvwDlog4 = new System.Windows.Forms.PrintPreviewDialog();
            this.btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ExitNrsPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVNrs)).BeginInit();
            this.gBxGend.SuspendLayout();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(945, 124);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 20);
            this.label14.TabIndex = 10037;
            this.label14.Text = "Status";
            // 
            // lblStat
            // 
            this.lblStat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblStat.Location = new System.Drawing.Point(1044, 124);
            this.lblStat.MaximumSize = new System.Drawing.Size(250, 20);
            this.lblStat.Name = "lblStat";
            this.lblStat.Size = new System.Drawing.Size(150, 20);
            this.lblStat.TabIndex = 10036;
            // 
            // btnDact
            // 
            this.btnDact.BackColor = System.Drawing.Color.Transparent;
            this.btnDact.FlatAppearance.BorderSize = 0;
            this.btnDact.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnDact.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDact.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDact.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDact.Location = new System.Drawing.Point(902, 340);
            this.btnDact.Name = "btnDact";
            this.btnDact.Size = new System.Drawing.Size(187, 29);
            this.btnDact.TabIndex = 10035;
            this.btnDact.Text = "DEACTIVATE";
            this.btnDact.UseVisualStyleBackColor = false;
            this.btnDact.Click += new System.EventHandler(this.btnDact_Click);
            // 
            // txtLnm
            // 
            this.txtLnm.BackColor = System.Drawing.Color.Bisque;
            this.txtLnm.Location = new System.Drawing.Point(152, 235);
            this.txtLnm.Name = "txtLnm";
            this.txtLnm.Size = new System.Drawing.Size(301, 27);
            this.txtLnm.TabIndex = 10027;
            this.txtLnm.Leave += new System.EventHandler(this.txtLnm_Leave);
            // 
            // txtFnm
            // 
            this.txtFnm.BackColor = System.Drawing.Color.Bisque;
            this.txtFnm.Location = new System.Drawing.Point(152, 191);
            this.txtFnm.Name = "txtFnm";
            this.txtFnm.Size = new System.Drawing.Size(301, 27);
            this.txtFnm.TabIndex = 10026;
            this.txtFnm.Leave += new System.EventHandler(this.txtFnm_Leave);
            // 
            // cBxPos
            // 
            this.cBxPos.BackColor = System.Drawing.Color.Bisque;
            this.cBxPos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cBxPos.FormattingEnabled = true;
            this.cBxPos.Items.AddRange(new object[] {
            "Nurse Practitioner",
            "Clinical Nurse Midwife",
            "Clinic Nurse Speacialist"});
            this.cBxPos.Location = new System.Drawing.Point(152, 142);
            this.cBxPos.Name = "cBxPos";
            this.cBxPos.Size = new System.Drawing.Size(301, 28);
            this.cBxPos.TabIndex = 10025;
            this.cBxPos.SelectedIndexChanged += new System.EventHandler(this.cBxPos_SelectedIndexChanged);
            // 
            // txtNmc
            // 
            this.txtNmc.BackColor = System.Drawing.Color.Bisque;
            this.txtNmc.Location = new System.Drawing.Point(1041, 170);
            this.txtNmc.Name = "txtNmc";
            this.txtNmc.Size = new System.Drawing.Size(301, 27);
            this.txtNmc.TabIndex = 10034;
            this.txtNmc.Leave += new System.EventHandler(this.txtNmc_Leave);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(942, 177);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 20);
            this.label13.TabIndex = 10024;
            this.label13.Text = "NMC";
            // 
            // ExitNrsPage
            // 
            this.ExitNrsPage.BackColor = System.Drawing.Color.Transparent;
            this.ExitNrsPage.BackgroundImage = global::HospitalManagementSystem.Properties.Resources.exit11;
            this.ExitNrsPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitNrsPage.ErrorImage = global::HospitalManagementSystem.Properties.Resources.exit1;
            this.ExitNrsPage.Location = new System.Drawing.Point(1435, 13);
            this.ExitNrsPage.Name = "ExitNrsPage";
            this.ExitNrsPage.Size = new System.Drawing.Size(40, 36);
            this.ExitNrsPage.TabIndex = 10023;
            this.ExitNrsPage.TabStop = false;
            this.ExitNrsPage.Click += new System.EventHandler(this.ExitNrsPage_Click);
            // 
            // lblNrsID
            // 
            this.lblNrsID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblNrsID.Location = new System.Drawing.Point(152, 98);
            this.lblNrsID.MaximumSize = new System.Drawing.Size(250, 20);
            this.lblNrsID.Name = "lblNrsID";
            this.lblNrsID.Size = new System.Drawing.Size(150, 20);
            this.lblNrsID.TabIndex = 10033;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(77, 98);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 20);
            this.label12.TabIndex = 10022;
            this.label12.Text = "ID";
            // 
            // dGVNrs
            // 
            this.dGVNrs.BackgroundColor = System.Drawing.Color.Bisque;
            this.dGVNrs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dGVNrs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVNrs.Location = new System.Drawing.Point(38, 381);
            this.dGVNrs.Name = "dGVNrs";
            this.dGVNrs.RowHeadersWidth = 51;
            this.dGVNrs.RowTemplate.Height = 29;
            this.dGVNrs.Size = new System.Drawing.Size(1404, 401);
            this.dGVNrs.TabIndex = 10021;
            this.dGVNrs.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVNrs_CellDoubleClick);
            // 
            // btnAct
            // 
            this.btnAct.BackColor = System.Drawing.Color.Transparent;
            this.btnAct.FlatAppearance.BorderSize = 0;
            this.btnAct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnAct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAct.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAct.Location = new System.Drawing.Point(652, 340);
            this.btnAct.Name = "btnAct";
            this.btnAct.Size = new System.Drawing.Size(149, 29);
            this.btnAct.TabIndex = 10020;
            this.btnAct.Text = "ACTIVATE";
            this.btnAct.UseVisualStyleBackColor = false;
            this.btnAct.Click += new System.EventHandler(this.btnAct_Click);
            // 
            // btnMod
            // 
            this.btnMod.BackColor = System.Drawing.Color.Transparent;
            this.btnMod.FlatAppearance.BorderSize = 0;
            this.btnMod.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnMod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnMod.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMod.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMod.Location = new System.Drawing.Point(428, 340);
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
            this.btnAdd.Location = new System.Drawing.Point(237, 340);
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
            this.txtEmail.Location = new System.Drawing.Point(598, 280);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(301, 27);
            this.txtEmail.TabIndex = 10031;
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(512, 280);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 20);
            this.label10.TabIndex = 10016;
            this.label10.Text = "Email";
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.Bisque;
            this.txtPhone.Location = new System.Drawing.Point(152, 280);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(301, 27);
            this.txtPhone.TabIndex = 10030;
            this.txtPhone.Leave += new System.EventHandler(this.txtPhone_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(66, 280);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 20);
            this.label9.TabIndex = 10015;
            this.label9.Text = "Contact";
            // 
            // txtQual
            // 
            this.txtQual.BackColor = System.Drawing.Color.Bisque;
            this.txtQual.Location = new System.Drawing.Point(1041, 279);
            this.txtQual.Name = "txtQual";
            this.txtQual.Size = new System.Drawing.Size(360, 27);
            this.txtQual.TabIndex = 10029;
            this.txtQual.Leave += new System.EventHandler(this.txtQual_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(941, 279);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 20);
            this.label8.TabIndex = 10014;
            this.label8.Text = "Qualification";
            // 
            // txtAdd
            // 
            this.txtAdd.BackColor = System.Drawing.Color.Bisque;
            this.txtAdd.Location = new System.Drawing.Point(1041, 213);
            this.txtAdd.Multiline = true;
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(360, 49);
            this.txtAdd.TabIndex = 10013;
            this.txtAdd.Leave += new System.EventHandler(this.txtAdd_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(942, 230);
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
            this.gBxGend.Location = new System.Drawing.Point(497, 189);
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
            this.txtDoB.Location = new System.Drawing.Point(598, 126);
            this.txtDoB.Name = "txtDoB";
            this.txtDoB.PlaceholderText = "YYYY/MM/DD";
            this.txtDoB.Size = new System.Drawing.Size(301, 27);
            this.txtDoB.TabIndex = 10028;
            this.txtDoB.Leave += new System.EventHandler(this.txtDoB_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(498, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 10010;
            this.label6.Text = "Date of Birth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 10009;
            this.label5.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 191);
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
            this.label2.Location = new System.Drawing.Point(656, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 38);
            this.label2.TabIndex = 10007;
            this.label2.Text = "NURSE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 10006;
            this.label1.Text = "Position";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(436, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(610, 38);
            this.label4.TabIndex = 10005;
            this.label4.Text = "A R HOSPITAL MANAGEMENT SYSTEM";
            // 
            // PrnDoc4
            // 
            this.PrnDoc4.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrnDoc4_PrintPage);
            // 
            // prnPrvwDlog4
            // 
            this.prnPrvwDlog4.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.prnPrvwDlog4.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.prnPrvwDlog4.ClientSize = new System.Drawing.Size(400, 300);
            this.prnPrvwDlog4.Document = this.PrnDoc4;
            this.prnPrvwDlog4.Enabled = true;
            this.prnPrvwDlog4.Icon = ((System.Drawing.Icon)(resources.GetObject("prnPrvwDlog4.Icon")));
            this.prnPrvwDlog4.Name = "prnPrvwDlog4";
            this.prnPrvwDlog4.Visible = false;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Transparent;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrint.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPrint.Location = new System.Drawing.Point(1165, 340);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(137, 29);
            this.btnPrint.TabIndex = 10038;
            this.btnPrint.Text = "PRINT";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // Nurse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1456, 849);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblStat);
            this.Controls.Add(this.btnDact);
            this.Controls.Add(this.txtLnm);
            this.Controls.Add(this.txtFnm);
            this.Controls.Add(this.cBxPos);
            this.Controls.Add(this.txtNmc);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.ExitNrsPage);
            this.Controls.Add(this.lblNrsID);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dGVNrs);
            this.Controls.Add(this.btnAct);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.btnAdd);
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
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Nurse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nurse";
            this.Load += new System.EventHandler(this.Nurse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ExitNrsPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVNrs)).EndInit();
            this.gBxGend.ResumeLayout(false);
            this.gBxGend.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label14;
        private Label lblStat;
        private Button btnDact;
        private TextBox txtLnm;
        private TextBox txtFnm;
        private ComboBox cBxPos;
        private TextBox txtNmc;
        private Label label13;
        private PictureBox ExitNrsPage;
        private Label lblNrsID;
        private Label label12;
        private DataGridView dGVNrs;
        private Button btnAct;
        private Button btnMod;
        private Button btnAdd;
        private TextBox txtEmail;
        private Label label10;
        private TextBox txtPhone;
        private Label label9;
        private TextBox txtQual;
        private Label label8;
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
        private System.Drawing.Printing.PrintDocument PrnDoc4;
        private PrintPreviewDialog prnPrvwDlog4;
        private Button btnPrint;
    }
}