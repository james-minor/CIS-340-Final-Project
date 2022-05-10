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

namespace Final_Project
{
    public partial class AdminPortal : Form
    {
        public AdminPortal(string username)
        {
            InitializeComponent();

            UsernameLabel.Text = username;
            ProductOutputLabel.Text = "";

            PopulateDataGrid(ProductDataView, "SELECT * FROM TB_Products");
        }

        /* Attempts to create a connection to the SQL Database using the Connection class.
         * If any errors are encountered, they are output to the ProductOutputLabel, and
         * CreateDatabaseConnection will return FALSE.
         */
        private bool CreateDatabaseConnection()
        {
            if (!Connection.Create())
            {
                GenerateError(ProductOutputLabel, "A Connection to the DB Could not be Established.");
                return false;
            }

            if (!Connection.Open())
            {
                GenerateError(ProductOutputLabel, "Internal Database Error.");
                return false;
            }

            return true;
        }

        /* When called, PopulateDataGrid populates a passed data grid view table.
         * 
         * dataView:            The DataGridView to populate.
         * selectStatement:     The SQL SELECT statement to determine what data to SELECT.
         */
        private void PopulateDataGrid(DataGridView dataView, string selectStatement)
        {
            /* Attempting to create a Database Connection.
             */
            if(!CreateDatabaseConnection())
            {
                return;
            }

            SqlCommand command = new SqlCommand(selectStatement, Connection.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();
            adapter.Fill(table);
            Connection.Close();

            /* Reformatting and changing settings on the generated data table before pushing it to the form.
             */
            table.Columns["Product_ID"].ColumnName = "ID";

            dataView.DataSource = table;
        }

        /* Outputs a passed string to a passed label, setting the proper formatting for the label -
         * styling it as an error.
         * 
         * outputLabel:         The label to print to.
         * outputString:        The string to output.
         */
        private void GenerateError(Label outputLabel, string outputString)
        {
            outputLabel.ForeColor = Color.Brown;
            outputLabel.Text = outputString;
        }

        /* Outputs a passed string to a passed label, setting the proper formatting for the label -
         * styling it as a successful operation message.
         * 
         * outputLabel:         The label to print to.
         * outputString:        The string to output.
         */
        private void GenerateSuccess(Label outputLabel, string outputString)
        {
            outputLabel.ForeColor = Color.Green;
            outputLabel.Text = outputString;
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
                GenerateError(ProductOutputLabel, "ID Numbers may ONLY be integers.");
                return;
            }

            /* SELECT statement to get the product information.
             */
            string statement =
                "SELECT Product_ID, Name, Price, Category " +
                "FROM TB_Products " +
                "WHERE Product_ID = @Product_ID";

            /* Attempting to create a Database Connection.
             */
            if (!CreateDatabaseConnection())
            {
                return;
            }

            /* Adding in the values for the SELECT statement parameters.
             */
            SqlCommand command = new SqlCommand(statement, Connection.GetConnection());
            command.Parameters.AddWithValue("@Product_ID", ProductSearchIDInput.Text);

            using SqlDataReader reader = command.ExecuteReader(
                CommandBehavior.SingleRow & CommandBehavior.CloseConnection);

            if (reader.Read())
            {
                GenerateSuccess(ProductOutputLabel, "Product found successfully.");

                ProductSearchIDInput.Text = Convert.ToString(reader["Product_ID"]);

                ProductUpdateIDInput.Text = Convert.ToString(reader["Product_ID"]);
                ProductUpdateNameInput.Text = (string)reader["Name"];
                ProductUpdatePriceInput.Text = String.Format("{0:0.00}", reader["Price"]);
                ProductUpdateCategoryInput.Text = (string)reader["Category"];
            }
            else
            {
                GenerateError(ProductOutputLabel, "Product could not be found.");
            }

            Connection.Close();
        }

        private void ProductCreateButton_Click(object sender, EventArgs e)
        {
            /* Sanitizing the product ID data before attempting a database connection.
             */
            if (ProductUpdateIDInput.Text == "" || !int.TryParse(ProductUpdateIDInput.Text, out int id))
            {
                GenerateError(ProductOutputLabel, "Could not update product. Invalid ID.");
                return;
            }

            /* Sanitizing the product Price data before attempting a database connection.
             */
            double productPrice;
            bool priceIsNumeric = double.TryParse(ProductUpdatePriceInput.Text, out productPrice);
            if (!priceIsNumeric)
            {
                GenerateError(ProductOutputLabel, "Could not update product. Price must be numeric.");
                return;
            }
            if (productPrice < 0.0)
            {
                GenerateError(ProductOutputLabel, "Could not update product. Price cannot be negative.");
                return;
            }

            /* ----- Pushing Data to the Database -----
             */

            if (!CreateDatabaseConnection())
            {
                return;
            }

            string selectStatement =
                "SELECT COUNT(Product_ID) " +
                "FROM TB_Products " +
                "WHERE Product_ID = @Product_ID";

            /* Checking to see if the product already exists, so we don't attempt to create a new one,
             * instead we just update the existing one.
             */
            SqlCommand selectCommand = new SqlCommand(selectStatement, Connection.GetConnection());
            selectCommand.Parameters.AddWithValue("@Product_ID", ProductUpdateIDInput.Text);

            if ((int) selectCommand.ExecuteScalar() == 0)
            {
                /* Creating a new product.
                 */
                Connection.Close();
                if (!CreateDatabaseConnection())
                {
                    return;
                }

                string statement =
                    "INSERT INTO TB_Products " +
                    "VALUES (@Product_ID, @Price, @Category, @Name)";

                SqlCommand command = new SqlCommand(statement, Connection.GetConnection());
                command.Parameters.AddWithValue("@Product_ID", ProductUpdateIDInput.Text);
                command.Parameters.AddWithValue("@Price", ProductUpdatePriceInput.Text);
                command.Parameters.AddWithValue("@Category", ProductUpdateCategoryInput.Text);
                command.Parameters.AddWithValue("@Name", ProductUpdateNameInput.Text);

                if (command.ExecuteNonQuery() <= 0)
                {
                    GenerateError(ProductOutputLabel, "Product could not be created.");
                }
                else
                {
                    GenerateSuccess(ProductOutputLabel, "Product created successfully.");
                }
            }
            else
            {
                /* Updating an existing product.
                 */
                Connection.Close();
                if (!CreateDatabaseConnection())
                {
                    return;
                }

                string statement =
                    "UPDATE TB_Products " +
                    "SET Product_ID = @Product_ID, Price = @Price, Category = @Category, Name = @Name " +
                    "WHERE Product_ID = @Product_ID";

                SqlCommand command = new SqlCommand(statement, Connection.GetConnection());
                command.Parameters.AddWithValue("@Product_ID", ProductUpdateIDInput.Text);
                command.Parameters.AddWithValue("@Price", ProductUpdatePriceInput.Text);
                command.Parameters.AddWithValue("@Category", ProductUpdateCategoryInput.Text);
                command.Parameters.AddWithValue("@Name", ProductUpdateNameInput.Text);

                if(command.ExecuteNonQuery() <= 0)
                {
                    GenerateError(ProductOutputLabel, "Product could not be updated.");
                }
                else
                {
                    GenerateSuccess(ProductOutputLabel, "Product updated successfully.");
                }
            }

            PopulateDataGrid(ProductDataView, "SELECT * FROM TB_Products");
        }

        private void ProductDeleteButton_Click(object sender, EventArgs e)
        {
            /* Sanitizing the input data before attempting a database connection.
             */
            if (ProductUpdateIDInput.Text != "" && !int.TryParse(ProductUpdateIDInput.Text, out int id))
            {
                GenerateError(ProductOutputLabel, "Could not delete product. Invalid ID.");
                return;
            }

            /* SELECT statement to get the product information.
             */
            string statement =
                "DELETE " +
                "FROM TB_Products " +
                "WHERE Product_ID = @Product_ID ";

            /* Attempting to create a Database Connection.
             */
            if (!CreateDatabaseConnection())
            {
                return;
            }

            /* Adding in the values for the DELETE statement parameters.
             */
            SqlCommand command = new SqlCommand(statement, Connection.GetConnection());
            command.Parameters.AddWithValue("@Product_ID", ProductUpdateIDInput.Text);

            /* Running and Validating the SQL query.
             */
            int rowsAffected = command.ExecuteNonQuery();
            Connection.Close();

            if (rowsAffected > 0)
            {
                GenerateSuccess(ProductOutputLabel, "Product deleted successfully.");
            }
            else
            {
                GenerateError(ProductOutputLabel, "Cannot delete a product that does not exist.");
            }

            PopulateDataGrid(ProductDataView, "SELECT * FROM TB_Products");
        }

        private void UserSettingsButton_Click(object sender, EventArgs e)
        {

        }
    }
}
