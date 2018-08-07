using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    class Taxpayer
    {
        private double socialSecNumber = 0;
        private double yearIncome; 

        private double taxOwed;

        public Taxpayer(double socialSecNumber, double yearIncome, double taxOwed)
        {
            this.taxOwed = calcTax(yearIncome);
            this.yearIncome = yearIncome;
            this.socialSecNumber = socialSecNumber;

        }

        private double calcTax(double yearIncome)
        {
            if (yearIncome < 30000)
            {
                taxOwed = yearIncome * 0.15;
                return taxOwed;
            }
            else
            {
                taxOwed = yearIncome * 0.28;
                return taxOwed;
            }
        }


        public double SocialSec
        {
            get
            {
                return socialSecNumber;
            }

            set
            {
                socialSecNumber = value;
            }

        }

        public double Income
        {
            get
            {
                return yearIncome;
            }

            set
            {
                yearIncome = value;
            }
        }

        public double OwedTax
        {
            get
            {
                return taxOwed;
            }
        }


    }
}

