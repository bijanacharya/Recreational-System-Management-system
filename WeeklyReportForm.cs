using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FeelFree_Recreation_System
{
    public partial class WeeklyReportForm : Form
    {
        public WeeklyReportForm()
        {
            InitializeComponent();
        }

        private void WeeklyReportForm_Load(object sender, EventArgs e)
        {

        }
        public static List<Record> GetRecordsFromCSV(string recordFilePath)
        {
            GlobalValues.RecordList = new List<Record>();
            string[] records = File.ReadAllLines(recordFilePath);
            foreach (string rds in records)
            {
                string[] recs = rds.Split(',');
                if (recs.Length != 7) continue;
                Record recObj = new Record();
                recObj.vId = Convert.ToInt32(recs[0]);
                recObj.vType = recs[1];
                recObj.vCount = Convert.ToInt32(recs[2]);
                recObj.vEntryTime = Convert.ToDateTime(recs[3]);
                recObj.vExitTime = Convert.ToDateTime(recs[4]);
                recObj.Duration = recs[5];
                recObj.vCost = Convert.ToInt32(recs[6]);
                GlobalValues.RecordList.Add(recObj);
            }
            return GlobalValues.RecordList;
        }
        public static Report GetReportPerDay(DateTime day)
        {
            List<Record> recordList = GetRecordsFromCSV(Helper.recordFilepath);
            Report report = new Report();
            report.Date = day;
            foreach (Record r in recordList)
            {
                if (r.vEntryTime.DayOfYear != day.DayOfYear) continue;
                if (r.vType == "Adult")
                {
                    report.AdultCount += r.vCount;
                    report.AdultIncome += r.vCost;
                }
                else if (r.vType == "Child")
                {
                    report.ChildrenCount += r.vCount;
                    report.ChildrenIncome += r.vCost;
                }
                else if (r.vType == "Group")
                {
                    report.GroupCount += r.vCount;
                    report.GroupIncome += r.vCost;
                }
            }
            return report;
        }
        private void UpdateReportA(Report r)
        {
            VisTot1.Text = (r.AdultCount + r.ChildrenCount + r.GroupCount).ToString();
            Earning1.Text = (r.AdultIncome + r.ChildrenIncome + r.GroupIncome).ToString();
            DayA.Text = DateTime.Now.DayOfWeek.ToString();
            chartWeekly.Series["TotalVisitors"].Points.Clear();
            chartWeekly.Series["TotalEarnings"].Points.Clear();
            chartWeekly.Series["TotalVisitors"].Points.AddXY(DayA.Text, VisTot1.Text);
            chartWeekly.Series["TotalEarnings"].Points.AddXY(DayA.Text, Earning1.Text);
        }

        private void UpdateReportB(Report r)
        {
            VisTot2.Text = (r.AdultCount + r.ChildrenCount + r.GroupCount).ToString();
            Earning2.Text = (r.AdultIncome + r.ChildrenIncome + r.GroupIncome).ToString();
            DayB.Text = DateTime.Now.AddDays(-1).DayOfWeek.ToString();
            chartWeekly.Series["TotalVisitors"].Points.AddXY(DayB.Text, VisTot2.Text);
            chartWeekly.Series["TotalEarnings"].Points.AddXY(DayB.Text, Earning2.Text);
        }

        private void UpdateReportC(Report r)
        {
            VisTot3.Text = (r.AdultCount + r.ChildrenCount + r.GroupCount).ToString();
            Earning3.Text = (r.AdultIncome + r.ChildrenIncome + r.GroupIncome).ToString();
            DayC.Text = DateTime.Now.AddDays(-2).DayOfWeek.ToString();
            chartWeekly.Series["TotalVisitors"].Points.AddXY(DayC.Text, VisTot3.Text);
            chartWeekly.Series["TotalEarnings"].Points.AddXY(DayC.Text, Earning3.Text);
        }

        private void UpdateReportD(Report r)
        {
            VisTot4.Text = (r.AdultCount + r.ChildrenCount + r.GroupCount).ToString();
            Earning4.Text = (r.AdultIncome + r.ChildrenIncome + r.GroupIncome).ToString();
            DayD.Text = DateTime.Now.AddDays(-3).DayOfWeek.ToString();
            chartWeekly.Series["TotalVisitors"].Points.AddXY(DayD.Text, VisTot4.Text);
            chartWeekly.Series["TotalEarnings"].Points.AddXY(DayD.Text, Earning4.Text);
        }

        private void UpdateReportE(Report r)
        {
            VisTot5.Text = (r.AdultCount + r.ChildrenCount + r.GroupCount).ToString();
            Earning5.Text = (r.AdultIncome + r.ChildrenIncome + r.GroupIncome).ToString();
            DayE.Text = DateTime.Now.AddDays(-4).DayOfWeek.ToString();
            chartWeekly.Series["TotalVisitors"].Points.AddXY(DayE.Text, VisTot5.Text);
            chartWeekly.Series["TotalEarnings"].Points.AddXY(DayE.Text, Earning5.Text);
        }

        private void UpdateReportF(Report r)
        {
            VisTot6.Text = (r.AdultCount + r.ChildrenCount + r.GroupCount).ToString();
            Earning6.Text = (r.AdultIncome + r.ChildrenIncome + r.GroupIncome).ToString();
            DayF.Text = DateTime.Now.AddDays(-5).DayOfWeek.ToString();
            chartWeekly.Series["TotalVisitors"].Points.AddXY(DayF.Text, VisTot6.Text);
            chartWeekly.Series["TotalEarnings"].Points.AddXY(DayF.Text, Earning6.Text);
        }

        private void UpdateReportG(Report r)
        {
            VisTot7.Text = (r.AdultCount + r.ChildrenCount + r.GroupCount).ToString();
            Earning7.Text = (r.AdultIncome + r.ChildrenIncome + r.GroupIncome).ToString();
            DayG.Text = DateTime.Now.AddDays(-6).DayOfWeek.ToString();
            chartWeekly.Series["TotalVisitors"].Points.AddXY(DayG.Text, VisTot7.Text);
            chartWeekly.Series["TotalEarnings"].Points.AddXY(DayG.Text, Earning7.Text);
        }

        private void CalculateValues()
        {
            for (int i = 0; i < 7; i++)
            {
                Report r = GetReportPerDay(DateTime.Today.AddDays(-i));
                if (i == 0)
                {
                    UpdateReportA(r);
                }
                if (i == 1)
                {
                    UpdateReportB(r);
                }
                if (i == 2)
                {
                    UpdateReportC(r);
                }
                if (i == 3)
                {
                    UpdateReportD(r);
                }
                if (i == 4)
                {
                    UpdateReportE(r);
                }
                if (i == 5)
                {
                    UpdateReportF(r);
                }
                if (i == 6)
                {
                    UpdateReportG(r);
                }
            }
        }
        private void sortingByCount()
        {
            int a, b, c, d, e, f, g;
            a = Convert.ToInt32(VisTot1.Text);
            b = Convert.ToInt32(VisTot2.Text);
            c = Convert.ToInt32(VisTot3.Text);
            d = Convert.ToInt32(VisTot4.Text);
            e = Convert.ToInt32(VisTot5.Text);
            f = Convert.ToInt32(VisTot6.Text);
            g = Convert.ToInt32(VisTot7.Text);

            int[] arr = { a, b, c, d, e, f, g };
            int temp;
            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }

            label14.Text = arr[0].ToString();
            label12.Text = arr[1].ToString();
            label11.Text = arr[2].ToString();
            label9.Text = arr[3].ToString();
            label8.Text = arr[4].ToString();
            label6.Text = arr[5].ToString();
            label5.Text = arr[6].ToString();
        }

        private void sortingByEarnings()
        {
            int a, b, c, d, e, f, g;
            a = Convert.ToInt32(Earning1.Text);
            b = Convert.ToInt32(Earning2.Text);
            c = Convert.ToInt32(Earning3.Text);
            d = Convert.ToInt32(Earning4.Text);
            e = Convert.ToInt32(Earning5.Text);
            f = Convert.ToInt32(Earning6.Text);
            g = Convert.ToInt32(Earning7.Text);

            // BUBLE SORTING
            int[] arr = { a, b, c, d, e, f, g };
            int temp;
            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }

            label14.Text = arr[0].ToString();
            label12.Text = arr[1].ToString();
            label11.Text = arr[2].ToString();
            label9.Text = arr[3].ToString();
            label8.Text = arr[4].ToString();
            label6.Text = arr[5].ToString();
            label5.Text = arr[6].ToString();
        }
        
        private void GetReport_Click(object sender, EventArgs e)
        {
            CalculateValues();
            labelSort.Visible = true;
            radioBtnSortByCount.Visible = true;
            radioBtnSortByEarning.Visible = true;
        }

        private void radioBtnSortByEarning_CheckedChanged(object sender, EventArgs e)
        {
            sortingByEarnings();
            
        }

        private void radioBtnSortByCount_CheckedChanged(object sender, EventArgs e)
        {
            sortingByCount();
            
        }
    }

}
