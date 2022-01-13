using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeelFree_Recreation_System
{
    public partial class DailyReportForm : Form
    {
        public DailyReportForm()
        {
            InitializeComponent();
        }

        private void UpdateReport(Report rm)
        {
            ChildCount.Text = rm.ChildrenCount.ToString();
            AdultCount.Text = rm.AdultCount.ToString();
            GroupCount.Text = rm.GroupCount.ToString();
            TotalCount.Text = (rm.AdultCount + rm.ChildrenCount + rm.GroupCount).ToString();
            ChildTransaction.Text = rm.ChildrenIncome.ToString();
            AdultTransaction.Text = rm.AdultIncome.ToString();
            GroupTransaction.Text = rm.GroupIncome.ToString();
            TotalTransaction.Text = (rm.ChildrenIncome + rm.AdultIncome + rm.GroupIncome).ToString();
            ReportChart.Series["Count"].Points.Clear();

            ReportChart.Series["Transaction"].Points.Clear();
            ReportChart.Series["Count"].Points.AddXY("Children", rm.ChildrenCount);
            ReportChart.Series["Count"].Points.AddXY("Adult", rm.AdultCount);
            ReportChart.Series["Count"].Points.AddXY("Group", rm.GroupCount);
            ReportChart.Series["Transaction"].Points.AddXY("Child", rm.ChildrenIncome);
            ReportChart.Series["Transaction"].Points.AddXY("Adult", rm.AdultIncome);
            ReportChart.Series["Transaction"].Points.AddXY("Group", rm.GroupIncome);



        }

        private void DailyReportForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Report rm = Helper.GetReportByDate(dateTimePicker1.Value);
            UpdateReport(rm);
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}
