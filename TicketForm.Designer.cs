
namespace FeelFree_Recreation_System
{
    partial class TicketForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.ticketView = new System.Windows.Forms.DataGridView();
            this.tktRateBindingSource9 = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.tktRateBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.tktRateBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.tktRateBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tktRateBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tktRateBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.tktRateBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.tktRateBindingSource7 = new System.Windows.Forms.BindingSource(this.components);
            this.visitorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tktRateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tktRateBindingSource8 = new System.Windows.Forms.BindingSource(this.components);
            this.tktIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tktTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rate1hrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rate2hrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rate3hrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rate4hrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rateWholedayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ticketView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tktRateBindingSource9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tktRateBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tktRateBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tktRateBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tktRateBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tktRateBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tktRateBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tktRateBindingSource7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tktRateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tktRateBindingSource8)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Location = new System.Drawing.Point(191, 36);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 37);
            this.button1.TabIndex = 36;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Silver;
            this.btnClose.Location = new System.Drawing.Point(305, 36);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(95, 37);
            this.btnClose.TabIndex = 35;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ticketView
            // 
            this.ticketView.AutoGenerateColumns = false;
            this.ticketView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ticketView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tktIdDataGridViewTextBoxColumn,
            this.tktTypeDataGridViewTextBoxColumn,
            this.rate1hrDataGridViewTextBoxColumn,
            this.rate2hrDataGridViewTextBoxColumn,
            this.rate3hrDataGridViewTextBoxColumn,
            this.rate4hrDataGridViewTextBoxColumn,
            this.rateWholedayDataGridViewTextBoxColumn});
            this.ticketView.DataSource = this.tktRateBindingSource9;
            this.ticketView.Location = new System.Drawing.Point(43, 92);
            this.ticketView.Name = "ticketView";
            this.ticketView.RowHeadersWidth = 51;
            this.ticketView.RowTemplate.Height = 24;
            this.ticketView.Size = new System.Drawing.Size(818, 305);
            this.ticketView.TabIndex = 34;
            // 
            // tktRateBindingSource9
            // 
            this.tktRateBindingSource9.DataSource = typeof(FeelFree_Recreation_System.TktRate);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "Ticket Rate";
            // 
            // tktIdDataGridViewTextBoxColumn
            // 
            this.tktIdDataGridViewTextBoxColumn.DataPropertyName = "TktId";
            this.tktIdDataGridViewTextBoxColumn.HeaderText = "TktId";
            this.tktIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tktIdDataGridViewTextBoxColumn.Name = "tktIdDataGridViewTextBoxColumn";
            this.tktIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // tktTypeDataGridViewTextBoxColumn
            // 
            this.tktTypeDataGridViewTextBoxColumn.DataPropertyName = "TktType";
            this.tktTypeDataGridViewTextBoxColumn.HeaderText = "TktType";
            this.tktTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tktTypeDataGridViewTextBoxColumn.Name = "tktTypeDataGridViewTextBoxColumn";
            this.tktTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // rate1hrDataGridViewTextBoxColumn
            // 
            this.rate1hrDataGridViewTextBoxColumn.DataPropertyName = "Rate1hr";
            this.rate1hrDataGridViewTextBoxColumn.HeaderText = "Rate1hr";
            this.rate1hrDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rate1hrDataGridViewTextBoxColumn.Name = "rate1hrDataGridViewTextBoxColumn";
            this.rate1hrDataGridViewTextBoxColumn.Width = 125;
            // 
            // rate2hrDataGridViewTextBoxColumn
            // 
            this.rate2hrDataGridViewTextBoxColumn.DataPropertyName = "Rate2hr";
            this.rate2hrDataGridViewTextBoxColumn.HeaderText = "Rate2hr";
            this.rate2hrDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rate2hrDataGridViewTextBoxColumn.Name = "rate2hrDataGridViewTextBoxColumn";
            this.rate2hrDataGridViewTextBoxColumn.Width = 125;
            // 
            // rate3hrDataGridViewTextBoxColumn
            // 
            this.rate3hrDataGridViewTextBoxColumn.DataPropertyName = "Rate3hr";
            this.rate3hrDataGridViewTextBoxColumn.HeaderText = "Rate3hr";
            this.rate3hrDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rate3hrDataGridViewTextBoxColumn.Name = "rate3hrDataGridViewTextBoxColumn";
            this.rate3hrDataGridViewTextBoxColumn.Width = 125;
            // 
            // rate4hrDataGridViewTextBoxColumn
            // 
            this.rate4hrDataGridViewTextBoxColumn.DataPropertyName = "Rate4hr";
            this.rate4hrDataGridViewTextBoxColumn.HeaderText = "Rate4hr";
            this.rate4hrDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rate4hrDataGridViewTextBoxColumn.Name = "rate4hrDataGridViewTextBoxColumn";
            this.rate4hrDataGridViewTextBoxColumn.Width = 125;
            // 
            // rateWholedayDataGridViewTextBoxColumn
            // 
            this.rateWholedayDataGridViewTextBoxColumn.DataPropertyName = "RateWholeday";
            this.rateWholedayDataGridViewTextBoxColumn.HeaderText = "RateWholeday";
            this.rateWholedayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rateWholedayDataGridViewTextBoxColumn.Name = "rateWholedayDataGridViewTextBoxColumn";
            this.rateWholedayDataGridViewTextBoxColumn.Width = 125;
            // 
            // TicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ticketView);
            this.Controls.Add(this.label4);
            this.Name = "TicketForm";
            this.Text = "TicketRateListForm";
            this.Load += new System.EventHandler(this.TicketForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ticketView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tktRateBindingSource9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tktRateBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tktRateBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tktRateBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tktRateBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tktRateBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tktRateBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tktRateBindingSource7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tktRateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tktRateBindingSource8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource tktRateBindingSource6;
        private System.Windows.Forms.BindingSource tktRateBindingSource5;
        private System.Windows.Forms.BindingSource tktRateBindingSource1;
        private System.Windows.Forms.BindingSource tktRateBindingSource2;
        private System.Windows.Forms.BindingSource tktRateBindingSource3;
        private System.Windows.Forms.BindingSource tktRateBindingSource4;
        private System.Windows.Forms.BindingSource tktRateBindingSource7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.BindingSource visitorBindingSource;
        private System.Windows.Forms.BindingSource tktRateBindingSource;
        private System.Windows.Forms.DataGridView ticketView;
        private System.Windows.Forms.BindingSource tktRateBindingSource8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource tktRateBindingSource9;
        private System.Windows.Forms.DataGridViewTextBoxColumn tktIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tktTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rate1hrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rate2hrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rate3hrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rate4hrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rateWholedayDataGridViewTextBoxColumn;
    }
}