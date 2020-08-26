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
	public partial class AddCustomer : Form
	{

		public static int currentCityId = -1;
		public static string selectedCountry = "";

		public AddCustomer()
		{
			InitializeComponent();
		}

		public void BackToMain()
		{
			MainForm redo = new MainForm();
		    this.Hide();
			redo.Show();
		}





		#region OOPSIES
		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			//SHIT
		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{
			//DAMN IT
		}

		#endregion

		private void button_Save_Click(object sender, EventArgs e)
		{
			DateTime nowtime = DateTime.Now;
			string formattime = nowtime.ToString("yyyy-MM-dd HH:mm:ss tt");

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

						command.CommandText = "INSERT INTO address(address, address2, cityId, postalCode, phone) " +
							"VALUES(@textBox_AddressLine1, @textBox_AddressLine2, @listBox_CityID, @textBox_ZipCode, @textBox_PhoneNumber);";

						command.Connection = con;
						con.Open();
						command.Parameters.AddWithValue("@textBox_AddressLine1", textBox_AddressLine1.Text);
						command.Parameters.AddWithValue("@textBox_AddressLine2", textBox_AddressLine2.Text);
						command.Parameters.AddWithValue("@listBox_CityID", listBox_CityID.SelectedIndex + 1);   //this is fucked
						command.Parameters.AddWithValue("@textBox_ZipCode", textBox_ZipCode.Text);
						command.Parameters.AddWithValue("@textBox_PhoneNumber", textBox_PhoneNumber.Text);
						command.ExecuteNonQuery();

						command.CommandText = "INSERT INTO customer (customerName, addressId, active, createDate, createdBy, lastUpdateBy) " +
							"VALUES (@textBox_CustomerName, @textBox_AddressId, @Active, @CreateDate, @CreatedBy, @lastUpdateBy);";

						long lastAddressId = command.LastInsertedId;

						command.Connection = con;

						command.Parameters.AddWithValue("@textBox_CustomerName", textBox_CustomerName.Text);
						command.Parameters.AddWithValue("@textBox_AddressId", lastAddressId);
						command.Parameters.AddWithValue("@Active", 1);
						command.Parameters.AddWithValue("@CreateDate", Convert.ToDateTime(formattime).ToUniversalTime());
						command.Parameters.AddWithValue("@CreatedBy", MainForm.currentUser);
						command.Parameters.AddWithValue("@LastUpdateBy", MainForm.currentUser);
						command.ExecuteNonQuery();
					}
					BackToMain();
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}



		private void button_Cancel_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure? All data will be discarded", "Add Customer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				BackToMain();
			}
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch(listBox_CityID.SelectedItem)	
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
