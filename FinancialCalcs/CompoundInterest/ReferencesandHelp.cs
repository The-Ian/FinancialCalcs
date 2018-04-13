using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace CompoundInterest
{
    public partial class ReferencesandHelp : Form
    {
        public ReferencesandHelp()
        {
            InitializeComponent();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.investor.gov/additional-resources/free-financial-planning-tools/compound-interest-calculator");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mortgageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mortgage mortgage = new Mortgage();
            this.Hide();
            mortgage.Show();
        }

        private void compoundInterestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompoundInterest compint = new CompoundInterest();
            this.Hide();
            compint.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.bankrate.com/calculators/mortgages/mortgage-calculator.aspx#testid=10413875559_iq360");
        }
    }
}
