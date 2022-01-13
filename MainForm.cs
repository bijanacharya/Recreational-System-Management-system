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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        //Display date and time
        private void entryFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            ShowEntryForm();
        }

        public static EntryForm EV;
        //Entry form show
        private void ShowEntryForm()
        {
            if (EV == null)
            {
                EV = new EntryForm();
                //EV.MdiParent = this;
                EV.FormClosed += EntryForm.EntryForm_FormClosed;
                EV.Show();
            }
            else
            {
                EV.Activate();
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void exitFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExitForm newForm = new ExitForm();
            newForm.Show();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            this.Hide();
            login.Show();
        }

        private void chartsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ChartForm newform = new ChartForm();
            newform.Show();
        }

        private void chartsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TicketForm newform = new TicketForm();
            newform.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LabelDateAndTime.Text = DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss tt");
        }

        private void dailyReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DailyReportForm newForm = new DailyReportForm();
            newForm.Show();
        }

        private void weeklyReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WeeklyReportForm newForm = new WeeklyReportForm();
            newForm.Show();
                
        }
    }
}
