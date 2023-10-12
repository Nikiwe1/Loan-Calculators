using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loan_Calculators
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMortgage_Click(object sender, EventArgs e)
        {
            double loanAmount = 0.0;
            double downpayment = 0.0;
            double interestrate = 0.0;
            double monthlypayment = 0.0;
            int terms = 0;
            if
            (!string.IsNullOrEmpty(txtLoanAmount.Text)) 
              loanAmount  = Convert.ToDouble(txtLoanAmount.Text);
            if
                (!String.IsNullOrEmpty(txtDownPayment.Text))
                downpayment = Convert.ToDouble(txtDownPayment.Text);
            if
                (!string.IsNullOrEmpty(txtInterestRate.Text))
                interestrate = Convert.ToDouble(txtInterestRate.Text);
            if 
                (!string.IsNullOrEmpty(txtTermsInYears.Text))
                    terms = Convert.ToInt32( txtTermsInYears.Text);

            int termsinMonths = terms * 12;
            monthlypayment = (loanAmount - downpayment) * (Math.Pow((1 + interestrate / 12),
                termsinMonths) * interestrate) /(12 * (Math.Pow((1 + interestrate / 12),
                termsinMonths) - 1));
            monthlypayment = Math.Round(monthlypayment, 2);

            lblMonthlyPayment.Text =
                String.Format("Monthly Payment: R {0}",monthlypayment.ToString());


            {
                
            }


        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            double loanamount = 0.0;
            double downpayment = 0.0;
            double interestrate = 0.0;
            double monthlypayment = 0.0;
            int terms = 0;

            if
                (!String.IsNullOrEmpty(txtLoanAmount.Text))
                loanamount = Convert.ToDouble(txtLoanAmount.Text);
            if
                (!String.IsNullOrEmpty (txtDownPayment.Text))
                downpayment = Convert.ToDouble(txtDownPayment.Text);
            if
                (!String.IsNullOrEmpty(txtInterestRate.Text))
                interestrate = Convert.ToDouble(txtInterestRate.Text);
            if
                (!String.IsNullOrEmpty(txtTermsInYears.Text))
                terms = Convert.ToInt32(txtTermsInYears.Text);

            int termsinmonths = terms * 12;
            interestrate /= 12;
            monthlypayment = (interestrate * loanamount) / (1 - Math.Pow(1 + interestrate,
                termsinmonths * -1));
            monthlypayment = Math.Round(monthlypayment, 2);

            lblMonthlyPayment.Text = String.Format("Monthly Payment: R {0}",
                monthlypayment.ToString());
        }
    }
}
