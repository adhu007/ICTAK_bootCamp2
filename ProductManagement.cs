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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace bootCamp2
{
    public partial class ProductManagement : Form
    {

        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog = UserAndProduct; Integrated Security = True; Trust Server Certificate=True";
        public ProductManagement()
        {
            InitializeComponent();
        }

        private int userID = 0;

        public int userId
        {

            get { return userID; }
            set { userID = value; }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var userLogin = new userLoginPage();
            userLogin.Closed += (s, args) => this.Close();
            userLogin.Show();
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {

            string productName = nameTextBox.Text;

            decimal price = 0;
            decimal.TryParse(priceTextBox.Text, out price);

            int quantity = 0;
            Int32.TryParse(quantityTextBox.Text, out quantity);


            if (productName != "" && price != 0 && quantity != 0 && userID != 0)
            {


                string query = "INSERT INTO Products (UserID, Name, Price, Quantity) VALUES (@UserID, @Name, @Price, @Quantity)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    try
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@UserID", userID);
                            command.Parameters.AddWithValue("@Name", productName);
                            command.Parameters.AddWithValue("@Price", price);
                            command.Parameters.AddWithValue("@Quantity", quantity);

                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {

                                MessageBox.Show("Product added successfully!");

                            }
                            else
                            {
                                MessageBox.Show("Invalid! Please try again.");

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
                MessageBox.Show("All fields *required valid data.");
            }
        }

        private void viewProductsButton_Click(object sender, EventArgs e)
        {


            string query = "SELECT Name, Price, Quantity FROM Products WHERE UserID = @UserID";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@UserID",userID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                           DataTable dt = new DataTable();
                           dt.Load(reader);

                           dataGridView1.DataSource = dt;

                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An Error occured : {ex.Message}");
                }


            }

        }
    }
}
