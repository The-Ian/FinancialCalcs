using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompoundInterest
{
    public partial class Mortgage : Form
    {
        public Mortgage()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Calling the class and using my tuple for the output values.
           
            var fwoggy = Formula.MortgageCalc(originalPriceTB.Text, downPaymentTB.Text, downPaymentCB.SelectedItem.ToString(),
                                              payoffStartDateTP.Text, loanDurationTB.Text, loanTypeDurationCB.SelectedItem.ToString(),
                                              interestRateTB.Text);
            loanAmtLabel.Text = fwoggy.Item1;
            monthPayOutput.Text = fwoggy.Item2;
            totalIntOutput.Text = fwoggy.Item3;
            payoffDateEndOutput.Text = fwoggy.Item4;
            totalPayWithIntOutput.Text = fwoggy.Item5;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }



        }

        

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            originalPriceTB.Text = "";
            downPaymentTB.Text = "";
            downPaymentCB.Text = "";
            loanAmtLabel.Text = "";
            loanDurationTB.Text = "";
            loanTypeDurationCB.Text = "";
            monthPayOutput.Text = "";
            totalIntOutput.Text = "";
            payoffDateEndOutput.Text = "";
            totalPayWithIntOutput.Text = "";
        }

        private void exitTSM_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void compoundInterestTSM_Click(object sender, EventArgs e)
        {
            
        }

        private void compoundInterestTSM_Click_1(object sender, EventArgs e)
        {
            CompoundInterest compint = new CompoundInterest();
            this.Hide();
            compint.Show();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReferencesandHelp refandhelp = new ReferencesandHelp();
            this.Hide();
            refandhelp.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
