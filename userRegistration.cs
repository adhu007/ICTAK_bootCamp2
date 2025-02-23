using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace bootCamp2
{
    public partial class userRegistration : Form
    {

        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog = UserAndProduct; Integrated Security = True; Trust Server Certificate=True";

        public userRegistration()
        {
            InitializeComponent();
        }

        private void backButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var welcome = new welcomePage();
            welcome.Closed += (s, args) => this.Close();
            welcome.Show();
        }

        private void registerButton2_Click(object sender, EventArgs e)
        {
            
            string userName = userNameTextBox.Text; 
            string email = emailTextBox.Text;
            string password = pwTextBox.Text;

            if (userName != "" && email != "" && password != "")
            {
                string query = "INSERT INTO Users (UserName, EmailID, Password) VALUES (@UserName, @EmailID, @Password)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    try
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@UserName", userName);
                            command.Parameters.AddWithValue("@EmailID", email);
                            command.Parameters.AddWithValue("@Password", password);

                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {

                                MessageBox.Show("Registration succeed! Please login using provided credentials.");

                            }
                            else
                            {
                                MessageBox.Show("Registration failed! Please try again.");

                            }


                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An Error occured! : {ex.Message}");

                    }
                }
            }
            else
            {
                MessageBox.Show("All fields are *required for new registration.");
            }
        }
    }
}
