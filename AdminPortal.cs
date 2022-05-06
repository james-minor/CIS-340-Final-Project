﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Final_Project
{
    public partial class AdminPortal : Form
    {
        public AdminPortal(string username)
        {
            InitializeComponent();

            UsernameLabel.Text = username;

            ProductOutputLabel.Text = "";
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void ProductSearchButton_Click(object sender, EventArgs e)
        {
            /* Sanitizing the input data before attempting a database connection.
             */
            if(ProductSearchIDInput.Text != "" && !int.TryParse(ProductSearchIDInput.Text, out int id))
            {
                ProductOutputLabel.ForeColor = Color.Brown;
                ProductOutputLabel.Text = "ID Numbers may ONLY be integers.";
                return;
            }

            /* SELECT statement to get the product information.
             */
            string statement =
                "SELECT Product_ID, Name, Price, Category " +
                "FROM TB_Products " +
                "WHERE Product_ID = @Product_ID " +
                "OR Name = @Name";

            /* Creating the connection to the SQL database.
             * Catching any errors regarding the ConnectionString.
             */
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(Connection.ConnectionString);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                ProductOutputLabel.ForeColor = Color.Brown;
                ProductOutputLabel.Text = "A Connection to the DB Could not be Established.";
                return;
            }

            /* Adding in the values for the SELECT statement parameters.
             */
            SqlCommand command = new SqlCommand(statement, connection);
            command.Parameters.AddWithValue("@Product_ID", ProductSearchIDInput.Text);
            command.Parameters.AddWithValue("@Name", ProductSearchNameInput.Text);

            /* Failsafe, catching any Exceptions that get thrown for any reason after attempting to
             * open the connection.
             */
            try
            {
                connection.Open();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                ProductOutputLabel.ForeColor = Color.Brown;
                ProductOutputLabel.Text = "Internal Database Error.";
                return;
            }

            using SqlDataReader reader = command.ExecuteReader(
                CommandBehavior.SingleRow & CommandBehavior.CloseConnection);

            if (reader.Read())
            {
                ProductOutputLabel.ForeColor = Color.Green;
                ProductOutputLabel.Text = "Product found successfully.";

                ProductSearchIDInput.Text = Convert.ToString(reader["Product_ID"]);
                ProductSearchNameInput.Text = (string)reader["Name"];

                ProductUpdateIDInput.Text = Convert.ToString(reader["Product_ID"]);
                ProductUpdateNameInput.Text = (string)reader["Name"];
                ProductUpdatePriceInput.Text = String.Format("{0:0.00}", reader["Price"]);
                ProductUpdateCategoryInput.Text = (string)reader["Category"];
            }
            else
            {
                ProductOutputLabel.ForeColor = Color.Brown;
                ProductOutputLabel.Text = "Product could not be found.";
            }

            connection.Close();
        }

        private void ProductCreateButton_Click(object sender, EventArgs e)
        {

        }

        private void ProductDeleteButton_Click(object sender, EventArgs e)
        {
            /* Sanitizing the input data before attempting a database connection.
             */
            if (ProductUpdateIDInput.Text != "" && !int.TryParse(ProductUpdateIDInput.Text, out int id))
            {
                ProductOutputLabel.ForeColor = Color.Brown;
                ProductOutputLabel.Text = "Could not delete product. Invalid ID.";
                return;
            }

            /* Counting the amount of rows before deletion.
             */
            string selectStatement =
                "SELECT COUNT(Product_ID) " +
                "FROM TB_Products";

            // TODO: Count before and after the deletion to verify a product was deleted.
            // TODO: Create a database connection function in the Connection static class, so it fucking works.

            /* SELECT statement to get the product information.
             */
            string deleteStatement =
                "DELETE " +
                "FROM TB_Products " +
                "WHERE Product_ID = @Product_ID ";

            /* Creating the connection to the SQL database.
             * Catching any errors regarding the ConnectionString.
             */
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(Connection.ConnectionString);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                ProductOutputLabel.ForeColor = Color.Brown;
                ProductOutputLabel.Text = "A Connection to the DB Could not be Established.";
                return;
            }

            /* Adding in the values for the DELETE statement parameters.
             */
            SqlCommand command = new SqlCommand(deleteStatement, connection);
            command.Parameters.AddWithValue("@Product_ID", ProductUpdateIDInput.Text);

            /* Failsafe, catching any Exceptions that get thrown for any reason after attempting to
             * open the connection.
             */
            try
            {
                connection.Open();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                ProductOutputLabel.ForeColor = Color.Brown;
                ProductOutputLabel.Text = "Internal Database Error.";
                return;
            }

            using SqlDataReader reader = command.ExecuteReader(
                CommandBehavior.SingleRow & CommandBehavior.CloseConnection);

            if (reader.Read())
            {
                ProductOutputLabel.ForeColor = Color.Green;
                ProductOutputLabel.Text = "Product deleted successfully.";
            }
            else
            {
                ProductOutputLabel.ForeColor = Color.Brown;
                ProductOutputLabel.Text = "Product could not be found.";
            }

            connection.Close();
        }
    }
}
