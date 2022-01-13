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
    public partial class EntryForm : Form
    {
        public static string entryFilePath = "Visitors.csv";
        public EntryForm()
        {
            InitializeComponent();
        }

        private void EntryForm_Load(object sender, EventArgs e)
        {
            visitorView.DataSource = null;
            ReadCsvFile();
            
        }
        public static void EntryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.EV = null;
        }

        public void ReadCsvFile()
        {

            //defniting the path of csv file
            string entryFilePath = "Visitors.csv";
            GlobalValues.VisitorList = new List<Visitor>();
            string[] vts = File.ReadAllLines(entryFilePath);
            foreach (string v in vts)
            {
                string[] vs = v.Split(',');
                if (vs.Length != 4) continue;
                Visitor vO = new Visitor(); // visitor object One: vO
                vO.vId = Convert.ToInt32(vs[0]);
                vO.vType = vs[1];
                vO.vCount = Convert.ToInt32(vs[2]);
                vO.vEntryTime = Convert.ToDateTime(vs[3]);
                GlobalValues.VisitorList.Add(vO);
            }
            visitorView.DataSource = GlobalValues.VisitorList;
        }
        private void AddVisitorToCsv(int vtrId, string vtrType, int vtrCount, DateTime vtrEntryTime)
        {
            string vDetails = "\n" + vtrId + "," + vtrType + "," + vtrCount + "," + vtrEntryTime;
            File.AppendAllText(entryFilePath, vDetails);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {
                Visitor vtr = new Visitor(); // visitor object Two: vT
                vtr.vId = (int)VId.Value;
                vtr.vType = VType.Text;
                vtr.vCount = (int)VCount.Value;
                vtr.vEntryTime = DateTime.Now;

                GlobalValues.VisitorList.Add(vtr);

                AddVisitorToCsv(vtr.vId, vtr.vType, vtr.vCount, vtr.vEntryTime);
                VId.Value = vtr.vId;
                VType.Text = "";
                VCount.Value = vtr.vCount;


                MessageBox.Show("Visitor Successfuly Added!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            visitorView.DataSource = null;
            visitorView.DataSource = GlobalValues.VisitorList;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {


            try
            {
                Visitor vT = new Visitor(); // visitor object Two: vT
                vT.vId = (int)VId.Value;
                vT.vType = VType.Text;
                vT.vCount = (int)VCount.Value;
                vT.vEntryTime = DateTime.Now;

                GlobalValues.VisitorList.Add(vT);

                AddVisitorToCsv(vT.vId, vT.vType, vT.vCount, vT.vEntryTime);
                vT.vId = vT.vId;
                VType.Text = "";
                VCount.Value = vT.vCount;


                MessageBox.Show("Visitor Successfuly Added!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            visitorView.DataSource = null;
            visitorView.DataSource = GlobalValues.VisitorList;
        }


        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Close();
        }

    }
}
