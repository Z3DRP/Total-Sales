
namespace TotalSales
{
    partial class Sales
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
            this.salesList = new System.Windows.Forms.ListBox();
            this.getSalesBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.hiLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.monthlySales = new System.Windows.Forms.GroupBox();
            this.selectFileBtn = new System.Windows.Forms.Button();
            this.summary = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.avgLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.totLabel = new System.Windows.Forms.Label();
            this.loLabel = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.monthlySales.SuspendLayout();
            this.summary.SuspendLayout();
            this.SuspendLayout();
            // 
            // salesList
            // 
            this.salesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesList.FormattingEnabled = true;
            this.salesList.ItemHeight = 18;
            this.salesList.Location = new System.Drawing.Point(58, 30);
            this.salesList.Name = "salesList";
            this.salesList.Size = new System.Drawing.Size(198, 166);
            this.salesList.TabIndex = 0;
            // 
            // getSalesBtn
            // 
            this.getSalesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getSalesBtn.Location = new System.Drawing.Point(58, 253);
            this.getSalesBtn.Name = "getSalesBtn";
            this.getSalesBtn.Size = new System.Drawing.Size(198, 29);
            this.getSalesBtn.TabIndex = 1;
            this.getSalesBtn.Text = "Get Sales";
            this.getSalesBtn.UseVisualStyleBackColor = true;
            this.getSalesBtn.Click += new System.EventHandler(this.getSalesBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(58, 288);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(198, 29);
            this.exitBtn.TabIndex = 2;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // hiLabel
            // 
            this.hiLabel.BackColor = System.Drawing.SystemColors.Window;
            this.hiLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hiLabel.Location = new System.Drawing.Point(60, 50);
            this.hiLabel.Name = "hiLabel";
            this.hiLabel.Size = new System.Drawing.Size(198, 37);
            this.hiLabel.TabIndex = 1;
            this.hiLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total Sales";
            // 
            // monthlySales
            // 
            this.monthlySales.BackColor = System.Drawing.SystemColors.ControlDark;
            this.monthlySales.Controls.Add(this.selectFileBtn);
            this.monthlySales.Controls.Add(this.salesList);
            this.monthlySales.Controls.Add(this.getSalesBtn);
            this.monthlySales.Controls.Add(this.exitBtn);
            this.monthlySales.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthlySales.Location = new System.Drawing.Point(37, 52);
            this.monthlySales.Name = "monthlySales";
            this.monthlySales.Size = new System.Drawing.Size(314, 323);
            this.monthlySales.TabIndex = 0;
            this.monthlySales.TabStop = false;
            this.monthlySales.Text = "Monthly Sales";
            // 
            // selectFileBtn
            // 
            this.selectFileBtn.Location = new System.Drawing.Point(58, 218);
            this.selectFileBtn.Name = "selectFileBtn";
            this.selectFileBtn.Size = new System.Drawing.Size(198, 29);
            this.selectFileBtn.TabIndex = 3;
            this.selectFileBtn.Text = "Select File";
            this.selectFileBtn.UseVisualStyleBackColor = true;
            this.selectFileBtn.Click += new System.EventHandler(this.selectFileBtn_Click);
            // 
            // summary
            // 
            this.summary.BackColor = System.Drawing.SystemColors.ControlDark;
            this.summary.Controls.Add(this.label8);
            this.summary.Controls.Add(this.avgLabel);
            this.summary.Controls.Add(this.label6);
            this.summary.Controls.Add(this.label5);
            this.summary.Controls.Add(this.totLabel);
            this.summary.Controls.Add(this.loLabel);
            this.summary.Controls.Add(this.hiLabel);
            this.summary.Controls.Add(this.label1);
            this.summary.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summary.Location = new System.Drawing.Point(377, 52);
            this.summary.Name = "summary";
            this.summary.Size = new System.Drawing.Size(314, 323);
            this.summary.TabIndex = 1;
            this.summary.TabStop = false;
            this.summary.Text = "Summary";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(114, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 18);
            this.label8.TabIndex = 2;
            this.label8.Text = "Lowest Sale";
            // 
            // avgLabel
            // 
            this.avgLabel.BackColor = System.Drawing.SystemColors.Window;
            this.avgLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.avgLabel.Location = new System.Drawing.Point(60, 255);
            this.avgLabel.Name = "avgLabel";
            this.avgLabel.Size = new System.Drawing.Size(198, 37);
            this.avgLabel.TabIndex = 7;
            this.avgLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(114, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Highest Sale";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(124, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Average";
            // 
            // totLabel
            // 
            this.totLabel.BackColor = System.Drawing.SystemColors.Window;
            this.totLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totLabel.Location = new System.Drawing.Point(60, 184);
            this.totLabel.Name = "totLabel";
            this.totLabel.Size = new System.Drawing.Size(198, 37);
            this.totLabel.TabIndex = 5;
            this.totLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loLabel
            // 
            this.loLabel.BackColor = System.Drawing.SystemColors.Window;
            this.loLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loLabel.Location = new System.Drawing.Point(60, 117);
            this.loLabel.Name = "loLabel";
            this.loLabel.Size = new System.Drawing.Size(198, 37);
            this.loLabel.TabIndex = 3;
            this.loLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // Sales
            // 
            this.AcceptButton = this.getSalesBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 427);
            this.Controls.Add(this.summary);
            this.Controls.Add(this.monthlySales);
            this.HelpButton = true;
            this.Name = "Sales";
            this.Text = "Sales";
            this.TopMost = true;
            this.monthlySales.ResumeLayout(false);
            this.summary.ResumeLayout(false);
            this.summary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox salesList;
        private System.Windows.Forms.Button getSalesBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label hiLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox monthlySales;
        private System.Windows.Forms.GroupBox summary;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label avgLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label totLabel;
        private System.Windows.Forms.Label loLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button selectFileBtn;
    }
}

