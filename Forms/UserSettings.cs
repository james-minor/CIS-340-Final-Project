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
    public partial class UserSettings : Form
    {
        string currentUsername;
        Form previousForm;

        public UserSettings(string username, Form previous)
        {
            InitializeComponent();

            currentUsername = username;
            previousForm = previous;

            this.Text = currentUsername + " User Settings";
            OutputLabel.Text = "";
            UsernameOutputLabel.Text = "";
            PasswordOutputLabel.Text = "";

            FillUserData();
        }

        /* Fills the User Information fields with data pulled from the SQL Database.
         */
        private void FillUserData()
        {
            if (!Connection.Create())
            {
                OutputLabel.ForeColor = Color.Brown;
                OutputLabel.Text = "A Connection to the DB Could not be Established.";
                return;
            }

            if (!Connection.Open())
            {
                OutputLabel.ForeColor = Color.Brown;
                OutputLabel.Text = "Internal Database Error.";
                return;
            }

            string statement =
                "SELECT * " +
                "FROM TB_Users " +
                "WHERE Username = @Username";

            SqlCommand command = new SqlCommand(statement, Connection.GetConnection());
            command.Parameters.AddWithValue("@Username", currentUsername);

            using SqlDataReader reader = command.ExecuteReader(
                CommandBehavior.SingleRow & CommandBehavior.CloseConnection);

            if (reader.Read())
            {
                FirstNameInput.Text = Convert.ToString(reader["First_Name"]);
                LastNameInput.Text = Convert.ToString(reader["Last_Name"]);
                EmailInput.Text = Convert.ToString(reader["Email"]);
                PhoneInput.Text = Convert.ToString(reader["Phone"]);
            }
        }

        /* Takes the user back to their previous portal.
         */
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            previousForm.Show();
        }

        private void ChangeInformationButton_Click(object sender, EventArgs e)
        {
            if (PhoneInput.Text.Length <= 9 || int.TryParse(PhoneInput.Text, out int phone))
            {
                OutputLabel.ForeColor = Color.Brown;
                OutputLabel.Text = "Invalid Phone Number.";
                return;
            }

            string statement =
                "UPDATE TB_Users " +
                "SET First_Name = @FirstName, Last_Name = @LastName, Phone = @Phone, Email = @Email " +
                "WHERE Username = @Username";

            SqlCommand command = new SqlCommand(statement, Connection.GetConnection());
            command.Parameters.AddWithValue("@FirstName", FirstNameInput.Text);
            command.Parameters.AddWithValue("@LastName", LastNameInput.Text);
            command.Parameters.AddWithValue("@Phone", PhoneInput.Text);
            command.Parameters.AddWithValue("@Email", EmailInput.Text);
            command.Parameters.AddWithValue("@Username", currentUsername);

            if (command.ExecuteNonQuery() <= 0)
            {
                OutputLabel.ForeColor = Color.Brown;
                OutputLabel.Text = "Could not update information.";
            }
            else
            {
                OutputLabel.ForeColor = Color.Green;
                OutputLabel.Text = "Updated User Information.";
            }
        }

        private void ChangeUsernameButton_Click(object sender, EventArgs e)
        {
            if (!Connection.Create())
            {
                UsernameOutputLabel.ForeColor = Color.Brown;
                UsernameOutputLabel.Text = "A Connection to the DB Could not be Established.";
                return;
            }

            if (!Connection.Open())
            {
                UsernameOutputLabel.ForeColor = Color.Brown;
                UsernameOutputLabel.Text = "Internal Database Error.";
                return;
            }

            if (NewUsernameInput.Text == "")
            {
                UsernameOutputLabel.ForeColor = Color.Brown;
                UsernameOutputLabel.Text = "Username cannot be empty.";
                return;
            }

            string selectStatement =
                "SELECT COUNT(Username) " +
                "FROM TB_Users " +
                "WHERE Username = @Username";

            SqlCommand countCommand = new SqlCommand(selectStatement, Connection.GetConnection());
            countCommand.Parameters.AddWithValue("@Username", NewUsernameInput.Text);

            if ((int)countCommand.ExecuteScalar() == 0)
            {
                Connection.Close();
                Connection.Open();

                string updateStatement =
                    "UPDATE TB_Users " +
                    "SET Username = @NewUsername " +
                    "WHERE Username = @OldUsername";

                SqlCommand updateCommand = new SqlCommand(updateStatement, Connection.GetConnection());
                updateCommand.Parameters.AddWithValue("@NewUsername", NewUsernameInput.Text);
                updateCommand.Parameters.AddWithValue("@OldUsername", currentUsername);

                if(updateCommand.ExecuteNonQuery() > 0)
                {
                    LoginForm login = new LoginForm();
                    this.Hide();
                    login.Show();
                    return;
                }

                UsernameOutputLabel.ForeColor = Color.Brown;
                UsernameOutputLabel.Text = "Error Changing Username";
                return;
            }
            else
            {
                Connection.Close();

                UsernameOutputLabel.ForeColor = Color.Brown;
                UsernameOutputLabel.Text = "Username already taken.";
                return;
            }
        }

        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            if (!Connection.Create())
            {
                PasswordOutputLabel.ForeColor = Color.Brown;
                PasswordOutputLabel.Text = "A Connection to the DB Could not be Established.";
                return;
            }

            if (!Connection.Open())
            {
                PasswordOutputLabel.ForeColor = Color.Brown;
                PasswordOutputLabel.Text = "Internal Database Error.";
                return;
            }

            if (NewPasswordInput.Text == "")
            {
                PasswordOutputLabel.ForeColor = Color.Brown;
                PasswordOutputLabel.Text = "Password cannot be empty.";
                return;
            }

            string statement =
                "UPDATE TB_Users " +
                "SET Password = @Password " +
                "WHERE Username = @Username";

            SqlCommand command = new SqlCommand(statement, Connection.GetConnection());
            command.Parameters.AddWithValue("@Password", NewPasswordInput.Text);
            command.Parameters.AddWithValue("@Username", currentUsername);

            if (command.ExecuteNonQuery() > 0)
            {
                Connection.Close();

                PasswordOutputLabel.ForeColor = Color.Green;
                PasswordOutputLabel.Text = "Successfully changed password.";
                return;
            }

            Connection.Close();

            PasswordOutputLabel.ForeColor = Color.Brown;
            PasswordOutputLabel.Text = "Error changing password.";
            return;
            
        }
    }
}
