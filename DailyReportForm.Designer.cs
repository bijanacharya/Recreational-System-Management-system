
namespace FeelFree_Recreation_System
{
    partial class DailyReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ReportChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.TotalTransaction = new System.Windows.Forms.Label();
            this.ChildTransaction = new System.Windows.Forms.Label();
            this.AdultTransaction = new System.Windows.Forms.Label();
            this.Transaction = new System.Windows.Forms.Label();
            this.TotalCount = new System.Windows.Forms.Label();
            this.GroupCount = new System.Windows.Forms.Label();
            this.GroupTransaction = new System.Windows.Forms.Label();
            this.ChildCount = new System.Windows.Forms.Label();
            this.AdultCount = new System.Windows.Forms.Label();
            this.Count = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ReportChart)).BeginInit();
            this.SuspendLayout();
            // 
            // ReportChart
            // 
            chartArea1.Name = "ChartArea1";
            this.ReportChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ReportChart.Legends.Add(legend1);
            this.ReportChart.Location = new System.Drawing.Point(476, 56);
            this.ReportChart.Name = "ReportChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Count";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Transaction";
            this.ReportChart.Series.Add(series1);
            this.ReportChart.Series.Add(series2);
            this.ReportChart.Size = new System.Drawing.Size(457, 349);
            this.ReportChart.TabIndex = 52;
            this.ReportChart.Text = "chartDailyReport";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(313, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 46);
            this.button1.TabIndex = 51;
            this.button1.Text = "Get Report";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TotalTransaction
            // 
            this.TotalTransaction.AutoSize = true;
            this.TotalTransaction.Location = new System.Drawing.Point(332, 367);
            this.TotalTransaction.Name = "TotalTransaction";
            this.TotalTransaction.Size = new System.Drawing.Size(115, 17);
            this.TotalTransaction.TabIndex = 50;
            this.TotalTransaction.Text = "TotalTransaction";
            // 
            // ChildTransaction
            // 
            this.ChildTransaction.AutoSize = true;
            this.ChildTransaction.Location = new System.Drawing.Point(332, 275);
            this.ChildTransaction.Name = "ChildTransaction";
            this.ChildTransaction.Size = new System.Drawing.Size(114, 17);
            this.ChildTransaction.TabIndex = 49;
            this.ChildTransaction.Text = "ChildTransaction";
            // 
            // AdultTransaction
            // 
            this.AdultTransaction.AutoSize = true;
            this.AdultTransaction.Location = new System.Drawing.Point(332, 230);
            this.AdultTransaction.Name = "AdultTransaction";
            this.AdultTransaction.Size = new System.Drawing.Size(115, 17);
            this.AdultTransaction.TabIndex = 48;
            this.AdultTransaction.Text = "AdultTransaction";
            // 
            // Transaction
            // 
            this.Transaction.AutoSize = true;
            this.Transaction.Location = new System.Drawing.Point(332, 182);
            this.Transaction.Name = "Transaction";
            this.Transaction.Size = new System.Drawing.Size(83, 17);
            this.Transaction.TabIndex = 47;
            this.Transaction.Text = "Transaction";
            // 
            // TotalCount
            // 
            this.TotalCount.AutoSize = true;
            this.TotalCount.Location = new System.Drawing.Point(177, 367);
            this.TotalCount.Name = "TotalCount";
            this.TotalCount.Size = new System.Drawing.Size(77, 17);
            this.TotalCount.TabIndex = 46;
            this.TotalCount.Text = "TotalCount";
            // 
            // GroupCount
            // 
            this.GroupCount.AutoSize = true;
            this.GroupCount.Location = new System.Drawing.Point(177, 324);
            this.GroupCount.Name = "GroupCount";
            this.GroupCount.Size = new System.Drawing.Size(85, 17);
            this.GroupCount.TabIndex = 45;
            this.GroupCount.Text = "GroupCount";
            // 
            // GroupTransaction
            // 
            this.GroupTransaction.AutoSize = true;
            this.GroupTransaction.Location = new System.Drawing.Point(332, 324);
            this.GroupTransaction.Name = "GroupTransaction";
            this.GroupTransaction.Size = new System.Drawing.Size(123, 17);
            this.GroupTransaction.TabIndex = 44;
            this.GroupTransaction.Text = "GroupTransaction";
            // 
            // ChildCount
            // 
            this.ChildCount.AutoSize = true;
            this.ChildCount.Location = new System.Drawing.Point(177, 275);
            this.ChildCount.Name = "ChildCount";
            this.ChildCount.Size = new System.Drawing.Size(76, 17);
            this.ChildCount.TabIndex = 43;
            this.ChildCount.Text = "ChildCount";
            // 
            // AdultCount
            // 
            this.AdultCount.AutoSize = true;
            this.AdultCount.Location = new System.Drawing.Point(177, 230);
            this.AdultCount.Name = "AdultCount";
            this.AdultCount.Size = new System.Drawing.Size(77, 17);
            this.AdultCount.TabIndex = 42;
            this.AdultCount.Text = "AdultCount";
            // 
            // Count
            // 
            this.Count.AutoSize = true;
            this.Count.Location = new System.Drawing.Point(177, 182);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(49, 17);
            this.Count.TabIndex = 41;
            this.Count.Text = "Count ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 367);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 40;
            this.label5.Text = "Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 39;
            this.label4.Text = "Group";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 38;
            this.label3.Text = "Child";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "Adult";
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Location = new System.Drawing.Point(25, 182);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(40, 17);
            this.Type.TabIndex = 36;
            this.Type.Text = "Type";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(28, 89);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 22);
            this.dateTimePicker1.TabIndex = 35;
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(299, 416);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(116, 41);
            this.Close.TabIndex = 53;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // DailyReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(964, 521);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.ReportChart);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TotalTransaction);
            this.Controls.Add(this.ChildTransaction);
            this.Controls.Add(this.AdultTransaction);
            this.Controls.Add(this.Transaction);
            this.Controls.Add(this.TotalCount);
            this.Controls.Add(this.GroupCount);
            this.Controls.Add(this.GroupTransaction);
            this.Controls.Add(this.ChildCount);
            this.Controls.Add(this.AdultCount);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "DailyReportForm";
            this.Text = "DailyReportForm";
            this.Load += new System.EventHandler(this.DailyReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReportChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ReportChart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label TotalTransaction;
        private System.Windows.Forms.Label ChildTransaction;
        private System.Windows.Forms.Label AdultTransaction;
        private System.Windows.Forms.Label Transaction;
        private System.Windows.Forms.Label TotalCount;
        private System.Windows.Forms.Label GroupCount;
        private System.Windows.Forms.Label GroupTransaction;
        private System.Windows.Forms.Label ChildCount;
        private System.Windows.Forms.Label AdultCount;
        private System.Windows.Forms.Label Count;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button Close;
    }
}