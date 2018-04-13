namespace CompoundInterest
{
    partial class CompoundInterest
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.calculatorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mortgageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CalculateBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.startInvestmentTB = new System.Windows.Forms.TextBox();
            this.compoundRateCB = new System.Windows.Forms.ComboBox();
            this.monthlyInvestmentTB = new System.Windows.Forms.TextBox();
            this.numberOfYearsTB = new System.Windows.Forms.TextBox();
            this.interestRateTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.resultValue = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculatorsToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(642, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // calculatorsToolStripMenuItem
            // 
            this.calculatorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mortgageToolStripMenuItem});
            this.calculatorsToolStripMenuItem.Name = "calculatorsToolStripMenuItem";
            this.calculatorsToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.calculatorsToolStripMenuItem.Text = "Calculators";
            // 
            // mortgageToolStripMenuItem
            // 
            this.mortgageToolStripMenuItem.Name = "mortgageToolStripMenuItem";
            this.mortgageToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.mortgageToolStripMenuItem.Text = "Mortgage";
            this.mortgageToolStripMenuItem.Click += new System.EventHandler(this.mortgageToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Initial Investment:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(43, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Interest Rate (%) :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Years of Investment:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Monthly Addition:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Ivory;
            this.label5.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(43, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Compoundment:";
            // 
            // CalculateBtn
            // 
            this.CalculateBtn.BackColor = System.Drawing.Color.Goldenrod;
            this.CalculateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CalculateBtn.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateBtn.ForeColor = System.Drawing.Color.Khaki;
            this.CalculateBtn.Location = new System.Drawing.Point(59, 273);
            this.CalculateBtn.Name = "CalculateBtn";
            this.CalculateBtn.Size = new System.Drawing.Size(99, 36);
            this.CalculateBtn.TabIndex = 6;
            this.CalculateBtn.Text = "CALCULATE";
            this.CalculateBtn.UseVisualStyleBackColor = false;
            this.CalculateBtn.Click += new System.EventHandler(this.CalculateBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearBtn.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClearBtn.Location = new System.Drawing.Point(276, 273);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(99, 36);
            this.ClearBtn.TabIndex = 7;
            this.ClearBtn.Text = "CLEAR";
            this.ClearBtn.UseVisualStyleBackColor = false;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // startInvestmentTB
            // 
            this.startInvestmentTB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.startInvestmentTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.startInvestmentTB.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startInvestmentTB.Location = new System.Drawing.Point(248, 89);
            this.startInvestmentTB.Name = "startInvestmentTB";
            this.startInvestmentTB.Size = new System.Drawing.Size(151, 20);
            this.startInvestmentTB.TabIndex = 8;
            this.startInvestmentTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // compoundRateCB
            // 
            this.compoundRateCB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.compoundRateCB.FormattingEnabled = true;
            this.compoundRateCB.Items.AddRange(new object[] {
            "Annually",
            "Semi-Annually",
            "Quarterly",
            "Monthly"});
            this.compoundRateCB.Location = new System.Drawing.Point(248, 221);
            this.compoundRateCB.Name = "compoundRateCB";
            this.compoundRateCB.Size = new System.Drawing.Size(151, 21);
            this.compoundRateCB.TabIndex = 12;
            // 
            // monthlyInvestmentTB
            // 
            this.monthlyInvestmentTB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.monthlyInvestmentTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.monthlyInvestmentTB.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthlyInvestmentTB.Location = new System.Drawing.Point(248, 125);
            this.monthlyInvestmentTB.Name = "monthlyInvestmentTB";
            this.monthlyInvestmentTB.Size = new System.Drawing.Size(151, 20);
            this.monthlyInvestmentTB.TabIndex = 13;
            this.monthlyInvestmentTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numberOfYearsTB
            // 
            this.numberOfYearsTB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.numberOfYearsTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numberOfYearsTB.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfYearsTB.Location = new System.Drawing.Point(248, 158);
            this.numberOfYearsTB.Name = "numberOfYearsTB";
            this.numberOfYearsTB.Size = new System.Drawing.Size(151, 20);
            this.numberOfYearsTB.TabIndex = 14;
            this.numberOfYearsTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // interestRateTB
            // 
            this.interestRateTB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.interestRateTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.interestRateTB.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interestRateTB.Location = new System.Drawing.Point(248, 188);
            this.interestRateTB.Name = "interestRateTB";
            this.interestRateTB.Size = new System.Drawing.Size(151, 20);
            this.interestRateTB.TabIndex = 16;
            this.interestRateTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poor Richard", 24F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(82, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(465, 36);
            this.label7.TabIndex = 19;
            this.label7.Text = "Ian\'s Authentic Interest Calculator";
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.DarkRed;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.Color.PeachPuff;
            this.ExitBtn.Location = new System.Drawing.Point(491, 273);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(99, 36);
            this.ExitBtn.TabIndex = 21;
            this.ExitBtn.Text = "EXIT";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(480, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 18);
            this.label9.TabIndex = 29;
            this.label9.Text = "Future Value:";
            // 
            // resultValue
            // 
            this.resultValue.BackColor = System.Drawing.Color.PaleTurquoise;
            this.resultValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.resultValue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resultValue.Location = new System.Drawing.Point(431, 144);
            this.resultValue.Name = "resultValue";
            this.resultValue.Size = new System.Drawing.Size(201, 56);
            this.resultValue.TabIndex = 28;
            this.resultValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CompoundInterest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(642, 329);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.resultValue);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.interestRateTB);
            this.Controls.Add(this.numberOfYearsTB);
            this.Controls.Add(this.monthlyInvestmentTB);
            this.Controls.Add(this.compoundRateCB);
            this.Controls.Add(this.startInvestmentTB);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.CalculateBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CompoundInterest";
            this.Text = "Compound Interest Calculator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem calculatorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mortgageToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button CalculateBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.TextBox startInvestmentTB;
        private System.Windows.Forms.ComboBox compoundRateCB;
        private System.Windows.Forms.TextBox monthlyInvestmentTB;
        private System.Windows.Forms.TextBox numberOfYearsTB;
        private System.Windows.Forms.TextBox interestRateTB;
        private System.Windows.Forms.Label resultOutput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label resultValue;
    }
}

