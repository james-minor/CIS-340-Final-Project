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

            PopulateDataGrid();
        }

        /* Attempts to create a connection to the SQL Database using the Connection class.
         * If any errors are encountered, they are output to the ProductOutputLabel, and
         * CreateDatabaseConnection will return FALSE.
         */
        private bool CreateDatabaseConnection()
        {
            if (!Connection.Create())
            {
                ProductOutputLabel.ForeColor = Color.Brown;
                ProductOutputLabel.Text = "A Connection to the DB Could not be Established.";
                return false;
            }

            if (!Connection.Open())
            {
                ProductOutputLabel.ForeColor = Color.Brown;
                ProductOutputLabel.Text = "Internal Database Error.";
                return false;
            }

            return true;
        }

        private void PopulateDataGrid()
        {
            /* Attempting to create a Database Connection.
             */
            if(!CreateDatabaseConnection())
            {
                return;
            }

            SqlCommand command = new SqlCommand("SELECT * FROM TB_Products", Connection.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();
            adapter.Fill(table);
            Connection.Close();

            /* Reformatting and changing settings on the generated data table before pushing it to the form.
             */
            table.Columns["Product_ID"].ColumnName = "ID";

            ProductDataView.DataSource = table;
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
            command.Parameters.AddWithValue("@Name", ProductSearchNameInput.Text);

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

            Connection.Close();
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

            /* SELECT statement to get the product information.
             */
            string deleteStatement =
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
            SqlCommand deleteCommand = new SqlCommand(deleteStatement, Connection.GetConnection());
            deleteCommand.Parameters.AddWithValue("@Product_ID", ProductUpdateIDInput.Text);

            using SqlDataReader reader = deleteCommand.ExecuteReader(
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

            Connection.Close();
        }
    }
}
