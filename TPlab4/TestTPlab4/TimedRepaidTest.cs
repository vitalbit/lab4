using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TPlab4;

namespace TestTPlab4
{
    [TestClass]
    public class TimedRepaidTest
    {
        [TestMethod]
        public void TestDateMoney()
        {
            double balance = 12000;
            double takeMoney = 3000;
            double interest = 0.3;
            double penalty = 0.4;
            DateTime dt = new DateTime(2015, 12, 12);
            TimedMaturityAccount acc = new TimedMaturityAccount(balance, interest, dt, penalty);
            double answerReal = acc.takeMoney(takeMoney);
            double answer;
            if (DateTime.Now >= dt) answer = takeMoney;
            else answer = takeMoney - takeMoney * penalty;
            Assert.AreEqual(answer, answerReal, "Wrong Timed Mature Method");
        }
    }
}
