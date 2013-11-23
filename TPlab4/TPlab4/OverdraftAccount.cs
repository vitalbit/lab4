using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPlab4
{
    /// <summary>
    /// Class OverdraftAccount
    /// </summary>
    public class OverdraftAccount : Account
    {
        /// <summary>
        /// define overdraft account
        /// </summary>
        protected bool isOverdraft = true;
        /// <summary>
        /// interest payments
        /// </summary>
        protected double interestPayments;
        /// <summary>
        /// Constructor without parameters
        /// </summary>
        public OverdraftAccount()
            : base()
        {
            interestPayments = 0;
        }
        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="startBalance">start balance</param>
        public OverdraftAccount(double startBalance)
            : base(startBalance)
        {
            interestPayments = 0;
        }
        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="startBalance">start balance</param>
        /// <param name="interestPayments">interest payments</param>
        public OverdraftAccount(double startBalance, double interestPayments)
            : base(startBalance)
        {
            this.interestPayments = interestPayments;
        }
        /// <summary>
        /// take interest payments if balance less than 0
        /// </summary>
        public void takePercent()
        {
            if (balance < 0) balance += balance * interestPayments;
        }
        /// <summary>
        /// take money
        /// </summary>
        /// <param name="amount">amount of money</param>
        /// <returns>entering amount</returns>
        public override double takeMoney(double amount)
        {
            balance -= amount;
            return amount;
        }
    }
}
