namespace OperaHouse_Assignment5
{
    partial class TicketSales
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
            this.btnReturn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumTickets = new System.Windows.Forms.TextBox();
            this.btnSell = new System.Windows.Forms.Button();
            this.lstTickets = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(230, 135);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 9;
            this.btnReturn.Text = "Return selected";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Number tickets to sell:";
            // 
            // txtNumTickets
            // 
            this.txtNumTickets.Location = new System.Drawing.Point(344, 70);
            this.txtNumTickets.Name = "txtNumTickets";
            this.txtNumTickets.Size = new System.Drawing.Size(46, 20);
            this.txtNumTickets.TabIndex = 7;
            // 
            // btnSell
            // 
            this.btnSell.Location = new System.Drawing.Point(410, 70);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(75, 23);
            this.btnSell.TabIndex = 6;
            this.btnSell.Text = "Sell";
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click_1);
            // 
            // lstTickets
            // 
            this.lstTickets.FormattingEnabled = true;
            this.lstTickets.Location = new System.Drawing.Point(18, 21);
            this.lstTickets.Name = "lstTickets";
            this.lstTickets.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstTickets.Size = new System.Drawing.Size(185, 420);
            this.lstTickets.TabIndex = 5;
            // 
            // TicketSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 463);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumTickets);
            this.Controls.Add(this.btnSell);
            this.Controls.Add(this.lstTickets);
            this.Name = "TicketSales";
            this.Text = "TicketSales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumTickets;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.ListBox lstTickets;
    }
}