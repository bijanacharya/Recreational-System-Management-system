
namespace FeelFree_Recreation_System
{
    partial class LoginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.weeklyReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dailyReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entryFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chartsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ticketRateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUser = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnLogin = new System.Windows.Forms.Button();
            this.Welcome = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.labelpassword = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.LabelDateAndTime = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(687, 48);
            this.label1.TabIndex = 33;
            this.label1.Text = "FEELFREE RECREATION SYSTEM";
            // 
            // weeklyReportsToolStripMenuItem
            // 
            this.weeklyReportsToolStripMenuItem.Name = "weeklyReportsToolStripMenuItem";
            this.weeklyReportsToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.weeklyReportsToolStripMenuItem.Text = "Weekly Reports";
            // 
            // dailyReportsToolStripMenuItem
            // 
            this.dailyReportsToolStripMenuItem.Name = "dailyReportsToolStripMenuItem";
            this.dailyReportsToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.dailyReportsToolStripMenuItem.Text = "Daily Reports";
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
            // exitFormToolStripMenuItem
            // 
            this.exitFormToolStripMenuItem.Name = "exitFormToolStripMenuItem";
            this.exitFormToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.exitFormToolStripMenuItem.Text = "Exit Form";
            // 
            // entryFormToolStripMenuItem
            // 
            this.entryFormToolStripMenuItem.Name = "entryFormToolStripMenuItem";
            this.entryFormToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.entryFormToolStripMenuItem.Text = "Entry Form";
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
            // 
            // chartsToolStripMenuItem
            // 
            this.chartsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ticketRateToolStripMenuItem});
            this.chartsToolStripMenuItem.Name = "chartsToolStripMenuItem";
            this.chartsToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.chartsToolStripMenuItem.Text = "Ticket";
            // 
            // ticketRateToolStripMenuItem
            // 
            this.ticketRateToolStripMenuItem.Name = "ticketRateToolStripMenuItem";
            this.ticketRateToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.ticketRateToolStripMenuItem.Text = "Ticket Rate";
            this.ticketRateToolStripMenuItem.Click += new System.EventHandler(this.ticketRateToolStripMenuItem_Click);
            // 
            // btnUser
            // 
            this.btnUser.Location = new System.Drawing.Point(468, 385);
            this.btnUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(119, 38);
            this.btnUser.TabIndex = 30;
            this.btnUser.Text = "Skip (User)";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(282, 385);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(121, 38);
            this.btnLogin.TabIndex = 29;
            this.btnLogin.Text = "Login (Admin)";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.BackColor = System.Drawing.Color.SpringGreen;
            this.Welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome.Location = new System.Drawing.Point(300, 106);
            this.Welcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(238, 36);
            this.Welcome.TabIndex = 27;
            this.Welcome.Text = "-- WELCOME --";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(419, 301);
            this.password.Margin = new System.Windows.Forms.Padding(4);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(132, 22);
            this.password.TabIndex = 25;
            // 
            // labelpassword
            // 
            this.labelpassword.AutoSize = true;
            this.labelpassword.BackColor = System.Drawing.Color.Yellow;
            this.labelpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpassword.Location = new System.Drawing.Point(294, 301);
            this.labelpassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelpassword.Name = "labelpassword";
            this.labelpassword.Size = new System.Drawing.Size(98, 25);
            this.labelpassword.TabIndex = 26;
            this.labelpassword.Text = "Password";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(419, 256);
            this.username.Margin = new System.Windows.Forms.Padding(4);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(132, 22);
            this.username.TabIndex = 23;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.BackColor = System.Drawing.Color.Yellow;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(291, 257);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(102, 25);
            this.usernameLabel.TabIndex = 24;
            this.usernameLabel.Text = "Username";
            // 
            // LabelDateAndTime
            // 
            this.LabelDateAndTime.AutoSize = true;
            this.LabelDateAndTime.Location = new System.Drawing.Point(507, 9);
            this.LabelDateAndTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelDateAndTime.Name = "LabelDateAndTime";
            this.LabelDateAndTime.Size = new System.Drawing.Size(44, 17);
            this.LabelDateAndTime.TabIndex = 28;
            this.LabelDateAndTime.Text = "Timer";
            this.LabelDateAndTime.Click += new System.EventHandler(this.LabelDataTime_Click);
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
            this.chartToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(821, 28);
            this.menuStrip1.TabIndex = 31;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chartToolStripMenuItem
            // 
            this.chartToolStripMenuItem.Name = "chartToolStripMenuItem";
            this.chartToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.chartToolStripMenuItem.Text = "Chart";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FeelFree_Recreation_System.Properties.Resources.Recreation_Centre;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(821, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.Welcome);
            this.Controls.Add(this.password);
            this.Controls.Add(this.labelpassword);
            this.Controls.Add(this.username);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.LabelDateAndTime);
            this.Controls.Add(this.menuStrip1);
            this.Name = "LoginForm";
            this.Text = "FeelFree Recreation System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem weeklyReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dailyReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entryFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chartsToolStripMenuItem;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label labelpassword;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label LabelDateAndTime;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ticketRateToolStripMenuItem;
    }
}

