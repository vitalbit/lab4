using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPlab4
{
    /// <summary>
    /// Class SavingAccount
    /// </summary>
    class SavingAccount : Account
    {
        /// <summary>
        /// interest rate
        /// </summary>
        protected double interestRate;
        /// <summary>
        /// Constructor without parameters
        /// </summary>
        public SavingAccount() : base()
        {
            interestRate = 0;
        }
        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="startBalance">start balance</param>
        /// <param name="interestRate">interest rate</param>
        public SavingAccount(double startBalance, double interestRate)
            : base(startBalance)
        {
            this.interestRate = interestRate;
        }
        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="startBalance">start balance</param>
        public SavingAccount(double startBalance)
            : base(startBalance)
        {
            interestRate = 0;
        }
        /// <summary>
        /// take funds accordingly with interest rate
        /// </summary>
        /// <param name="amount">amount to take</param>
        /// <returns>true if tak proceed, else false</returns>
        public override bool takeFunds(double amount)
        {
            if (amount <= funds)
            {
                balance += amount + (amount * interestRate);
                funds -= amount;
                return true;
            }
            else return false;
        }
    }
}
