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
        string currentUsername;

        public AdminPortal(string username)
        {
            InitializeComponent();

            currentUsername = username;
            UsernameLabel.Text = currentUsername;

            ProductOutputLabel.Text = "";
            UserOutputLabel.Text = "";

            PopulateDataGrid(ProductDataView, "SELECT * FROM TB_Products");
            PopulateDataGrid(UserDataView, "SELECT Username, First_Name, Last_Name, Phone, Email, IsAdmin, IsVeteran, IsSenior, IsTeacher FROM TB_Users");

            /* Styling the Product DataGridView.
             */
            int[] productDataViewColumnWeights =
{
                50, 50, 100, 100
            };

            for (int i = 0; i < productDataViewColumnWeights.Length; i++)
            {
                ProductDataView.Columns[i].FillWeight = productDataViewColumnWeights[i];
                ProductDataView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            ProductDataView.Columns[0].HeaderText = "ID";
            ProductDataView.Columns[1].DefaultCellStyle.Format = "c";

            /* Styling the User DataGridView
             */
            int[] userDataViewColumnWeights =
            {
                50, 40, 40, 32, 65, 25, 25, 25, 25
            };

            for(int i = 0; i < userDataViewColumnWeights.Length; i++)
            {
                UserDataView.Columns[i].FillWeight = userDataViewColumnWeights[i];
                UserDataView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            UserDataView.Columns[1].HeaderText = "First Name";
            UserDataView.Columns[2].HeaderText = "Last Name";
            UserDataView.Columns[5].HeaderText = "Admin";
            UserDataView.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            UserDataView.Columns[6].HeaderText = "Veteran";
            UserDataView.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            UserDataView.Columns[7].HeaderText = "Senior";
            UserDataView.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            UserDataView.Columns[8].HeaderText = "Teacher";
            UserDataView.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        /* Attempts to create a connection to the SQL Database using the Connection class.
         * If any errors are encountered, they are output to the ProductOutputLabel, and
         * CreateDatabaseConnection will return FALSE.
         * 
         * outputLabel:         The Label to output any errors to.
         */
        private bool CreateDatabaseConnection(Label outputLabel)
        {
            if (!Connection.Create())
            {
                GenerateError(outputLabel, "A Connection to the DB Could not be Established.");
                return false;
            }

            if (!Connection.Open())
            {
                GenerateError(outputLabel, "Internal Database Error.");
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
            if(!CreateDatabaseConnection(ProductOutputLabel))
            {
                return;
            }

            SqlCommand command = new SqlCommand(selectStatement, Connection.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();
            adapter.Fill(table);
            Connection.Close();

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

        /* ------- Global Form Buttons -------
         */
        private void UserSettingsButton_Click(object sender, EventArgs e)
        {
            Form settingsForm = new UserSettings(currentUsername, this);
            this.Hide();
            settingsForm.Show();
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

        /* ------- Product Tab Functions -------
         */
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
            if (!CreateDatabaseConnection(ProductOutputLabel))
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

            if (!CreateDatabaseConnection(ProductOutputLabel))
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
                if (!CreateDatabaseConnection(ProductOutputLabel))
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
                if (!CreateDatabaseConnection(ProductOutputLabel))
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
            if (!CreateDatabaseConnection(ProductOutputLabel))
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

        /* ------- User Tab Functions -------
         */
        
        private void UserSearchButton_Click(object sender, EventArgs e)
        {
            /* Sanitizing the input data before attempting a database connection.
             */
            if (SearchUserUsernameInput.Text == "")
            {
                GenerateError(UserOutputLabel, "Invalid Username.");
                return;
            }

            /* SELECT statement to get the user information.
             */
            string statement =
                "SELECT Username, First_Name, Last_Name, Phone, Email, IsAdmin, IsVeteran, IsSenior, IsTeacher " +
                "FROM TB_Users " +
                "WHERE Username = @Username";

            /* Attempting to create a Database Connection.
             */
            if (!CreateDatabaseConnection(UserOutputLabel))
            {
                return;
            }

            /* Adding in the values for the SELECT statement parameters.
             */
            SqlCommand command = new SqlCommand(statement, Connection.GetConnection());
            command.Parameters.AddWithValue("@Username", SearchUserUsernameInput.Text);

            using SqlDataReader reader = command.ExecuteReader(
                CommandBehavior.SingleRow & CommandBehavior.CloseConnection);

            if (reader.Read())
            {
                GenerateSuccess(UserOutputLabel, "User found successfully.");

                UpdateUserUsernameInput.Text = Convert.ToString(reader["Username"]);
                UpdateUserFirstNameInput.Text = Convert.ToString(reader["First_Name"]);
                UpdateUserLastNameInput.Text = Convert.ToString(reader["Last_Name"]);
                UpdateUserPhoneInput.Text = Convert.ToString(reader["Phone"]);
                UpdateUserEmailInput.Text = Convert.ToString(reader["Email"]);

                UpdateUserAdminCheckbox.Checked = Convert.ToBoolean(reader["IsAdmin"]);
                UpdateUserVeteranCheckbox.Checked = Convert.ToBoolean(reader["IsVeteran"]);
                UpdateUserSeniorCheckbox.Checked = Convert.ToBoolean(reader["IsSenior"]);
                UpdateUserTeacherCheckbox.Checked = Convert.ToBoolean(reader["IsTeacher"]);
            }
            else
            {
                GenerateError(UserOutputLabel, "User could not be found.");
            }

            Connection.Close();
        }

        private void UpdateUserButton_Click(object sender, EventArgs e)
        {
            /* Sanitizing the product ID data before attempting a database connection.
             */
            if (UpdateUserUsernameInput.Text == "")
            {
                GenerateError(UserOutputLabel, "Could not update user. Invalid Username.");
                return;
            }

            if (!CreateDatabaseConnection(UserOutputLabel))
            {
                return;
            }

            string statement =
                "UPDATE TB_Users " +
                "SET First_Name = @FirstName, Last_Name = @LastName, Phone = @Phone, Email = @Email, " +
                "IsAdmin = @Admin, IsVeteran = @Veteran, IsSenior = @Senior, IsTeacher = @Teacher " +
                "WHERE Username = @Username";

            SqlCommand command = new SqlCommand(statement, Connection.GetConnection());
            command.Parameters.AddWithValue("@FirstName", UpdateUserFirstNameInput.Text);
            command.Parameters.AddWithValue("@LastName", UpdateUserLastNameInput.Text);
            command.Parameters.AddWithValue("@Phone", UpdateUserPhoneInput.Text);
            command.Parameters.AddWithValue("@Email", UpdateUserEmailInput.Text);
            command.Parameters.AddWithValue("@Admin", UpdateUserAdminCheckbox.Checked);
            command.Parameters.AddWithValue("@Veteran", UpdateUserVeteranCheckbox.Checked);
            command.Parameters.AddWithValue("@Senior", UpdateUserSeniorCheckbox.Checked);
            command.Parameters.AddWithValue("@Teacher", UpdateUserTeacherCheckbox.Checked);
            command.Parameters.AddWithValue("@Username", UpdateUserUsernameInput.Text);
                
            if (command.ExecuteNonQuery() <= 0)
            {
                GenerateError(UserOutputLabel, "User could not be updated.");
            }
            else
            {
                GenerateSuccess(UserOutputLabel, "User information updated successfully.");
            }

            PopulateDataGrid(UserDataView, "SELECT Username, First_Name, Last_Name, Phone, Email, IsAdmin, IsVeteran, IsSenior, IsTeacher FROM TB_Users");
        }

        private void DeleteUserButton_Click(object sender, EventArgs e)
        {
            /* Sanitizing the input data before attempting a database connection.
             */
            if (UpdateUserUsernameInput.Text == "")
            {
                GenerateError(UserOutputLabel, "Could not delete user. Invalid Username.");
                return;
            }

            if (UpdateUserUsernameInput.Text == currentUsername)
            {
                GenerateError(UserOutputLabel, "Cannot delete currently logged in user.");
               return;
            }

            /* DELETE statement to remove the user information.
             */
            string statement =
                "DELETE " +
                "FROM TB_Users " +
                "WHERE Username = @Username ";

            /* Attempting to create a Database Connection.
             */
            if (!CreateDatabaseConnection(UserOutputLabel))
            {
                return;
            }

            /* Adding in the values for the DELETE statement parameters.
             */
            SqlCommand command = new SqlCommand(statement, Connection.GetConnection());
            command.Parameters.AddWithValue("@Username", UpdateUserUsernameInput.Text);

            /* Running and Validating the SQL query.
             */
            int rowsAffected = command.ExecuteNonQuery();
            Connection.Close();

            if (rowsAffected > 0)
            {
                GenerateSuccess(UserOutputLabel, "User deleted successfully.");
            }
            else
            {
                GenerateError(UserOutputLabel, "Cannot delete a user that does not exist.");
            }

            PopulateDataGrid(UserDataView, "SELECT Username, First_Name, Last_Name, Phone, Email, IsAdmin, IsVeteran, IsSenior, IsTeacher FROM TB_Users");
        }

        private void CreateUserButton_Click(object sender, EventArgs e)
        {

        }
    }
}
