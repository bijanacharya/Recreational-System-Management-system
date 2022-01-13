
namespace FeelFree_Recreation_System
{
    partial class ExitForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExitForm));
            this.btnExit = new System.Windows.Forms.Button();
            this.price = new System.Windows.Forms.TextBox();
            this.exitDuration = new System.Windows.Forms.TextBox();
            this.exitTime = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.entryTime = new System.Windows.Forms.TextBox();
            this.exitCount = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.exitType = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSearchId = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ExitId = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.exitCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitId)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Silver;
            this.btnExit.Location = new System.Drawing.Point(332, 149);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(180, 60);
            this.btnExit.TabIndex = 53;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(151, 308);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(135, 22);
            this.price.TabIndex = 52;
            // 
            // exitDuration
            // 
            this.exitDuration.Location = new System.Drawing.Point(151, 268);
            this.exitDuration.Name = "exitDuration";
            this.exitDuration.Size = new System.Drawing.Size(135, 22);
            this.exitDuration.TabIndex = 51;
            // 
            // exitTime
            // 
            this.exitTime.Location = new System.Drawing.Point(151, 228);
            this.exitTime.Name = "exitTime";
            this.exitTime.Size = new System.Drawing.Size(135, 22);
            this.exitTime.TabIndex = 50;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(20, 268);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 20);
            this.label11.TabIndex = 49;
            this.label11.Text = "Duration";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(20, 228);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 20);
            this.label10.TabIndex = 48;
            this.label10.Text = "Exit Time";
            // 
            // entryTime
            // 
            this.entryTime.Location = new System.Drawing.Point(151, 190);
            this.entryTime.Name = "entryTime";
            this.entryTime.Size = new System.Drawing.Size(135, 22);
            this.entryTime.TabIndex = 47;
            // 
            // exitCount
            // 
            this.exitCount.Location = new System.Drawing.Point(151, 147);
            this.exitCount.Name = "exitCount";
            this.exitCount.Size = new System.Drawing.Size(135, 22);
            this.exitCount.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 45;
            this.label3.Text = "Price";
            // 
            // exitType
            // 
            this.exitType.Location = new System.Drawing.Point(151, 109);
            this.exitType.Name = "exitType";
            this.exitType.Size = new System.Drawing.Size(135, 22);
            this.exitType.TabIndex = 44;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.Location = new System.Drawing.Point(332, 242);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 72);
            this.button2.TabIndex = 43;
            this.button2.Text = "Generate Report";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSearchId
            // 
            this.btnSearchId.BackColor = System.Drawing.Color.Silver;
            this.btnSearchId.Location = new System.Drawing.Point(332, 73);
            this.btnSearchId.Name = "btnSearchId";
            this.btnSearchId.Size = new System.Drawing.Size(180, 58);
            this.btnSearchId.TabIndex = 42;
            this.btnSearchId.Text = "Search";
            this.btnSearchId.UseVisualStyleBackColor = false;
            this.btnSearchId.Click += new System.EventHandler(this.btnSearchId_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(47, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 20);
            this.label7.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 20);
            this.label6.TabIndex = 40;
            this.label6.Text = "Entry Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 39;
            this.label5.Text = "Count";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "Type";
            // 
            // ExitId
            // 
            this.ExitId.Location = new System.Drawing.Point(151, 73);
            this.ExitId.Name = "ExitId";
            this.ExitId.Size = new System.Drawing.Size(135, 22);
            this.ExitId.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "Add Visitors Detail";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Silver;
            this.btnClose.Location = new System.Drawing.Point(106, 363);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(116, 37);
            this.btnClose.TabIndex = 34;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Recreation Centre.jpg");
            // 
            // ExitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FeelFree_Recreation_System.Properties.Resources.Recreation_Centre1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.price);
            this.Controls.Add(this.exitDuration);
            this.Controls.Add(this.exitTime);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.entryTime);
            this.Controls.Add(this.exitCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.exitType);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSearchId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ExitId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnClose);
            this.Name = "ExitForm";
            this.Text = "ExitForm";
            this.Load += new System.EventHandler(this.ExitForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.exitCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox exitDuration;
        private System.Windows.Forms.TextBox exitTime;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox entryTime;
        private System.Windows.Forms.NumericUpDown exitCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox exitType;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSearchId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown ExitId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ImageList imageList1;
    }
}