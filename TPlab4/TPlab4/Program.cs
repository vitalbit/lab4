using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPlab4
{
    class Program
    {
        static void Main(string[] args)
        {
            OverdraftAccount oAcc = new OverdraftAccount(1000, 0.5);
            TimedMaturityAccount tma = new TimedMaturityAccount(2000, 0.3, new DateTime(2013, 2, 1), 0.1);
            Client client = new Client("Vasya", "vasya", oAcc);
            client.addAccount(tma);
            ATM atm = new ATM();
            atm.addClient(client);
            Console.WriteLine("Введите логин: ");
            string login = Console.ReadLine();
            Console.WriteLine("Введите пароль: ");
            string password = Console.ReadLine();
            int num;
            if ((num = atm.logIn(login, password)) != -1)
            {
                string ans;
                do
                {
                    Console.WriteLine("1 - выбрать счет\n0 - выход");
                    ans = Console.ReadLine();
                    if (ans == "1")
                    {
                        Client cl = atm.getClient(num);
                        for (int i = 0; i != cl.accountCount(); i++)
                        {
                            if (cl.getAccount(i).GetType() == typeof(Account)) Console.WriteLine("{0} - Универсальный счет", i + 1);
                            else if (cl.getAccount(i).GetType() == typeof(SavingAccount)) Console.WriteLine("{0} - Сберегательный аккаунт", i + 1);
                            else if (cl.getAccount(i).GetType() == typeof(TimedMaturityAccount)) Console.WriteLine("{0} - Счет со временем погашения платежа", i + 1);
                            else if (cl.getAccount(i).GetType() == typeof(CheckingAccount)) Console.WriteLine("{0} - Текущий счет", i + 1);
                            else if (cl.getAccount(i).GetType() == typeof(OverdraftAccount)) Console.WriteLine("{0} - Счет по которому допускается овердрафт", i + 1);
                        }
                        int numAcc = Convert.ToInt32(Console.ReadLine());
                        numAcc--;
                        Account acc = cl.getAccount(numAcc);
                        int res;
                        do
                        {
                            Console.WriteLine("1 - Узнать баланс\n2 - Вложить фонды\n3 - Снять фонды\n4 - Снять деньги\n5 - Положить деньги\n0 - Выход");
                            res = Convert.ToInt32(Console.ReadLine());
                            if (res == 1) Console.WriteLine(acc.getBalance());
                            else if (res == 2)
                            {
                                Console.WriteLine("Введите сумму: ");
                                double sum = Convert.ToDouble(Console.ReadLine());
                                if (acc.investFunds(sum)) Console.WriteLine("Вложение прошло успешно");
                                else Console.WriteLine("Ошибка не хватает средств");
                            }
                            else if (res == 3)
                            {
                                Console.WriteLine("Введите сумму: ");
                                double sum = Convert.ToDouble(Console.ReadLine());
                                if (acc.takeFunds(sum)) Console.WriteLine("Снятие прошло успешно");
                                else Console.WriteLine("Ошибка не хватает средств");
                            }
                            else if (res == 4)
                            {
                                Console.WriteLine("Введите сумму: ");
                                double sum = Convert.ToDouble(Console.ReadLine());
                                if (acc.takeMoney(sum) != 0) Console.WriteLine("Снятие прошло успешно");
                                else Console.WriteLine("Ошибка не хватает средств");
                            }
                            else if (res == 5)
                            {
                                Console.WriteLine("Введите сумму: ");
                                double sum = Convert.ToDouble(Console.ReadLine());
                                acc.addMoney(sum);
                                Console.WriteLine("Положено " + sum + " денег");
                            }
                        }
                        while (res != 0);
                    }
                }
                while (ans == "1");
                atm.logOff(login);
            }
        }
    }
}
