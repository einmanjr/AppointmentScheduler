using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace C969
{
	public partial class ModifyAppointment : Form
	{

		int overLappingAppointment = -1;

		public ModifyAppointment()
		{
			InitializeComponent();
		}

		public void BackToMain()
		{
			MainForm redo = new MainForm();
			this.Hide();
			redo.Show();
		}

		bool OverLap(TimeSpan newapptstart, TimeSpan newapptend, TimeSpan dbapptstart, TimeSpan dbapptend)
		{
			// refer
			//
			if (dbapptstart <= newapptstart && newapptstart <= dbapptend)
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





















		//space
		//space
		//space
		//space
		//space
		//space
		//space
		//space

		// CREATE Save!
		private void button_Save_Click(object sender, EventArgs e)
		{
			DateTime nowtime = DateTime.Now;
			string formattime = nowtime.ToString("yyyy-MM-dd HH:mm:ss tt");

			try
			{
				DateTime newapptstart = Convert.ToDateTime(dateTimePicker_StartTime.Text);
				DateTime blahblah = newapptstart.ToUniversalTime();
				var maddafukka = blahblah.ToString("yyyy-MM-dd");

				DateTime newapptend = Convert.ToDateTime(dateTimePicker_EndTime.Text);
				var newapptstarttime = newapptstart - newapptend.Date;
				var newapptendtime = newapptend - newapptend.Date;

				string query = "SELECT * FROM appointment WHERE customerId = " + MainForm.currentCustomerID + " AND start >= '" + maddafukka + "00:00:00' AND start < '" + maddafukka + " 23:59:59'";
				//string query = "SELECT * FROM appointment;";
				string CS = ConfigurationManager.ConnectionStrings["C969.Properties.Settings.U06N2HConnectionString"].ConnectionString;

				DataTable dt = new DataTable();

				using (MySqlConnection con = new MySqlConnection(CS))
				{
					con.Open();
					MySqlCommand command = new MySqlCommand(query, con);
					MySqlDataAdapter adaptorr = new MySqlDataAdapter(selectCommand: command);
					adaptorr.Fill(dt);

					for (int i = 0; i < dt.Rows.Count; i++)
					{
						DateTime dbapptstart = (DateTime)dt.Rows[i]["start"];
						dbapptstart = dbapptstart.ToLocalTime();
						DateTime dbapptend = (DateTime)dt.Rows[i]["end"];
						dbapptend = dbapptend.ToLocalTime();

						var dbapptstarttime = dbapptstart - dbapptstart.Date;

						var dbapptendtime = dbapptend - dbapptend.Date;

						if(OverLap(newapptstarttime, newapptendtime, dbapptstarttime,dbapptendtime))
						{
							MessageBox.Show("Overlapping Appointments!!");
							break;
						}
					}
				}

				if(textBox_CustomerID.Text == "" || textBox_Description.Text == "" || listBox_Type.Text == "" || dateTimePicker_StartTime.Text == "" || dateTimePicker_EndTime.Text == "")
				{
					MessageBox.Show("Enter Values for ALL fields!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else if (dateTimePicker_StartTime.Value >= dateTimePicker_EndTime.Value)
				{
					MessageBox.Show("Your times do not make sense! Your START time cannot be later than your END time", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
						command.CommandText = "SET FOREIGN_KEY_CHECKS = 0; UPDATE appointment SET appointmentId = @textBox_AppointmentID," +
							" customerId = @textBox_CustomerID, description = @textBox_Description, type = @listBox_Type, " +
	                        "start = @dateTimePicker_StartTime, end = @dateTimePicker_EndTime, createDate = @CreateDate " +
						    "WHERE appointmentId = @textBox_AppointmentID; SET FOREIGN_KEY_CHECKS = 1;";
					    command.Connection = con;
						con.Open();
						command.Parameters.AddWithValue("@textBox_AppointmentID", MainForm.currentAppointmentID);
						command.Parameters.AddWithValue("@textBox_CustomerID", textBox_CustomerID.Text);
						command.Parameters.AddWithValue("@textBox_Description", textBox_Description.Text);
						command.Parameters.AddWithValue("@listBox_Type", listBox_Type.Text);
						command.Parameters.AddWithValue("@dateTimePicker_StartTime", Convert.ToDateTime(dateTimePicker_StartTime.Value).ToUniversalTime());
						command.Parameters.AddWithValue("@dateTimePicker_EndTime", Convert.ToDateTime(dateTimePicker_EndTime.Value).ToUniversalTime());
					    command.Parameters.AddWithValue("@CreateDate", MainForm.partytime);  //MAYBE HERE
						command.ExecuteNonQuery();
						con.Close();
             		}
					BackToMain();
				}	
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}


	    private void button_Cancel_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure? Your unsaved data will be discarded.", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				BackToMain();
			}
		}
	
		// FIXME MODAPPTLOAD below
		private void ModifyAppointment_Load(object sender, EventArgs e)
		{
			string CS = ConfigurationManager.ConnectionStrings["C969.Properties.Settings.U06N2HConnectionString"].ConnectionString;

			using (MySqlConnection connection = new MySqlConnection(CS))
			{                                                                                                                                // ";" below
				MySqlCommand command = new MySqlCommand("SELECT * FROM appointment WHERE appointmentId = '" + MainForm.currentAppointmentID + "'", connection);
				connection.Open();
				MySqlDataReader reader = command.ExecuteReader();
				if (reader.Read())
				{
					textBox_CustomerID.Text = reader["customerId"].ToString();
					textBox_Description.Text = reader["description"].ToString();
					listBox_Type.Text = reader["type"].ToString();


					// THIS PART BELOW ?????? 01/17/2020
					DateTime current = (DateTime)reader["start"];
					current = current.ToLocalTime();
					dateTimePicker_StartTime.Text = current.ToString();

					DateTime currentendtime = (DateTime)reader["end"];
					currentendtime = currentendtime.ToLocalTime();
					dateTimePicker_EndTime.Text = currentendtime.ToString();
				}
				else
				{
					MessageBox.Show("Address is messed up");
				}
			}
		}

		//private void dateTimePicker_StartTime_ValueChanged(object sender, EventArgs e)
		//{
		//	var beforestarttime = new TimeSpan(9, 00, 00);
		//	if(dateTimePicker_StartTime.Value.TimeOfDay < beforestarttime)
		//	{
		//		MessageBox.Show("Business hours: 9:00 AM - 5:00 PM, Schedule an appointment within these parameters");
		//		dateTimePicker_StartTime.Value = dateTimePicker_StartTime.Value.Date + beforestarttime;
		//	}
		//}

		//private void dateTimePicker_EndTime_ValueChanged(object sender, EventArgs e)
		//{
		//	var afterendtime = new TimeSpan(17, 00, 00);
		//	if(dateTimePicker_EndTime.Value.TimeOfDay > afterendtime)
		//	{
		//		MessageBox.Show("Business hours: 9:00 AM - 5:00 PM, Schedule an appointment within these parameters");
		//		dateTimePicker_EndTime.Value = dateTimePicker_EndTime.Value.Date + afterendtime;
		//	}
		//}

		private void dateTimePicker_EndTime_ValueChanged_1(object sender, EventArgs e)
		{
			var afterendtime = new TimeSpan(17, 00, 00);
			if (dateTimePicker_EndTime.Value.TimeOfDay > afterendtime)
			{
				MessageBox.Show("Business hours: 9:00 AM - 5:00 PM, Schedule an appointment within these parameters");
				dateTimePicker_EndTime.Value = dateTimePicker_EndTime.Value.Date + afterendtime;
			}
		}

		private void dateTimePicker_StartTime_ValueChanged_1(object sender, EventArgs e)
		{
			var beforestarttime = new TimeSpan(9, 00, 00);
			if (dateTimePicker_StartTime.Value.TimeOfDay < beforestarttime)
			{
				MessageBox.Show("Business hours: 9:00 AM - 5:00 PM, Schedule an appointment within these parameters");
				dateTimePicker_StartTime.Value = dateTimePicker_StartTime.Value.Date + beforestarttime;
			}
		}
	}
}
