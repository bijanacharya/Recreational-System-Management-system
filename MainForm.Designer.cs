
namespace FeelFree_Recreation_System
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.weeklyReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chartsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dailyReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entryFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Welcome = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chartsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.LabelDateAndTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // weeklyReportsToolStripMenuItem
            // 
            this.weeklyReportsToolStripMenuItem.Name = "weeklyReportsToolStripMenuItem";
            this.weeklyReportsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.weeklyReportsToolStripMenuItem.Text = "Weekly Reports";
            this.weeklyReportsToolStripMenuItem.Click += new System.EventHandler(this.weeklyReportsToolStripMenuItem_Click);
            // 
            // chartsToolStripMenuItem
            // 
            this.chartsToolStripMenuItem.Name = "chartsToolStripMenuItem";
            this.chartsToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.chartsToolStripMenuItem.Text = "Ticket";
            this.chartsToolStripMenuItem.Click += new System.EventHandler(this.chartsToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dailyReportsToolStripMenuItem,
            this.weeklyReportsToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // dailyReportsToolStripMenuItem
            // 
            this.dailyReportsToolStripMenuItem.Name = "dailyReportsToolStripMenuItem";
            this.dailyReportsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dailyReportsToolStripMenuItem.Text = "Daily Reports";
            this.dailyReportsToolStripMenuItem.Click += new System.EventHandler(this.dailyReportsToolStripMenuItem_Click);
            // 
            // exitFormToolStripMenuItem
            // 
            this.exitFormToolStripMenuItem.Name = "exitFormToolStripMenuItem";
            this.exitFormToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.exitFormToolStripMenuItem.Text = "Exit Form";
            this.exitFormToolStripMenuItem.Click += new System.EventHandler(this.exitFormToolStripMenuItem_Click);
            // 
            // entryFormToolStripMenuItem
            // 
            this.entryFormToolStripMenuItem.Name = "entryFormToolStripMenuItem";
            this.entryFormToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.entryFormToolStripMenuItem.Text = "Entry Form";
            this.entryFormToolStripMenuItem.Click += new System.EventHandler(this.entryFormToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entryFormToolStripMenuItem,
            this.exitFormToolStripMenuItem});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.signOutToolStripMenuItem});
            this.userToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.userToolStripMenuItem.Text = "User";
            this.userToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.signOutToolStripMenuItem.Text = "Sign Out";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Aquamarine;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(242, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(404, 46);
            this.label2.TabIndex = 40;
            this.label2.Text = "Management Sysyem";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MintCream;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(687, 48);
            this.label1.TabIndex = 39;
            this.label1.Text = "FEELFREE RECREATION SYSTEM";
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.BackColor = System.Drawing.Color.SpringGreen;
            this.Welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome.Location = new System.Drawing.Point(328, 140);
            this.Welcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(238, 36);
            this.Welcome.TabIndex = 38;
            this.Welcome.Text = "-- WELCOME --";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem,
            this.openToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.chartsToolStripMenuItem,
            this.chartsToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(886, 28);
            this.menuStrip1.TabIndex = 36;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chartsToolStripMenuItem1
            // 
            this.chartsToolStripMenuItem1.Enabled = false;
            this.chartsToolStripMenuItem1.Name = "chartsToolStripMenuItem1";
            this.chartsToolStripMenuItem1.Size = new System.Drawing.Size(64, 24);
            this.chartsToolStripMenuItem1.Text = "Charts";
            this.chartsToolStripMenuItem1.Click += new System.EventHandler(this.chartsToolStripMenuItem1_Click);
            // 
            // LabelDateAndTime
            // 
            this.LabelDateAndTime.AutoSize = true;
            this.LabelDateAndTime.Location = new System.Drawing.Point(642, 10);
            this.LabelDateAndTime.Name = "LabelDateAndTime";
            this.LabelDateAndTime.Size = new System.Drawing.Size(94, 17);
            this.LabelDateAndTime.TabIndex = 41;
            this.LabelDateAndTime.Text = "DateAndTime";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FeelFree_Recreation_System.Properties.Resources.Recreation_Centre;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(886, 492);
            this.Controls.Add(this.LabelDateAndTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Welcome);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem weeklyReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chartsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dailyReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entryFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chartsToolStripMenuItem1;
        private System.Windows.Forms.Label LabelDateAndTime;
        private System.Windows.Forms.Timer timer1;
    }
}