namespace CompoundInterest
{
    partial class Mortgage
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
            this.totalPayWithIntOutput = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.payoffDateEndOutput = new System.Windows.Forms.Label();
            this.totalIntOutput = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.monthPayOutput = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.loanAmtLabel = new System.Windows.Forms.Label();
            this.loanTypeDurationCB = new System.Windows.Forms.ComboBox();
            this.downPaymentCB = new System.Windows.Forms.ComboBox();
            this.loanDurationTB = new System.Windows.Forms.TextBox();
            this.interestRateTB = new System.Windows.Forms.TextBox();
            this.originalPriceTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.exitTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compoundInterestTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatorsTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.downPaymentTB = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.payoffStartDateTP = new System.Windows.Forms.DateTimePicker();
            this.label19 = new System.Windows.Forms.Label();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // totalPayWithIntOutput
            // 
            this.totalPayWithIntOutput.BackColor = System.Drawing.Color.PaleTurquoise;
            this.totalPayWithIntOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalPayWithIntOutput.Location = new System.Drawing.Point(95, 576);
            this.totalPayWithIntOutput.Name = "totalPayWithIntOutput";
            this.totalPayWithIntOutput.Size = new System.Drawing.Size(200, 55);
            this.totalPayWithIntOutput.TabIndex = 55;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(62, 543);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(263, 24);
            this.label17.TabIndex = 31;
            this.label17.Text = "Total Payment With Interest";
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(284, 487);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(99, 16);
            this.label16.TabIndex = 32;
            this.label16.Text = "Pay-Off End Date:";
            // 
            // payoffDateEndOutput
            // 
            this.payoffDateEndOutput.BackColor = System.Drawing.Color.PaleTurquoise;
            this.payoffDateEndOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.payoffDateEndOutput.Location = new System.Drawing.Point(274, 503);
            this.payoffDateEndOutput.Name = "payoffDateEndOutput";
            this.payoffDateEndOutput.Size = new System.Drawing.Size(100, 23);
            this.payoffDateEndOutput.TabIndex = 54;
            // 
            // totalIntOutput
            // 
            this.totalIntOutput.BackColor = System.Drawing.Color.PaleTurquoise;
            this.totalIntOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalIntOutput.Location = new System.Drawing.Point(142, 503);
            this.totalIntOutput.Name = "totalIntOutput";
            this.totalIntOutput.Size = new System.Drawing.Size(100, 23);
            this.totalIntOutput.TabIndex = 53;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(156, 487);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 16);
            this.label13.TabIndex = 33;
            this.label13.Text = "Total Interest:";
            // 
            // monthPayOutput
            // 
            this.monthPayOutput.BackColor = System.Drawing.Color.PaleTurquoise;
            this.monthPayOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.monthPayOutput.Location = new System.Drawing.Point(8, 503);
            this.monthPayOutput.Name = "monthPayOutput";
            this.monthPayOutput.Size = new System.Drawing.Size(100, 23);
            this.monthPayOutput.TabIndex = 52;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(5, 487);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 16);
            this.label11.TabIndex = 34;
            this.label11.Text = "Monthly Payments";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(142, 439);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 29);
            this.label10.TabIndex = 51;
            this.label10.Text = "Results";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label9.Location = new System.Drawing.Point(203, 315);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 13);
            this.label9.TabIndex = 50;
            this.label9.Text = "Loan Duration Type:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label8.Location = new System.Drawing.Point(203, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 13);
            this.label8.TabIndex = 49;
            this.label8.Text = "Down Payment Type:";
            // 
            // loanAmtLabel
            // 
            this.loanAmtLabel.BackColor = System.Drawing.Color.PaleTurquoise;
            this.loanAmtLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.loanAmtLabel.Location = new System.Drawing.Point(70, 259);
            this.loanAmtLabel.Name = "loanAmtLabel";
            this.loanAmtLabel.Size = new System.Drawing.Size(100, 23);
            this.loanAmtLabel.TabIndex = 48;
            // 
            // loanTypeDurationCB
            // 
            this.loanTypeDurationCB.FormattingEnabled = true;
            this.loanTypeDurationCB.Items.AddRange(new object[] {
            "Years",
            "Months"});
            this.loanTypeDurationCB.Location = new System.Drawing.Point(206, 331);
            this.loanTypeDurationCB.Name = "loanTypeDurationCB";
            this.loanTypeDurationCB.Size = new System.Drawing.Size(121, 21);
            this.loanTypeDurationCB.TabIndex = 47;
            // 
            // downPaymentCB
            // 
            this.downPaymentCB.FormattingEnabled = true;
            this.downPaymentCB.Items.AddRange(new object[] {
            "Percent",
            "Money"});
            this.downPaymentCB.Location = new System.Drawing.Point(206, 187);
            this.downPaymentCB.Name = "downPaymentCB";
            this.downPaymentCB.Size = new System.Drawing.Size(121, 21);
            this.downPaymentCB.TabIndex = 46;
            // 
            // loanDurationTB
            // 
            this.loanDurationTB.Location = new System.Drawing.Point(70, 332);
            this.loanDurationTB.Name = "loanDurationTB";
            this.loanDurationTB.Size = new System.Drawing.Size(100, 20);
            this.loanDurationTB.TabIndex = 45;
            // 
            // interestRateTB
            // 
            this.interestRateTB.Location = new System.Drawing.Point(70, 399);
            this.interestRateTB.Name = "interestRateTB";
            this.interestRateTB.Size = new System.Drawing.Size(100, 20);
            this.interestRateTB.TabIndex = 44;
            // 
            // originalPriceTB
            // 
            this.originalPriceTB.Location = new System.Drawing.Point(70, 126);
            this.originalPriceTB.Name = "originalPriceTB";
            this.originalPriceTB.Size = new System.Drawing.Size(257, 20);
            this.originalPriceTB.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label7.Location = new System.Drawing.Point(67, 383);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "Interest Rate:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.Location = new System.Drawing.Point(67, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Down Payment:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(67, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Amount Loaned:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(67, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Loan Duration:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(67, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Original Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poor Richard", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(144, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 16);
            this.label2.TabIndex = 36;
            this.label2.Text = "Ian\'s Handy Mortgage Calculator";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 33);
            this.label1.TabIndex = 35;
            this.label1.Text = "What\'s Your Mortgage?";
            // 
            // exitTSM
            // 
            this.exitTSM.Name = "exitTSM";
            this.exitTSM.Size = new System.Drawing.Size(37, 20);
            this.exitTSM.Text = "E&xit";
            this.exitTSM.Click += new System.EventHandler(this.exitTSM_Click_1);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // compoundInterestTSM
            // 
            this.compoundInterestTSM.Name = "compoundInterestTSM";
            this.compoundInterestTSM.Size = new System.Drawing.Size(177, 22);
            this.compoundInterestTSM.Text = "Compound Interest";
            this.compoundInterestTSM.Click += new System.EventHandler(this.compoundInterestTSM_Click_1);
            // 
            // calculatorsTSM
            // 
            this.calculatorsTSM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compoundInterestTSM});
            this.calculatorsTSM.Name = "calculatorsTSM";
            this.calculatorsTSM.Size = new System.Drawing.Size(78, 20);
            this.calculatorsTSM.Text = "Calculators";
            // 
            // downPaymentTB
            // 
            this.downPaymentTB.Location = new System.Drawing.Point(70, 188);
            this.downPaymentTB.Name = "downPaymentTB";
            this.downPaymentTB.Size = new System.Drawing.Size(100, 20);
            this.downPaymentTB.TabIndex = 43;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculatorsTSM,
            this.helpToolStripMenuItem,
            this.exitTSM});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(387, 24);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // payoffStartDateTP
            // 
            this.payoffStartDateTP.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.payoffStartDateTP.Location = new System.Drawing.Point(178, 259);
            this.payoffStartDateTP.Name = "payoffStartDateTP";
            this.payoffStartDateTP.Size = new System.Drawing.Size(180, 20);
            this.payoffStartDateTP.TabIndex = 56;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(216, 243);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(96, 13);
            this.label19.TabIndex = 57;
            this.label19.Text = "Pay-Off Start Date:";
            // 
            // calculateBtn
            // 
            this.calculateBtn.BackColor = System.Drawing.Color.SandyBrown;
            this.calculateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateBtn.ForeColor = System.Drawing.Color.SaddleBrown;
            this.calculateBtn.Location = new System.Drawing.Point(60, 650);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(75, 36);
            this.calculateBtn.TabIndex = 58;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = false;
            this.calculateBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Crimson;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.ForeColor = System.Drawing.Color.Salmon;
            this.exitBtn.Location = new System.Drawing.Point(250, 650);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 36);
            this.exitBtn.TabIndex = 59;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.AliceBlue;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.clearBtn.Location = new System.Drawing.Point(155, 650);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 36);
            this.clearBtn.TabIndex = 60;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // Mortgage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(387, 697);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.payoffStartDateTP);
            this.Controls.Add(this.totalPayWithIntOutput);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.payoffDateEndOutput);
            this.Controls.Add(this.totalIntOutput);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.monthPayOutput);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.loanAmtLabel);
            this.Controls.Add(this.loanTypeDurationCB);
            this.Controls.Add(this.downPaymentCB);
            this.Controls.Add(this.loanDurationTB);
            this.Controls.Add(this.interestRateTB);
            this.Controls.Add(this.originalPriceTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.downPaymentTB);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Mortgage";
            this.Text = "Mortgage Calculator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label totalPayWithIntOutput;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label payoffDateEndOutput;
        private System.Windows.Forms.Label totalIntOutput;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label monthPayOutput;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label loanAmtLabel;
        private System.Windows.Forms.ComboBox loanTypeDurationCB;
        private System.Windows.Forms.ComboBox downPaymentCB;
        private System.Windows.Forms.TextBox loanDurationTB;
        private System.Windows.Forms.TextBox interestRateTB;
        private System.Windows.Forms.TextBox originalPriceTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem exitTSM;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compoundInterestTSM;
        private System.Windows.Forms.ToolStripMenuItem calculatorsTSM;
        private System.Windows.Forms.TextBox downPaymentTB;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DateTimePicker payoffStartDateTP;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button clearBtn;
    }
}