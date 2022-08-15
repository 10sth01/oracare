namespace OraCare
{
    partial class AppointmentWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppointmentWindow));
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAppointment = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtPhoneNum = new System.Windows.Forms.TextBox();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTime = new System.Windows.Forms.ComboBox();
            this.txtServiceCategory = new System.Windows.Forms.ComboBox();
            this.txtDentist = new System.Windows.Forms.ComboBox();
            this.txtDate = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvAppointment = new System.Windows.Forms.DataGridView();
            this.dsAppointment = new OraCare.dsAppointment();
            this.dsAppointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAppointment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAppointmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.Color.AliceBlue;
            this.monthCalendar1.Location = new System.Drawing.Point(73, 101);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(16);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.TitleBackColor = System.Drawing.Color.DarkTurquoise;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(147, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 58);
            this.label1.TabIndex = 1;
            this.label1.Text = "Appointments";
            // 
            // btnAppointment
            // 
            this.btnAppointment.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnAppointment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppointment.Font = new System.Drawing.Font("Roboto Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppointment.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnAppointment.Location = new System.Drawing.Point(595, 330);
            this.btnAppointment.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnAppointment.Name = "btnAppointment";
            this.btnAppointment.Size = new System.Drawing.Size(225, 40);
            this.btnAppointment.TabIndex = 2;
            this.btnAppointment.Text = "New appointment";
            this.btnAppointment.UseVisualStyleBackColor = false;
            this.btnAppointment.Click += new System.EventHandler(this.btnAppointment_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(8, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "First  name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(14, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Last name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(17, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Username";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(68, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Age";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(534, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Location = new System.Drawing.Point(532, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 23);
            this.label7.TabIndex = 9;
            this.label7.Text = "Time";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label8.Location = new System.Drawing.Point(517, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 23);
            this.label8.TabIndex = 10;
            this.label8.Text = "Dentist";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label9.Location = new System.Drawing.Point(438, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 23);
            this.label9.TabIndex = 11;
            this.label9.Text = "Service category";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label10.Location = new System.Drawing.Point(7, 252);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 23);
            this.label10.TabIndex = 12;
            this.label10.Text = "Comments";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label11.Location = new System.Drawing.Point(17, 208);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 23);
            this.label11.TabIndex = 13;
            this.label11.Text = "Phone no.";
            // 
            // txtFname
            // 
            this.txtFname.BackColor = System.Drawing.Color.AliceBlue;
            this.txtFname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFname.Enabled = false;
            this.txtFname.Location = new System.Drawing.Point(119, 28);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(230, 30);
            this.txtFname.TabIndex = 14;
            this.txtFname.TextChanged += new System.EventHandler(this.txtFname_TextChanged);
            // 
            // txtLname
            // 
            this.txtLname.BackColor = System.Drawing.Color.AliceBlue;
            this.txtLname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLname.Enabled = false;
            this.txtLname.Location = new System.Drawing.Point(119, 71);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(230, 30);
            this.txtLname.TabIndex = 15;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.AliceBlue;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Enabled = false;
            this.txtUsername.Location = new System.Drawing.Point(119, 114);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(230, 30);
            this.txtUsername.TabIndex = 16;
            // 
            // txtAge
            // 
            this.txtAge.BackColor = System.Drawing.Color.AliceBlue;
            this.txtAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAge.Location = new System.Drawing.Point(119, 159);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(230, 30);
            this.txtAge.TabIndex = 17;
            this.txtAge.TextChanged += new System.EventHandler(this.txtAge_TextChanged);
            this.txtAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAge_KeyPress);
            // 
            // txtPhoneNum
            // 
            this.txtPhoneNum.BackColor = System.Drawing.Color.AliceBlue;
            this.txtPhoneNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhoneNum.Location = new System.Drawing.Point(119, 204);
            this.txtPhoneNum.MaxLength = 11;
            this.txtPhoneNum.Name = "txtPhoneNum";
            this.txtPhoneNum.Size = new System.Drawing.Size(230, 30);
            this.txtPhoneNum.TabIndex = 18;
            this.txtPhoneNum.TextChanged += new System.EventHandler(this.txtPhoneNum_TextChanged);
            this.txtPhoneNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhoneNum_KeyPress_1);
            // 
            // txtComments
            // 
            this.txtComments.BackColor = System.Drawing.Color.AliceBlue;
            this.txtComments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComments.Location = new System.Drawing.Point(120, 249);
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(381, 121);
            this.txtComments.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtTime);
            this.groupBox1.Controls.Add(this.txtServiceCategory);
            this.groupBox1.Controls.Add(this.txtDentist);
            this.groupBox1.Controls.Add(this.txtDate);
            this.groupBox1.Controls.Add(this.txtComments);
            this.groupBox1.Controls.Add(this.txtPhoneNum);
            this.groupBox1.Controls.Add(this.txtAge);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.txtLname);
            this.groupBox1.Controls.Add(this.txtFname);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnAppointment);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.groupBox1.Location = new System.Drawing.Point(389, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(890, 386);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // txtTime
            // 
            this.txtTime.BackColor = System.Drawing.Color.AliceBlue;
            this.txtTime.FormattingEnabled = true;
            this.txtTime.Items.AddRange(new object[] {
            "8:00AM",
            "9:00AM",
            "10:00AM",
            "11:00AM",
            "12:00PM",
            "1:00PM",
            "2:00PM",
            "3:00PM",
            "4:00PM",
            "5:00PM"});
            this.txtTime.Location = new System.Drawing.Point(591, 68);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(231, 31);
            this.txtTime.TabIndex = 27;
            // 
            // txtServiceCategory
            // 
            this.txtServiceCategory.BackColor = System.Drawing.Color.AliceBlue;
            this.txtServiceCategory.FormattingEnabled = true;
            this.txtServiceCategory.Items.AddRange(new object[] {
            "Cleaning",
            "Extraction",
            "Filling"});
            this.txtServiceCategory.Location = new System.Drawing.Point(591, 160);
            this.txtServiceCategory.Name = "txtServiceCategory";
            this.txtServiceCategory.Size = new System.Drawing.Size(231, 31);
            this.txtServiceCategory.TabIndex = 26;
            // 
            // txtDentist
            // 
            this.txtDentist.BackColor = System.Drawing.Color.AliceBlue;
            this.txtDentist.FormattingEnabled = true;
            this.txtDentist.Items.AddRange(new object[] {
            "Jerome Garcia",
            "Kimberly Velasco"});
            this.txtDentist.Location = new System.Drawing.Point(591, 114);
            this.txtDentist.Name = "txtDentist";
            this.txtDentist.Size = new System.Drawing.Size(231, 31);
            this.txtDentist.TabIndex = 25;
            // 
            // txtDate
            // 
            this.txtDate.CalendarMonthBackground = System.Drawing.Color.AliceBlue;
            this.txtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDate.Location = new System.Drawing.Point(591, 23);
            this.txtDate.MinDate = new System.DateTime(2022, 7, 14, 0, 0, 0, 0);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(230, 30);
            this.txtDate.TabIndex = 24;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(71, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dgvAppointment
            // 
            this.dgvAppointment.AllowUserToAddRows = false;
            this.dgvAppointment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAppointment.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointment.GridColor = System.Drawing.SystemColors.ControlText;
            this.dgvAppointment.Location = new System.Drawing.Point(71, 492);
            this.dgvAppointment.Name = "dgvAppointment";
            this.dgvAppointment.Size = new System.Drawing.Size(1208, 215);
            this.dgvAppointment.TabIndex = 28;
            this.dgvAppointment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAppointment_CellContentClick_1);
            // 
            // dsAppointment
            // 
            this.dsAppointment.DataSetName = "dsAppointment";
            this.dsAppointment.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsAppointmentBindingSource
            // 
            this.dsAppointmentBindingSource.DataSource = this.dsAppointment;
            this.dsAppointmentBindingSource.Position = 0;
            // 
            // AppointmentWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.dgvAppointment);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendar1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Roboto Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.AliceBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "AppointmentWindow";
            this.Text = "OraCare";
            this.Load += new System.EventHandler(this.AppointmentWindow_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAppointment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAppointmentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAppointment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtPhoneNum;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox txtServiceCategory;
        private System.Windows.Forms.ComboBox txtDentist;
        private System.Windows.Forms.DateTimePicker txtDate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox txtTime;
        private System.Windows.Forms.DataGridView dgvAppointment;
        private System.Windows.Forms.BindingSource dsAppointmentBindingSource;
        private dsAppointment dsAppointment;
    }
}