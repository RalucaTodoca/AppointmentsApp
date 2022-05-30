namespace AppointmentImg
{
    partial class Appointments
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
            this.btnBook = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDeparture = new System.Windows.Forms.TextBox();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbIdentity = new System.Windows.Forms.RadioButton();
            this.rbPassport = new System.Windows.Forms.RadioButton();
            this.lblDocNo = new System.Windows.Forms.Label();
            this.txtDocNo = new System.Windows.Forms.TextBox();
            this.lblDocIssueDate = new System.Windows.Forms.Label();
            this.dtpDocIssueDate = new System.Windows.Forms.DateTimePicker();
            this.lblDocExpiryDate = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDownBaggage = new System.Windows.Forms.NumericUpDown();
            this.dtpDocExpiryDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBaggage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBook
            // 
            this.btnBook.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBook.Location = new System.Drawing.Point(295, 734);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(202, 34);
            this.btnBook.TabIndex = 0;
            this.btnBook.Text = "Creaza programarea";
            this.btnBook.UseVisualStyleBackColor = false;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ora";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(356, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Alege medicul";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(265, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Creaza o programare conform orarului";
            // 
            // txtDeparture
            // 
            this.txtDeparture.Location = new System.Drawing.Point(65, 52);
            this.txtDeparture.Name = "txtDeparture";
            this.txtDeparture.Size = new System.Drawing.Size(125, 27);
            this.txtDeparture.TabIndex = 8;
            // 
            // txtDestination
            // 
            this.txtDestination.Location = new System.Drawing.Point(496, 59);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(261, 27);
            this.txtDestination.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Alegeti data";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(12, 142);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(371, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Nume";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(371, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Prenume";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(477, 179);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(280, 27);
            this.txtFirstName.TabIndex = 15;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(479, 300);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(278, 27);
            this.txtLastName.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbIdentity);
            this.groupBox1.Controls.Add(this.rbPassport);
            this.groupBox1.Location = new System.Drawing.Point(12, 403);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 95);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Documente de identitate";
            // 
            // rbIdentity
            // 
            this.rbIdentity.AutoSize = true;
            this.rbIdentity.Location = new System.Drawing.Point(171, 48);
            this.rbIdentity.Name = "rbIdentity";
            this.rbIdentity.Size = new System.Drawing.Size(133, 24);
            this.rbIdentity.TabIndex = 1;
            this.rbIdentity.TabStop = true;
            this.rbIdentity.Text = "Carte Identitate";
            this.rbIdentity.UseVisualStyleBackColor = true;
            this.rbIdentity.CheckedChanged += new System.EventHandler(this.rbIdentity_CheckedChanged);
            // 
            // rbPassport
            // 
            this.rbPassport.AutoSize = true;
            this.rbPassport.Location = new System.Drawing.Point(20, 48);
            this.rbPassport.Name = "rbPassport";
            this.rbPassport.Size = new System.Drawing.Size(87, 24);
            this.rbPassport.TabIndex = 0;
            this.rbPassport.TabStop = true;
            this.rbPassport.Text = "Pasaport";
            this.rbPassport.UseVisualStyleBackColor = true;
            this.rbPassport.CheckedChanged += new System.EventHandler(this.rbPassport_CheckedChanged);
            // 
            // lblDocNo
            // 
            this.lblDocNo.AutoSize = true;
            this.lblDocNo.Location = new System.Drawing.Point(451, 441);
            this.lblDocNo.Name = "lblDocNo";
            this.lblDocNo.Size = new System.Drawing.Size(98, 20);
            this.lblDocNo.TabIndex = 18;
            this.lblDocNo.Text = "Nr Document";
            // 
            // txtDocNo
            // 
            this.txtDocNo.Location = new System.Drawing.Point(564, 438);
            this.txtDocNo.Name = "txtDocNo";
            this.txtDocNo.Size = new System.Drawing.Size(239, 27);
            this.txtDocNo.TabIndex = 19;
            // 
            // lblDocIssueDate
            // 
            this.lblDocIssueDate.AutoSize = true;
            this.lblDocIssueDate.Location = new System.Drawing.Point(98, 532);
            this.lblDocIssueDate.Name = "lblDocIssueDate";
            this.lblDocIssueDate.Size = new System.Drawing.Size(239, 20);
            this.lblDocIssueDate.TabIndex = 20;
            this.lblDocIssueDate.Text = " Data emitere document identitate";
            // 
            // dtpDocIssueDate
            // 
            this.dtpDocIssueDate.Location = new System.Drawing.Point(451, 532);
            this.dtpDocIssueDate.Name = "dtpDocIssueDate";
            this.dtpDocIssueDate.Size = new System.Drawing.Size(263, 27);
            this.dtpDocIssueDate.TabIndex = 21;
            // 
            // lblDocExpiryDate
            // 
            this.lblDocExpiryDate.AutoSize = true;
            this.lblDocExpiryDate.Location = new System.Drawing.Point(106, 578);
            this.lblDocExpiryDate.Name = "lblDocExpiryDate";
            this.lblDocExpiryDate.Size = new System.Drawing.Size(238, 20);
            this.lblDocExpiryDate.TabIndex = 22;
            this.lblDocExpiryDate.Text = "Data expirare document identitate";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(133, 657);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(275, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "Nr radiografii ce se doresc a fi efectuate";
            // 
            // numericUpDownBaggage
            // 
            this.numericUpDownBaggage.Location = new System.Drawing.Point(479, 655);
            this.numericUpDownBaggage.Name = "numericUpDownBaggage";
            this.numericUpDownBaggage.Size = new System.Drawing.Size(150, 27);
            this.numericUpDownBaggage.TabIndex = 25;
            // 
            // dtpDocExpiryDate
            // 
            this.dtpDocExpiryDate.Location = new System.Drawing.Point(451, 582);
            this.dtpDocExpiryDate.Name = "dtpDocExpiryDate";
            this.dtpDocExpiryDate.Size = new System.Drawing.Size(263, 27);
            this.dtpDocExpiryDate.TabIndex = 26;
            // 
            // Appointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(853, 780);
            this.Controls.Add(this.dtpDocExpiryDate);
            this.Controls.Add(this.numericUpDownBaggage);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblDocExpiryDate);
            this.Controls.Add(this.dtpDocIssueDate);
            this.Controls.Add(this.lblDocIssueDate);
            this.Controls.Add(this.txtDocNo);
            this.Controls.Add(this.lblDocNo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.txtDeparture);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBook);
            this.Name = "Appointments";
            this.Text = "Appointments";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBaggage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnBook;
        private Label label1;
        private Label label2;
        private Label label4;
        private TextBox txtDeparture;
        private TextBox txtDestination;
        private Label label5;
        private MonthCalendar monthCalendar1;
        private Label label6;
        private Label label7;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private GroupBox groupBox1;
        private RadioButton rbIdentity;
        private RadioButton rbPassport;
        private Label lblDocNo;
        private TextBox txtDocNo;
        private Label lblDocIssueDate;
        private DateTimePicker dtpDocIssueDate;
        private Label lblDocExpiryDate;
        private Label label8;
        private NumericUpDown numericUpDownBaggage;
        private DateTimePicker dtpDocExpiryDate;
    }
}