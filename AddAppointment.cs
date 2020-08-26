using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;


namespace C969
{
	public partial class AddAppointment : Form
	{
		int overLappingAppointment = -1;
		public AddAppointment()
		{
			InitializeComponent(); 
		}

		public void BackToMain()
		{
			MainForm redo = new MainForm();
			this.Hide();
			redo.Show();
		}

		private void AddAppointment_Load(object sender, EventArgs e)
		{
			textBox_CustomerID.Text = MainForm.currentCustomerID.ToString();
			textBox_CustomerID.Enabled = false;
		}

		// OVERLAPPING TIME??? CHECK IT OUT

		bool OverLap(TimeSpan newapptstart, TimeSpan newapptend, TimeSpan dbapptstart, TimeSpan dbapptend)
		{
			if(dbapptstart <= newapptstart && newapptstart <= dbapptend)
			{
				overLappingAppointment = 1;
				return true;
			}
			else if (dbapptstart <= newapptend && newapptend <= dbapptend)
			{
				overLappingAppointment = 1;
				return true;
			}
			else
			{
				overLappingAppointment = 0;
				return false;
			}
		}






		//OOPSIES
		private void label12_Click(object sender, EventArgs e)
		{
			//SHIT
		}
		//END OF OOPSIES














		private void button_Save_Click(object sender, EventArgs e)
		{
			DateTime nowtime = DateTime.Now;
			string formattime = nowtime.ToString("yyyy-MM-dd HH:mm:ss tt");

			try
			{
				DateTime newapptstart = Convert.ToDateTime(dateTimePicker_StartTime.Text);
				DateTime blahblah = newapptstart.ToUniversalTime();
				var maddafukka = blahblah.ToString("yyyy-MM-dd");      //YYYY-MM-dd HH-mm-ss 

				DateTime newapptend = Convert.ToDateTime(dateTimePicker_EndTime.Text);
				var newapptstarttime = newapptstart  - newapptstart.Date;
				var newapptendtime = newapptend - newapptend.Date;

				string query = "SELECT * from appointment where customerId = " + MainForm.currentCustomerID
					+ " and start >= '" + maddafukka + " 00:00:00' and start < '" +
					maddafukka + " 23:59:59';";

				//string query = "SELECT * FROM appointment;"; // WHERE customerId = " + MainForm.currentCustomerID +";";

				//string query = "SELECT * from appointment";

				string CS = ConfigurationManager.ConnectionStrings["C969.Properties.Settings.U06N2HConnectionString"].ConnectionString;

				DataTable dt = new DataTable();

				using (MySqlConnection con = new MySqlConnection(CS))
				{
					con.Open();
					MySqlCommand command = new MySqlCommand(query, con);
					MySqlDataAdapter adaptorr = new MySqlDataAdapter(selectCommand: command);
					adaptorr.Fill(dt);

					for(int i = 0; i < dt.Rows.Count; i++)    //RE-LOOK AT THIS ONE, DUMB ASS
					{
						DateTime dbapptstart = (DateTime)dt.Rows[i]["start"];
						dbapptstart = dbapptstart.ToLocalTime();
						DateTime dbapptend = (DateTime)dt.Rows[i]["end"];
						dbapptend = dbapptend.ToLocalTime();

						var dbapptstarttime = dbapptstart - dbapptstart.Date;
						var dbapptendtime = dbapptend - dbapptend.Date;

						if (OverLap(newapptstarttime, newapptendtime, dbapptstarttime, dbapptendtime))
						{
							MessageBox.Show("something is wrong");
							break;
						}
					}
				}
				if (textBox_CustomerID.Text == "" || textBox_Description.Text == "" || listBox_Type.Text == "" || dateTimePicker_StartTime.Text == "" || dateTimePicker_EndTime.Text =="")
				{
					MessageBox.Show("Enter values for ALL fields!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else if (dateTimePicker_StartTime.Value >= dateTimePicker_EndTime.Value)
				{
					MessageBox.Show("Your times do not make sense! Your START time cannot be later than your END time");
				}
				else if(overLappingAppointment == 1)
				{
					MessageBox.Show("Appointment times are interfering with one another, please correct this nonsense", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{
					using (MySqlConnection con = new MySqlConnection(CS))
					{
						MySqlCommand command = new MySqlCommand();
						                                     
						command.CommandText = "INSERT INTO appointment(customerId, description, type, start, end, createDate, createdBy, lastUpdateBy, userId) "     // @createdBy, @lastUpdateBy -- who the hell are these people
						+ "VALUES (@textBox_CustomerID, @textBox_Description, @listBox_Type, @dateTimePicker_StartTime, @dateTimePicker_EndTime, @CreateDate, @CreatedBy, @LastUpdateBy, @UserID);";
						//                         ^^^^^^ MAYBE (this.)
						command.Connection = con;
						con.Open();
						command.Parameters.AddWithValue("@textBox_CustomerID", MainForm.currentCustomerID);
						command.Parameters.AddWithValue("@textBox_Description", textBox_Description.Text);
						command.Parameters.AddWithValue("@listBox_Type", listBox_Type.Text);
						command.Parameters.AddWithValue("@dateTimePicker_StartTime", Convert.ToDateTime(dateTimePicker_StartTime.Value).ToUniversalTime());
						command.Parameters.AddWithValue("@dateTimePicker_EndTime", Convert.ToDateTime(dateTimePicker_EndTime.Value).ToUniversalTime());
						command.Parameters.AddWithValue("@CreateDate", Convert.ToDateTime(formattime).ToUniversalTime());
						command.Parameters.AddWithValue("@CreatedBy", MainForm.currentUser);
						command.Parameters.AddWithValue("@LastUpdateBy", MainForm.currentUser);
						command.Parameters.AddWithValue("@UserID", MainForm.currentUserID);
						command.ExecuteNonQuery();
					}
					this.Close();
					MainForm redo = new MainForm();
					redo.Show();
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}


		private void button_Cancel_Click(object sender, EventArgs e)
		{
		    if(MessageBox.Show("Are you sure? All data will be discarded", "Add Appointment", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				BackToMain();
			}
		}



		//private void dateTimePicker_StartTime_ValueChanged(object sender, EventArgs e)
		//{
		//	var beforestarttime = new TimeSpan(9, 00, 00);
		//	if (dateTimePicker_StartTime.Value.TimeOfDay < beforestarttime)
		//	{
		//		MessageBox.Show("Business hours: 9:00 AM - 5:00 PM, Schedule an appointment within these parameters");
		//		dateTimePicker_StartTime.Value = dateTimePicker_StartTime.Value.Date + beforestarttime;
		//	}
		//}

		//private void dateTimePicker_EndTime_ValueChanged(object sender, EventArgs e)
		//{
		//	var afterendtime = new TimeSpan(17, 00, 00);
		//	if (dateTimePicker_EndTime.Value.TimeOfDay > afterendtime)
		//	{
		//		MessageBox.Show("Business hours: 9:00 AM - 5:00 PM, Schedule an appointment within these parameters");
		//		dateTimePicker_EndTime.Value = dateTimePicker_EndTime.Value.Date + afterendtime;
		//	}
		//}

		private void dateTimePicker_StartTime_ValueChanged_1(object sender, EventArgs e)
		{
			var beforestarttime = new TimeSpan(9, 00, 00);
			if (dateTimePicker_StartTime.Value.TimeOfDay < beforestarttime)
			{
				MessageBox.Show("Business hours: 9:00 AM - 5:00 PM, Schedule an appointment within these parameters");
				dateTimePicker_StartTime.Value = dateTimePicker_StartTime.Value.Date + beforestarttime;
			}
		}

		private void dateTimePicker_EndTime_ValueChanged_1(object sender, EventArgs e)
		{
			var afterendtime = new TimeSpan(17, 00, 00);
			if (dateTimePicker_EndTime.Value.TimeOfDay > afterendtime)
			{
				MessageBox.Show("Business hours: 9:00 AM - 5:00 PM, Schedule an appointment within these parameters");
				dateTimePicker_EndTime.Value = dateTimePicker_EndTime.Value.Date + afterendtime;
			}
		}
	}
}
