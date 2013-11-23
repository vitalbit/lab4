using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TPlab4;

namespace TestTPlab4
{
    [TestClass]
    public class CheckingAccountTest
    {
        [TestMethod]
        public void TestMonthPass()
        {
            double balance = 12000;
            double takeMoney = 3000;
            double giveMoney = 2000;
            double penalty = 200;
            int count = 3;
            CheckingAccount acc = new CheckingAccount(balance, count, penalty);
            for (int i = 0; i!=3; i++)
            {
                acc.takeMoney(takeMoney);
                balance -= takeMoney;
                acc.addMoney(giveMoney);
                balance += giveMoney;
            }
            acc.monthPass();
            if (count - 6 < 0) balance += penalty * (count - 6);
            Assert.AreEqual(balance, acc.getBalance(), "Error in monthPass method");
        }
    }
}
