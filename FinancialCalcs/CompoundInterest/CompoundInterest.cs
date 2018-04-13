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
    public partial class CompoundInterest : Form
    {
        public CompoundInterest()
        {
            InitializeComponent();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            startInvestmentTB.Text = "";
            monthlyInvestmentTB.Text = "";
            numberOfYearsTB.Text = "";
            interestRateTB.Text = "";
            compoundRateCB.Text = "";
        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            string Wow = Formula.InterestCalc(startInvestmentTB.Text, monthlyInvestmentTB.Text,
                                              interestRateTB.Text, numberOfYearsTB.Text,
                                              compoundRateCB.SelectedItem.ToString());

            resultValue.Text = "After " + numberOfYearsTB.Text + " Years, You Will Have Accrued " + Wow.ToString();
            
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mortgageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mortgage mortgage = new Mortgage();
            this.Hide();
            mortgage.Show();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReferencesandHelp refandhelp = new ReferencesandHelp();
            this.Hide();
            refandhelp.Show();
        }
    }
}
