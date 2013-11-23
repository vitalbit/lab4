using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPlab4
{
    /// <summary>
    /// Class Account
    /// </summary>
    public class Account
    {
        /// <summary>
        /// balance
        /// </summary>
        protected double balance;
        /// <summary>
        /// funds
        /// </summary>
        protected double funds;
        /// <summary>
        /// define overdraft account
        /// </summary>
        protected bool isOverdraft = false;
        /// <summary>
        /// Constructor without parameters
        /// </summary>
        public Account()
        {
            funds = 0;
            balance = 0;
        }
        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="startBalance">start balance</param>
        public Account(double startBalance)
        {
            funds = 0;
            balance = startBalance;
        }
        /// <summary>
        /// invest funds
        /// </summary>
        /// <param name="amount">amount to invest</param>
        /// <returns>true if invest is proceed, else false</returns>
        public virtual bool investFunds(double amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                funds += amount;
                return true;
            }
            else return false;
        }
        /// <summary>
        /// take funds
        /// </summary>
        /// <param name="amount">amount to take</param>
        /// <returns>true if take proceed, else false</returns>
        public virtual bool takeFunds(double amount)
        {
            if (amount <= funds)
            {
                balance += amount;
                funds -= amount;
                return true;
            }
            else return false;
        }
        /// <summary>
        /// get balance
        /// </summary>
        /// <returns>balance</returns>
        public virtual double getBalance()
        {
            return balance;
        }
        /// <summary>
        /// take money from account
        /// </summary>
        /// <param name="amount">amount of money</param>
        /// <returns>amount of money if entering amount is correct</returns>
        public virtual double takeMoney(double amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                return amount;
            }
            else return 0;
        }
        /// <summary>
        /// add money to the account
        /// </summary>
        /// <param name="amount">amount of money</param>
        public virtual void addMoney(double amount)
        {
            balance += amount;
        }
    }
}
