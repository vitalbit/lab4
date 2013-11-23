using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TPlab4;

namespace TestTPlab4
{
    [TestClass]
    public class OverdraftAccountTest
    {
        [TestMethod]
        public void TestTakeMoneyPercent()
        {
            double balance = 1000;
            double takeMoney = 3000;
            double interest = 0.3;
            OverdraftAccount acc = new OverdraftAccount(balance, interest);
            acc.takeMoney(takeMoney);
            balance -= takeMoney;
            acc.takePercent();
            if (balance < 0) balance += balance * interest;
            Assert.AreEqual(balance, acc.getBalance(), "Wrong takePercent Method");
        }
    }
}
