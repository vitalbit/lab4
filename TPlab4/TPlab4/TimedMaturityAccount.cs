using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPlab4
{
    /// <summary>
    /// Class TimedMaturityAccount
    /// </summary>
    class TimedMaturityAccount : SavingAccount
    {
        /// <summary>
        /// date of pay
        /// </summary>
        protected DateTime paidDate;
        /// <summary>
        /// penalty percent
        /// </summary>
        protected double penaltyPercent;
        /// <summary>
        /// Constructor without parameters
        /// </summary>
        public TimedMaturityAccount()
            : base()
        {
            penaltyPercent = 0;
            paidDate = new DateTime(2011, 01, 01);
        }
        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="startBalance">start balance</param>
        public TimedMaturityAccount(double startBalance)
            : base(startBalance)
        {
            penaltyPercent = 0;
            paidDate = new DateTime(2011, 01, 01);
        }
        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="startBalance">start balance</param>
        /// <param name="interestRate">interest rate</param>
        /// <param name="paidDate">date of pay</param>
        /// <param name="penaltyPercent">penalty percent</param>
        public TimedMaturityAccount(double startBalance, double interestRate, DateTime paidDate, double penaltyPercent)
            : base(startBalance, interestRate)
        {
            this.paidDate = paidDate;
            this.penaltyPercent = penaltyPercent;
        }
        /// <summary>
        /// change date of pay
        /// </summary>
        /// <param name="newDate">new date of pay</param>
        /// <returns>true if date has changed, else false</returns>
        public bool changeDate(DateTime newDate)
        {
            if (DateTime.Now >= paidDate)
            {
                paidDate = newDate;
                return true;
            }
            else return false;
        }
        /// <summary>
        /// take money
        /// </summary>
        /// <param name="amount">amount of money</param>
        /// <returns>amount of money accordingly with date</returns>
        public override double takeMoney(double amount)
        {
            if (amount <= balance)
            {
                if (DateTime.Now>=paidDate) return base.takeMoney(amount);
                else
                {
                    balance -= amount;
                    return amount-(amount*penaltyPercent);
                }
            }
            else return 0;
        }
    }
}
