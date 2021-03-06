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
using Microsoft.Data.SqlClient;

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
            UsernameInput.MaxLength = 25;

            PasswordInput.Text = "";
            PasswordInput.PasswordChar = '*';
            PasswordInput.MaxLength = 25;

            ErrorLabel.Text = "";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            /* SELECT statement to check if we have a valid Username and Password combination.
             */
            string statement =
                "SELECT Username, Password, IsAdmin " +
                "FROM TB_Users " +
                "WHERE Username = @Username " +
                "AND Password = @Password";

            /* Attempting to create a Database Connection.
             */
            if(!Connection.Create())
            {
                ErrorLabel.Text = "A Connection to the DB Could not be Established.";
                return;
            }
            if(!Connection.Open())
            {
                ErrorLabel.Text = "Internal Database Error.";
                return;
            }

            /* Adding in the values for the SELECT statement parameters.
             */
            SqlCommand command = new SqlCommand(statement, Connection.GetConnection());
            command.Parameters.AddWithValue("@Username", UsernameInput.Text);
            command.Parameters.AddWithValue("@Password", PasswordInput.Text);

            using SqlDataReader reader = command.ExecuteReader(
                CommandBehavior.SingleRow & CommandBehavior.CloseConnection);

            if (reader.Read())
            {
                Form userPortal = null;

                if ((bool)reader["IsAdmin"] == true)
                {
                    userPortal = new AdminPortal((string)reader["Username"]);
                }
                else
                {
                    userPortal = new UserPortal();
                }

                Connection.Close();
                this.Hide();
                userPortal.Show();
            }
            else
            {
                ErrorLabel.Text = "Incorrect Username or Password";
            }

            Connection.Close();
        }
    }
}
