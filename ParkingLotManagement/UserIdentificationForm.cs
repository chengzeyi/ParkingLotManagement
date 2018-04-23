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
        private string connectionString =
            "Data Source=(localdb)\\MSSQLLocalDB;" +
            "Initial Catalog=Test;" +
            "Integrated Security=True;" +
            "Connect Timeout=30;" +
            "Encrypt=False;" +
            "TrustServerCertificate=False;" +
            "ApplicationIntent=ReadWrite;" +
            "MultiSubnetFailover=False";

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
            string username = this.textBoxUsername.Text.Trim();
            // Get the password.
            string pwd = this.textBoxPwd.Text.Trim();
            // The signal variable to judge whether the

            // The username and password are not empty.
            if(username.Length != 0 && pwd.Length != 0)
            {
                DBConnection dbconn = new DBConnection(this.connectionString);
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
                    this.Hide();
                    MainForm mainForm = new MainForm();
                    mainForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Incorrect username or password!");
                //this.textBoxUsername.Clear();
                this.textBoxPwd.Clear();
                }
            }
            // The username or password is empty.
            else
            {
                MessageBox.Show("The username and password cannnot be empty!");
                //this.textBoxUsername.Clear();
                this.textBoxPwd.Clear();
            }
        }
    }
}
