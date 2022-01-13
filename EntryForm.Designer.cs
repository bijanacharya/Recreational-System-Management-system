
namespace FeelFree_Recreation_System
{
    partial class EntryForm
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
            this.inTimePicker = new System.Windows.Forms.DateTimePicker();
            this.VId = new System.Windows.Forms.NumericUpDown();
            this.btnClose = new System.Windows.Forms.Button();
            this.visitorView = new System.Windows.Forms.DataGridView();
            this.VType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.VCount = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inTime = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.visitorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.VId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitorView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // inTimePicker
            // 
            this.inTimePicker.Location = new System.Drawing.Point(483, 40);
            this.inTimePicker.Name = "inTimePicker";
            this.inTimePicker.Size = new System.Drawing.Size(232, 22);
            this.inTimePicker.TabIndex = 25;
            // 
            // VId
            // 
            this.VId.Location = new System.Drawing.Point(170, 109);
            this.VId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.VId.Name = "VId";
            this.VId.Size = new System.Drawing.Size(121, 22);
            this.VId.TabIndex = 24;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Silver;
            this.btnClose.Location = new System.Drawing.Point(147, 319);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(95, 37);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // visitorView
            // 
            this.visitorView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.visitorView.Location = new System.Drawing.Point(326, 80);
            this.visitorView.Margin = new System.Windows.Forms.Padding(4);
            this.visitorView.Name = "visitorView";
            this.visitorView.RowHeadersWidth = 51;
            this.visitorView.Size = new System.Drawing.Size(619, 326);
            this.visitorView.TabIndex = 23;
            // 
            // VType
            // 
            this.VType.FormattingEnabled = true;
            this.VType.Items.AddRange(new object[] {
            "Child",
            "Adult",
            "Group"});
            this.VType.Location = new System.Drawing.Point(170, 155);
            this.VType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.VType.Name = "VType";
            this.VType.Size = new System.Drawing.Size(121, 24);
            this.VType.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(99, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Add Visitor Details";
            // 
            // VCount
            // 
            this.VCount.Location = new System.Drawing.Point(170, 200);
            this.VCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.VCount.Name = "VCount";
            this.VCount.Size = new System.Drawing.Size(121, 22);
            this.VCount.TabIndex = 19;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Silver;
            this.btnAdd.Location = new System.Drawing.Point(147, 247);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 37);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(88, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Count";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Id";
            // 
            // visitorBindingSource
            // 
            this.visitorBindingSource.DataSource = typeof(FeelFree_Recreation_System.Visitor);
            // 
            // EntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FeelFree_Recreation_System.Properties.Resources.Recreation_Centre1;
            this.ClientSize = new System.Drawing.Size(1032, 443);
            this.Controls.Add(this.inTimePicker);
            this.Controls.Add(this.VId);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.visitorView);
            this.Controls.Add(this.VType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.VCount);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EntryForm";
            this.Text = "EntryForm";
            this.Load += new System.EventHandler(this.EntryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitorView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker inTimePicker;
        private System.Windows.Forms.NumericUpDown VId;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView visitorView;
        private System.Windows.Forms.ComboBox VType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown VCount;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer inTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource visitorBindingSource;
    }
}