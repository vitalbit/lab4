using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TPlab4;

namespace TestTPlab4
{
    [TestClass]
    public class AccountTest
    {
        [TestMethod]
        public void TestTakeZeroMoney()
        {
            double balance = 0;
            double takeMoney = 1500;
            Account acc = new Account(balance);
            Assert.AreEqual(0, acc.takeMoney(takeMoney), "Wrong takeMoney");
        }
        [TestMethod]
        public void TestTakeZeroFunds()
        {
            double balance = 12000;
            double takeMoney = 1500;
            Account acc = new Account(balance);
            Assert.AreEqual(false, acc.takeFunds(takeMoney), "Wrong takeFunds");
        }
        [TestMethod]
        public void TestInvestFundZero()
        {
            double balance = 0;
            double plusMoney = 1500;
            Account acc = new Account(balance);
            Assert.AreEqual(false, acc.investFunds(plusMoney), "Wrong addMoney");
        }
        [TestMethod]
        public void TestAddMoney()
        {
            double balance = 12000;
            double plusMoney = 1500;
            Account acc = new Account(balance);
            acc.addMoney(plusMoney);
            balance+=plusMoney;
            Assert.AreEqual(balance, acc.getBalance(), "Wrong addMoney");
        }
        [TestMethod]
        public void TestTakeMoney()
        {
            double balance = 12000;
            double minusMoney = 1000;
            Account acc = new Account(balance);
            acc.takeMoney(minusMoney);
            balance -= minusMoney;
            Assert.AreEqual(balance, acc.getBalance(), "Wrong takeMoney");
        }
        [TestMethod]
        public void TestInvestFunds()
        {
            double balance = 12000;
            double investFunds = 3000;
            Account acc = new Account(balance);
            acc.investFunds(investFunds);
            balance -= investFunds;
            Assert.AreEqual(balance, acc.getBalance(), "Wrong investFunds");
        }
        [TestMethod]
        public void TestTakeFunds()
        {
            double balance = 12000;
            double takeFunds = 3000;
            Account acc = new Account(balance);
            acc.takeFunds(takeFunds);
            Assert.AreEqual(balance, acc.getBalance(), "Wrong takeFunds");
        }
    }
}
