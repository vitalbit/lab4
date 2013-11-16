using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPlab4
{
    class Client
    {
        private string login;
        private string password;
        private bool status;
        private List<Account> accounts;

        public Client(string login, string password, Account account)
        {
            this.login = login;
            this.password = password;
            status = false;
            this.accounts = new List<Account>();
            this.accounts.Add(account);
        }

        public string getLogin()
        {
            return login;
        }

        public string getPassword()
        {
            return password;
        }

        public bool setPassword(string newPass)
        {
            if (status)
            {
                password = newPass;
                return true;
            }
            else return false;
        }

        public bool getStatus()
        {
            return status;
        }

        public void setStatus(bool newStatus)
        {
            status = newStatus;
        }

        public Account getAccount(int i)
        {
            if (i >= 0 && i < accounts.Count) return accounts[i];
            else return null;
        }

        public void addAccount(Account acc)
        {
            accounts.Add(acc);
        }

        public bool removeAccount(Account acc)
        {
            if (accounts.Remove(acc)) return true;
            else return false;
        }

        public int accountCount()
        {
            return accounts.Count;
        }
    }
}
