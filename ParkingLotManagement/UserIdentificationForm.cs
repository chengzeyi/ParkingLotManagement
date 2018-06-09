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
    /// <summary>
    /// Control the user identification form and its procedure.
    /// </summary>
    public partial class UserIdentificationForm : Form
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public UserIdentificationForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Things to be done when loading user identification form.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">E.</param>
        private void UserIdentificationForm_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Action Performed when buttonSignIn Clicked.
        /// Check if the username and password is correct.
        /// And if it is, hide this form and start main form.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">E.</param>
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
                int count = DBConnection.DBQueryCount(
                    "SELECT username, password\n" +
                    "FROM Register\n" +
                    "WHERE username = '" + username + "'\n" +
                    "AND password = '" + pwd + "'"
                    );
                if (count != 0)
                {
                    MessageBox.Show("Succeeded to sign in!");
                    // Start the main form and hide this form.
                    Hide();
                    MainForm mainForm = new MainForm();
                    mainForm.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show("Failed to sign in!");
                    // this.textBoxUsername.Clear();
                    textBoxPwd.Clear();
                }
            }
            // The username or password is empty.
            else
            {
                MessageBox.Show("The username and password cannnot be empty!");
                // this.textBoxUsername.Clear();
                textBoxPwd.Clear();
            }
        }
    }
}
