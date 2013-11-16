using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPlab4
{

    class ATM
    {
        private List<Client> clients;

        public ATM()
        {
            clients = new List<Client>();
        }

        public void addClient(Client client)
        {
            clients.Add(client);
        }

        public bool removeClient(string login, string password)
        {
            foreach (Client lp in clients)
            {
                if (lp.getLogin() == login && lp.getPassword() == password)
                {
                    clients.Remove(lp);
                    return true;
                }
            }
            return false;
        }

        public int logIn(string login, string password)
        {
            int i = 0;
            foreach (Client lp in clients)
            {
                if (lp.getLogin() == login && lp.getPassword() == password)
                {
                    clients[i].setStatus(true);
                    return i;
                }
                i++;
            }
            return -1;
        }

        public bool logOff(string login)
        {
            int i = 0;
            foreach (Client lp in clients)
            {
                if (lp.getLogin() == login)
                {
                    clients[i].setStatus(false);
                    return true;
                }
                i++;
            }
            return false;
        }

        public Client getClient(int i)
        {
            if (i >= 0 && i < clients.Count) return clients[i];
            else return null;
        }
    }
}