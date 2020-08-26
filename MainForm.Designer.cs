namespace C969
{
	partial class MainForm
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
			this.dataGridView_Customers = new System.Windows.Forms.DataGridView();
			this.dataGridView_Appointments = new System.Windows.Forms.DataGridView();
			this.button_CalendarViewer = new System.Windows.Forms.Button();
			this.button_Log_Out = new System.Windows.Forms.Button();
			this.label_Appointments = new System.Windows.Forms.Label();
			this.label_Customers = new System.Windows.Forms.Label();
			this.button_Appointments_Delete = new System.Windows.Forms.Button();
			this.button_Appointments_Modify = new System.Windows.Forms.Button();
			this.button_Appointments_Add = new System.Windows.Forms.Button();
			this.button_Customers_Add = new System.Windows.Forms.Button();
			this.button_Customers_Modify = new System.Windows.Forms.Button();
			this.button_Customers_Delete = new System.Windows.Forms.Button();
			this.radioButton_Week = new System.Windows.Forms.RadioButton();
			this.radioButton_Month = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.radioButton_AllAppointments = new System.Windows.Forms.RadioButton();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Customers)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Appointments)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView_Customers
			// 
			this.dataGridView_Customers.AllowUserToAddRows = false;
			this.dataGridView_Customers.AllowUserToDeleteRows = false;
			this.dataGridView_Customers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView_Customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_Customers.Location = new System.Drawing.Point(32, 456);
			this.dataGridView_Customers.MultiSelect = false;
			this.dataGridView_Customers.Name = "dataGridView_Customers";
			this.dataGridView_Customers.ReadOnly = true;
			this.dataGridView_Customers.RowHeadersWidth = 51;
			this.dataGridView_Customers.RowTemplate.Height = 24;
			this.dataGridView_Customers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView_Customers.Size = new System.Drawing.Size(993, 333);
			this.dataGridView_Customers.TabIndex = 0;
			this.dataGridView_Customers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Customers_CellClick);
			this.dataGridView_Customers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Customers_CellContentClick);
			// 
			// dataGridView_Appointments
			// 
			this.dataGridView_Appointments.AllowUserToAddRows = false;
			this.dataGridView_Appointments.AllowUserToDeleteRows = false;
			this.dataGridView_Appointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView_Appointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_Appointments.Location = new System.Drawing.Point(32, 60);
			this.dataGridView_Appointments.MultiSelect = false;
			this.dataGridView_Appointments.Name = "dataGridView_Appointments";
			this.dataGridView_Appointments.ReadOnly = true;
			this.dataGridView_Appointments.RowHeadersWidth = 51;
			this.dataGridView_Appointments.RowTemplate.Height = 24;
			this.dataGridView_Appointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView_Appointments.Size = new System.Drawing.Size(1504, 292);
			this.dataGridView_Appointments.TabIndex = 1;
			this.dataGridView_Appointments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Appointments_CellClick);
			this.dataGridView_Appointments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Appointments_CellContentClick);
			// 
			// button_CalendarViewer
			// 
			this.button_CalendarViewer.Location = new System.Drawing.Point(1151, 527);
			this.button_CalendarViewer.Name = "button_CalendarViewer";
			this.button_CalendarViewer.Size = new System.Drawing.Size(156, 56);
			this.button_CalendarViewer.TabIndex = 2;
			this.button_CalendarViewer.Text = "Calendar Viewer";
			this.button_CalendarViewer.UseVisualStyleBackColor = true;
			this.button_CalendarViewer.Click += new System.EventHandler(this.button1_Click);
			// 
			// button_Log_Out
			// 
			this.button_Log_Out.Location = new System.Drawing.Point(1258, 779);
			this.button_Log_Out.Name = "button_Log_Out";
			this.button_Log_Out.Size = new System.Drawing.Size(156, 56);
			this.button_Log_Out.TabIndex = 4;
			this.button_Log_Out.Text = "Log Out";
			this.button_Log_Out.UseVisualStyleBackColor = true;
			this.button_Log_Out.Click += new System.EventHandler(this.button_Log_Out_Click);
			// 
			// label_Appointments
			// 
			this.label_Appointments.AutoSize = true;
			this.label_Appointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_Appointments.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label_Appointments.Location = new System.Drawing.Point(111, 18);
			this.label_Appointments.Name = "label_Appointments";
			this.label_Appointments.Size = new System.Drawing.Size(216, 38);
			this.label_Appointments.TabIndex = 8;
			this.label_Appointments.Text = "Appointments";
			this.label_Appointments.Click += new System.EventHandler(this.label1_Click);
			// 
			// label_Customers
			// 
			this.label_Customers.AutoSize = true;
			this.label_Customers.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_Customers.Location = new System.Drawing.Point(111, 414);
			this.label_Customers.Name = "label_Customers";
			this.label_Customers.Size = new System.Drawing.Size(176, 38);
			this.label_Customers.TabIndex = 9;
			this.label_Customers.Text = "Customers";
			this.label_Customers.Click += new System.EventHandler(this.label2_Click);
			// 
			// button_Appointments_Delete
			// 
			this.button_Appointments_Delete.Location = new System.Drawing.Point(512, 358);
			this.button_Appointments_Delete.Name = "button_Appointments_Delete";
			this.button_Appointments_Delete.Size = new System.Drawing.Size(75, 41);
			this.button_Appointments_Delete.TabIndex = 11;
			this.button_Appointments_Delete.Text = "Delete";
			this.button_Appointments_Delete.UseVisualStyleBackColor = true;
			this.button_Appointments_Delete.Click += new System.EventHandler(this.button_Appointments_Delete_Click);
			// 
			// button_Appointments_Modify
			// 
			this.button_Appointments_Modify.Location = new System.Drawing.Point(415, 358);
			this.button_Appointments_Modify.Name = "button_Appointments_Modify";
			this.button_Appointments_Modify.Size = new System.Drawing.Size(75, 41);
			this.button_Appointments_Modify.TabIndex = 15;
			this.button_Appointments_Modify.Text = "Modify";
			this.button_Appointments_Modify.UseVisualStyleBackColor = true;
			this.button_Appointments_Modify.Click += new System.EventHandler(this.button_Appointments_Modify_Click);
			// 
			// button_Appointments_Add
			// 
			this.button_Appointments_Add.Location = new System.Drawing.Point(318, 357);
			this.button_Appointments_Add.Name = "button_Appointments_Add";
			this.button_Appointments_Add.Size = new System.Drawing.Size(75, 41);
			this.button_Appointments_Add.TabIndex = 16;
			this.button_Appointments_Add.Text = "Add";
			this.button_Appointments_Add.UseVisualStyleBackColor = true;
			this.button_Appointments_Add.Click += new System.EventHandler(this.button_Appointments_Add_Click);
			// 
			// button_Customers_Add
			// 
			this.button_Customers_Add.Location = new System.Drawing.Point(318, 794);
			this.button_Customers_Add.Name = "button_Customers_Add";
			this.button_Customers_Add.Size = new System.Drawing.Size(75, 41);
			this.button_Customers_Add.TabIndex = 19;
			this.button_Customers_Add.Text = "Add";
			this.button_Customers_Add.UseVisualStyleBackColor = true;
			this.button_Customers_Add.Click += new System.EventHandler(this.button_Customers_Add_Click);
			// 
			// button_Customers_Modify
			// 
			this.button_Customers_Modify.Location = new System.Drawing.Point(415, 795);
			this.button_Customers_Modify.Name = "button_Customers_Modify";
			this.button_Customers_Modify.Size = new System.Drawing.Size(75, 41);
			this.button_Customers_Modify.TabIndex = 18;
			this.button_Customers_Modify.Text = "Modify";
			this.button_Customers_Modify.UseVisualStyleBackColor = true;
			this.button_Customers_Modify.Click += new System.EventHandler(this.button_Customers_Modify_Click);
			// 
			// button_Customers_Delete
			// 
			this.button_Customers_Delete.Location = new System.Drawing.Point(512, 795);
			this.button_Customers_Delete.Name = "button_Customers_Delete";
			this.button_Customers_Delete.Size = new System.Drawing.Size(75, 41);
			this.button_Customers_Delete.TabIndex = 17;
			this.button_Customers_Delete.Text = "Delete";
			this.button_Customers_Delete.UseVisualStyleBackColor = true;
			this.button_Customers_Delete.Click += new System.EventHandler(this.button_Customers_Delete_Click);
			// 
			// radioButton_Week
			// 
			this.radioButton_Week.AutoSize = true;
			this.radioButton_Week.Location = new System.Drawing.Point(743, 378);
			this.radioButton_Week.Name = "radioButton_Week";
			this.radioButton_Week.Size = new System.Drawing.Size(96, 21);
			this.radioButton_Week.TabIndex = 20;
			this.radioButton_Week.TabStop = true;
			this.radioButton_Week.Text = "This Week";
			this.radioButton_Week.UseVisualStyleBackColor = true;
			this.radioButton_Week.CheckedChanged += new System.EventHandler(this.radioButton_Week_CheckedChanged);
			// 
			// radioButton_Month
			// 
			this.radioButton_Month.AutoSize = true;
			this.radioButton_Month.Location = new System.Drawing.Point(743, 399);
			this.radioButton_Month.Name = "radioButton_Month";
			this.radioButton_Month.Size = new System.Drawing.Size(99, 21);
			this.radioButton_Month.TabIndex = 21;
			this.radioButton_Month.TabStop = true;
			this.radioButton_Month.Text = "This Month";
			this.radioButton_Month.UseVisualStyleBackColor = true;
			this.radioButton_Month.CheckedChanged += new System.EventHandler(this.radioButton_Month_CheckedChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(660, 370);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 17);
			this.label1.TabIndex = 22;
			this.label1.Text = "View by:";
			// 
			// radioButton_AllAppointments
			// 
			this.radioButton_AllAppointments.AutoSize = true;
			this.radioButton_AllAppointments.Location = new System.Drawing.Point(743, 357);
			this.radioButton_AllAppointments.Name = "radioButton_AllAppointments";
			this.radioButton_AllAppointments.Size = new System.Drawing.Size(134, 21);
			this.radioButton_AllAppointments.TabIndex = 23;
			this.radioButton_AllAppointments.TabStop = true;
			this.radioButton_AllAppointments.Text = "All Appointments";
			this.radioButton_AllAppointments.UseVisualStyleBackColor = true;
			this.radioButton_AllAppointments.CheckedChanged += new System.EventHandler(this.radioButton_AllAppointments_CheckedChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(293, 401);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(135, 17);
			this.label2.TabIndex = 24;
			this.label2.Text = "(by customer below)";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1548, 883);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.radioButton_AllAppointments);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.radioButton_Month);
			this.Controls.Add(this.radioButton_Week);
			this.Controls.Add(this.button_Customers_Add);
			this.Controls.Add(this.button_Customers_Modify);
			this.Controls.Add(this.button_Customers_Delete);
			this.Controls.Add(this.button_Appointments_Add);
			this.Controls.Add(this.button_Appointments_Modify);
			this.Controls.Add(this.button_Appointments_Delete);
			this.Controls.Add(this.label_Customers);
			this.Controls.Add(this.label_Appointments);
			this.Controls.Add(this.button_Log_Out);
			this.Controls.Add(this.button_CalendarViewer);
			this.Controls.Add(this.dataGridView_Appointments);
			this.Controls.Add(this.dataGridView_Customers);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MainForm";
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Customers)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Appointments)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView_Customers;
		private System.Windows.Forms.DataGridView dataGridView_Appointments;
		private System.Windows.Forms.Button button_CalendarViewer;
		private System.Windows.Forms.Button button_Log_Out;
		private System.Windows.Forms.Label label_Appointments;
		private System.Windows.Forms.Label label_Customers;
		private System.Windows.Forms.Button button_Appointments_Delete;
		private System.Windows.Forms.Button button_Appointments_Modify;
		private System.Windows.Forms.Button button_Appointments_Add;
		private System.Windows.Forms.Button button_Customers_Add;
		private System.Windows.Forms.Button button_Customers_Modify;
		private System.Windows.Forms.Button button_Customers_Delete;
		private System.Windows.Forms.RadioButton radioButton_Week;
		private System.Windows.Forms.RadioButton radioButton_Month;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton radioButton_AllAppointments;
		private System.Windows.Forms.Label label2;
	}
}

