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

namespace C969
{
	public partial class Report : Form
	{
		public Report()
		{
			InitializeComponent();

			radioButton_ByMonthTypes.Checked = true;
		}

		public void BackToMain()
		{
			MainForm redo = new MainForm();
			this.Hide();
			redo.Show();
		}

		public int Typecount = 0;


		#region LAMBA 2
		//Lambda 2 Simplifies property declaration ++ less code
		public int CurrentAppointmentDate { get => CurrentAppointmentDate; set { CurrentAppointmentDate = value; } }
		#endregion





















		//OOPSIES
		private void button_Exit_Click(object sender, EventArgs e)
		{
			BackToMain();
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{
			//if (radioButton_ByMonthTypes.Checked)
			//{
			//	//this.Show();
			//	//groupBox2.Hide();
			//	//groupBox3.Hide();
			//}
		}

		private void groupBox2_Enter(object sender, EventArgs e)
		{
			//if(radioButton_ByConsultant.Checked)
			//{
			//	this.Show();
			//	groupBox1.Visible = false;
			//	groupBox3.Visible = false;
			//}
		}

		private void groupBox3_Enter(object sender, EventArgs e)
		{
			//if(radioButton_ByAppointmentDescription.Checked)
			//{
			//	this.Show();
			//	groupBox1.Hide();
			//	groupBox2.Hide();
			//}
		}

		
		//END OF OOPSIES





		private void radioButton_ByMonthTypes_CheckedChanged(object sender, EventArgs e)
		{
			groupBox1.Show();
			groupBox2.Hide();
			groupBox3.Hide();
			dataGridView2.Show();
			label_MonthName.Show();
			label_DescriptionMonth.Show();

		//	dataGridView3.Hide();

		}

		private void radioButton_ByConsultant_CheckedChanged(object sender, EventArgs e)
		{
			
			groupBox1.Hide();
			groupBox2.Show();
			groupBox3.Hide();
			dataGridView2.Hide();
			label_MonthName.Hide();
			label_DescriptionMonth.Hide();

			//dataGridView3.Hide();
		}

		private void radioButton_ByAppointmentDescription_CheckedChanged(object sender, EventArgs e)
		{
			groupBox1.Hide();
			groupBox2.Hide();
			groupBox3.Hide();
			dataGridView2.Hide();
			label_MonthName.Hide();
			label_DescriptionMonth.Hide();

			dataGridView1.Show();

			MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["C969.Properties.Settings.U06N2HConnectionString"].ConnectionString);
			MySqlCommand cmd = new MySqlCommand("SELECT customerId, COUNT(*) FROM appointment  GROUP BY customerId;", con);

			con.Open();
			MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
			DataTable ds = new DataTable();
			adapter.Fill(ds);
			dataGridView1.DataSource = ds;
			dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			con.Close();
			dataGridView1.ClearSelection();
			dataGridView1.CurrentCell = null;

			dataGridView1.Update();
			dataGridView1.Refresh();

			dataGridView1.Update();
			dataGridView1.Refresh();

		}



	






		#region Months radio buttons
		//MONTHS PROBABLY A BETTER WAY TO DO THIS..................
		private void radioButton_January_CheckedChanged(object sender, EventArgs e)
		{
			label_MonthName.Text = "January";

			string query = "SELECT * FROM appointment WHERE MONTH(start) = 1";
			string littletable = "SELECT type, COUNT(*) FROM appointment WHERE MONTH(start) = 1 AND YEAR(start) = 2020 GROUP BY type;";

			MySqlConnection con1 = new MySqlConnection(ConfigurationManager.ConnectionStrings["C969.Properties.Settings.U06N2HConnectionString"].ConnectionString); //Creates the connection and passes in the connection string parameter
			MySqlCommand cmd1 = new MySqlCommand(query, con1);
			MySqlCommand cmd2 = new MySqlCommand(littletable, con1); //MAYBE



			con1.Open();
			MySqlDataAdapter adapter1 = new MySqlDataAdapter(cmd1);
			MySqlDataAdapter adapter2 = new MySqlDataAdapter(cmd2); //MAYBE

			DataTable ds1 = new DataTable();
			DataTable ds2 = new DataTable(); //MAYBE

			adapter1.Fill(ds1);
			adapter2.Fill(ds2); //MAYBE
			dataGridView1.DataSource = ds1;
			dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridView2.DataSource = ds2;                                                    //MAYBE
			dataGridView2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;       //MAYBE
			con1.Close();
			dataGridView1.ClearSelection();
			dataGridView1.CurrentCell = null;
			dataGridView2.ClearSelection();      //MAYBE
			dataGridView2.CurrentCell = null;    //MAYBE


			dataGridView1.Update();
			dataGridView1.Refresh();

			dataGridView2.Update();        //MAYBE
			dataGridView2.Refresh();       //MAYBE



		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{
			label_MonthName.Text = "February";

			string query = "SELECT * FROM appointment WHERE MONTH(start) = 2";
			string littletable = "SELECT type, COUNT(*) FROM appointment WHERE MONTH(start) = 2 AND YEAR(start) = 2020 GROUP BY type;";   //MAYBE

			MySqlConnection con1 = new MySqlConnection(ConfigurationManager.ConnectionStrings["C969.Properties.Settings.U06N2HConnectionString"].ConnectionString); //Creates the connection and passes in the connection string parameter
			MySqlCommand cmd1 = new MySqlCommand(query, con1);
			MySqlCommand cmd2 = new MySqlCommand(littletable, con1); //MAYBE



			con1.Open();
			MySqlDataAdapter adapter1 = new MySqlDataAdapter(cmd1);
			MySqlDataAdapter adapter2 = new MySqlDataAdapter(cmd2); //MAYBE

			DataTable ds1 = new DataTable();
			DataTable ds2 = new DataTable(); //MAYBE

			adapter1.Fill(ds1);
			adapter2.Fill(ds2); //MAYBE
			dataGridView1.DataSource = ds1;
			dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridView2.DataSource = ds2;                                                    //MAYBE
			dataGridView2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;       //MAYBE
			con1.Close();
			dataGridView1.ClearSelection();
			dataGridView1.CurrentCell = null;
			dataGridView2.ClearSelection();      //MAYBE
			dataGridView2.CurrentCell = null;    //MAYBE


			dataGridView1.Update();
			dataGridView1.Refresh();

			dataGridView2.Update();        //MAYBE
			dataGridView2.Refresh();       //MAYBE
		}

		private void radioButton_March_CheckedChanged(object sender, EventArgs e)
		{
			label_MonthName.Text = "March";

			string query = "SELECT * FROM appointment WHERE MONTH(start) = 3";
			string littletable = "SELECT type, COUNT(*) FROM appointment WHERE MONTH(start) = 3 AND YEAR(start) = 2020 GROUP BY type;";
			MySqlConnection con1 = new MySqlConnection(ConfigurationManager.ConnectionStrings["C969.Properties.Settings.U06N2HConnectionString"].ConnectionString); //Creates the connection and passes in the connection string parameter
			MySqlCommand cmd1 = new MySqlCommand(query, con1);
			MySqlCommand cmd2 = new MySqlCommand(littletable, con1); //MAYBE



			con1.Open();
			MySqlDataAdapter adapter1 = new MySqlDataAdapter(cmd1);
			MySqlDataAdapter adapter2 = new MySqlDataAdapter(cmd2); //MAYBE

			DataTable ds1 = new DataTable();
			DataTable ds2 = new DataTable(); //MAYBE

			adapter1.Fill(ds1);
			adapter2.Fill(ds2); //MAYBE
			dataGridView1.DataSource = ds1;
			dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridView2.DataSource = ds2;                                                    //MAYBE
			dataGridView2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;       //MAYBE
			con1.Close();
			dataGridView1.ClearSelection();
			dataGridView1.CurrentCell = null;
			dataGridView2.ClearSelection();      //MAYBE
			dataGridView2.CurrentCell = null;    //MAYBE


			dataGridView1.Update();
			dataGridView1.Refresh();

			dataGridView2.Update();        //MAYBE
			dataGridView2.Refresh();       //MAYBE
		}

		private void radioButton4_CheckedChanged(object sender, EventArgs e)
		{
			label_MonthName.Text = "April";

			string query = "SELECT * FROM appointment WHERE MONTH(start) = 4";
			string littletable = "SELECT type, COUNT(*) FROM appointment WHERE MONTH(start) = 4 AND YEAR(start) = 2020 GROUP BY type;";
			MySqlConnection con1 = new MySqlConnection(ConfigurationManager.ConnectionStrings["C969.Properties.Settings.U06N2HConnectionString"].ConnectionString); //Creates the connection and passes in the connection string parameter
			MySqlCommand cmd1 = new MySqlCommand(query, con1);
			MySqlCommand cmd2 = new MySqlCommand(littletable, con1); //MAYBE



			con1.Open();
			MySqlDataAdapter adapter1 = new MySqlDataAdapter(cmd1);
			MySqlDataAdapter adapter2 = new MySqlDataAdapter(cmd2); //MAYBE

			DataTable ds1 = new DataTable();
			DataTable ds2 = new DataTable(); //MAYBE

			adapter1.Fill(ds1);
			adapter2.Fill(ds2); //MAYBE
			dataGridView1.DataSource = ds1;
			dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridView2.DataSource = ds2;                                                    //MAYBE
			dataGridView2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;       //MAYBE
			con1.Close();
			dataGridView1.ClearSelection();
			dataGridView1.CurrentCell = null;
			dataGridView2.ClearSelection();      //MAYBE
			dataGridView2.CurrentCell = null;    //MAYBE


			dataGridView1.Update();
			dataGridView1.Refresh();

			dataGridView2.Update();        //MAYBE
			dataGridView2.Refresh();       //MAYBE
		}

		private void radioButton_May_CheckedChanged(object sender, EventArgs e)
		{
			label_MonthName.Text = "May";

			string query = "SELECT * FROM appointment WHERE MONTH(start) = 5";
			string littletable = "SELECT type, COUNT(*) FROM appointment WHERE MONTH(start) = 5 AND YEAR(start) = 2020 GROUP BY type;";
			MySqlConnection con1 = new MySqlConnection(ConfigurationManager.ConnectionStrings["C969.Properties.Settings.U06N2HConnectionString"].ConnectionString); //Creates the connection and passes in the connection string parameter
			MySqlCommand cmd1 = new MySqlCommand(query, con1);
			MySqlCommand cmd2 = new MySqlCommand(littletable, con1); //MAYBE



			con1.Open();
			MySqlDataAdapter adapter1 = new MySqlDataAdapter(cmd1);
			MySqlDataAdapter adapter2 = new MySqlDataAdapter(cmd2); //MAYBE

			DataTable ds1 = new DataTable();
			DataTable ds2 = new DataTable(); //MAYBE

			adapter1.Fill(ds1);
			adapter2.Fill(ds2); //MAYBE
			dataGridView1.DataSource = ds1;
			dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridView2.DataSource = ds2;                                                    //MAYBE
			dataGridView2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;       //MAYBE
			con1.Close();
			dataGridView1.ClearSelection();
			dataGridView1.CurrentCell = null;
			dataGridView2.ClearSelection();      //MAYBE
			dataGridView2.CurrentCell = null;    //MAYBE


			dataGridView1.Update();
			dataGridView1.Refresh();

			dataGridView2.Update();        //MAYBE
			dataGridView2.Refresh();       //MAYBE
		}

		private void radioButton_June_CheckedChanged(object sender, EventArgs e)
		{
			label_MonthName.Text = "June";

			string query = "SELECT * FROM appointment WHERE MONTH(start) = 6";
			string littletable = "SELECT type, COUNT(*) FROM appointment WHERE MONTH(start) = 6 AND YEAR(start) = 2020 GROUP BY type;";

			MySqlConnection con1 = new MySqlConnection(ConfigurationManager.ConnectionStrings["C969.Properties.Settings.U06N2HConnectionString"].ConnectionString); //Creates the connection and passes in the connection string parameter
			MySqlCommand cmd1 = new MySqlCommand(query, con1);
			MySqlCommand cmd2 = new MySqlCommand(littletable, con1); //MAYBE



			con1.Open();
			MySqlDataAdapter adapter1 = new MySqlDataAdapter(cmd1);
			MySqlDataAdapter adapter2 = new MySqlDataAdapter(cmd2); //MAYBE

			DataTable ds1 = new DataTable();
			DataTable ds2 = new DataTable(); //MAYBE

			adapter1.Fill(ds1);
			adapter2.Fill(ds2); //MAYBE
			dataGridView1.DataSource = ds1;
			dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridView2.DataSource = ds2;                                                    //MAYBE
			dataGridView2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;       //MAYBE
			con1.Close();
			dataGridView1.ClearSelection();
			dataGridView1.CurrentCell = null;
			dataGridView2.ClearSelection();      //MAYBE
			dataGridView2.CurrentCell = null;    //MAYBE


			dataGridView1.Update();
			dataGridView1.Refresh();

			dataGridView2.Update();        //MAYBE
			dataGridView2.Refresh();       //MAYBE
		}

		private void radioButton_July_CheckedChanged(object sender, EventArgs e)
		{
			label_MonthName.Text = "July";

			string query = "SELECT * FROM appointment WHERE MONTH(start) = 7";
			string littletable = "SELECT type, COUNT(*) FROM appointment WHERE MONTH(start) = 7 AND YEAR(start) = 2020 GROUP BY type;";

			MySqlConnection con1 = new MySqlConnection(ConfigurationManager.ConnectionStrings["C969.Properties.Settings.U06N2HConnectionString"].ConnectionString); //Creates the connection and passes in the connection string parameter
			MySqlCommand cmd1 = new MySqlCommand(query, con1);
			MySqlCommand cmd2 = new MySqlCommand(littletable, con1); //MAYBE



			con1.Open();
			MySqlDataAdapter adapter1 = new MySqlDataAdapter(cmd1);
			MySqlDataAdapter adapter2 = new MySqlDataAdapter(cmd2); //MAYBE

			DataTable ds1 = new DataTable();
			DataTable ds2 = new DataTable(); //MAYBE

			adapter1.Fill(ds1);
			adapter2.Fill(ds2); //MAYBE
			dataGridView1.DataSource = ds1;
			dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridView2.DataSource = ds2;                                                    //MAYBE
			dataGridView2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;       //MAYBE
			con1.Close();
			dataGridView1.ClearSelection();
			dataGridView1.CurrentCell = null;
			dataGridView2.ClearSelection();      //MAYBE
			dataGridView2.CurrentCell = null;    //MAYBE


			dataGridView1.Update();
			dataGridView1.Refresh();

			dataGridView2.Update();        //MAYBE
			dataGridView2.Refresh();       //MAYBE
		}

		private void radioButton_August_CheckedChanged(object sender, EventArgs e)
		{
			label_MonthName.Text = "August";

			string query = "SELECT * FROM appointment WHERE MONTH(start) = 8";
			string littletable = "SELECT type, COUNT(*) FROM appointment WHERE MONTH(start) = 8 AND YEAR(start) = 2020 GROUP BY type;";

			MySqlConnection con1 = new MySqlConnection(ConfigurationManager.ConnectionStrings["C969.Properties.Settings.U06N2HConnectionString"].ConnectionString); //Creates the connection and passes in the connection string parameter
			MySqlCommand cmd1 = new MySqlCommand(query, con1);
			MySqlCommand cmd2 = new MySqlCommand(littletable, con1); //MAYBE



			con1.Open();
			MySqlDataAdapter adapter1 = new MySqlDataAdapter(cmd1);
			MySqlDataAdapter adapter2 = new MySqlDataAdapter(cmd2); //MAYBE

			DataTable ds1 = new DataTable();
			DataTable ds2 = new DataTable(); //MAYBE

			adapter1.Fill(ds1);
			adapter2.Fill(ds2); //MAYBE
			dataGridView1.DataSource = ds1;
			dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridView2.DataSource = ds2;                                                    //MAYBE
			dataGridView2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;       //MAYBE
			con1.Close();
			dataGridView1.ClearSelection();
			dataGridView1.CurrentCell = null;
			dataGridView2.ClearSelection();      //MAYBE
			dataGridView2.CurrentCell = null;    //MAYBE


			dataGridView1.Update();
			dataGridView1.Refresh();

			dataGridView2.Update();        //MAYBE
			dataGridView2.Refresh();       //MAYBE
		}

		private void radioButton9_CheckedChanged(object sender, EventArgs e)
		{
			label_MonthName.Text = "September";

			string query = "SELECT * FROM appointment WHERE MONTH(start) = 9";
			string littletable = "SELECT type, COUNT(*) FROM appointment WHERE MONTH(start) = 9 AND YEAR(start) = 2020 GROUP BY type;";

			MySqlConnection con1 = new MySqlConnection(ConfigurationManager.ConnectionStrings["C969.Properties.Settings.U06N2HConnectionString"].ConnectionString); //Creates the connection and passes in the connection string parameter
			MySqlCommand cmd1 = new MySqlCommand(query, con1);
			MySqlCommand cmd2 = new MySqlCommand(littletable, con1); //MAYBE



			con1.Open();
			MySqlDataAdapter adapter1 = new MySqlDataAdapter(cmd1);
			MySqlDataAdapter adapter2 = new MySqlDataAdapter(cmd2); //MAYBE

			DataTable ds1 = new DataTable();
			DataTable ds2 = new DataTable(); //MAYBE

			adapter1.Fill(ds1);
			adapter2.Fill(ds2); //MAYBE
			dataGridView1.DataSource = ds1;
			dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridView2.DataSource = ds2;                                                    //MAYBE
			dataGridView2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;       //MAYBE
			con1.Close();
			dataGridView1.ClearSelection();
			dataGridView1.CurrentCell = null;
			dataGridView2.ClearSelection();      //MAYBE
			dataGridView2.CurrentCell = null;    //MAYBE


			dataGridView1.Update();
			dataGridView1.Refresh();

			dataGridView2.Update();        //MAYBE
			dataGridView2.Refresh();       //MAYBE
		}

		private void radioButton_October_CheckedChanged(object sender, EventArgs e)
		{
			label_MonthName.Text = "October";

			string query = "SELECT * FROM appointment WHERE MONTH(start) = 10";
			string littletable = "SELECT type, COUNT(*) FROM appointment WHERE MONTH(start) = 10 AND YEAR(start) = 2020 GROUP BY type;";

			MySqlConnection con1 = new MySqlConnection(ConfigurationManager.ConnectionStrings["C969.Properties.Settings.U06N2HConnectionString"].ConnectionString); //Creates the connection and passes in the connection string parameter
			MySqlCommand cmd1 = new MySqlCommand(query, con1);
			MySqlCommand cmd2 = new MySqlCommand(littletable, con1); //MAYBE



			con1.Open();
			MySqlDataAdapter adapter1 = new MySqlDataAdapter(cmd1);
			MySqlDataAdapter adapter2 = new MySqlDataAdapter(cmd2); //MAYBE

			DataTable ds1 = new DataTable();
			DataTable ds2 = new DataTable(); //MAYBE

			adapter1.Fill(ds1);
			adapter2.Fill(ds2); //MAYBE
			dataGridView1.DataSource = ds1;
			dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridView2.DataSource = ds2;                                                    //MAYBE
			dataGridView2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;       //MAYBE
			con1.Close();
			dataGridView1.ClearSelection();
			dataGridView1.CurrentCell = null;
			dataGridView2.ClearSelection();      //MAYBE
			dataGridView2.CurrentCell = null;    //MAYBE


			dataGridView1.Update();
			dataGridView1.Refresh();

			dataGridView2.Update();        //MAYBE
			dataGridView2.Refresh();       //MAYBE
		}

		private void radioButton_November_CheckedChanged(object sender, EventArgs e)
		{
			label_MonthName.Text = "November";

			string query = "SELECT * FROM appointment WHERE MONTH(start) = 11";
			string littletable = "SELECT type, COUNT(*) FROM appointment WHERE MONTH(start) = 11 AND YEAR(start) = 2020 GROUP BY type;";

			MySqlConnection con1 = new MySqlConnection(ConfigurationManager.ConnectionStrings["C969.Properties.Settings.U06N2HConnectionString"].ConnectionString); //Creates the connection and passes in the connection string parameter
			MySqlCommand cmd1 = new MySqlCommand(query, con1);
			MySqlCommand cmd2 = new MySqlCommand(littletable, con1); //MAYBE



			con1.Open();
			MySqlDataAdapter adapter1 = new MySqlDataAdapter(cmd1);
			MySqlDataAdapter adapter2 = new MySqlDataAdapter(cmd2); //MAYBE

			DataTable ds1 = new DataTable();
			DataTable ds2 = new DataTable(); //MAYBE

			adapter1.Fill(ds1);
			adapter2.Fill(ds2); //MAYBE
			dataGridView1.DataSource = ds1;
			dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridView2.DataSource = ds2;                                                    //MAYBE
			dataGridView2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;       //MAYBE
			con1.Close();
			dataGridView1.ClearSelection();
			dataGridView1.CurrentCell = null;
			dataGridView2.ClearSelection();      //MAYBE
			dataGridView2.CurrentCell = null;    //MAYBE


			dataGridView1.Update();
			dataGridView1.Refresh();

			dataGridView2.Update();        //MAYBE
			dataGridView2.Refresh();       //MAYBE
		}

		private void radioButton_December_CheckedChanged(object sender, EventArgs e)
		{
			label_MonthName.Text = "December";

			string query = "SELECT * FROM appointment WHERE MONTH(start) = 12";
			string littletable = "SELECT type, COUNT(*) FROM appointment WHERE MONTH(start) = 12 AND YEAR(start) = 2020 GROUP BY type;";

			MySqlConnection con1 = new MySqlConnection(ConfigurationManager.ConnectionStrings["C969.Properties.Settings.U06N2HConnectionString"].ConnectionString); //Creates the connection and passes in the connection string parameter
			MySqlCommand cmd1 = new MySqlCommand(query, con1);
			MySqlCommand cmd2 = new MySqlCommand(littletable, con1); //MAYBE



			con1.Open();
			MySqlDataAdapter adapter1 = new MySqlDataAdapter(cmd1);
			MySqlDataAdapter adapter2 = new MySqlDataAdapter(cmd2); //MAYBE

			DataTable ds1 = new DataTable();
			DataTable ds2 = new DataTable(); //MAYBE

			adapter1.Fill(ds1);
			adapter2.Fill(ds2); //MAYBE
			dataGridView1.DataSource = ds1;
			dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridView2.DataSource = ds2;                                                    //MAYBE
			dataGridView2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;       //MAYBE
			con1.Close();
			dataGridView1.ClearSelection();
			dataGridView1.CurrentCell = null;
			dataGridView2.ClearSelection();      //MAYBE
			dataGridView2.CurrentCell = null;    //MAYBE


			dataGridView1.Update();
			dataGridView1.Refresh();

			dataGridView2.Update();        //MAYBE
			dataGridView2.Refresh();       //MAYBE
		}
		#endregion

		#region Consultant radio buttons
		//CONSULTANTS
		private void radioButton_Consultant1_CheckedChanged(object sender, EventArgs e)
		{
			MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["C969.Properties.Settings.U06N2HConnectionString"].ConnectionString);
			MySqlCommand cmd = new MySqlCommand("SELECT * FROM appointment WHERE userId = 1;", con);

			con.Open();
			MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
			DataTable ds = new DataTable();
			adapter.Fill(ds);
			dataGridView1.DataSource = ds;
			dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			con.Close();
			dataGridView1.ClearSelection();
			dataGridView1.CurrentCell = null;

			dataGridView1.Update();
			dataGridView1.Refresh();
		}

		private void radioButton_Consultant2_CheckedChanged(object sender, EventArgs e)
		{
			MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["C969.Properties.Settings.U06N2HConnectionString"].ConnectionString);
			MySqlCommand cmd = new MySqlCommand("SELECT * FROM appointment WHERE userId = 2;", con);    //1 MAYBE THIS is a PROBLEM

			con.Open();
			MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
			DataTable ds = new DataTable();
			adapter.Fill(ds);
			dataGridView1.DataSource = ds;
			dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			con.Close();
			dataGridView1.ClearSelection();
			dataGridView1.CurrentCell = null;

			dataGridView1.Update();
			dataGridView1.Refresh();
		}

		#endregion



		//MY CHOICE IS A BIG FAT MAYBE [to be decided]
	}
}
