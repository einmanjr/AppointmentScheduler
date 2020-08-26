namespace C969
{
	partial class ModifyAppointment
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
			this.button_Save = new System.Windows.Forms.Button();
			this.button_Cancel = new System.Windows.Forms.Button();
			this.label_ModifyAppointment = new System.Windows.Forms.Label();
			this.listBox_Type = new System.Windows.Forms.ListBox();
			this.dateTimePicker_EndTime = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker_StartTime = new System.Windows.Forms.DateTimePicker();
			this.textBox_Description = new System.Windows.Forms.TextBox();
			this.textBox_CustomerID = new System.Windows.Forms.TextBox();
			this.label_Start = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label_Type = new System.Windows.Forms.Label();
			this.label_Description = new System.Windows.Forms.Label();
			this.label_CustomerID = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button_Save
			// 
			this.button_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_Save.Location = new System.Drawing.Point(275, 632);
			this.button_Save.Name = "button_Save";
			this.button_Save.Size = new System.Drawing.Size(90, 42);
			this.button_Save.TabIndex = 51;
			this.button_Save.Text = "Save";
			this.button_Save.UseVisualStyleBackColor = true;
			this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
			// 
			// button_Cancel
			// 
			this.button_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_Cancel.Location = new System.Drawing.Point(421, 632);
			this.button_Cancel.Name = "button_Cancel";
			this.button_Cancel.Size = new System.Drawing.Size(90, 42);
			this.button_Cancel.TabIndex = 50;
			this.button_Cancel.Text = "Cancel";
			this.button_Cancel.UseVisualStyleBackColor = true;
			this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
			// 
			// label_ModifyAppointment
			// 
			this.label_ModifyAppointment.AutoSize = true;
			this.label_ModifyAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_ModifyAppointment.Location = new System.Drawing.Point(229, 56);
			this.label_ModifyAppointment.Name = "label_ModifyAppointment";
			this.label_ModifyAppointment.Size = new System.Drawing.Size(304, 38);
			this.label_ModifyAppointment.TabIndex = 49;
			this.label_ModifyAppointment.Text = "Modify Appointment";
			// 
			// listBox_Type
			// 
			this.listBox_Type.DisplayMember = "crayons";
			this.listBox_Type.FormattingEnabled = true;
			this.listBox_Type.ItemHeight = 16;
			this.listBox_Type.Items.AddRange(new object[] {
            "Consultation",
            "Referral",
            "Appraisal",
            "ACTION!"});
			this.listBox_Type.Location = new System.Drawing.Point(349, 329);
			this.listBox_Type.Name = "listBox_Type";
			this.listBox_Type.Size = new System.Drawing.Size(212, 20);
			this.listBox_Type.TabIndex = 180;
			// 
			// dateTimePicker_EndTime
			// 
			this.dateTimePicker_EndTime.CustomFormat = "MM/dd/yyyy HH:mm";
			this.dateTimePicker_EndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker_EndTime.Location = new System.Drawing.Point(355, 477);
			this.dateTimePicker_EndTime.Margin = new System.Windows.Forms.Padding(4);
			this.dateTimePicker_EndTime.Name = "dateTimePicker_EndTime";
			this.dateTimePicker_EndTime.Size = new System.Drawing.Size(206, 22);
			this.dateTimePicker_EndTime.TabIndex = 179;
			this.dateTimePicker_EndTime.Value = new System.DateTime(2020, 2, 1, 17, 0, 0, 0);
			this.dateTimePicker_EndTime.ValueChanged += new System.EventHandler(this.dateTimePicker_EndTime_ValueChanged_1);
			// 
			// dateTimePicker_StartTime
			// 
			this.dateTimePicker_StartTime.CustomFormat = "MM/dd/yyyy HH:mm";
			this.dateTimePicker_StartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker_StartTime.Location = new System.Drawing.Point(355, 402);
			this.dateTimePicker_StartTime.Margin = new System.Windows.Forms.Padding(4);
			this.dateTimePicker_StartTime.Name = "dateTimePicker_StartTime";
			this.dateTimePicker_StartTime.Size = new System.Drawing.Size(206, 22);
			this.dateTimePicker_StartTime.TabIndex = 178;
			this.dateTimePicker_StartTime.Value = new System.DateTime(2020, 2, 1, 9, 0, 0, 0);
			this.dateTimePicker_StartTime.ValueChanged += new System.EventHandler(this.dateTimePicker_StartTime_ValueChanged_1);
			// 
			// textBox_Description
			// 
			this.textBox_Description.Location = new System.Drawing.Point(355, 254);
			this.textBox_Description.Name = "textBox_Description";
			this.textBox_Description.Size = new System.Drawing.Size(206, 22);
			this.textBox_Description.TabIndex = 177;
			// 
			// textBox_CustomerID
			// 
			this.textBox_CustomerID.Location = new System.Drawing.Point(355, 179);
			this.textBox_CustomerID.Name = "textBox_CustomerID";
			this.textBox_CustomerID.Size = new System.Drawing.Size(206, 22);
			this.textBox_CustomerID.TabIndex = 176;
			// 
			// label_Start
			// 
			this.label_Start.AutoSize = true;
			this.label_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_Start.Location = new System.Drawing.Point(222, 404);
			this.label_Start.Name = "label_Start";
			this.label_Start.Size = new System.Drawing.Size(87, 20);
			this.label_Start.TabIndex = 175;
			this.label_Start.Text = "Start Time";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(221, 479);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 20);
			this.label1.TabIndex = 174;
			this.label1.Text = "End Time";
			// 
			// label_Type
			// 
			this.label_Type.AutoSize = true;
			this.label_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_Type.Location = new System.Drawing.Point(222, 329);
			this.label_Type.Name = "label_Type";
			this.label_Type.Size = new System.Drawing.Size(45, 20);
			this.label_Type.TabIndex = 173;
			this.label_Type.Text = "Type";
			// 
			// label_Description
			// 
			this.label_Description.AutoSize = true;
			this.label_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_Description.Location = new System.Drawing.Point(222, 254);
			this.label_Description.Name = "label_Description";
			this.label_Description.Size = new System.Drawing.Size(95, 20);
			this.label_Description.TabIndex = 172;
			this.label_Description.Text = "Description";
			// 
			// label_CustomerID
			// 
			this.label_CustomerID.AutoSize = true;
			this.label_CustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_CustomerID.Location = new System.Drawing.Point(221, 179);
			this.label_CustomerID.Name = "label_CustomerID";
			this.label_CustomerID.Size = new System.Drawing.Size(104, 20);
			this.label_CustomerID.TabIndex = 171;
			this.label_CustomerID.Text = "Customer ID";
			// 
			// ModifyAppointment
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 779);
			this.Controls.Add(this.listBox_Type);
			this.Controls.Add(this.dateTimePicker_EndTime);
			this.Controls.Add(this.dateTimePicker_StartTime);
			this.Controls.Add(this.textBox_Description);
			this.Controls.Add(this.textBox_CustomerID);
			this.Controls.Add(this.label_Start);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label_Type);
			this.Controls.Add(this.label_Description);
			this.Controls.Add(this.label_CustomerID);
			this.Controls.Add(this.button_Save);
			this.Controls.Add(this.button_Cancel);
			this.Controls.Add(this.label_ModifyAppointment);
			this.Name = "ModifyAppointment";
			this.Text = "ModifyAppointment";
			this.Load += new System.EventHandler(this.ModifyAppointment_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button button_Save;
		private System.Windows.Forms.Button button_Cancel;
		private System.Windows.Forms.Label label_ModifyAppointment;
		private System.Windows.Forms.ListBox listBox_Type;
		private System.Windows.Forms.DateTimePicker dateTimePicker_EndTime;
		private System.Windows.Forms.DateTimePicker dateTimePicker_StartTime;
		private System.Windows.Forms.TextBox textBox_Description;
		private System.Windows.Forms.TextBox textBox_CustomerID;
		private System.Windows.Forms.Label label_Start;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label_Type;
		private System.Windows.Forms.Label label_Description;
		private System.Windows.Forms.Label label_CustomerID;
	}
}