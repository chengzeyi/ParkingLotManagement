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
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.tabPageSummary = new System.Windows.Forms.TabPage();
            this.dataGridViewSummary = new System.Windows.Forms.DataGridView();
            this.tabPageAll = new System.Windows.Forms.TabPage();
            this.dataGridViewAll = new System.Windows.Forms.DataGridView();
            this.tabPageFloor1 = new System.Windows.Forms.TabPage();
            this.dataGridViewFloor1 = new System.Windows.Forms.DataGridView();
            this.tabPageFloor2 = new System.Windows.Forms.TabPage();
            this.dataGridViewFloor2 = new System.Windows.Forms.DataGridView();
            this.textBoxEnteringCar = new System.Windows.Forms.TextBox();
            this.textBoxLeftingCar = new System.Windows.Forms.TextBox();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.mainTabControl.SuspendLayout();
            this.tabPageSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSummary)).BeginInit();
            this.tabPageAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAll)).BeginInit();
            this.tabPageFloor1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFloor1)).BeginInit();
            this.tabPageFloor2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFloor2)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.tabPageSummary);
            this.mainTabControl.Controls.Add(this.tabPageAll);
            this.mainTabControl.Controls.Add(this.tabPageFloor1);
            this.mainTabControl.Controls.Add(this.tabPageFloor2);
            this.mainTabControl.Location = new System.Drawing.Point(12, 12);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(1234, 572);
            this.mainTabControl.TabIndex = 0;
            // 
            // tabPageSummary
            // 
            this.tabPageSummary.Controls.Add(this.dataGridViewSummary);
            this.tabPageSummary.Location = new System.Drawing.Point(4, 28);
            this.tabPageSummary.Name = "tabPageSummary";
            this.tabPageSummary.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSummary.Size = new System.Drawing.Size(1226, 540);
            this.tabPageSummary.TabIndex = 0;
            this.tabPageSummary.Text = "Summary";
            this.tabPageSummary.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSummary
            // 
            this.dataGridViewSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSummary.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewSummary.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewSummary.Name = "dataGridViewSummary";
            this.dataGridViewSummary.RowTemplate.Height = 30;
            this.dataGridViewSummary.Size = new System.Drawing.Size(1223, 533);
            this.dataGridViewSummary.TabIndex = 0;
            // 
            // tabPageAll
            // 
            this.tabPageAll.Controls.Add(this.dataGridViewAll);
            this.tabPageAll.Location = new System.Drawing.Point(4, 28);
            this.tabPageAll.Name = "tabPageAll";
            this.tabPageAll.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAll.Size = new System.Drawing.Size(1226, 540);
            this.tabPageAll.TabIndex = 1;
            this.tabPageAll.Text = "All";
            this.tabPageAll.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAll
            // 
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
            this.tabPageFloor1.Location = new System.Drawing.Point(4, 28);
            this.tabPageFloor1.Name = "tabPageFloor1";
            this.tabPageFloor1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFloor1.Size = new System.Drawing.Size(1226, 540);
            this.tabPageFloor1.TabIndex = 2;
            this.tabPageFloor1.Text = "Floor 1";
            this.tabPageFloor1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewFloor1
            // 
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
            this.tabPageFloor2.Location = new System.Drawing.Point(4, 28);
            this.tabPageFloor2.Name = "tabPageFloor2";
            this.tabPageFloor2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFloor2.Size = new System.Drawing.Size(1226, 540);
            this.tabPageFloor2.TabIndex = 3;
            this.tabPageFloor2.Text = "Floor 2";
            this.tabPageFloor2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewFloor2
            // 
            this.dataGridViewFloor2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFloor2.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewFloor2.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewFloor2.Name = "dataGridViewFloor2";
            this.dataGridViewFloor2.RowTemplate.Height = 30;
            this.dataGridViewFloor2.Size = new System.Drawing.Size(1223, 533);
            this.dataGridViewFloor2.TabIndex = 1;
            // 
            // textBoxEnteringCar
            // 
            this.textBoxEnteringCar.Location = new System.Drawing.Point(12, 590);
            this.textBoxEnteringCar.Name = "textBoxEnteringCar";
            this.textBoxEnteringCar.Size = new System.Drawing.Size(434, 28);
            this.textBoxEnteringCar.TabIndex = 1;
            this.textBoxEnteringCar.Text = "Type the plate number of the entering car here.";
            // 
            // textBoxLeftingCar
            // 
            this.textBoxLeftingCar.Location = new System.Drawing.Point(12, 624);
            this.textBoxLeftingCar.Name = "textBoxLeftingCar";
            this.textBoxLeftingCar.Size = new System.Drawing.Size(434, 28);
            this.textBoxLeftingCar.TabIndex = 2;
            this.textBoxLeftingCar.Text = "Type the plate number of the lefting car here.";
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(461, 590);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(147, 28);
            this.buttonEnter.TabIndex = 3;
            this.buttonEnter.Text = "Enter";
            this.buttonEnter.UseVisualStyleBackColor = true;
            // 
            // buttonLeft
            // 
            this.buttonLeft.Location = new System.Drawing.Point(461, 624);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(147, 28);
            this.buttonLeft.TabIndex = 4;
            this.buttonLeft.Text = "Left";
            this.buttonLeft.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 664);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.textBoxLeftingCar);
            this.Controls.Add(this.textBoxEnteringCar);
            this.Controls.Add(this.mainTabControl);
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "MainForm";
            this.Text = "Parking Lot Management";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainTabControl.ResumeLayout(false);
            this.tabPageSummary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSummary)).EndInit();
            this.tabPageAll.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAll)).EndInit();
            this.tabPageFloor1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFloor1)).EndInit();
            this.tabPageFloor2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFloor2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage tabPageSummary;
        private System.Windows.Forms.TabPage tabPageAll;
        private System.Windows.Forms.TabPage tabPageFloor1;
        private System.Windows.Forms.TabPage tabPageFloor2;
        private System.Windows.Forms.TextBox textBoxEnteringCar;
        private System.Windows.Forms.TextBox textBoxLeftingCar;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.DataGridView dataGridViewAll;
        private System.Windows.Forms.DataGridView dataGridViewFloor1;
        private System.Windows.Forms.DataGridView dataGridViewFloor2;
        private System.Windows.Forms.DataGridView dataGridViewSummary;
    }
}

