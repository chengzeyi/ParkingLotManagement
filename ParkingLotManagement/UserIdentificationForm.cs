using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParkingLotDB;

namespace ParkingLotManagement
{
    public partial class UserIdentificationForm : Form
    {
        public UserIdentificationForm()
        {
            InitializeComponent();
        }

        private void UserIdentificationForm_Load(object sender, EventArgs e)
        {

        }

        private void ButtonSignIn_Click(object sender, EventArgs e)
        {
            // Get the username.
            string username = textBoxUsername.Text.Trim();
            // Get the password.
            string pwd = textBoxPwd.Text.Trim();
            // The signal variable to judge whether the

            // The username and password are not empty.
            if(username.Length != 0 && pwd.Length != 0)
            {
                DBConnection dbconn = new DBConnection();
                int count = dbconn.DBQueryCount(
                    "SELECT username, password\n" +
                    "FROM Register\n" +
                    "WHERE username = '" + username + "'\n" +
                    "AND password = '" + pwd + "'"
                    );
                dbconn.Close();
                if (count != 0)
                {
                    MessageBox.Show("User Identification succeeded!");
                    // Start the main form and hide this form.
                }
                else
                {
                    MessageBox.Show("Incorrect username or password!");
                }
            }
            // The username or password is empty.
            else
            {
                MessageBox.Show("The username and password cannnot be empty!");
            }
        }
    }
}
