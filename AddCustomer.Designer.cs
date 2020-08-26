namespace C969
{
	partial class AddCustomer
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
			this.label_AddCustomer = new System.Windows.Forms.Label();
			this.label_CustomerName = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.textBox_CustomerName = new System.Windows.Forms.TextBox();
			this.textBox_AddressLine1 = new System.Windows.Forms.TextBox();
			this.textBox_AddressLine2 = new System.Windows.Forms.TextBox();
			this.textBox_ZipCode = new System.Windows.Forms.TextBox();
			this.textBox_PhoneNumber = new System.Windows.Forms.TextBox();
			this.button_Save = new System.Windows.Forms.Button();
			this.button_Cancel = new System.Windows.Forms.Button();
			this.listBox_CityID = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// label_AddCustomer
			// 
			this.label_AddCustomer.AutoSize = true;
			this.label_AddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_AddCustomer.Location = new System.Drawing.Point(250, 46);
			this.label_AddCustomer.Name = "label_AddCustomer";
			this.label_AddCustomer.Size = new System.Drawing.Size(226, 38);
			this.label_AddCustomer.TabIndex = 0;
			this.label_AddCustomer.Text = "Add Customer";
			// 
			// label_CustomerName
			// 
			this.label_CustomerName.AutoSize = true;
			this.label_CustomerName.Location = new System.Drawing.Point(206, 147);
			this.label_CustomerName.Name = "label_CustomerName";
			this.label_CustomerName.Size = new System.Drawing.Size(109, 17);
			this.label_CustomerName.TabIndex = 2;
			this.label_CustomerName.Text = "Customer Name";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(206, 200);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(111, 17);
			this.label4.TabIndex = 3;
			this.label4.Text = "Address Line #1";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(206, 253);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(111, 17);
			this.label5.TabIndex = 4;
			this.label5.Text = "Address Line #2";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(206, 304);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(31, 17);
			this.label6.TabIndex = 5;
			this.label6.Text = "City";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(206, 357);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(65, 17);
			this.label8.TabIndex = 7;
			this.label8.Text = "Zip Code";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(206, 410);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(103, 17);
			this.label9.TabIndex = 8;
			this.label9.Text = "Phone Number";
			// 
			// textBox_CustomerName
			// 
			this.textBox_CustomerName.Location = new System.Drawing.Point(342, 147);
			this.textBox_CustomerName.Name = "textBox_CustomerName";
			this.textBox_CustomerName.Size = new System.Drawing.Size(214, 22);
			this.textBox_CustomerName.TabIndex = 11;
			// 
			// textBox_AddressLine1
			// 
			this.textBox_AddressLine1.Location = new System.Drawing.Point(342, 200);
			this.textBox_AddressLine1.Name = "textBox_AddressLine1";
			this.textBox_AddressLine1.Size = new System.Drawing.Size(214, 22);
			this.textBox_AddressLine1.TabIndex = 12;
			this.textBox_AddressLine1.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
			// 
			// textBox_AddressLine2
			// 
			this.textBox_AddressLine2.Location = new System.Drawing.Point(342, 253);
			this.textBox_AddressLine2.Name = "textBox_AddressLine2";
			this.textBox_AddressLine2.Size = new System.Drawing.Size(214, 22);
			this.textBox_AddressLine2.TabIndex = 13;
			// 
			// textBox_ZipCode
			// 
			this.textBox_ZipCode.Location = new System.Drawing.Point(342, 357);
			this.textBox_ZipCode.Name = "textBox_ZipCode";
			this.textBox_ZipCode.Size = new System.Drawing.Size(214, 22);
			this.textBox_ZipCode.TabIndex = 15;
			// 
			// textBox_PhoneNumber
			// 
			this.textBox_PhoneNumber.Location = new System.Drawing.Point(342, 410);
			this.textBox_PhoneNumber.Name = "textBox_PhoneNumber";
			this.textBox_PhoneNumber.Size = new System.Drawing.Size(214, 22);
			this.textBox_PhoneNumber.TabIndex = 16;
			// 
			// button_Save
			// 
			this.button_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_Save.Location = new System.Drawing.Point(260, 549);
			this.button_Save.Name = "button_Save";
			this.button_Save.Size = new System.Drawing.Size(90, 42);
			this.button_Save.TabIndex = 25;
			this.button_Save.Text = "Save";
			this.button_Save.UseVisualStyleBackColor = true;
			this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
			// 
			// button_Cancel
			// 
			this.button_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_Cancel.Location = new System.Drawing.Point(406, 549);
			this.button_Cancel.Name = "button_Cancel";
			this.button_Cancel.Size = new System.Drawing.Size(90, 42);
			this.button_Cancel.TabIndex = 24;
			this.button_Cancel.Text = "Cancel";
			this.button_Cancel.UseVisualStyleBackColor = true;
			this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
			// 
			// listBox_CityID
			// 
			this.listBox_CityID.FormattingEnabled = true;
			this.listBox_CityID.ItemHeight = 16;
			this.listBox_CityID.Items.AddRange(new object[] {
            "New York",
            "Los Angeles",
            "Toronto",
            "Vancouver",
            "Oslo"});
			this.listBox_CityID.Location = new System.Drawing.Point(342, 306);
			this.listBox_CityID.Name = "listBox_CityID";
			this.listBox_CityID.Size = new System.Drawing.Size(214, 20);
			this.listBox_CityID.TabIndex = 28;
			this.listBox_CityID.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// AddCustomer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 613);
			this.Controls.Add(this.listBox_CityID);
			this.Controls.Add(this.button_Save);
			this.Controls.Add(this.button_Cancel);
			this.Controls.Add(this.textBox_PhoneNumber);
			this.Controls.Add(this.textBox_ZipCode);
			this.Controls.Add(this.textBox_AddressLine2);
			this.Controls.Add(this.textBox_AddressLine1);
			this.Controls.Add(this.textBox_CustomerName);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label_CustomerName);
			this.Controls.Add(this.label_AddCustomer);
			this.Name = "AddCustomer";
			this.Text = "AddCustomer";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label_AddCustomer;
		private System.Windows.Forms.Label label_CustomerName;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox textBox_CustomerName;
		private System.Windows.Forms.TextBox textBox_AddressLine1;
		private System.Windows.Forms.TextBox textBox_AddressLine2;
		private System.Windows.Forms.TextBox textBox_ZipCode;
		private System.Windows.Forms.TextBox textBox_PhoneNumber;
		private System.Windows.Forms.Button button_Save;
		private System.Windows.Forms.Button button_Cancel;
		private System.Windows.Forms.ListBox listBox_CityID;
	}
}