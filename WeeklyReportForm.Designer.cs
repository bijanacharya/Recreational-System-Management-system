
namespace FeelFree_Recreation_System
{
    partial class WeeklyReportForm
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.radioBtnSortByCount = new System.Windows.Forms.RadioButton();
            this.radioBtnSortByEarning = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.VisTot1 = new System.Windows.Forms.Label();
            this.Earning1 = new System.Windows.Forms.Label();
            this.VisTot2 = new System.Windows.Forms.Label();
            this.Earning2 = new System.Windows.Forms.Label();
            this.VisTot3 = new System.Windows.Forms.Label();
            this.Earning3 = new System.Windows.Forms.Label();
            this.VisTot4 = new System.Windows.Forms.Label();
            this.Earning4 = new System.Windows.Forms.Label();
            this.VisTot5 = new System.Windows.Forms.Label();
            this.Earning5 = new System.Windows.Forms.Label();
            this.VisTot6 = new System.Windows.Forms.Label();
            this.Earning6 = new System.Windows.Forms.Label();
            this.VisTot7 = new System.Windows.Forms.Label();
            this.Earning7 = new System.Windows.Forms.Label();
            this.chartWeekly = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.GetReport = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.labelSort = new System.Windows.Forms.Label();
            this.DayG = new System.Windows.Forms.Label();
            this.DayF = new System.Windows.Forms.Label();
            this.DayE = new System.Windows.Forms.Label();
            this.DayD = new System.Windows.Forms.Label();
            this.DayC = new System.Windows.Forms.Label();
            this.DayB = new System.Windows.Forms.Label();
            this.DayA = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartWeekly)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(76, 21);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(220, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // radioBtnSortByCount
            // 
            this.radioBtnSortByCount.AutoSize = true;
            this.radioBtnSortByCount.Location = new System.Drawing.Point(12, 61);
            this.radioBtnSortByCount.Name = "radioBtnSortByCount";
            this.radioBtnSortByCount.Size = new System.Drawing.Size(116, 21);
            this.radioBtnSortByCount.TabIndex = 1;
            this.radioBtnSortByCount.TabStop = true;
            this.radioBtnSortByCount.Text = "Sort By Count";
            this.radioBtnSortByCount.UseVisualStyleBackColor = true;
            this.radioBtnSortByCount.CheckedChanged += new System.EventHandler(this.radioBtnSortByCount_CheckedChanged);
            // 
            // radioBtnSortByEarning
            // 
            this.radioBtnSortByEarning.AutoSize = true;
            this.radioBtnSortByEarning.Location = new System.Drawing.Point(157, 61);
            this.radioBtnSortByEarning.Name = "radioBtnSortByEarning";
            this.radioBtnSortByEarning.Size = new System.Drawing.Size(128, 21);
            this.radioBtnSortByEarning.TabIndex = 2;
            this.radioBtnSortByEarning.TabStop = true;
            this.radioBtnSortByEarning.Text = "Sort By Earning";
            this.radioBtnSortByEarning.UseVisualStyleBackColor = true;
            this.radioBtnSortByEarning.CheckedChanged += new System.EventHandler(this.radioBtnSortByEarning_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Total Visitors";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(200, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total Earning";
            // 
            // VisTot1
            // 
            this.VisTot1.AutoSize = true;
            this.VisTot1.Location = new System.Drawing.Point(122, 148);
            this.VisTot1.Name = "VisTot1";
            this.VisTot1.Size = new System.Drawing.Size(45, 17);
            this.VisTot1.TabIndex = 7;
            this.VisTot1.Text = "Count";
            // 
            // Earning1
            // 
            this.Earning1.AutoSize = true;
            this.Earning1.Location = new System.Drawing.Point(213, 147);
            this.Earning1.Name = "Earning1";
            this.Earning1.Size = new System.Drawing.Size(57, 17);
            this.Earning1.TabIndex = 8;
            this.Earning1.Text = "Earning";
            // 
            // VisTot2
            // 
            this.VisTot2.AutoSize = true;
            this.VisTot2.Location = new System.Drawing.Point(122, 190);
            this.VisTot2.Name = "VisTot2";
            this.VisTot2.Size = new System.Drawing.Size(45, 17);
            this.VisTot2.TabIndex = 10;
            this.VisTot2.Text = "Count";
            // 
            // Earning2
            // 
            this.Earning2.AutoSize = true;
            this.Earning2.Location = new System.Drawing.Point(213, 189);
            this.Earning2.Name = "Earning2";
            this.Earning2.Size = new System.Drawing.Size(57, 17);
            this.Earning2.TabIndex = 11;
            this.Earning2.Text = "Earning";
            // 
            // VisTot3
            // 
            this.VisTot3.AutoSize = true;
            this.VisTot3.Location = new System.Drawing.Point(122, 226);
            this.VisTot3.Name = "VisTot3";
            this.VisTot3.Size = new System.Drawing.Size(45, 17);
            this.VisTot3.TabIndex = 13;
            this.VisTot3.Text = "Count";
            // 
            // Earning3
            // 
            this.Earning3.AutoSize = true;
            this.Earning3.Location = new System.Drawing.Point(213, 225);
            this.Earning3.Name = "Earning3";
            this.Earning3.Size = new System.Drawing.Size(57, 17);
            this.Earning3.TabIndex = 14;
            this.Earning3.Text = "Earning";
            // 
            // VisTot4
            // 
            this.VisTot4.AutoSize = true;
            this.VisTot4.Location = new System.Drawing.Point(125, 265);
            this.VisTot4.Name = "VisTot4";
            this.VisTot4.Size = new System.Drawing.Size(45, 17);
            this.VisTot4.TabIndex = 16;
            this.VisTot4.Text = "Count";
            // 
            // Earning4
            // 
            this.Earning4.AutoSize = true;
            this.Earning4.Location = new System.Drawing.Point(216, 265);
            this.Earning4.Name = "Earning4";
            this.Earning4.Size = new System.Drawing.Size(57, 17);
            this.Earning4.TabIndex = 17;
            this.Earning4.Text = "Earning";
            // 
            // VisTot5
            // 
            this.VisTot5.AutoSize = true;
            this.VisTot5.Location = new System.Drawing.Point(125, 306);
            this.VisTot5.Name = "VisTot5";
            this.VisTot5.Size = new System.Drawing.Size(45, 17);
            this.VisTot5.TabIndex = 19;
            this.VisTot5.Text = "Count";
            // 
            // Earning5
            // 
            this.Earning5.AutoSize = true;
            this.Earning5.Location = new System.Drawing.Point(219, 305);
            this.Earning5.Name = "Earning5";
            this.Earning5.Size = new System.Drawing.Size(57, 17);
            this.Earning5.TabIndex = 20;
            this.Earning5.Text = "Earning";
            // 
            // VisTot6
            // 
            this.VisTot6.AutoSize = true;
            this.VisTot6.Location = new System.Drawing.Point(128, 349);
            this.VisTot6.Name = "VisTot6";
            this.VisTot6.Size = new System.Drawing.Size(45, 17);
            this.VisTot6.TabIndex = 22;
            this.VisTot6.Text = "Count";
            // 
            // Earning6
            // 
            this.Earning6.AutoSize = true;
            this.Earning6.Location = new System.Drawing.Point(216, 349);
            this.Earning6.Name = "Earning6";
            this.Earning6.Size = new System.Drawing.Size(57, 17);
            this.Earning6.TabIndex = 23;
            this.Earning6.Text = "Earning";
            // 
            // VisTot7
            // 
            this.VisTot7.AutoSize = true;
            this.VisTot7.Location = new System.Drawing.Point(131, 390);
            this.VisTot7.Name = "VisTot7";
            this.VisTot7.Size = new System.Drawing.Size(45, 17);
            this.VisTot7.TabIndex = 25;
            this.VisTot7.Text = "Count";
            // 
            // Earning7
            // 
            this.Earning7.AutoSize = true;
            this.Earning7.Location = new System.Drawing.Point(219, 391);
            this.Earning7.Name = "Earning7";
            this.Earning7.Size = new System.Drawing.Size(57, 17);
            this.Earning7.TabIndex = 26;
            this.Earning7.Text = "Earning";
            // 
            // chartWeekly
            // 
            chartArea1.Name = "ChartArea1";
            this.chartWeekly.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartWeekly.Legends.Add(legend1);
            this.chartWeekly.Location = new System.Drawing.Point(416, 12);
            this.chartWeekly.Name = "chartWeekly";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "TotalVisitors";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "TotalEarnings";
            this.chartWeekly.Series.Add(series1);
            this.chartWeekly.Series.Add(series2);
            this.chartWeekly.Size = new System.Drawing.Size(372, 413);
            this.chartWeekly.TabIndex = 27;
            this.chartWeekly.Text = "chart1";
            // 
            // GetReport
            // 
            this.GetReport.Location = new System.Drawing.Point(308, 49);
            this.GetReport.Name = "GetReport";
            this.GetReport.Size = new System.Drawing.Size(92, 44);
            this.GetReport.TabIndex = 28;
            this.GetReport.Text = "Get Report";
            this.GetReport.UseVisualStyleBackColor = true;
            this.GetReport.Click += new System.EventHandler(this.GetReport_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(331, 394);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 36;
            this.label5.Text = "label24";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(328, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 17);
            this.label6.TabIndex = 35;
            this.label6.Text = "label21";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(331, 308);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 17);
            this.label8.TabIndex = 34;
            this.label8.Text = "label18";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(328, 268);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 17);
            this.label9.TabIndex = 33;
            this.label9.Text = "label15";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(325, 228);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 17);
            this.label11.TabIndex = 32;
            this.label11.Text = "label12";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(325, 192);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 17);
            this.label12.TabIndex = 31;
            this.label12.Text = "label9";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(325, 150);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 17);
            this.label14.TabIndex = 30;
            this.label14.Text = "label6";
            // 
            // labelSort
            // 
            this.labelSort.AutoSize = true;
            this.labelSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSort.Location = new System.Drawing.Point(317, 115);
            this.labelSort.Name = "labelSort";
            this.labelSort.Size = new System.Drawing.Size(58, 18);
            this.labelSort.TabIndex = 29;
            this.labelSort.Text = "Sorted";
            // 
            // DayG
            // 
            this.DayG.AutoSize = true;
            this.DayG.Location = new System.Drawing.Point(26, 390);
            this.DayG.Name = "DayG";
            this.DayG.Size = new System.Drawing.Size(44, 17);
            this.DayG.TabIndex = 44;
            this.DayG.Text = "DayG";
            // 
            // DayF
            // 
            this.DayF.AutoSize = true;
            this.DayF.Location = new System.Drawing.Point(25, 349);
            this.DayF.Name = "DayF";
            this.DayF.Size = new System.Drawing.Size(41, 17);
            this.DayF.TabIndex = 43;
            this.DayF.Text = "DayF";
            // 
            // DayE
            // 
            this.DayE.AutoSize = true;
            this.DayE.Location = new System.Drawing.Point(24, 306);
            this.DayE.Name = "DayE";
            this.DayE.Size = new System.Drawing.Size(42, 17);
            this.DayE.TabIndex = 42;
            this.DayE.Text = "DayE";
            // 
            // DayD
            // 
            this.DayD.AutoSize = true;
            this.DayD.Location = new System.Drawing.Point(26, 265);
            this.DayD.Name = "DayD";
            this.DayD.Size = new System.Drawing.Size(43, 17);
            this.DayD.TabIndex = 41;
            this.DayD.Text = "DayD";
            // 
            // DayC
            // 
            this.DayC.AutoSize = true;
            this.DayC.Location = new System.Drawing.Point(25, 226);
            this.DayC.Name = "DayC";
            this.DayC.Size = new System.Drawing.Size(42, 17);
            this.DayC.TabIndex = 40;
            this.DayC.Text = "DayC";
            // 
            // DayB
            // 
            this.DayB.AutoSize = true;
            this.DayB.Location = new System.Drawing.Point(25, 190);
            this.DayB.Name = "DayB";
            this.DayB.Size = new System.Drawing.Size(42, 17);
            this.DayB.TabIndex = 39;
            this.DayB.Text = "DayB";
            // 
            // DayA
            // 
            this.DayA.AutoSize = true;
            this.DayA.Location = new System.Drawing.Point(25, 148);
            this.DayA.Name = "DayA";
            this.DayA.Size = new System.Drawing.Size(42, 17);
            this.DayA.TabIndex = 38;
            this.DayA.Text = "DayA";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(20, 113);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 18);
            this.label18.TabIndex = 37;
            this.label18.Text = "Day";
            // 
            // WeeklyReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DayG);
            this.Controls.Add(this.DayF);
            this.Controls.Add(this.DayE);
            this.Controls.Add(this.DayD);
            this.Controls.Add(this.DayC);
            this.Controls.Add(this.DayB);
            this.Controls.Add(this.DayA);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.labelSort);
            this.Controls.Add(this.GetReport);
            this.Controls.Add(this.chartWeekly);
            this.Controls.Add(this.Earning7);
            this.Controls.Add(this.VisTot7);
            this.Controls.Add(this.Earning6);
            this.Controls.Add(this.VisTot6);
            this.Controls.Add(this.Earning5);
            this.Controls.Add(this.VisTot5);
            this.Controls.Add(this.Earning4);
            this.Controls.Add(this.VisTot4);
            this.Controls.Add(this.Earning3);
            this.Controls.Add(this.VisTot3);
            this.Controls.Add(this.Earning2);
            this.Controls.Add(this.VisTot2);
            this.Controls.Add(this.Earning1);
            this.Controls.Add(this.VisTot1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioBtnSortByEarning);
            this.Controls.Add(this.radioBtnSortByCount);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "WeeklyReportForm";
            this.Text = "WeeklyReportForm";
            this.Load += new System.EventHandler(this.WeeklyReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartWeekly)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton radioBtnSortByCount;
        private System.Windows.Forms.RadioButton radioBtnSortByEarning;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label VisTot1;
        private System.Windows.Forms.Label Earning1;
        private System.Windows.Forms.Label VisTot2;
        private System.Windows.Forms.Label Earning2;
        private System.Windows.Forms.Label VisTot3;
        private System.Windows.Forms.Label Earning3;
        private System.Windows.Forms.Label VisTot4;
        private System.Windows.Forms.Label Earning4;
        private System.Windows.Forms.Label VisTot5;
        private System.Windows.Forms.Label Earning5;
        private System.Windows.Forms.Label VisTot6;
        private System.Windows.Forms.Label Earning6;
        private System.Windows.Forms.Label VisTot7;
        private System.Windows.Forms.Label Earning7;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartWeekly;
        private System.Windows.Forms.Button GetReport;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label labelSort;
        private System.Windows.Forms.Label DayG;
        private System.Windows.Forms.Label DayF;
        private System.Windows.Forms.Label DayE;
        private System.Windows.Forms.Label DayD;
        private System.Windows.Forms.Label DayC;
        private System.Windows.Forms.Label DayB;
        private System.Windows.Forms.Label DayA;
        private System.Windows.Forms.Label label18;
    }
}