namespace C969
{
	partial class LogInForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
			this.label_UserName = new System.Windows.Forms.Label();
			this.label_Password = new System.Windows.Forms.Label();
			this.button_Login = new System.Windows.Forms.Button();
			this.button_Exit = new System.Windows.Forms.Button();
			this.textBox_UserName = new System.Windows.Forms.TextBox();
			this.textBox_Password = new System.Windows.Forms.TextBox();
			this.label_LoginHeader = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label_UserName
			// 
			resources.ApplyResources(this.label_UserName, "label_UserName");
			this.label_UserName.Name = "label_UserName";
			// 
			// label_Password
			// 
			resources.ApplyResources(this.label_Password, "label_Password");
			this.label_Password.Name = "label_Password";
			// 
			// button_Login
			// 
			resources.ApplyResources(this.button_Login, "button_Login");
			this.button_Login.Name = "button_Login";
			this.button_Login.UseVisualStyleBackColor = true;
			this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
			// 
			// button_Exit
			// 
			resources.ApplyResources(this.button_Exit, "button_Exit");
			this.button_Exit.Name = "button_Exit";
			this.button_Exit.UseVisualStyleBackColor = true;
			this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
			// 
			// textBox_UserName
			// 
			resources.ApplyResources(this.textBox_UserName, "textBox_UserName");
			this.textBox_UserName.Name = "textBox_UserName";
			this.textBox_UserName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// textBox_Password
			// 
			resources.ApplyResources(this.textBox_Password, "textBox_Password");
			this.textBox_Password.Name = "textBox_Password";
			// 
			// label_LoginHeader
			// 
			resources.ApplyResources(this.label_LoginHeader, "label_LoginHeader");
			this.label_LoginHeader.Name = "label_LoginHeader";
			// 
			// LogInForm
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.label_LoginHeader);
			this.Controls.Add(this.textBox_Password);
			this.Controls.Add(this.textBox_UserName);
			this.Controls.Add(this.button_Exit);
			this.Controls.Add(this.button_Login);
			this.Controls.Add(this.label_Password);
			this.Controls.Add(this.label_UserName);
			this.Name = "LogInForm";
			this.Load += new System.EventHandler(this.LogInForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label_UserName;
		private System.Windows.Forms.Label label_Password;
		private System.Windows.Forms.Button button_Login;
		private System.Windows.Forms.Button button_Exit;
		private System.Windows.Forms.TextBox textBox_UserName;
		private System.Windows.Forms.TextBox textBox_Password;
		private System.Windows.Forms.Label label_LoginHeader;
	}
}