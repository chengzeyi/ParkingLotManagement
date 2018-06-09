using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using ParkingLotDB;

namespace ParkingLotManagement
{
    /// <summary>
    /// Control the main form and its procedure.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Enum used for representing diagram mode.
        /// </summary>
        enum DiagramMode { Monthly, Yearly };
        /// <summary>
        /// Store the configuration of fee count.
        /// </summary>
        private decimal pricePerTenMinutes;
        /// <summary>
        /// Store all configurations' names.
        /// </summary>
        private List<string> configNames = new List<string>();
        /// <summary>
        /// Store all configurations' prices.
        /// </summary>
        private List<decimal> listPricePerTenMinutes = new List<decimal>();
        /// <summary>
        /// Store the current diagram mode.
        /// </summary>
        private DiagramMode diagramMode;

        /// <summary>
        /// Make a series according to the given data table.
        /// The chart type of the series will be set to line type.
        /// If the x is not found in the table, its corresponding y value
        /// will be zero.
        /// </summary>
        /// <param name="seriesName">The series' name.</param>
        /// <param name="xCount">The total count of points.</param>
        /// <param name="dt">The given data table.</param>
        /// <returns>The series you want.</returns>
        private Series MakeSeries(string seriesName, int xCount, DataTable dt)
        {
            Series series = new Series(seriesName)
            {
                // Set chart type to be Line Chart.
                ChartType = SeriesChartType.Line
            };
            int rowIndex = 0;
            for (int i = 1; i <= xCount; i++)
            {
                // Find data in the dataTable.
                if(rowIndex < dt.Rows.Count && int.Parse(dt.Rows[rowIndex][1].ToString()) == i)
                {
                    series.Points.AddXY(i, float.Parse(dt.Rows[rowIndex][0].ToString()));
                    rowIndex++;
                }
                // Not find.
                else
                {
                    series.Points.AddXY(i, 0);
                }
            }
            return series;
        }

        /// <summary>
        /// Initialize comboBoxConfig by adding items to it and setting
        /// its default selected item to the first one. class member variables
        /// configNames and listPricePerTenMinutes will also be initialized in
        /// this method.
        /// </summary>
        private void InitComboBoxConfig()
        {
            try
            {
                DataSet dataSet = DBConnection.DBQuery(
                    "SELECT configname, pricepertenminutes FROM ParkingLotConfig", "Config");
                // Get.
                foreach (DataRow dr in dataSet.Tables["Config"].Rows)
                {
                    configNames.Add(dr[0].ToString());
                    listPricePerTenMinutes.Add(decimal.Parse(dr[1].ToString()));
                }
                // Add.
                foreach (string configName in configNames)
                {
                    comboBoxConfig.Items.Add(configName);
                }
                // Set the first to be selected.
                comboBoxConfig.SelectedIndex = 0;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        /// <summary>
        /// Initialize comboBoxDiagramMode by adding items to it
        /// and setting its default selected item to "monthly".
        /// </summary>
        private void InitComboBoxDiagramMode()
        {
            try
            {
                // Add monthly option item.
                comboBoxDiagramMode.Items.Add("monthly");
                // Add yearly option item
                comboBoxDiagramMode.Items.Add("yearly");
                // Defaultly select monthly option.
                comboBoxDiagramMode.SelectedIndex = 0;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        /// <summary>
        /// Refresh dataGridViewAll by resetting its data
        /// source and table name and columns' name.
        /// </summary>
        private void DataGridViewAllRefresh()
        {
            try
            {
                DataSet dataSet = DBConnection.DBQuery(
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
                dataGridViewAll.DataSource = dataSet;
                // Set the table neme.
                dataGridViewAll.DataMember = "All";
                // Set columns' name.
                dataGridViewAll.Columns[0].HeaderText = "floor";
                dataGridViewAll.Columns[1].HeaderText = "No.";
                dataGridViewAll.Columns[2].HeaderText = "status";
                dataGridViewAll.Columns[3].HeaderText = "entry time";
                dataGridViewAll.Columns[4].HeaderText = "plate number";
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        /// <summary>
        /// Refresh dataGridViewFloor1 by resetting its data
        /// source and table name and columns' name.
        /// </summary>
        private void DataGridViewFloor1Refresh()
        {
            try
            {
                DataSet dataSet = DBConnection.DBQuery(
                    "SELECT parkingfloor, parkingno," +
                        "CASE parkingisused\n" +
                            "WHEN 0 THEN 'not used'\n" +
                            "WHEN 1 THEN 'used'\n" +
                        "END," +
                    "parkingindatetime, carplatenumber\n" +
                    "FROM ParkingLotStatus\n" +
                    "WHERE parkingfloor = 1\n" +
                    "ORDER BY parkingfloor, parkingno",
                    "Floor1");
                // Set dataSet as the data source of dataGridViewAll.
                dataGridViewFloor1.DataSource = dataSet;
                // Set the table name.
                dataGridViewFloor1.DataMember = "Floor1";
                // Set columns' name.
                dataGridViewFloor1.Columns[0].HeaderText = "floor";
                dataGridViewFloor1.Columns[1].HeaderText = "No.";
                dataGridViewFloor1.Columns[2].HeaderText = "status";
                dataGridViewFloor1.Columns[3].HeaderText = "entry time";
                dataGridViewFloor1.Columns[4].HeaderText = "plate number";
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        /// <summary>
        /// Refresh dataGridViewFloor2 by resetting its data
        /// source and table name and columns' name.
        /// </summary>
        private void DataGridViewFloor2Refresh()
        {
            try
            {
                DataSet dataSet = DBConnection.DBQuery(
                    "SELECT parkingfloor, parkingno," +
                        "CASE parkingisused\n" +
                            "WHEN 0 THEN 'not used'\n" +
                            "WHEN 1 THEN 'used'\n" +
                        "END," +
                    "parkingindatetime, carplatenumber\n" +
                    "FROM ParkingLotStatus\n" +
                    "WHERE parkingfloor = 2\n" +
                    "ORDER BY parkingfloor, parkingno",
                    "Floor2");
                // Set dataSet as the data source of dataGridViewAll.
                dataGridViewFloor2.DataSource = dataSet;
                // Set the table name.
                dataGridViewFloor2.DataMember = "Floor2";
                dataGridViewFloor2.Columns[0].HeaderText = "floor";
                dataGridViewFloor2.Columns[1].HeaderText = "No.";
                dataGridViewFloor2.Columns[2].HeaderText = "status";
                dataGridViewFloor2.Columns[3].HeaderText = "entry time";
                dataGridViewFloor2.Columns[4].HeaderText = "plate number";
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        /// <summary>
        /// Refresh dataGridViewSummary by resetting its data
        /// source and table name and columns' name.
        /// This method will check whether carPlateNumber's text
        /// is empty. If it is empty, the query will not contain
        /// the plate number, otherwise it will contain it.
        /// </summary>
        private void DataGridViewSummaryRefresh()
        {
            try
            {
                string carPlateNumber = textBoxSummaryCarPlateNumber.Text.Trim();
                DateTime inDateTimeStart = dateTimePickerSummaryInDateTimeStart.Value;
                DateTime inDateTimeEnd = dateTimePickerSummaryInDateTimeEnd.Value;
                DateTime inDateTimeStartFormatted = inDateTimeStart.Date;
                DateTime inDateTimeEndFormatted = new DateTime(inDateTimeEnd.Year, inDateTimeEnd.Month, inDateTimeEnd.Day, 23, 59, 59);
                string querySql =
                    "SELECT serialnumber, carplatenumber, parkingindatetime, parkingoutdatetime, totalfee\n" +
                    "FROM ParkingLotSummary\n" +
                    "WHERE parkingInDateTime BETWEEN '" + inDateTimeStartFormatted.ToString() + "' AND '" + inDateTimeEndFormatted.ToString() + "'";
                if (carPlateNumber.Length != 0)
                {
                    querySql += "AND carplatenumber = '" + carPlateNumber + "'";
                }
                querySql += "\nORDER BY serialnumber";
                DataSet dataSet = DBConnection.DBQuery(querySql, "Summary");
                // Set dataSet as the data source of dataGridViewSummary.
                dataGridViewSummary.DataSource = dataSet;
                // Set the table name.
                dataGridViewSummary.DataMember = "Summary";
                dataGridViewSummary.Columns[0].HeaderText = "serial number";
                dataGridViewSummary.Columns[1].HeaderText = "plate number";
                dataGridViewSummary.Columns[2].HeaderText = "entry time";
                dataGridViewSummary.Columns[3].HeaderText = "exit time";
                dataGridViewSummary.Columns[4].HeaderText = "total fee";
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        /// <summary>
        /// Refresh chartParkingLotStat by resetting its series and its style.
        /// This method will use different ways to set the chart according to
        /// member variable diagramMode.
        /// </summary>
        private void ChartParkingLotStatRefresh()
        {
            try
            {
                DateTime dateTimeDuration = dateTimePickerDiagramDuration.Value;
                chartParkingLotStat.Series.Clear();
                int year = dateTimeDuration.Year;
                if (diagramMode == DiagramMode.Monthly)
                {
                    int month = dateTimeDuration.Month;
                    int dayCount = DateTime.DaysInMonth(year, month);
                    DataSet dataSetParkingInCount = DBConnection.DBQuery(
                        "SELECT COUNT(*) AS parkingincount, DAY(parkingindatetime) AS parkinginday\n" +
                        "FROM ParkingLotSummary\n" +
                        "WHERE YEAR(parkingindatetime) = " + year.ToString() + " AND MONTH(parkingindatetime) = " + month.ToString() + "\n" +
                        "GROUP BY DAY(parkingindatetime)\n" +
                        "ORDER BY parkinginday", "ParkingInCount");
                    DataSet dataSetParkingOutCount = DBConnection.DBQuery(
                        "SELECT COUNT(*) AS parkingoutcount, DAY(parkingoutdatetime) AS parkingoutday\n" +
                        "FROM ParkingLotSummary\n" +
                        "WHERE YEAR(parkingoutdatetime) = " + year.ToString() + " AND MONTH(parkingoutdatetime) = " + month.ToString() + "\n" +
                        "GROUP BY DAY(parkingoutdatetime)\n" +
                        "ORDER BY parkingoutday", "ParkingOutCount");
                    DataSet dataSetFeeCount = DBConnection.DBQuery(
                        "SELECT SUM(totalfee) AS feecount, DAY(parkingoutdatetime) AS parkingoutday\n" +
                        "FROM ParkingLotSummary\n" +
                        "WHERE YEAR(parkingoutdatetime) = " + year.ToString() + " AND MONTH(parkingoutdatetime) = " + month.ToString() + "\n" +
                        "GROUP BY DAY(parkingoutdatetime)\n" +
                        "ORDER BY parkingoutday", "FeeCount");
                    Series parkingInCount = MakeSeries("parking in count", dayCount, dataSetParkingInCount.Tables["ParkingInCount"]);
                    Series parkingOutCount = MakeSeries("parking out count", dayCount, dataSetParkingOutCount.Tables["ParkingOutCount"]);
                    Series feeCount = MakeSeries("fee count", dayCount, dataSetFeeCount.Tables["FeeCount"]);
                    // Make fee count series in the secondary y axis.
                    feeCount.YAxisType = AxisType.Secondary;
                    chartParkingLotStat.Series.Add(parkingInCount);
                    chartParkingLotStat.Series.Add(parkingOutCount);
                    chartParkingLotStat.Series.Add(feeCount);
                    // Add x axis' title.
                    chartParkingLotStat.ChartAreas[0].AxisX.Title = "day";
                }
                else
                {
                    DataSet dataSetParkingInCount = DBConnection.DBQuery(
                        "SELECT COUNT(*) AS parkingincount, MONTH(parkingindatetime) AS parkinginmonth\n" +
                        "FROM ParkingLotSummary\n" +
                        "WHERE YEAR(parkingindatetime) = " + year.ToString() + "\n" +
                        "GROUP BY MONTH(parkingindatetime)\n" +
                        "ORDER BY parkinginmonth", "ParkingInCount");
                    DataSet dataSetParkingOutCount = DBConnection.DBQuery(
                        "SELECT COUNT(*) AS parkingoutcount, MONTH(parkingoutdatetime) AS parkingoutmonth\n" +
                        "FROM ParkingLotSummary\n" +
                        "WHERE YEAR(parkingoutdatetime) = " + year.ToString() + "\n" +
                        "GROUP BY MONTH(parkingoutdatetime)\n" +
                        "ORDER BY parkingoutmonth", "ParkingOutCount");
                    DataSet dataSetFeeCount = DBConnection.DBQuery(
                        "SELECT SUM(totalfee) AS feecount, MONTH(parkingoutdatetime) AS parkingoutmonth\n" +
                        "FROM ParkingLotSummary\n" +
                        "WHERE YEAR(parkingoutdatetime) = " + year.ToString() + "\n" +
                        "GROUP BY MONTH(parkingoutdatetime)\n" +
                        "ORDER BY parkingoutmonth", "FeeCount");
                    Series parkingInCount = MakeSeries("parking in count", 12, dataSetParkingInCount.Tables["ParkingInCount"]);
                    Series parkingOutCount = MakeSeries("parking out count", 12, dataSetParkingOutCount.Tables["ParkingOutCount"]);
                    Series feeCount = MakeSeries("fee count", 12, dataSetFeeCount.Tables["FeeCount"]);
                    // Make fee count series in the secondary y axis.
                    feeCount.YAxisType = AxisType.Secondary;
                    chartParkingLotStat.Series.Add(parkingInCount);
                    chartParkingLotStat.Series.Add(parkingOutCount);
                    chartParkingLotStat.Series.Add(feeCount);
                    // Add x axis' title.
                    chartParkingLotStat.ChartAreas[0].AxisX.Title = "month";
                }
                // Add y axis' title.
                chartParkingLotStat.ChartAreas[0].AxisY.Title = "number of cars";
                // Add y2 axis' title.
                chartParkingLotStat.ChartAreas[0].AxisY2.Title = "fee (RMB)";
                // Cancel the margin.
                chartParkingLotStat.ChartAreas[0].AxisX.IsMarginVisible = false;
                // Set line dash style to be dash.
                chartParkingLotStat.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
                chartParkingLotStat.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
                chartParkingLotStat.ChartAreas[0].AxisY2.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        /// <summary>
        /// Update the summary table to set the parking out date time and total fee.
        /// Total fee will be calculated according to member variable pricePerTenMinutes.
        /// The part total time less than 10 minutes will also be charged as 10 minutes.
        /// </summary>
        /// <param name="carPlateNumber">The car plate number.</param>
        /// <param name="parkingInDateTime">The parking in date time.</param>
        /// <returns>The total fee the car's owner should give.</returns>
        private decimal UpdateSummaryTable(string carPlateNumber, DateTime parkingInDateTime)
        {
            DateTime parkingOutDateTime = DateTime.Now;
            TimeSpan timeSpan = parkingOutDateTime - parkingInDateTime;
            int tenMinutesCount = (int)Math.Ceiling(timeSpan.TotalMinutes / 10);
            decimal totalFee = pricePerTenMinutes * tenMinutesCount;
            DBConnection.DBCmd(
                "UPDATE ParkingLotSummary\n" +
                "SET parkingoutdatetime = '" + parkingOutDateTime.ToString() + "', totalfee = " + totalFee.ToString() + "\n" +
                "WHERE carplatenumber = '" + carPlateNumber + "' AND parkingindatetime = '" + parkingInDateTime + "'");
            return totalFee;
        }

        /// <summary>
        /// Insert a new row into the summary table containing the carplate
        /// number and parking in date time.
        /// </summary>
        /// <param name="carPlateNumber">The car plate number.</param>
        /// <param name="parkingInDateTime">The parking in date time.</param>
        private void InsertIntoSummaryTable(string carPlateNumber, DateTime parkingInDateTime)
        {
            DBConnection.DBCmd(
                "INSERT INTO ParkingLotSummary(carplatenumber, parkingindatetime)\n" +
                "VALUES('" + carPlateNumber + "', '" + parkingInDateTime.ToString() + "')");
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Things to be done when loading the main form.
        /// Set all data grid views read only.
        /// Initialize all components.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">E.</param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Set all data grid views read only.
            dataGridViewAll.ReadOnly = true;
            dataGridViewFloor1.ReadOnly = true;
            dataGridViewFloor2.ReadOnly = true;
            dataGridViewSummary.ReadOnly = true;

            // Init all components.
            InitComboBoxConfig();
            InitComboBoxDiagramMode();
            ChartParkingLotStatRefresh();
            DataGridViewAllRefresh();
            DataGridViewFloor1Refresh();
            DataGridViewFloor2Refresh();
            DataGridViewSummaryRefresh();
        }

        /// <summary>
        /// Action performed when clicking buttonEnter.
        /// Check out for car entry.
        /// Insert into summary table.
        /// Refresh all data grid views.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">E.</param>
        private void ButtonEnter_Click(object sender, EventArgs e)
        {
            // Find out whether there is any empty position.
            string carPlateNumber = textBoxCarPlateNumber.Text.Trim();
            if(carPlateNumber.Length == 0)
            {
                MessageBox.Show("Car plate number cannot be empty!");
                return;
            }
            DataSet dataSet = DBConnection.DBQuery(
                "SELECT parkingfloor, parkingno\n" +
                "FROM ParkingLotStatus\n" +
                "WHERE NOT EXISTS(\n" +
                    "SELECT * FROM ParkingLotStatus WHERE carplatenumber = '" + carPlateNumber + "')\n" +
                    "AND parkingisused = 0\n" +
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
                DateTime parkingInDateTime = DateTime.Now;
                if (DBConnection.DBCmd(
                    "UPDATE ParkingLotStatus\n" +
                    "SET parkingisused = 1, parkingindatetime = '" + parkingInDateTime.ToString() + "', carplatenumber = '" + carPlateNumber + "'\n" +
                    "WHERE parkingfloor = " + floor + "AND parkingno = " + no
                    ) == 0)
                {
                    MessageBox.Show("Failed to update the database!");
                }
                else
                {
                    InsertIntoSummaryTable(carPlateNumber, parkingInDateTime);
                    MessageBox.Show(
                        "Entry allowed!\n" +
                        "Car plate number: " + carPlateNumber + ".\n" +
                        "Car position: floor " + floor + ", number " + no + "."
                        );
                }
            }
            // Clear textBoxCarPlateNumber's text.
            textBoxCarPlateNumber.Clear();
            // Refresh all data grid views.
            DataGridViewAllRefresh();
            DataGridViewFloor1Refresh();
            DataGridViewFloor2Refresh();
        }

        /// <summary>
        /// Action performed when clicking buttonExit.
        /// Check out for car exit.
        /// Calculate total fee.
        /// Update summary table.
        /// Refresh all data grid views.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">E.</param>
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            string carPlateNumber = textBoxCarPlateNumber.Text.Trim();
            if (carPlateNumber.Length == 0)
            {
                MessageBox.Show("Car plate number cannot be empty!");
                return;
            }
            DataSet dataSet = DBConnection.DBQuery(
                "SELECT parkingfloor, parkingno, parkingindatetime\n" +
                "FROM ParkingLotStatus\n" +
                "WHERE carplatenumber = '" + carPlateNumber + "'",
                "LeavingCarInfo");
            // Find out whether the plate number is right.
            if (dataSet.Tables["LeavingCarInfo"].Rows.Count == 0)
            {
                MessageBox.Show("Wrong plate number!");
            }
            else
            {
                DataRow dataRow = dataSet.Tables["LeavingCarInfo"].Rows[0];
                int parkingFloor = int.Parse(dataRow[0].ToString());
                int parkingNo = int.Parse(dataRow[1].ToString());
                DateTime parkingInDateTime = DateTime.Parse(dataRow[2].ToString());
                // Set the position empty.
                DBConnection.DBCmd(
                    "UPDATE ParkingLotStatus\n" +
                    "SET parkingisused = 0, parkingindatetime = null, carplatenumber = null\n" +
                    "WHERE parkingfloor = " + parkingFloor.ToString() + "AND parkingno = " + parkingNo.ToString());
                decimal totalFee = UpdateSummaryTable(carPlateNumber, parkingInDateTime);
                MessageBox.Show(
                    "Exit allowed!\n" +
                    "Total parking fee: " + totalFee.ToString() + "."
                    );
            }
            // Clear textBoxCarPlateNumber's text.
            textBoxCarPlateNumber.Clear();
            // Refresh all data grid views.
            DataGridViewAllRefresh();
            DataGridViewFloor1Refresh();
            DataGridViewFloor2Refresh();
        }

        /// <summary>
        /// Action performed when comboBoxConfig's selected index changed.
        /// Reset pricePerTenMinutes.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">E.</param>
        private void ComboBoxConfig_SelectedIndexChanged(object sender, EventArgs e)
        {
            pricePerTenMinutes = listPricePerTenMinutes[comboBoxConfig.SelectedIndex];
        }

        /// <summary>
        /// Action performed when clicking buttonSummaryQuery.
        /// Refresh dataDridViewSummary.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">E.</param>
        private void ButtonSummaryQuery_Click(object sender, EventArgs e)
        {
            DataGridViewSummaryRefresh();
        }

        /// <summary>
        /// Action performed when comboBoxDiagramMode's selected index changed.
        /// Reset diagramMode and dataTimePickerDiagramDuration.CustomFormat.
        /// If mode is "yearly", the CustomFormat will be set to "yyyy", or it
        /// will be "yyyy-MM".
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">E.</param>
        private void ComboBoxDiagramMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBoxDiagramMode.SelectedIndex)
            {
                case 1:
                    diagramMode = DiagramMode.Yearly;
                    // Automatically change DateTimePickerFormat.
                    dateTimePickerDiagramDuration.CustomFormat = "yyyy";
                    break;
                default:
                    diagramMode = DiagramMode.Monthly;
                    // Automatically change DateTimePickerFormat.
                    dateTimePickerDiagramDuration.CustomFormat = "yyyy-MM";
                    break;
            }
        }

        /// <summary>
        /// Action performed when clicking buttonDiagramQuery.
        /// Refresh chartParkingLotState.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">E.</param>
        private void ButtonDiagramQuery_Click(object sender, EventArgs e)
        {
            ChartParkingLotStatRefresh();
        }
    }
}
