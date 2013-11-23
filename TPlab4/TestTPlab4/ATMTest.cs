using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TPlab4;

namespace TestTPlab4
{
    [TestClass]
    public class ATMTest
    {
        [TestMethod]
        public void TestATMLogInOff()
        {
            Account acc = new Account();
            string login = "Petya";
            string pass = "password";
            Client cl = new Client(login, pass, acc);
            ATM atm = new ATM();
            atm.addClient(cl);
            int n = atm.logIn(login, pass);
            Assert.AreEqual(0, n, "Error find client");
            Assert.AreEqual(true, atm.logOff(login), "Error logOff");
        }
    }
}
