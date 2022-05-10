using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }

        private void UserSettings_Load(object sender, EventArgs e)
        {
            
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            previousForm.Show();
        }
    }
}
