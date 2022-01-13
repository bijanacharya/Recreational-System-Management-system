using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using CsvHelper;
using System.Windows.Forms;
using System.IO;

namespace FeelFree_Recreation_System
{
    public partial class TicketForm : Form
    {
        public TicketForm()
        {
            InitializeComponent();
        }

        private void TicketForm_Load(object sender, EventArgs e)
        {
            tktRateBindingSource8.DataSource = new List<TktRate>();
            ticketView.DataSource = null;
            ticketView.DataSource = ReadTicketCsvFile(GlobalValues.ticketFilepath);

            ReadTicketCsvFile();
        }
        public static List<TktRate> ReadTicketCsvFile(string ticketFilepath)
        {
            GlobalValues.TicketList = new List<TktRate>();
            string[] tickets = File.ReadAllLines(ticketFilepath);
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

    
        public void ReadTicketCsvFile()
        {
            GlobalValues.TicketList = new List<TktRate>();

            string[] vts = File.ReadAllLines(GlobalValues.ticketFilepath);
            foreach (string v in vts)
            {
                string[] vs = v.Split(',');
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
            ticketView.DataSource = GlobalValues.TicketList;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void EditTicketRate()
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "CSV|*.csv", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    //Save datagridview to csv file
                    using (var sw = new StreamWriter(sfd.FileName))
                    {
                        var writer = new CsvWriter(sw, CultureInfo.CurrentCulture);
                        writer.WriteHeader(typeof(TktRate));
                        foreach (TktRate tkt in tktRateBindingSource8.DataSource as List<TktRate>)
                        {
                            writer.WriteRecord(tkt);
                        } 
                    }
                    MessageBox.Show("Your data has been successfully saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        
        //Edit Ticket Rate by admin
        private void button1_Click_1(object sender, EventArgs e)
        {
            EditTicketRate();
        }
    }
}
