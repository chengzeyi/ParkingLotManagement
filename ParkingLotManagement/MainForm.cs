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
    public partial class MainForm : Form
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

        private void DataGridViewAllRefresh()
        {
            DBConnection dBConnection = new DBConnection(this.connectionString);
            DataSet dataSet = dBConnection.DBQuery(
                "SELECT parkingfloor, parkingno," +
                    "CASE parkingisused\n" +
                        "WHEN 0 THEN 'not used'\n" +
                        "WHEN 1 THEN 'used'\n" +
                    "END," +
                "parkingindatetime, carplatenumber\n" +
                "FROM ParkingLotStatus\n" +
                "ORDER BY parkingfloor, parkingno",
                "All");
            // Set dataSet as the data source of dataGridViewAll.
            this.dataGridViewAll.DataSource = dataSet;
            // Set the table neme.
            this.dataGridViewAll.DataMember = "All";
            this.dataGridViewAll.Columns[0].HeaderText = "floor";
            this.dataGridViewAll.Columns[1].HeaderText = "No.";
            this.dataGridViewAll.Columns[2].HeaderText = "status";
            this.dataGridViewAll.Columns[3].HeaderText = "entry time";
            this.dataGridViewAll.Columns[4].HeaderText = "plate number";

            dBConnection.Close();
        }

        private void DataGridViewFloor1Refresh()
        {
            DBConnection dBConnection = new DBConnection(this.connectionString);
            DataSet dataSet = dBConnection.DBQuery(
                "SELECT parkingfloor, parkingno," +
                    "CASE parkingisused\n" +
                        "WHEN 0 THEN 'not used'\n" +
                        "WHEN 1 THEN 'used'\n" +
                    "END," +
                "parkingindatetime, carplatenumber\n" +
                "FROM ParkingLotStatus\n" +
                "WHERE parkingfloor = 1\n" +
                "ORDER BY parkingfloor, parkingno",
                "All");
            // Set dataSet as the data source of dataGridViewAll.
            this.dataGridViewFloor1.DataSource = dataSet;
            // Set the table neme.
            this.dataGridViewFloor1.DataMember = "All";
            this.dataGridViewFloor1.Columns[0].HeaderText = "floor";
            this.dataGridViewFloor1.Columns[1].HeaderText = "No.";
            this.dataGridViewFloor1.Columns[2].HeaderText = "status";
            this.dataGridViewFloor1.Columns[3].HeaderText = "entry time";
            this.dataGridViewFloor1.Columns[4].HeaderText = "plate number";

            dBConnection.Close();
        }

        private void DataGridViewFloor2Refresh()
        {
            DBConnection dBConnection = new DBConnection(this.connectionString);
            DataSet dataSet = dBConnection.DBQuery(
                "SELECT parkingfloor, parkingno," +
                    "CASE parkingisused\n" +
                        "WHEN 0 THEN 'not used'\n" +
                        "WHEN 1 THEN 'used'\n" +
                    "END," +
                "parkingindatetime, carplatenumber\n" +
                "FROM ParkingLotStatus\n" +
                "WHERE parkingfloor = 2\n" +
                "ORDER BY parkingfloor, parkingno",
                "All");
            // Set dataSet as the data source of dataGridViewAll.
            this.dataGridViewFloor2.DataSource = dataSet;
            // Set the table neme.
            this.dataGridViewFloor2.DataMember = "All";
            this.dataGridViewFloor2.Columns[0].HeaderText = "floor";
            this.dataGridViewFloor2.Columns[1].HeaderText = "No.";
            this.dataGridViewFloor2.Columns[2].HeaderText = "status";
            this.dataGridViewFloor2.Columns[3].HeaderText = "entry time";
            this.dataGridViewFloor2.Columns[4].HeaderText = "plate number";

            dBConnection.Close();
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.dataGridViewAll.ReadOnly = true;
            this.dataGridViewFloor1.ReadOnly = true;
            this.dataGridViewFloor2.ReadOnly = true;
            this.dataGridViewSummary.ReadOnly = true;

            this.DataGridViewAllRefresh();
            this.DataGridViewFloor1Refresh();
            this.DataGridViewFloor2Refresh();
        }

        private void ButtonEnter_Click(object sender, EventArgs e)
        {
            // Find out whether there is any empty position.
            string plateNumber = this.textBoxEnteringCar.Text.Trim();
            if(plateNumber.Length == 0)
            {
                MessageBox.Show("Car plate number cannot be empty!");
                return;
            }
            DBConnection dBConnection = new DBConnection(this.connectionString);
            DataSet dataSet = dBConnection.DBQuery(
                "SELECT parkingfloor, parkingno\n" +
                "FROM ParkingLotStatus\n" +
                "WHERE parkingisused = 0 AND carplatenumber <> '" + plateNumber + "'\n" +
                "ORDER BY parkingfloor, parkingno",
                "ParkingNotUsed");
            // No empty position or car plate number repeats.
            if (dataSet.Tables["ParkingNotUsed"].Rows.Count == 0)
            {
                MessageBox.Show("No empty position or car plate number repeats!");
            }
            // Empty position.
            else
            {
                string floor = dataSet.Tables["ParkingNotUsed"].Rows[0]["parkingfloor"].ToString();
                string no = dataSet.Tables["ParkingNotUsed"].Rows[0]["parkingno"].ToString();
                if (dBConnection.DBCmd(
                    "UPDATE ParkingLotStatus\n" +
                    "SET parkingisused = 1, parkingindatetime = GETDATE(), carplatenumber = '" + plateNumber + "'\n" +
                    "WHERE parkingfloor = " + floor + "AND parkingno = " + no
                    ) == 0)
                {
                    MessageBox.Show("Failed to update the database!");
                }
                else
                {
                    MessageBox.Show(
                        "Entry allowed!\n" +
                        "Car plate number: " + plateNumber + ".\n" +
                        "Car position: floor " + floor + ", number " + no + "."
                        );
                }
            }
            this.textBoxEnteringCar.Clear();
            this.DataGridViewAllRefresh();
            this.DataGridViewFloor1Refresh();
            this.DataGridViewFloor2Refresh();
        }

        private void ButtonLeft_Click(object sender, EventArgs e)
        {
            string plateNumber = this.textBoxLeftingCar.Text.Trim();
            // Find out whether the plate number is right.
            if(true)
            {
                MessageBox.Show("Wrong plate number!");
            }
            else
            {
                // ...
                MessageBox.Show(
                    "Car left!\n" +
                    "Total parking fee: " + "."
                    );
            }
            this.textBoxLeftingCar.Clear();
        }
    }
}
