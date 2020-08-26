namespace C969
{
	partial class Report
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
			this.radioButton_ByMonthTypes = new System.Windows.Forms.RadioButton();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.radioButton_ByConsultant = new System.Windows.Forms.RadioButton();
			this.radioButton_CustomerAppointments = new System.Windows.Forms.RadioButton();
			this.button_Exit = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioButton_December = new System.Windows.Forms.RadioButton();
			this.radioButton_November = new System.Windows.Forms.RadioButton();
			this.radioButton_October = new System.Windows.Forms.RadioButton();
			this.radioButton_September = new System.Windows.Forms.RadioButton();
			this.radioButton_August = new System.Windows.Forms.RadioButton();
			this.radioButton_July = new System.Windows.Forms.RadioButton();
			this.radioButton_June = new System.Windows.Forms.RadioButton();
			this.radioButton_May = new System.Windows.Forms.RadioButton();
			this.radioButton4 = new System.Windows.Forms.RadioButton();
			this.radioButton_April = new System.Windows.Forms.RadioButton();
			this.radioButton_February = new System.Windows.Forms.RadioButton();
			this.radioButton_January = new System.Windows.Forms.RadioButton();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.radioButton_Consultant2 = new System.Windows.Forms.RadioButton();
			this.radioButton_Consultant1 = new System.Windows.Forms.RadioButton();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.label_DescriptionMonth = new System.Windows.Forms.Label();
			this.label_MonthName = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			this.SuspendLayout();
			// 
			// radioButton_ByMonthTypes
			// 
			this.radioButton_ByMonthTypes.AutoSize = true;
			this.radioButton_ByMonthTypes.Location = new System.Drawing.Point(59, 36);
			this.radioButton_ByMonthTypes.Name = "radioButton_ByMonthTypes";
			this.radioButton_ByMonthTypes.Size = new System.Drawing.Size(163, 21);
			this.radioButton_ByMonthTypes.TabIndex = 0;
			this.radioButton_ByMonthTypes.TabStop = true;
			this.radioButton_ByMonthTypes.Text = "Month (+Type Count)";
			this.radioButton_ByMonthTypes.UseVisualStyleBackColor = true;
			this.radioButton_ByMonthTypes.CheckedChanged += new System.EventHandler(this.radioButton_ByMonthTypes_CheckedChanged);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(59, 204);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(632, 296);
			this.dataGridView1.TabIndex = 1;
			// 
			// radioButton_ByConsultant
			// 
			this.radioButton_ByConsultant.AutoSize = true;
			this.radioButton_ByConsultant.Location = new System.Drawing.Point(59, 63);
			this.radioButton_ByConsultant.Name = "radioButton_ByConsultant";
			this.radioButton_ByConsultant.Size = new System.Drawing.Size(159, 21);
			this.radioButton_ByConsultant.TabIndex = 2;
			this.radioButton_ByConsultant.TabStop = true;
			this.radioButton_ByConsultant.Text = "Consultant Schedule";
			this.radioButton_ByConsultant.UseVisualStyleBackColor = true;
			this.radioButton_ByConsultant.CheckedChanged += new System.EventHandler(this.radioButton_ByConsultant_CheckedChanged);
			// 
			// radioButton_CustomerAppointments
			// 
			this.radioButton_CustomerAppointments.AutoSize = true;
			this.radioButton_CustomerAppointments.Location = new System.Drawing.Point(59, 90);
			this.radioButton_CustomerAppointments.Name = "radioButton_CustomerAppointments";
			this.radioButton_CustomerAppointments.Size = new System.Drawing.Size(268, 21);
			this.radioButton_CustomerAppointments.TabIndex = 3;
			this.radioButton_CustomerAppointments.TabStop = true;
			this.radioButton_CustomerAppointments.Text = "All Appointment Count by Customer ID";
			this.radioButton_CustomerAppointments.UseVisualStyleBackColor = true;
			this.radioButton_CustomerAppointments.CheckedChanged += new System.EventHandler(this.radioButton_ByAppointmentDescription_CheckedChanged);
			// 
			// button_Exit
			// 
			this.button_Exit.AutoSize = true;
			this.button_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_Exit.Location = new System.Drawing.Point(828, 458);
			this.button_Exit.Name = "button_Exit";
			this.button_Exit.Size = new System.Drawing.Size(75, 42);
			this.button_Exit.TabIndex = 4;
			this.button_Exit.Text = "Exit";
			this.button_Exit.UseVisualStyleBackColor = true;
			this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radioButton_December);
			this.groupBox1.Controls.Add(this.radioButton_November);
			this.groupBox1.Controls.Add(this.radioButton_October);
			this.groupBox1.Controls.Add(this.radioButton_September);
			this.groupBox1.Controls.Add(this.radioButton_August);
			this.groupBox1.Controls.Add(this.radioButton_July);
			this.groupBox1.Controls.Add(this.radioButton_June);
			this.groupBox1.Controls.Add(this.radioButton_May);
			this.groupBox1.Controls.Add(this.radioButton4);
			this.groupBox1.Controls.Add(this.radioButton_April);
			this.groupBox1.Controls.Add(this.radioButton_February);
			this.groupBox1.Controls.Add(this.radioButton_January);
			this.groupBox1.Location = new System.Drawing.Point(363, 15);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(387, 166);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// radioButton_December
			// 
			this.radioButton_December.AutoSize = true;
			this.radioButton_December.Location = new System.Drawing.Point(252, 121);
			this.radioButton_December.Name = "radioButton_December";
			this.radioButton_December.Size = new System.Drawing.Size(94, 21);
			this.radioButton_December.TabIndex = 11;
			this.radioButton_December.TabStop = true;
			this.radioButton_December.Text = "December";
			this.radioButton_December.UseVisualStyleBackColor = true;
			this.radioButton_December.CheckedChanged += new System.EventHandler(this.radioButton_December_CheckedChanged);
			// 
			// radioButton_November
			// 
			this.radioButton_November.AutoSize = true;
			this.radioButton_November.Location = new System.Drawing.Point(252, 90);
			this.radioButton_November.Name = "radioButton_November";
			this.radioButton_November.Size = new System.Drawing.Size(94, 21);
			this.radioButton_November.TabIndex = 10;
			this.radioButton_November.TabStop = true;
			this.radioButton_November.Text = "November";
			this.radioButton_November.UseVisualStyleBackColor = true;
			this.radioButton_November.CheckedChanged += new System.EventHandler(this.radioButton_November_CheckedChanged);
			// 
			// radioButton_October
			// 
			this.radioButton_October.AutoSize = true;
			this.radioButton_October.Location = new System.Drawing.Point(252, 59);
			this.radioButton_October.Name = "radioButton_October";
			this.radioButton_October.Size = new System.Drawing.Size(80, 21);
			this.radioButton_October.TabIndex = 9;
			this.radioButton_October.TabStop = true;
			this.radioButton_October.Text = "October";
			this.radioButton_October.UseVisualStyleBackColor = true;
			this.radioButton_October.CheckedChanged += new System.EventHandler(this.radioButton_October_CheckedChanged);
			// 
			// radioButton_September
			// 
			this.radioButton_September.AutoSize = true;
			this.radioButton_September.Location = new System.Drawing.Point(252, 28);
			this.radioButton_September.Name = "radioButton_September";
			this.radioButton_September.Size = new System.Drawing.Size(98, 21);
			this.radioButton_September.TabIndex = 8;
			this.radioButton_September.TabStop = true;
			this.radioButton_September.Text = "September";
			this.radioButton_September.UseVisualStyleBackColor = true;
			this.radioButton_September.CheckedChanged += new System.EventHandler(this.radioButton9_CheckedChanged);
			// 
			// radioButton_August
			// 
			this.radioButton_August.AutoSize = true;
			this.radioButton_August.Location = new System.Drawing.Point(128, 121);
			this.radioButton_August.Name = "radioButton_August";
			this.radioButton_August.Size = new System.Drawing.Size(73, 21);
			this.radioButton_August.TabIndex = 7;
			this.radioButton_August.TabStop = true;
			this.radioButton_August.Text = "August";
			this.radioButton_August.UseVisualStyleBackColor = true;
			this.radioButton_August.CheckedChanged += new System.EventHandler(this.radioButton_August_CheckedChanged);
			// 
			// radioButton_July
			// 
			this.radioButton_July.AutoSize = true;
			this.radioButton_July.Location = new System.Drawing.Point(128, 90);
			this.radioButton_July.Name = "radioButton_July";
			this.radioButton_July.Size = new System.Drawing.Size(54, 21);
			this.radioButton_July.TabIndex = 6;
			this.radioButton_July.TabStop = true;
			this.radioButton_July.Text = "July";
			this.radioButton_July.UseVisualStyleBackColor = true;
			this.radioButton_July.CheckedChanged += new System.EventHandler(this.radioButton_July_CheckedChanged);
			// 
			// radioButton_June
			// 
			this.radioButton_June.AutoSize = true;
			this.radioButton_June.Location = new System.Drawing.Point(128, 59);
			this.radioButton_June.Name = "radioButton_June";
			this.radioButton_June.Size = new System.Drawing.Size(60, 21);
			this.radioButton_June.TabIndex = 5;
			this.radioButton_June.TabStop = true;
			this.radioButton_June.Text = "June";
			this.radioButton_June.UseVisualStyleBackColor = true;
			this.radioButton_June.CheckedChanged += new System.EventHandler(this.radioButton_June_CheckedChanged);
			// 
			// radioButton_May
			// 
			this.radioButton_May.AutoSize = true;
			this.radioButton_May.Location = new System.Drawing.Point(128, 28);
			this.radioButton_May.Name = "radioButton_May";
			this.radioButton_May.Size = new System.Drawing.Size(55, 21);
			this.radioButton_May.TabIndex = 4;
			this.radioButton_May.TabStop = true;
			this.radioButton_May.Text = "May";
			this.radioButton_May.UseVisualStyleBackColor = true;
			this.radioButton_May.CheckedChanged += new System.EventHandler(this.radioButton_May_CheckedChanged);
			// 
			// radioButton4
			// 
			this.radioButton4.AutoSize = true;
			this.radioButton4.Location = new System.Drawing.Point(6, 121);
			this.radioButton4.Name = "radioButton4";
			this.radioButton4.Size = new System.Drawing.Size(57, 21);
			this.radioButton4.TabIndex = 3;
			this.radioButton4.TabStop = true;
			this.radioButton4.Text = "April";
			this.radioButton4.UseVisualStyleBackColor = true;
			this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
			// 
			// radioButton_April
			// 
			this.radioButton_April.AutoSize = true;
			this.radioButton_April.Location = new System.Drawing.Point(6, 90);
			this.radioButton_April.Name = "radioButton_April";
			this.radioButton_April.Size = new System.Drawing.Size(68, 21);
			this.radioButton_April.TabIndex = 2;
			this.radioButton_April.TabStop = true;
			this.radioButton_April.Text = "March";
			this.radioButton_April.UseVisualStyleBackColor = true;
			this.radioButton_April.CheckedChanged += new System.EventHandler(this.radioButton_March_CheckedChanged);
			// 
			// radioButton_February
			// 
			this.radioButton_February.AutoSize = true;
			this.radioButton_February.Location = new System.Drawing.Point(6, 59);
			this.radioButton_February.Name = "radioButton_February";
			this.radioButton_February.Size = new System.Drawing.Size(86, 21);
			this.radioButton_February.TabIndex = 1;
			this.radioButton_February.TabStop = true;
			this.radioButton_February.Text = "February";
			this.radioButton_February.UseVisualStyleBackColor = true;
			this.radioButton_February.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
			// 
			// radioButton_January
			// 
			this.radioButton_January.AutoSize = true;
			this.radioButton_January.Location = new System.Drawing.Point(6, 28);
			this.radioButton_January.Name = "radioButton_January";
			this.radioButton_January.Size = new System.Drawing.Size(80, 21);
			this.radioButton_January.TabIndex = 0;
			this.radioButton_January.TabStop = true;
			this.radioButton_January.Text = "January";
			this.radioButton_January.UseVisualStyleBackColor = true;
			this.radioButton_January.CheckedChanged += new System.EventHandler(this.radioButton_January_CheckedChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.radioButton_Consultant2);
			this.groupBox2.Controls.Add(this.radioButton_Consultant1);
			this.groupBox2.Location = new System.Drawing.Point(357, 15);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(387, 166);
			this.groupBox2.TabIndex = 8;
			this.groupBox2.TabStop = false;
			this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
			// 
			// radioButton_Consultant2
			// 
			this.radioButton_Consultant2.AutoSize = true;
			this.radioButton_Consultant2.Location = new System.Drawing.Point(6, 57);
			this.radioButton_Consultant2.Name = "radioButton_Consultant2";
			this.radioButton_Consultant2.Size = new System.Drawing.Size(108, 21);
			this.radioButton_Consultant2.TabIndex = 1;
			this.radioButton_Consultant2.TabStop = true;
			this.radioButton_Consultant2.Text = "Consultant 2";
			this.radioButton_Consultant2.UseVisualStyleBackColor = true;
			this.radioButton_Consultant2.CheckedChanged += new System.EventHandler(this.radioButton_Consultant2_CheckedChanged);
			// 
			// radioButton_Consultant1
			// 
			this.radioButton_Consultant1.AutoSize = true;
			this.radioButton_Consultant1.Location = new System.Drawing.Point(6, 28);
			this.radioButton_Consultant1.Name = "radioButton_Consultant1";
			this.radioButton_Consultant1.Size = new System.Drawing.Size(108, 21);
			this.radioButton_Consultant1.TabIndex = 0;
			this.radioButton_Consultant1.TabStop = true;
			this.radioButton_Consultant1.Text = "Consultant 1";
			this.radioButton_Consultant1.UseVisualStyleBackColor = true;
			this.radioButton_Consultant1.CheckedChanged += new System.EventHandler(this.radioButton_Consultant1_CheckedChanged);
			// 
			// dataGridView2
			// 
			this.dataGridView2.AllowUserToAddRows = false;
			this.dataGridView2.AllowUserToDeleteRows = false;
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Location = new System.Drawing.Point(735, 204);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.ReadOnly = true;
			this.dataGridView2.RowHeadersVisible = false;
			this.dataGridView2.RowHeadersWidth = 51;
			this.dataGridView2.RowTemplate.Height = 24;
			this.dataGridView2.Size = new System.Drawing.Size(333, 195);
			this.dataGridView2.TabIndex = 9;
			// 
			// label_DescriptionMonth
			// 
			this.label_DescriptionMonth.AutoSize = true;
			this.label_DescriptionMonth.Location = new System.Drawing.Point(67, 184);
			this.label_DescriptionMonth.Name = "label_DescriptionMonth";
			this.label_DescriptionMonth.Size = new System.Drawing.Size(202, 17);
			this.label_DescriptionMonth.TabIndex = 10;
			this.label_DescriptionMonth.Text = "Appointments for the month of:";
			// 
			// label_MonthName
			// 
			this.label_MonthName.AutoSize = true;
			this.label_MonthName.Location = new System.Drawing.Point(264, 184);
			this.label_MonthName.Name = "label_MonthName";
			this.label_MonthName.Size = new System.Drawing.Size(0, 17);
			this.label_MonthName.TabIndex = 11;
			// 
			// groupBox3
			// 
			this.groupBox3.Location = new System.Drawing.Point(1006, 81);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(200, 100);
			this.groupBox3.TabIndex = 12;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "groupBox3";
			// 
			// Report
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1108, 523);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.label_MonthName);
			this.Controls.Add(this.label_DescriptionMonth);
			this.Controls.Add(this.dataGridView2);
			this.Controls.Add(this.radioButton_CustomerAppointments);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.button_Exit);
			this.Controls.Add(this.radioButton_ByConsultant);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.radioButton_ByMonthTypes);
			this.Name = "Report";
			this.Text = "Report";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RadioButton radioButton_ByMonthTypes;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.RadioButton radioButton_ByConsultant;
		private System.Windows.Forms.RadioButton radioButton_CustomerAppointments;
		private System.Windows.Forms.Button button_Exit;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioButton_December;
		private System.Windows.Forms.RadioButton radioButton_November;
		private System.Windows.Forms.RadioButton radioButton_October;
		private System.Windows.Forms.RadioButton radioButton_September;
		private System.Windows.Forms.RadioButton radioButton_August;
		private System.Windows.Forms.RadioButton radioButton_July;
		private System.Windows.Forms.RadioButton radioButton_June;
		private System.Windows.Forms.RadioButton radioButton_May;
		private System.Windows.Forms.RadioButton radioButton4;
		private System.Windows.Forms.RadioButton radioButton_April;
		private System.Windows.Forms.RadioButton radioButton_February;
		private System.Windows.Forms.RadioButton radioButton_January;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton radioButton_Consultant2;
		private System.Windows.Forms.RadioButton radioButton_Consultant1;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.Label label_DescriptionMonth;
		private System.Windows.Forms.Label label_MonthName;
		private System.Windows.Forms.GroupBox groupBox3;
	}
}