using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TPlab4;

namespace TestTPlab4
{
    [TestClass]
    public class SavingAccountTest
    {
        [TestMethod]
        public void TestTakeFunds()
        {
            double balance = 12000;
            double investFunds = 3000;
            double takeFunds = 2000;
            double interestRate = 0.3;
            SavingAccount acc = new SavingAccount(balance, interestRate);
            acc.investFunds(investFunds);
            balance -= investFunds;
            Assert.AreEqual(balance, acc.getBalance(), "Wrong investFunds");
            acc.takeFunds(takeFunds);
            balance += takeFunds + (takeFunds * interestRate);
            Assert.AreEqual(balance, acc.getBalance(), "Wrong takeFunds");
        }
    }
}
