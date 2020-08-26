using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Globalization;

namespace C969
{
	public partial class MainForm : Form
	{
		public static int currentUserID = 1;   // FIXME here AND IN REPORTS ->ByConsultant Radio button
		public static string currentUser = LogInForm.DBUserName; //test

		public static int currentCustomerID = 1;
		public static int currentAddressID = -1;
		public static int currentAppointmentID = -1;

		#region LAMBA 1
		//Lambda 1 Simplifies property declaration ++ less code
		public int CurrentAppointmentDate { get => CurrentAppointmentDate; set { CurrentAppointmentDate = value; } }
		#endregion

		public static string partytime = DateTime.Now.Date.ToString("yyyy-MM-dd");




		//static MySqlConnection con;


		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e) 
		{
			

				MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["C969.Properties.Settings.U06N2HConnectionString"].ConnectionString); //Creates the connection and passes in the connection string parameter
				MySqlCommand cmd = new MySqlCommand("SELECT * FROM customer ;", con); //Creates the command and passes it in the parameters (Cmd, connection)
				
				con.Open();
				MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);   //instantiates the connection and passes in the Sql cmd
				DataTable ds = new DataTable();
				adapter.Fill(ds);
				dataGridView_Customers.DataSource = ds;
				dataGridView_Customers.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
				con.Close();
				dataGridView_Customers.ClearSelection();
				dataGridView_Customers.CurrentCell = null;


				MySqlConnection con1 = new MySqlConnection(ConfigurationManager.ConnectionStrings["C969.Properties.Settings.U06N2HConnectionString"].ConnectionString); //Creates the connection and passes in the connection string parameter
				MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM appointment ;", con1); //Creates the command and passes it in the parameters (Cmd, connection)
				
				con1.Open();
				MySqlDataAdapter adapter1 = new MySqlDataAdapter(cmd1);   //instantiates the connection and passes in the Sql cmd
				DataTable ds1 = new DataTable();
				adapter1.Fill(ds1);
				dataGridView_Appointments.DataSource = ds1;
				dataGridView_Appointments.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
				con1.Close();
				dataGridView_Appointments.ClearSelection();
				dataGridView_Appointments.CurrentCell = null;

			radioButton_AllAppointments.Checked = true;
		}

		// BIG ASS TABLES

		private void dataGridView_Appointments_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				currentAppointmentID = (int)dataGridView_Appointments.Rows[e.RowIndex].Cells[0].Value;
				currentCustomerID = (int)dataGridView_Appointments.Rows[e.RowIndex].Cells[1].Value;
			}
			catch (Exception)
			{
				MessageBox.Show("Select an Appointment!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void dataGridView_Customers_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{       // MAYBE FIXME ---- Cells[1] May cause problems
				currentCustomerID = (int)dataGridView_Customers.Rows[e.RowIndex].Cells[0].Value;  //1
				currentAddressID = (int)dataGridView_Customers.Rows[e.RowIndex].Cells[2].Value;   //2 or 3
			}
			catch (Exception)
			{
				//MessageBox.Show("Select a Customer!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void dataGridView_Appointments_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			//try
			//{
			//	currentAppointmentID = (int)dataGridView_Appointments.Rows[e.RowIndex].Cells[0].Value;
			//	currentCustomerID = (int)dataGridView_Appointments.Rows[e.RowIndex].Cells[1].Value;
			//}
			//catch (Exception)
			//{
			//	MessageBox.Show("Select an Appointment!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			//}
		}
		// BELOW!!!!!!!!!!!! THIS MAY CAUSE A PROBLEM! 1/17
		private void dataGridView_Customers_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			//try
			//{       // MAYBE FIXME ---- Cells[1] May cause problems
			//	currentCustomerID = (int)dataGridView_Customers.Rows[e.RowIndex].Cells[1].Value;
			//	currentAddressID = (int)dataGridView_Customers.Rows[e.RowIndex].Cells[2].Value;
			//}
			//catch (Exception)
			//{
			//	//MessageBox.Show("Select a Customer!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			//}
		}


		private void radioButton_AllAppointments_CheckedChanged(object sender, EventArgs e)
		{
			MySqlConnection con1 = new MySqlConnection(ConfigurationManager.ConnectionStrings["C969.Properties.Settings.U06N2HConnectionString"].ConnectionString); //Creates the connection and passes in the connection string parameter
			MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM appointment ;", con1); //Creates the command and passes it in the parameters (Cmd, connection)

			con1.Open();
			MySqlDataAdapter adapter1 = new MySqlDataAdapter(cmd1);   //instantiates the connection and passes in the Sql cmd
			DataTable ds1 = new DataTable();
			adapter1.Fill(ds1);
			dataGridView_Appointments.DataSource = ds1;
			dataGridView_Appointments.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			con1.Close();
			dataGridView_Appointments.ClearSelection();
			dataGridView_Appointments.CurrentCell = null;
		}

		private void radioButton_Week_CheckedChanged(object sender, EventArgs e)
		{
			var thisWeek = DateTime.Now.AddDays(7).ToString("yyyy-MM--dd");

			string query = "SELECT * FROM appointment WHERE start BETWEEN '" + partytime + "' AND '" + thisWeek + "';";

			MySqlConnection con1 = new MySqlConnection(ConfigurationManager.ConnectionStrings["C969.Properties.Settings.U06N2HConnectionString"].ConnectionString); //Creates the connection and passes in the connection string parameter
			MySqlCommand cmd1 = new MySqlCommand(query, con1); 

			con1.Open();
			MySqlDataAdapter adapter1 = new MySqlDataAdapter(cmd1);   //instantiates the connection and passes in the Sql cmd
			DataTable ds1 = new DataTable();
			adapter1.Fill(ds1);
			dataGridView_Appointments.DataSource = ds1;
			dataGridView_Appointments.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			con1.Close();
			dataGridView_Appointments.ClearSelection();
			dataGridView_Appointments.CurrentCell = null;

			dataGridView_Appointments.Update();
			dataGridView_Appointments.Refresh();
		}

		private void radioButton_Month_CheckedChanged(object sender, EventArgs e)
		{
			var thisMonth = DateTime.Now.AddDays(31).ToString("yyyy-MM--dd");

			string query = "SELECT * FROM appointment WHERE start BETWEEN '" + partytime + "' AND '" + thisMonth + "';";

			MySqlConnection con1 = new MySqlConnection(ConfigurationManager.ConnectionStrings["C969.Properties.Settings.U06N2HConnectionString"].ConnectionString); //Creates the connection and passes in the connection string parameter
			MySqlCommand cmd1 = new MySqlCommand(query, con1);

			con1.Open();
			MySqlDataAdapter adapter1 = new MySqlDataAdapter(cmd1);   //instantiates the connection and passes in the Sql cmd
			DataTable ds1 = new DataTable();
			adapter1.Fill(ds1);
			dataGridView_Appointments.DataSource = ds1;
			dataGridView_Appointments.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			con1.Close();
			dataGridView_Appointments.ClearSelection();
			dataGridView_Appointments.CurrentCell = null;

			dataGridView_Appointments.Update();
			dataGridView_Appointments.Refresh();
		}






		// OOPSIES
		private void button2_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{
			//OOPS
		}

		private void label1_Click(object sender, EventArgs e)
		{
			//FUCK
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Report newReportForm = new Report();
			this.Hide();
			newReportForm.Show();
		}

		private void label_Options_Click(object sender, EventArgs e)
		{
			//DAMN IT
		}
		//END OF OOPSIES



		//TOUCH MY BUTTONS
		private void button_Appointments_Add_Click(object sender, EventArgs e)
		{
			if(dataGridView_Customers.CurrentCell == null)
			{
				MessageBox.Show("First, select a CUSTOMER to add an APPOINTMENT to!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				AddAppointment NewAddAppointmentForm = new AddAppointment();
				this.Hide();
				NewAddAppointmentForm.Show();
			}
		}

		private void button_Appointments_Modify_Click(object sender, EventArgs e)
		{
			if(dataGridView_Appointments.CurrentCell == null)
			{
				MessageBox.Show("Select an Appointment to MODIFY!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				ModifyAppointment NewModifyAppointmentForm = new ModifyAppointment();
				this.Hide();
				NewModifyAppointmentForm.Show();
			}
		}

		//       
		private void button_Appointments_Delete_Click(object sender, EventArgs e)
		{
			if (dataGridView_Appointments.CurrentCell == null)
			{
				MessageBox.Show("Select an Appointment to DELETE!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{                                                         
				string connection = ConfigurationManager.ConnectionStrings["C969.Properties.Settings.U06N2HConnectionString"].ConnectionString;
				using (MySqlConnection con = new MySqlConnection(connection))
				{
					MySqlCommand command = new MySqlCommand();
					command.CommandText = "DELETE FROM appointment WHERE appointmentId = @appointmentId ;" ;
					command.Connection = con;
					con.Open();                       //BELOW ME
					command.Parameters.AddWithValue("@appointmentId", MainForm.currentAppointmentID);
					command.ExecuteNonQuery();
				}
				MainForm redo = new MainForm();
				this.Hide();
				redo.Show();
			}
		}

		private void button_Customers_Add_Click(object sender, EventArgs e)
		{
			AddCustomer newcustomer = new AddCustomer();
			this.Hide();
			newcustomer.Show();
		}

		private void button_Customers_Modify_Click(object sender, EventArgs e)
		{
			if(dataGridView_Customers.CurrentCell == null)
			{
				MessageBox.Show("Select a CUSTOMER to MODIFY!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				ModifyCustomer modcust = new ModifyCustomer();
				this.Hide();
				modcust.Show();
			}
		}

		//         FIX --> CONFIGURATION MANAGER in DELETE (Below)
		private void button_Customers_Delete_Click(object sender, EventArgs e)
		{
			if (dataGridView_Customers.CurrentCell == null)
			{
				MessageBox.Show("Select a CUSTOMER to DELETE first!!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				string connection = ConfigurationManager.ConnectionStrings["C969.Properties.Settings.U06N2HConnectionString"].ConnectionString;
				using (MySqlConnection con = new MySqlConnection(connection))
				{
					MySqlCommand command = new MySqlCommand();
					command.CommandText = "SET FOREIGN_KEY_CHECKS = 0; DELETE FROM customer WHERE customerId = @customerId; SET FOREIGN_KEY_CHECKS = 1;";
					command.Connection = con;
					con.Open();
					command.Parameters.AddWithValue("@customerId", currentCustomerID);
					command.ExecuteNonQuery();
				}
				MainForm redo = new MainForm();
				this.Hide();
				redo.Show();
			}
		}












		//k
		//k
		//k
		//k
		//k
		//k
		//k
		//k
		//k
		//k
		//k
		//k


		private void button_Log_Out_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}


	}
}
