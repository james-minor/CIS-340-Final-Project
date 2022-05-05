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
using System.Data.SqlClient;

namespace Final_Project
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            PasswordInput.Text = "";
            PasswordInput.PasswordChar = '*';
            PasswordInput.MaxLength = 20;

            ErrorLabel.Text = "";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {

            // TODO: On LoginButton_Click, check to see if the user is valid, then move to a new screen.
            // TODO: Switch from Windows Authentication to a Username and Password Auth for DB. This allows other PCs to use the app.
            string connectionString = "";
            try
            {
                connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Final_roject.Properties.Settings.ShopEasyDBConnectionString"].ConnectionString;
            }
            catch (NullReferenceException exception)
            {
                Console.WriteLine(exception.Message);
                ErrorLabel.Text = "A Connection to the DB Could not be Established.";
                return;
            }
            
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            connection.Close();


            /*
             * Customer customer = null;

            string selectStatement =
                "SELECT CustomerID, CompanyName, ContactName, Phone " +
                "FROM Customers " +
                "WHERE CustomerID = @CustomerID";

            using SqlConnection connection = new SqlConnection(Connection.ConnectionString);
            using SqlCommand command = new SqlCommand(selectStatement, connection);
            command.Parameters.AddWithValue("@CustomerID", customerID);
            connection.Open();

            using SqlDataReader reader = command.ExecuteReader(
                CommandBehavior.SingleRow & CommandBehavior.CloseConnection);

            if (reader.Read())
            {
                customer = new Customer
                {
                    CustomerID = (int)reader["CustomerID"],
                    CompanyName = reader["CompanyName"].ToString(),
                    ContactName = reader["ContactName"].ToString(),
                    Phone = reader["Phone"].ToString()
                };
            }

            return customer;
             * 
             */
        }

    }
}
