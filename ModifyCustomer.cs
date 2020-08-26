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
	public partial class ModifyCustomer : Form
	{
		int currentCityId = -2;
		string selectedCountry = "";
		int currentAddressId = -1;


		public ModifyCustomer()
		{
			InitializeComponent();
		}

		public void BackToMain()
		{
			MainForm redo = new MainForm();
			this.Hide();
			redo.Show();
		}

		private void ModifyCustomer_Load(object sender, EventArgs e)
		{
			string CS = ConfigurationManager.ConnectionStrings["C969.Properties.Settings.U06N2HConnectionString"].ConnectionString;

			using (MySqlConnection con = new MySqlConnection(CS))
			{
				MySqlCommand command = new MySqlCommand("SELECT * FROM customer WHERE customerId='" + MainForm.currentCustomerID + "'", con);
				con.Open();
				MySqlDataReader read = command.ExecuteReader();
				if (read.Read())
				{
					textBox_CustomerName.Text = read["customerName"].ToString();
				}
				else
				{
					MessageBox.Show("Fatal Error, Program will self destruct in 3..2..1..");
				}
			}

			using (MySqlConnection con = new MySqlConnection(CS))
			{
				int currentSelectedCityId = -0;

				MySqlCommand command = new MySqlCommand("SELECT * FROM address WHERE addressId='" + MainForm.currentAddressID + "'", con);
				con.Open();
				MySqlDataReader read = command.ExecuteReader();
				if (read.Read())
				{
					textBox_AddressLine1.Text = read["address"].ToString();
					textBox_AddressLine2.Text = read["address2"].ToString();
					currentSelectedCityId = Convert.ToInt32(read["cityId"].ToString());
					textBox_ZipCode.Text = read["postalCode"].ToString();
					textBox_PhoneNumber.Text = read["phone"].ToString();

					//CITY??
				}
			}



		}

		private void textBox_CustomerName_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
			{
				e.Handled = true;
				base.OnKeyPress(e);
				MessageBox.Show("Letters only for the Name text box", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void button_Save_Click(object sender, EventArgs e)
		{
			//DateTime nowtime = DateTime.Now;
			//string formattime = nowtime.ToString("yyyy-MM-dd HH:mm:ss tt");

			try
			{
				if (textBox_CustomerName.Text == "" || textBox_AddressLine1.Text == "" || listBox_CityID.Text == "" || textBox_ZipCode.Text == "" || textBox_PhoneNumber.Text == "")
				{
					MessageBox.Show("Enter values for ALL fields!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{
					string CS = ConfigurationManager.ConnectionStrings["C969.Properties.Settings.U06N2HConnectionString"].ConnectionString;
					using (MySqlConnection con = new MySqlConnection(CS))
					{
						MySqlCommand command = new MySqlCommand();

						command.CommandText = "UPDATE customer SET customerName = @textBox_CustomerName, addressId = @addressId WHERE customerId = @CustomerId;";

						command.Connection = con;
						con.Open();

						command.Parameters.AddWithValue("@textBox_CustomerName", textBox_CustomerName.Text);
						command.Parameters.AddWithValue("@CustomerId", MainForm.currentCustomerID);
						command.Parameters.AddWithValue("@addressId", MainForm.currentAddressID);
						command.ExecuteNonQuery();

						command.CommandText = "Set FOREIGN_KEY_CHECKS = 0; UPDATE address SET address = @textBox_AddressLine1, address2 = @textBox_AddressLine2, cityId = " +
							"@listBox_CityID, postalCode = @textBox_ZipCode, phone = @textBox_PhoneNumber WHERE addressId = @addressId; SET FOREIGN_KEY_CHECKS = 1; "; //1


					
						command.Parameters.AddWithValue("@textBox_AddressLine1", textBox_AddressLine1.Text);
						command.Parameters.AddWithValue("@textBox_AddressLine2", textBox_AddressLine2.Text);
						command.Parameters.AddWithValue("@listBox_CityID", listBox_CityID.SelectedIndex);
						command.Parameters.AddWithValue("@textBox_ZipCode", textBox_ZipCode.Text);
						command.Parameters.AddWithValue("@textBox_PhoneNumber", textBox_PhoneNumber.Text);
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
			if (MessageBox.Show("Are you sure? All unsaved data will be discarded", "Add Customer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				BackToMain();
			}
		}

		private void listBox_CityID_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (listBox_CityID.SelectedItem)
			{
				case "New York":
					currentCityId = 1;
					selectedCountry = "US";
					break;
				case "Los Angeles":
					currentCityId = 2;
					selectedCountry = "US";
					break;
				case "Toronto":
					currentCityId = 3;
					selectedCountry = "Canada";
					break;
				case "Vancouver":
					currentCityId = 4;
					selectedCountry = "Canada";
					break;
				case "Oslo":
					currentCityId = 5;
					selectedCountry = "Norway";
					break;
			}
	
		
		
		
		}
	}
}
