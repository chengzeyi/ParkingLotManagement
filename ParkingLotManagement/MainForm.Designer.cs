namespace ParkingLotManagement
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.tabPageDiagram = new System.Windows.Forms.TabPage();
            this.labelDiagramMode = new System.Windows.Forms.Label();
            this.labelDiagramDuration = new System.Windows.Forms.Label();
            this.comboBoxDiagramMode = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDiagramDuration = new System.Windows.Forms.DateTimePicker();
            this.buttonDiagramQuery = new System.Windows.Forms.Button();
            this.chartParkingLotStat = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPageAll = new System.Windows.Forms.TabPage();
            this.dataGridViewAll = new System.Windows.Forms.DataGridView();
            this.tabPageFloor1 = new System.Windows.Forms.TabPage();
            this.dataGridViewFloor1 = new System.Windows.Forms.DataGridView();
            this.tabPageFloor2 = new System.Windows.Forms.TabPage();
            this.dataGridViewFloor2 = new System.Windows.Forms.DataGridView();
            this.tabPageSummary = new System.Windows.Forms.TabPage();
            this.labelSummaryInDateTimeEnd = new System.Windows.Forms.Label();
            this.labelSummaryInDateTimeStart = new System.Windows.Forms.Label();
            this.labelSummaryCarPlateNumber = new System.Windows.Forms.Label();
            this.buttonSummaryQuery = new System.Windows.Forms.Button();
            this.dateTimePickerSummaryInDateTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerSummaryInDateTimeStart = new System.Windows.Forms.DateTimePicker();
            this.textBoxSummaryCarPlateNumber = new System.Windows.Forms.TextBox();
            this.dataGridViewSummary = new System.Windows.Forms.DataGridView();
            this.tabPageAbout = new System.Windows.Forms.TabPage();
            this.labelAboutInfo = new System.Windows.Forms.Label();
            this.textBoxCarPlateNumber = new System.Windows.Forms.TextBox();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.comboBoxConfig = new System.Windows.Forms.ComboBox();
            this.labelConfig = new System.Windows.Forms.Label();
            this.mainTabControl.SuspendLayout();
            this.tabPageDiagram.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartParkingLotStat)).BeginInit();
            this.tabPageAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAll)).BeginInit();
            this.tabPageFloor1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFloor1)).BeginInit();
            this.tabPageFloor2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFloor2)).BeginInit();
            this.tabPageSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSummary)).BeginInit();
            this.tabPageAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.tabPageDiagram);
            this.mainTabControl.Controls.Add(this.tabPageAll);
            this.mainTabControl.Controls.Add(this.tabPageFloor1);
            this.mainTabControl.Controls.Add(this.tabPageFloor2);
            this.mainTabControl.Controls.Add(this.tabPageSummary);
            this.mainTabControl.Controls.Add(this.tabPageAbout);
            this.mainTabControl.Location = new System.Drawing.Point(12, 12);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(1234, 572);
            this.mainTabControl.TabIndex = 4;
            // 
            // tabPageDiagram
            // 
            this.tabPageDiagram.Controls.Add(this.labelDiagramMode);
            this.tabPageDiagram.Controls.Add(this.labelDiagramDuration);
            this.tabPageDiagram.Controls.Add(this.comboBoxDiagramMode);
            this.tabPageDiagram.Controls.Add(this.dateTimePickerDiagramDuration);
            this.tabPageDiagram.Controls.Add(this.buttonDiagramQuery);
            this.tabPageDiagram.Controls.Add(this.chartParkingLotStat);
            this.tabPageDiagram.Location = new System.Drawing.Point(4, 33);
            this.tabPageDiagram.Name = "tabPageDiagram";
            this.tabPageDiagram.Size = new System.Drawing.Size(1226, 535);
            this.tabPageDiagram.TabIndex = 4;
            this.tabPageDiagram.Text = "Diagram";
            this.tabPageDiagram.UseVisualStyleBackColor = true;
            // 
            // labelDiagramMode
            // 
            this.labelDiagramMode.AutoSize = true;
            this.labelDiagramMode.Location = new System.Drawing.Point(12, 3);
            this.labelDiagramMode.Name = "labelDiagramMode";
            this.labelDiagramMode.Size = new System.Drawing.Size(55, 24);
            this.labelDiagramMode.TabIndex = 2;
            this.labelDiagramMode.Text = "Mode";
            // 
            // labelDiagramDuration
            // 
            this.labelDiagramDuration.AutoSize = true;
            this.labelDiagramDuration.Location = new System.Drawing.Point(214, 3);
            this.labelDiagramDuration.Name = "labelDiagramDuration";
            this.labelDiagramDuration.Size = new System.Drawing.Size(78, 24);
            this.labelDiagramDuration.TabIndex = 6;
            this.labelDiagramDuration.Text = "Duration";
            // 
            // comboBoxDiagramMode
            // 
            this.comboBoxDiagramMode.FormattingEnabled = true;
            this.comboBoxDiagramMode.Location = new System.Drawing.Point(73, 0);
            this.comboBoxDiagramMode.Name = "comboBoxDiagramMode";
            this.comboBoxDiagramMode.Size = new System.Drawing.Size(121, 32);
            this.comboBoxDiagramMode.TabIndex = 0;
            this.comboBoxDiagramMode.SelectedIndexChanged += new System.EventHandler(this.ComboBoxDiagramMode_SelectedIndexChanged);
            // 
            // dateTimePickerDiagramDuration
            // 
            this.dateTimePickerDiagramDuration.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDiagramDuration.Location = new System.Drawing.Point(298, 0);
            this.dateTimePickerDiagramDuration.Name = "dateTimePickerDiagramDuration";
            this.dateTimePickerDiagramDuration.Size = new System.Drawing.Size(200, 32);
            this.dateTimePickerDiagramDuration.TabIndex = 1;
            // 
            // buttonDiagramQuery
            // 
            this.buttonDiagramQuery.Location = new System.Drawing.Point(1116, 0);
            this.buttonDiagramQuery.Name = "buttonDiagramQuery";
            this.buttonDiagramQuery.Size = new System.Drawing.Size(107, 36);
            this.buttonDiagramQuery.TabIndex = 2;
            this.buttonDiagramQuery.Text = "Query(&Q)";
            this.buttonDiagramQuery.UseVisualStyleBackColor = true;
            this.buttonDiagramQuery.Click += new System.EventHandler(this.ButtonDiagramQuery_Click);
            // 
            // chartParkingLotStat
            // 
            chartArea1.Name = "ChartArea1";
            this.chartParkingLotStat.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartParkingLotStat.Legends.Add(legend1);
            this.chartParkingLotStat.Location = new System.Drawing.Point(-4, 41);
            this.chartParkingLotStat.Name = "chartParkingLotStat";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartParkingLotStat.Series.Add(series1);
            this.chartParkingLotStat.Size = new System.Drawing.Size(1230, 503);
            this.chartParkingLotStat.TabIndex = 4;
            this.chartParkingLotStat.Text = "Parking Lot Statistics";
            // 
            // tabPageAll
            // 
            this.tabPageAll.Controls.Add(this.dataGridViewAll);
            this.tabPageAll.Location = new System.Drawing.Point(4, 33);
            this.tabPageAll.Name = "tabPageAll";
            this.tabPageAll.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAll.Size = new System.Drawing.Size(1226, 535);
            this.tabPageAll.TabIndex = 1;
            this.tabPageAll.Text = "All";
            this.tabPageAll.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAll
            // 
            this.dataGridViewAll.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAll.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAll.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewAll.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewAll.Name = "dataGridViewAll";
            this.dataGridViewAll.RowTemplate.Height = 30;
            this.dataGridViewAll.Size = new System.Drawing.Size(1223, 533);
            this.dataGridViewAll.TabIndex = 1;
            // 
            // tabPageFloor1
            // 
            this.tabPageFloor1.Controls.Add(this.dataGridViewFloor1);
            this.tabPageFloor1.Location = new System.Drawing.Point(4, 33);
            this.tabPageFloor1.Name = "tabPageFloor1";
            this.tabPageFloor1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFloor1.Size = new System.Drawing.Size(1226, 535);
            this.tabPageFloor1.TabIndex = 2;
            this.tabPageFloor1.Text = "Floor 1";
            this.tabPageFloor1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewFloor1
            // 
            this.dataGridViewFloor1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFloor1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewFloor1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFloor1.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewFloor1.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewFloor1.Name = "dataGridViewFloor1";
            this.dataGridViewFloor1.RowTemplate.Height = 30;
            this.dataGridViewFloor1.Size = new System.Drawing.Size(1223, 533);
            this.dataGridViewFloor1.TabIndex = 1;
            // 
            // tabPageFloor2
            // 
            this.tabPageFloor2.Controls.Add(this.dataGridViewFloor2);
            this.tabPageFloor2.Location = new System.Drawing.Point(4, 33);
            this.tabPageFloor2.Name = "tabPageFloor2";
            this.tabPageFloor2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFloor2.Size = new System.Drawing.Size(1226, 535);
            this.tabPageFloor2.TabIndex = 3;
            this.tabPageFloor2.Text = "Floor 2";
            this.tabPageFloor2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewFloor2
            // 
            this.dataGridViewFloor2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFloor2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewFloor2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFloor2.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewFloor2.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewFloor2.Name = "dataGridViewFloor2";
            this.dataGridViewFloor2.RowTemplate.Height = 30;
            this.dataGridViewFloor2.Size = new System.Drawing.Size(1223, 533);
            this.dataGridViewFloor2.TabIndex = 1;
            // 
            // tabPageSummary
            // 
            this.tabPageSummary.Controls.Add(this.labelSummaryInDateTimeEnd);
            this.tabPageSummary.Controls.Add(this.labelSummaryInDateTimeStart);
            this.tabPageSummary.Controls.Add(this.labelSummaryCarPlateNumber);
            this.tabPageSummary.Controls.Add(this.buttonSummaryQuery);
            this.tabPageSummary.Controls.Add(this.dateTimePickerSummaryInDateTimeEnd);
            this.tabPageSummary.Controls.Add(this.dateTimePickerSummaryInDateTimeStart);
            this.tabPageSummary.Controls.Add(this.textBoxSummaryCarPlateNumber);
            this.tabPageSummary.Controls.Add(this.dataGridViewSummary);
            this.tabPageSummary.Location = new System.Drawing.Point(4, 33);
            this.tabPageSummary.Name = "tabPageSummary";
            this.tabPageSummary.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSummary.Size = new System.Drawing.Size(1226, 535);
            this.tabPageSummary.TabIndex = 0;
            this.tabPageSummary.Text = "Summary";
            this.tabPageSummary.UseVisualStyleBackColor = true;
            // 
            // labelSummaryInDateTimeEnd
            // 
            this.labelSummaryInDateTimeEnd.AutoSize = true;
            this.labelSummaryInDateTimeEnd.Location = new System.Drawing.Point(760, 5);
            this.labelSummaryInDateTimeEnd.Name = "labelSummaryInDateTimeEnd";
            this.labelSummaryInDateTimeEnd.Size = new System.Drawing.Size(144, 24);
            this.labelSummaryInDateTimeEnd.TabIndex = 7;
            this.labelSummaryInDateTimeEnd.Text = "In DataTime End";
            // 
            // labelSummaryInDateTimeStart
            // 
            this.labelSummaryInDateTimeStart.AutoSize = true;
            this.labelSummaryInDateTimeStart.Location = new System.Drawing.Point(398, 5);
            this.labelSummaryInDateTimeStart.Name = "labelSummaryInDateTimeStart";
            this.labelSummaryInDateTimeStart.Size = new System.Drawing.Size(150, 24);
            this.labelSummaryInDateTimeStart.TabIndex = 6;
            this.labelSummaryInDateTimeStart.Text = "In DateTime Start";
            // 
            // labelSummaryCarPlateNumber
            // 
            this.labelSummaryCarPlateNumber.AutoSize = true;
            this.labelSummaryCarPlateNumber.Location = new System.Drawing.Point(6, 5);
            this.labelSummaryCarPlateNumber.Name = "labelSummaryCarPlateNumber";
            this.labelSummaryCarPlateNumber.Size = new System.Drawing.Size(154, 24);
            this.labelSummaryCarPlateNumber.TabIndex = 5;
            this.labelSummaryCarPlateNumber.Text = "Car Plate Number";
            // 
            // buttonSummaryQuery
            // 
            this.buttonSummaryQuery.Location = new System.Drawing.Point(1116, 0);
            this.buttonSummaryQuery.Name = "buttonSummaryQuery";
            this.buttonSummaryQuery.Size = new System.Drawing.Size(107, 36);
            this.buttonSummaryQuery.TabIndex = 3;
            this.buttonSummaryQuery.Text = "Query(&Q)";
            this.buttonSummaryQuery.UseVisualStyleBackColor = true;
            this.buttonSummaryQuery.Click += new System.EventHandler(this.ButtonSummaryQuery_Click);
            // 
            // dateTimePickerSummaryInDateTimeEnd
            // 
            this.dateTimePickerSummaryInDateTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerSummaryInDateTimeEnd.Location = new System.Drawing.Point(910, 0);
            this.dateTimePickerSummaryInDateTimeEnd.Name = "dateTimePickerSummaryInDateTimeEnd";
            this.dateTimePickerSummaryInDateTimeEnd.Size = new System.Drawing.Size(200, 32);
            this.dateTimePickerSummaryInDateTimeEnd.TabIndex = 2;
            // 
            // dateTimePickerSummaryInDateTimeStart
            // 
            this.dateTimePickerSummaryInDateTimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerSummaryInDateTimeStart.Location = new System.Drawing.Point(554, 0);
            this.dateTimePickerSummaryInDateTimeStart.Name = "dateTimePickerSummaryInDateTimeStart";
            this.dateTimePickerSummaryInDateTimeStart.Size = new System.Drawing.Size(200, 32);
            this.dateTimePickerSummaryInDateTimeStart.TabIndex = 1;
            // 
            // textBoxSummaryCarPlateNumber
            // 
            this.textBoxSummaryCarPlateNumber.Location = new System.Drawing.Point(178, 0);
            this.textBoxSummaryCarPlateNumber.Name = "textBoxSummaryCarPlateNumber";
            this.textBoxSummaryCarPlateNumber.Size = new System.Drawing.Size(214, 32);
            this.textBoxSummaryCarPlateNumber.TabIndex = 0;
            // 
            // dataGridViewSummary
            // 
            this.dataGridViewSummary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSummary.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSummary.Location = new System.Drawing.Point(0, 35);
            this.dataGridViewSummary.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewSummary.Name = "dataGridViewSummary";
            this.dataGridViewSummary.RowTemplate.Height = 30;
            this.dataGridViewSummary.Size = new System.Drawing.Size(1223, 498);
            this.dataGridViewSummary.TabIndex = 4;
            // 
            // tabPageAbout
            // 
            this.tabPageAbout.Controls.Add(this.labelAboutInfo);
            this.tabPageAbout.Location = new System.Drawing.Point(4, 33);
            this.tabPageAbout.Name = "tabPageAbout";
            this.tabPageAbout.Size = new System.Drawing.Size(1226, 535);
            this.tabPageAbout.TabIndex = 5;
            this.tabPageAbout.Text = "About";
            this.tabPageAbout.UseVisualStyleBackColor = true;
            // 
            // labelAboutInfo
            // 
            this.labelAboutInfo.AutoSize = true;
            this.labelAboutInfo.Location = new System.Drawing.Point(390, 252);
            this.labelAboutInfo.Name = "labelAboutInfo";
            this.labelAboutInfo.Size = new System.Drawing.Size(476, 24);
            this.labelAboutInfo.TabIndex = 0;
            this.labelAboutInfo.Text = "Copyright © 2018 - 2018 Cheng Zeyi. All Rights Reserved.";
            // 
            // textBoxCarPlateNumber
            // 
            this.textBoxCarPlateNumber.Location = new System.Drawing.Point(12, 590);
            this.textBoxCarPlateNumber.Name = "textBoxCarPlateNumber";
            this.textBoxCarPlateNumber.Size = new System.Drawing.Size(300, 32);
            this.textBoxCarPlateNumber.TabIndex = 0;
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(12, 628);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(147, 33);
            this.buttonEnter.TabIndex = 1;
            this.buttonEnter.Text = "Enter(&P)";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.ButtonEnter_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(165, 628);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(147, 34);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Exit(&L)";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // comboBoxConfig
            // 
            this.comboBoxConfig.FormattingEnabled = true;
            this.comboBoxConfig.Location = new System.Drawing.Point(1077, 626);
            this.comboBoxConfig.Name = "comboBoxConfig";
            this.comboBoxConfig.Size = new System.Drawing.Size(162, 32);
            this.comboBoxConfig.TabIndex = 3;
            this.comboBoxConfig.SelectedIndexChanged += new System.EventHandler(this.ComboBoxConfig_SelectedIndexChanged);
            // 
            // labelConfig
            // 
            this.labelConfig.AutoSize = true;
            this.labelConfig.Location = new System.Drawing.Point(1073, 598);
            this.labelConfig.Name = "labelConfig";
            this.labelConfig.Size = new System.Drawing.Size(117, 24);
            this.labelConfig.TabIndex = 6;
            this.labelConfig.Text = "Configuration";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1258, 664);
            this.Controls.Add(this.labelConfig);
            this.Controls.Add(this.comboBoxConfig);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.textBoxCarPlateNumber);
            this.Controls.Add(this.mainTabControl);
            this.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "MainForm";
            this.Text = "Parking Lot Management";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainTabControl.ResumeLayout(false);
            this.tabPageDiagram.ResumeLayout(false);
            this.tabPageDiagram.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartParkingLotStat)).EndInit();
            this.tabPageAll.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAll)).EndInit();
            this.tabPageFloor1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFloor1)).EndInit();
            this.tabPageFloor2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFloor2)).EndInit();
            this.tabPageSummary.ResumeLayout(false);
            this.tabPageSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSummary)).EndInit();
            this.tabPageAbout.ResumeLayout(false);
            this.tabPageAbout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage tabPageSummary;
        private System.Windows.Forms.TabPage tabPageAll;
        private System.Windows.Forms.TabPage tabPageFloor1;
        private System.Windows.Forms.TabPage tabPageFloor2;
        private System.Windows.Forms.TextBox textBoxCarPlateNumber;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.DataGridView dataGridViewAll;
        private System.Windows.Forms.DataGridView dataGridViewFloor1;
        private System.Windows.Forms.DataGridView dataGridViewFloor2;
        private System.Windows.Forms.DataGridView dataGridViewSummary;
        private System.Windows.Forms.ComboBox comboBoxConfig;
        private System.Windows.Forms.Label labelConfig;
        private System.Windows.Forms.Label labelSummaryInDateTimeEnd;
        private System.Windows.Forms.Label labelSummaryInDateTimeStart;
        private System.Windows.Forms.Label labelSummaryCarPlateNumber;
        private System.Windows.Forms.Button buttonSummaryQuery;
        private System.Windows.Forms.DateTimePicker dateTimePickerSummaryInDateTimeEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerSummaryInDateTimeStart;
        private System.Windows.Forms.TextBox textBoxSummaryCarPlateNumber;
        private System.Windows.Forms.TabPage tabPageDiagram;
        private System.Windows.Forms.Label labelDiagramDuration;
        private System.Windows.Forms.Button buttonDiagramQuery;
        private System.Windows.Forms.DateTimePicker dateTimePickerDiagramDuration;
        private System.Windows.Forms.Label labelDiagramMode;
        private System.Windows.Forms.ComboBox comboBoxDiagramMode;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartParkingLotStat;
        private System.Windows.Forms.TabPage tabPageAbout;
        private System.Windows.Forms.Label labelAboutInfo;
    }
}

