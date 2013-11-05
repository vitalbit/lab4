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
            OverdraftAccount acc = new OverdraftAccount(1000, 0.5);
            acc.investFunds(600);
            Console.WriteLine(acc.takeMoney(500));
            acc.takePercent();
            acc.takeFunds(400);
        }
    }
}
