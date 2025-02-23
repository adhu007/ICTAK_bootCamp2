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

namespace bootCamp2
{
    public partial class userLoginPage : Form
    {


        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog = UserAndProduct; Integrated Security = True; Trust Server Certificate=True";

        public userLoginPage()
        {
            InitializeComponent();
        }

        private void backButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var welcome = new welcomePage();
            welcome.Closed += (s, args) => this.Close();
            welcome.Show();
        }

        private void loginButton2_Click(object sender, EventArgs e)
        {

            string email = emailTextBox.Text;
            string inputpw = pwTextBox.Text;

            if (email != "" && inputpw != "")
            {

                string password = string.Empty;
                int userId = 0;

                string query = "SELECT UserId, Password FROM Users WHERE EmailID = @EmailID";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    try
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {

                            command.Parameters.AddWithValue("@EmailID", email);

                            using (SqlDataReader reader = command.ExecuteReader())
                            {

                                while (reader.Read())
                                {
                                    userId = (int)reader["UserId"];
                                    password = (string)reader["Password"];

                                }


                            }

                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An Error occured! : {ex.Message}");
                    }

                }

                if (password == inputpw)
                {

                    this.Hide();
                    var productPage = new ProductManagement();
                    productPage.Closed += (s, args) => this.Close();
                    productPage.userId = userId;
                    productPage.Show();

                }
                else
                {
                    MessageBox.Show($"Incorrect EmailId/Password! ");
                }
            }
            else
            {
                MessageBox.Show($"Please enter your Email Id and Password.");
            }
        }
    }
}
