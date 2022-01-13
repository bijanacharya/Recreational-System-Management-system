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
    public partial class ExitForm : Form
    {

        // Declaring instance variable
        static int TktId;
        static int totalHours;
        static int totalCharge;
        static int rate;
        static int m = 1; // m will be the multiplier which multiply rate per person by visitor count.

        public int cost;
        public static string entryFilePath = "visitors.csv";

        public static string recordFilepath = "Record.csv";

        public ExitForm()
        {
            InitializeComponent();
        }

        private void ExitForm_Load(object sender, EventArgs e)
        {
            TicketForm TF = new TicketForm();
            TF.ReadTicketCsvFile();
        }
        //Id search and display details
        private void btnSearchId_Click(object sender, EventArgs e)
        {
            String Id = ExitId.Text;
            Visitor v = GetRecordWithId(Id);


            btnExit.Visible = true;
            try
            {
                exitType.Text = v.vType.ToString();
                exitCount.Text = v.vCount.ToString();
                entryTime.Text = v.vEntryTime.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Visitor with that Id is not available");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            exitDuration.Visible = true;
            btnExit.Enabled = true;

            //btnCompleteExit.Visible = true;
            exitTime.Text = DateTime.Now.ToString();

            // calculate duration 
            int durationHrs = (DateTime.Now - Convert.ToDateTime(entryTime.Text)).Hours;
            int durationMins = (DateTime.Now - Convert.ToDateTime(entryTime.Text)).Minutes;
            exitDuration.Text = durationHrs.ToString() + "Hrs" + durationMins.ToString() + "Mins";

            // if minute id more than 1 minute, they vill be charge of 2 hours

            if (durationMins >= 1)
            {
                totalHours = durationHrs + 1; // if it's not been an hour i.e 0. +1 will set it as 1 hour
            }

            // calculate cost of the visitor
            if (exitType.Text == "Child")
            {
                TktId = 1; // set ticket Id accordingly
                m = Convert.ToInt32(exitCount.Text);
            }
            else if (exitCount.Text == "Adult")
            {
                TktId = 2;
                m = Convert.ToInt32(exitCount.Text);
            }
            else if (exitType.Text == "Group")
            {
                m = 1;
                if (Convert.ToInt32(exitCount.Text) <= 5)
                {
                    TktId = 3;
                }
                if (Convert.ToInt32(exitCount.Text) > 5 & Convert.ToInt32(exitCount.Text) <= 10)
                {
                    TktId = 4;
                }
                if (Convert.ToInt32(exitCount.Text) > 10 & Convert.ToInt32(exitCount.Text) <= 15)
                {
                    TktId = 5;

                }

            }
            //else
            //{
             //}

            TktRate t = GetTktRecordWithId(TktId);

            switch (totalHours)
            {
                case 1:
                    rate = t.Rate1hr;
                    break;
                case 2:
                    rate = t.Rate2hr;
                    break;
                case 3:
                    rate = t.Rate3hr;
                    break;
                case 4:
                    rate = t.Rate4hr;
                    break;
                default:
                    rate = t.RateWholeday;
                    break;
            }
            price.Visible = true;
            totalCharge = rate * m;
            price.Text = totalCharge.ToString();
        }
        public static List<Visitor> ReadCsvFile(string entryFilePath)
        {
            GlobalValues.VisitorList = new List<Visitor>();
            string[] visitors = File.ReadAllLines(entryFilePath);
            foreach (string v in visitors)
            {
                string[] vs = v.Split(',');
                if (vs.Length != 4) continue;
                Visitor vtrObj = new Visitor();
                vtrObj.vId = Convert.ToInt32(vs[0]);
                vtrObj.vType = vs[1];
                vtrObj.vCount = Convert.ToInt32(vs[2]);
                vtrObj.vEntryTime = Convert.ToDateTime(vs[3]);
                GlobalValues.VisitorList.Add(vtrObj );
            }
            return GlobalValues.VisitorList;
        }
        public static List<TktRate> ReadTicketCsvFile(string ticketFilePath)
        {
            GlobalValues.TicketList = new List<TktRate>();
            string[] tickets = File.ReadAllLines(ticketFilePath);
            foreach (string tc in tickets)
            {

                string[] vs = tc.Split(',');
                if (vs.Length != 7) continue;
                TktRate vO = new TktRate();
                vO.TktId = Convert.ToInt32(vs[0]);
                vO.TktType = vs[1];
                vO.Rate1hr = Convert.ToInt32(vs[2]);
                vO.Rate2hr = Convert.ToInt32(vs[3]);
                vO.Rate3hr = Convert.ToInt32(vs[4]);
                vO.Rate4hr = Convert.ToInt32(vs[5]);
                vO.RateWholeday = Convert.ToInt32(vs[6]);

                GlobalValues.TicketList.Add(vO);
            }
            return GlobalValues.TicketList;

        }
        public static Visitor GetRecordWithId(string searchterm)
        {
            if (GlobalValues.VisitorList == null || GlobalValues.VisitorList.Count < 1)
            {

                GlobalValues.VisitorList = ReadCsvFile(entryFilePath);
            }
            int id = Convert.ToInt32(searchterm);
            Visitor visitor = null;
            foreach (Visitor v in GlobalValues.VisitorList)
            {
                if (v.vId == id)
                {
                    visitor = v;
                }
            }
            return visitor;
        }
        public static TktRate GetTktRecordWithId(int searchterm)
        {
            if (GlobalValues.TicketList == null)
            {

                GlobalValues.TicketList = ReadTicketCsvFile(GlobalValues.ticketFilepath);
            }

            int tktid = searchterm;
            TktRate ticket = null;
            foreach (TktRate t in GlobalValues.TicketList)
            {
                if (t.TktId == tktid)
                {
                    ticket = t;
                }
            }
            return ticket;
        }
        public void ClearInputs()
        {

            exitType.Clear();
            entryTime.Clear();
            exitTime.Clear();

            exitDuration.Clear();
            price.Clear();


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // creating record object
                Record r = new Record();
                r.vId = (int)ExitId.Value;
                r.vType = exitType.Text;
                r.vCount = Convert.ToInt32(exitCount.Text);
                r.vEntryTime = Convert.ToDateTime(entryTime.Text);
                r.vExitTime = Convert.ToDateTime(exitTime.Text);
                r.Duration = exitDuration.Text;
                r.vCost = Convert.ToInt32(price.Text);

                GlobalValues.RecordList.Add(r);



                Helper.AddRecordToCsv(r.vId, r.vType, r.vCount, r.vEntryTime, r.vExitTime, r.Duration, r.vCost);
                r.vId = Convert.ToInt32(ExitId.Value);
                r.vType = exitType.Text;
                r.vCount = Convert.ToInt32(exitCount.Text);
                r.vEntryTime = Convert.ToDateTime(entryTime.Text);
                r.vExitTime = Convert.ToDateTime(exitTime.Text);
                r.Duration = exitDuration.Text;
                r.vCost = Convert.ToInt32(price.Text);

                MessageBox.Show("Exit Record Saved");

            }
            catch (FormatException)
            {
                MessageBox.Show("Something went wrong with btnComplete");
            }
            ClearInputs();
        }
    }
}
