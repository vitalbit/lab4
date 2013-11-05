using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPlab4
{
    /// <summary>
    /// Class CheckingAccount
    /// </summary>
    class CheckingAccount : Account
    {
        /// <summary>
        /// operations counter
        /// </summary>
        protected int countOperations;
        /// <summary>
        /// maximum of operations
        /// </summary>
        protected int maxCountOperations;
        /// <summary>
        /// penalty amount
        /// </summary>
        protected double penaltyAmount;
        /// <summary>
        /// Constructor without parameters
        /// </summary>
        public CheckingAccount()
            : base()
        {
            countOperations = 0;
            maxCountOperations = 0;
            penaltyAmount = 0;
        }
        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="startBalance">start balance</param>
        public CheckingAccount(double startBalance)
            : base(startBalance)
        {
            countOperations = 0;
            maxCountOperations = 0;
            penaltyAmount = 0;
        }
        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="startBalance">start balance</param>
        /// <param name="countOperations">number of operations</param>
        /// <param name="penaltyAmount">penalty amount</param>
        public CheckingAccount(double startBalance, int countOperations, double penaltyAmount)
            : base(startBalance)
        {
            this.countOperations = countOperations;
            maxCountOperations = countOperations;
            this.penaltyAmount = penaltyAmount;
        }
        /// <summary>
        /// invest funds
        /// </summary>
        /// <param name="amount">amount to invest</param>
        /// <returns>true if invest proceed, else false</returns>
        public override bool investFunds(double amount)
        {
            if (amount <= balance)
            {
                countOperations--;
                return base.investFunds(amount);
            }
            else return false;
        }
        /// <summary>
        /// take funds
        /// </summary>
        /// <param name="amount">amount to take</param>
        /// <returns>true if take proceed, else false</returns>
        public override bool takeFunds(double amount)
        {
            if (amount <= funds)
            {
                countOperations--;
                return base.takeFunds(amount);
            }
            else return false;
        }
        /// <summary>
        /// take money
        /// </summary>
        /// <param name="amount">amount of money</param>
        /// <returns>0 if there is no such amount of money, else entering amount</returns>
        public override double takeMoney(double amount)
        {
            countOperations--;
            return base.takeMoney(amount);
        }
        /// <summary>
        /// get penalty amount when month is pass
        /// </summary>
        public void monthPass()
        {
            balance -= (0 - countOperations) * penaltyAmount;
            countOperations = maxCountOperations;
        }
    }
}
