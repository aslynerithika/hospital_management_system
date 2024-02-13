namespace HospitalManagementSystem
{
    partial class Rooms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rooms));
            this.label14 = new System.Windows.Forms.Label();
            this.lblStat = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRmNo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNoBds = new System.Windows.Forms.TextBox();
            this.cBxTyp = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cBxWard = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDact = new System.Windows.Forms.Button();
            this.btnAct = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.DGVRooms = new System.Windows.Forms.DataGridView();
            this.ExitRoomPage = new System.Windows.Forms.PictureBox();
            this.PrnDoc5 = new System.Drawing.Printing.PrintDocument();
            this.prnPrvwDlog5 = new System.Windows.Forms.PrintPreviewDialog();
            this.btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitRoomPage)).BeginInit();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(23, 196);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 20);
            this.label14.TabIndex = 10008;
            this.label14.Text = "Status";
            // 
            // lblStat
            // 
            this.lblStat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblStat.Location = new System.Drawing.Point(102, 201);
            this.lblStat.MaximumSize = new System.Drawing.Size(250, 20);
            this.lblStat.Name = "lblStat";
            this.lblStat.Size = new System.Drawing.Size(150, 20);
            this.lblStat.TabIndex = 10007;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(464, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 38);
            this.label2.TabIndex = 10006;
            this.label2.Text = "ROOMS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(244, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(610, 38);
            this.label4.TabIndex = 10005;
            this.label4.Text = "A R HOSPITAL MANAGEMENT SYSTEM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 10009;
            this.label1.Text = "Room No";
            // 
            // lblRmNo
            // 
            this.lblRmNo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblRmNo.Location = new System.Drawing.Point(102, 144);
            this.lblRmNo.MaximumSize = new System.Drawing.Size(250, 20);
            this.lblRmNo.Name = "lblRmNo";
            this.lblRmNo.Size = new System.Drawing.Size(150, 20);
            this.lblRmNo.TabIndex = 10010;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(314, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 10011;
            this.label3.Text = "No of beds";
            // 
            // txtNoBds
            // 
            this.txtNoBds.BackColor = System.Drawing.Color.Bisque;
            this.txtNoBds.Location = new System.Drawing.Point(413, 137);
            this.txtNoBds.Name = "txtNoBds";
            this.txtNoBds.Size = new System.Drawing.Size(156, 27);
            this.txtNoBds.TabIndex = 100012;
            this.txtNoBds.Leave += new System.EventHandler(this.txtNoBds_Leave);
            // 
            // cBxTyp
            // 
            this.cBxTyp.AutoCompleteCustomSource.AddRange(new string[] {
            "Common",
            "Semi Private",
            "Private",
            "Maternity",
            "Casuality",
            "Sickroom",
            "Consulting"});
            this.cBxTyp.BackColor = System.Drawing.Color.Bisque;
            this.cBxTyp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cBxTyp.FormattingEnabled = true;
            this.cBxTyp.Items.AddRange(new object[] {
            "Casuality",
            "Common",
            "Consulting",
            "Maternity",
            "Private",
            "Semi Private",
            "Sick room"});
            this.cBxTyp.Location = new System.Drawing.Point(698, 136);
            this.cBxTyp.Name = "cBxTyp";
            this.cBxTyp.Size = new System.Drawing.Size(266, 28);
            this.cBxTyp.TabIndex = 100014;
            this.cBxTyp.SelectedIndexChanged += new System.EventHandler(this.cBxTyp_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(612, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 10013;
            this.label5.Text = "Type";
            // 
            // cBxWard
            // 
            this.cBxWard.AutoCompleteCustomSource.AddRange(new string[] {
            "Common",
            "Semi Private",
            "Private",
            "Maternity",
            "Casuality",
            "Sickroom",
            "Consulting"});
            this.cBxWard.BackColor = System.Drawing.Color.Bisque;
            this.cBxWard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cBxWard.FormattingEnabled = true;
            this.cBxWard.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F"});
            this.cBxWard.Location = new System.Drawing.Point(1068, 132);
            this.cBxWard.Name = "cBxWard";
            this.cBxWard.Size = new System.Drawing.Size(116, 28);
            this.cBxWard.TabIndex = 100016;
            this.cBxWard.SelectedIndexChanged += new System.EventHandler(this.cBxWard_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(982, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 10015;
            this.label6.Text = "Ward";
            // 
            // btnDact
            // 
            this.btnDact.BackColor = System.Drawing.Color.Transparent;
            this.btnDact.FlatAppearance.BorderSize = 0;
            this.btnDact.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnDact.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDact.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDact.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDact.Location = new System.Drawing.Point(688, 279);
            this.btnDact.Name = "btnDact";
            this.btnDact.Size = new System.Drawing.Size(187, 29);
            this.btnDact.TabIndex = 10020;
            this.btnDact.Text = "DEACTIVATE";
            this.btnDact.UseVisualStyleBackColor = false;
            this.btnDact.Click += new System.EventHandler(this.btnDact_Click);
            // 
            // btnAct
            // 
            this.btnAct.BackColor = System.Drawing.Color.Transparent;
            this.btnAct.FlatAppearance.BorderSize = 0;
            this.btnAct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnAct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAct.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAct.Location = new System.Drawing.Point(456, 279);
            this.btnAct.Name = "btnAct";
            this.btnAct.Size = new System.Drawing.Size(149, 29);
            this.btnAct.TabIndex = 10019;
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
            this.btnMod.Location = new System.Drawing.Point(242, 279);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(137, 29);
            this.btnMod.TabIndex = 10018;
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
            this.btnAdd.Location = new System.Drawing.Point(57, 279);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(115, 29);
            this.btnAdd.TabIndex = 10017;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // DGVRooms
            // 
            this.DGVRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVRooms.Location = new System.Drawing.Point(48, 331);
            this.DGVRooms.Name = "DGVRooms";
            this.DGVRooms.RowHeadersWidth = 51;
            this.DGVRooms.RowTemplate.Height = 29;
            this.DGVRooms.Size = new System.Drawing.Size(1103, 244);
            this.DGVRooms.TabIndex = 10021;
            this.DGVRooms.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVRooms_CellDoubleClick);
            // 
            // ExitRoomPage
            // 
            this.ExitRoomPage.BackColor = System.Drawing.Color.Transparent;
            this.ExitRoomPage.BackgroundImage = global::HospitalManagementSystem.Properties.Resources.exit11;
            this.ExitRoomPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitRoomPage.ErrorImage = global::HospitalManagementSystem.Properties.Resources.exit1;
            this.ExitRoomPage.Location = new System.Drawing.Point(1150, 12);
            this.ExitRoomPage.Name = "ExitRoomPage";
            this.ExitRoomPage.Size = new System.Drawing.Size(40, 36);
            this.ExitRoomPage.TabIndex = 10022;
            this.ExitRoomPage.TabStop = false;
            this.ExitRoomPage.Click += new System.EventHandler(this.ExitRoomPage_Click);
            // 
            // PrnDoc5
            // 
            this.PrnDoc5.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrnDoc5_PrintPage);
            // 
            // prnPrvwDlog5
            // 
            this.prnPrvwDlog5.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.prnPrvwDlog5.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.prnPrvwDlog5.ClientSize = new System.Drawing.Size(400, 300);
            this.prnPrvwDlog5.Document = this.PrnDoc5;
            this.prnPrvwDlog5.Enabled = true;
            this.prnPrvwDlog5.Icon = ((System.Drawing.Icon)(resources.GetObject("prnPrvwDlog5.Icon")));
            this.prnPrvwDlog5.Name = "prnPrvwDlog5";
            this.prnPrvwDlog5.Visible = false;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Transparent;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrint.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPrint.Location = new System.Drawing.Point(933, 279);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(137, 29);
            this.btnPrint.TabIndex = 100017;
            this.btnPrint.Text = "PRINT";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // Rooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 587);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.ExitRoomPage);
            this.Controls.Add(this.DGVRooms);
            this.Controls.Add(this.btnDact);
            this.Controls.Add(this.btnAct);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cBxWard);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cBxTyp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNoBds);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblRmNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblStat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rooms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Rooms";
            this.Load += new System.EventHandler(this.Rooms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitRoomPage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label14;
        private Label lblStat;
        private Label label2;
        private Label label4;
        private Label label1;
        private Label lblRmNo;
        private Label label3;
        private TextBox txtNoBds;
        private ComboBox cBxTyp;
        private Label label5;
        private ComboBox cBxWard;
        private Label label6;
        private Button btnDact;
        private Button btnAct;
        private Button btnMod;
        private Button btnAdd;
        private DataGridView DGVRooms;
        private PictureBox ExitRoomPage;
        private System.Drawing.Printing.PrintDocument PrnDoc5;
        private PrintPreviewDialog prnPrvwDlog5;
        private Button btnPrint;
    }
}