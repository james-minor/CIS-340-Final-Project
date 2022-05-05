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

            // TODO: Properly get connection string from App.Config, currently throwing null exception.
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ShopEasyDBConnectionString"].ConnectionString;
            Console.WriteLine(connectionString);
        }

    }
}
