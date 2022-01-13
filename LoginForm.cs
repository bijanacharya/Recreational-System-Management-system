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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            //Disable menustrip 
            menuStrip1.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //Redirect to main form
        private void btnUser_Click(object sender, EventArgs e)
        {
            MainForm newForm = new MainForm();
            newForm.Show();
        }
        //Date and time display
        private void timer1_Tick(object sender, EventArgs e)
        {
            LabelDateAndTime.Text = DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss tt");
        }
        //Login process by user or admin
        private void btnLogin_Click(object sender, EventArgs e)
        {
            {
                if (username.Text != "admin")
                {
                    MessageBox.Show("Username is incorrect!", "Alert",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    username.Clear();
                }
                else if (password.Text != "admin")
                {
                    MessageBox.Show("Password is incorrect!", "Alert",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    password.Clear();
                }
                else
                {
                    MessageBox.Show("Logged in Successfully !!!", "Success",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                }
            }
        }

        private void LabelDataTime_Click(object sender, EventArgs e)
        {

        }
        //Main Form load process
        private void ticketRateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TicketForm newForm = new TicketForm();
            newForm.Show();
        }
    }
}
