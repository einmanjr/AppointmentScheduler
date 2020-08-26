using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.IO;

namespace C969
{
	public partial class LogInForm : Form
	{
		public static string DBUserName { get; set; } //static??
		public static string DBPassword { get; set; } //static??

		string ErrorMessage = "";
		string FormType = "";

		private StreamWriter fileWriter;
		string userActivity = "C969UserActivity.txt";


		public LogInForm()
		{
			InitializeComponent();
		}

		public void BackToMain()
		{
			MainForm redo = new MainForm();
			this.Hide();
			redo.Show();
		}



		#region Language

		private void Language()
		{
			String Region = RegionInfo.CurrentRegion.EnglishName;  //.EnglishName;

			try
			{
				if(Region == "United States")
				{
					DisplayEnglish();
				}
				else if (Region == "Philippines")
				{


					label_LoginHeader.Text = "Mag-login sa iyong account";
					label_UserName.Text = "Pangalan ng Gumagamit";
					label_Password.Text = "Password";
					button_Login.Text = "Mag log in";
					button_Exit.Text = "Lumabas";
					ErrorMessage = "ito ay isang mensahe ng error";
				}
				else
				{
					DisplayEnglish();
				}
			}
			catch (Exception)
			{
				throw;
			}
		}

		private void DisplayEnglish()
		{
			label_LoginHeader.Text = "Login to your Account";
			label_UserName.Text = "Username";
			label_Password.Text = "Password";
			button_Login.Text = "Login";
			button_Exit.Text = "Exit";
			ErrorMessage = "Incorrect UserName or Password";
		}

		#endregion













		private void LogInForm_Load(object sender, EventArgs e)
		{
			Language();

			string CS = ConfigurationManager.ConnectionStrings["C969.Properties.Settings.U06N2HConnectionString"].ConnectionString;

			using (MySqlConnection con = new MySqlConnection(CS))
			{
				try
				{
					MySqlCommand command = new MySqlCommand("SELECT * FROM user WHERE userId = 1", con);
					con.Open();
					MySqlDataReader reader = command.ExecuteReader();
					if(reader.Read())
					{
						DBUserName = reader["userName"].ToString();
						DBPassword = reader["password"].ToString();
					}
				}
				catch (Exception)
				{
					throw;  
				}
			}

		}

		private void button_Login_Click(object sender, EventArgs e)
		{
			DateTime partytime = DateTime.Now;
			string formattime = partytime.ToString("yyyy-MM-dd HH:mm:ss tt");

			try
			{
				if(textBox_UserName.Text == DBUserName && textBox_Password.Text == DBPassword)
				{
					try
					{
						FileStream output = new FileStream(userActivity, FileMode.Append, FileAccess.Write);
						fileWriter = new StreamWriter(output);
						fileWriter.WriteLine("Login Time:" + formattime + "....  Current User: " + MainForm.currentUser + "....  Successful Login");
						fileWriter.Close();
					}
					catch (Exception)
					{
						MessageBox.Show("Cannot find userActivity.txt");
					}
					
					
					
					
					MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["C969.Properties.Settings.U06N2HConnectionString"].ConnectionString);

					MySqlCommand command = new MySqlCommand("SELECT * FROM appointment;", con);
					con.Open();
					MySqlDataAdapter adaptorr = new MySqlDataAdapter(command);

					DataTable dt = new DataTable();
					adaptorr.Fill(dt);

					for (int i = 0; i < dt.Rows.Count; i++)
					{
						DateTime dbapptstart = (DateTime)dt.Rows[i]["start"];
						dbapptstart = dbapptstart.ToLocalTime();

						TimeSpan span = dbapptstart.Subtract(partytime);   //HMMMMM

						if (span.TotalMinutes < 15 && span.TotalMinutes > 0)
						{
							MessageBox.Show("You have an appointment within 15 Minutes!!!!!!");
							break;
						}
					}
					BackToMain();
				}
				else
				{
					try
					{
						FileStream output = new FileStream(userActivity, FileMode.Append, FileAccess.Write);
						fileWriter = new StreamWriter(output);
						fileWriter.WriteLine("Login Time:" + formattime + "....  Current User: " + MainForm.currentUser + "....  FAILED Login");
						fileWriter.Close();
					}
					catch
					{
						MessageBox.Show("Cannot find userActivity.txt");
					}
				
					MessageBox.Show(ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					textBox_UserName.Clear();
					textBox_Password.Clear();
					return;
				}
			}
			catch (Exception)
			{ 
				throw;
			}
		}










		//OOPSIES
		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			//shit
		}
		//END OF OOPSIES

		private void button_Exit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
