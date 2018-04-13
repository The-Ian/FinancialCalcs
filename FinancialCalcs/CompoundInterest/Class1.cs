using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundInterest
{

    class Formula
    { 
   
        public static string InterestCalc(string Principal, string Additions,
                                          string InterestRate, string YearsofInvestment,
                                          string CompoundmentType)
        {

            // Defining my variables.

            double startVal;
            double monthAdditions;
            double interest;
            double futureVal;
            double AnnualAdd;
            double ratePR;
            int yrsInvestment;
            int compoundType;

            // Parsing text to digits.
            startVal = Double.Parse(Principal);
            interest = Double.Parse(InterestRate) / 100;
            monthAdditions = Double.Parse(Additions);
            yrsInvestment = Int32.Parse(YearsofInvestment);

            // Initializing the two variables.
            compoundType = 0;
            AnnualAdd = 0;


            // Giving the compoundment frequency's a value and converting all of them into months.


            if (CompoundmentType == "Monthly")
            {
                compoundType = 12; AnnualAdd = monthAdditions;
            }
            else if (CompoundmentType == "Quarterly")
            {
                compoundType = 4; AnnualAdd = monthAdditions * 3;
            }
            else if (CompoundmentType == "Semi-Annually")
            {
                compoundType = 2; AnnualAdd = monthAdditions * 6;
            }
            else
            {
                compoundType = 1; AnnualAdd = monthAdditions * 12;
            }

            // Making formulas for the output value.
            double i = interest / compoundType;

            int n = yrsInvestment;
            int c = compoundType;
            double l = (n * c);
            double R = AnnualAdd;
            double y = Math.Pow(1 + i, l);
            double Z = (y - 1);
            double P = startVal;



            ratePR = interest / yrsInvestment;

            futureVal = (P * y) + ((R * Z) / i);

            return futureVal.ToString("C");
          
        }

        public static Tuple  <string, string, string, string, string> MortgageCalc(string StartPrice, string DwnPayment, 
                                          string DwnPayType, string StartDate,
                                          string LoanDuration, string LoanDurationType,
                                           string IntRate)
        {
            // Defining my variables.

            double startPrice;
            DateTime startDate = DateTime.Today;
            double downPay;
            double interest;
            double monthpay;
            double totalInt;
            double totalwithInt;
            double loanAmnt;
            double percentage;
            DateTime payoffEndDate;
            int loanDur;

            

        // Parsing text to digits
        startPrice = Double.Parse(StartPrice);
            interest = Double.Parse(IntRate) / 100;
            downPay = Double.Parse(DwnPayment);
            loanDur = int.Parse(LoanDuration);
            startDate = DateTime.Parse(StartDate);
            loanAmnt = startPrice - downPay;
            percentage = Double.Parse(DwnPayment) / 100;




        if (DwnPayType == "Money")
        {
            downPay = Double.Parse(DwnPayment);
        }
        else 
        {
              downPay = percentage;  
        }

        // Translating my loan duration into months if years is selected.
        if (LoanDurationType == "Years")
        {
            loanDur = Int32.Parse(LoanDuration) * 12;
        }
        else
        {
             loanDur = Int32.Parse(LoanDuration);
        }


            // Making formulas for the output values.
            double R = interest / 12;
            
            monthpay = loanAmnt * ((R * (Math.Pow(1 + R, loanDur)))/ (Math.Pow(1 + R, loanDur) - 1));
            totalwithInt = monthpay * loanDur;
            totalInt = (monthpay * loanDur) - loanAmnt;
            payoffEndDate = startDate.AddMonths(loanDur);

            if (percentage > 100 || startPrice < downPay)
            {
                throw new System.InvalidOperationException("Can't pay more than the object price.");
            }



            // calling the tuple so I can return all of my output values.
            var frog = Tuple.Create(loanAmnt.ToString("c"), monthpay.ToString("c"), totalInt.ToString("c"), payoffEndDate.ToString("yyyy/dd/MM"), totalwithInt.ToString("c"));

            return frog;
        }
     }
}
