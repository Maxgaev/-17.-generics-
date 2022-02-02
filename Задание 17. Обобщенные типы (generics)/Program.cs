using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_17.Обобщенные_типы__generics_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nВведите номер счёта");
            var idInt =Console.ReadLine();
            Console.WriteLine("\nВведите владельца счёта");
            string owner = Console.ReadLine();
            Console.WriteLine("\nВведите баланс счёта");
            var sheet = double.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Yellow;
            Account<double> account1 = new Account<double>(idInt, owner, sheet);
            Console.WriteLine(account1.GetInfo());

            //Console.WriteLine("\nВведите строковый номер счёта");
            //string idString = Console.ReadLine();
            //Console.WriteLine("\nВведите владельца счёта");
            //owner = Console.ReadLine();
            //Console.WriteLine("\nВведите баланс счёта");
            //sheet = Int32.Parse(Console.ReadLine());

            //Account<int> account1 = new Account<int>();
            //account1.Input();
            //Console.WriteLine(account1.GetInfo());

            //Account<string> account2 = new Account<string>();
            //account2.Input();
            //Console.WriteLine(account2.GetInfo());

            Console.ReadLine();
        }

        public static void Print<T>(T id, string owener, double sheet)
        {
            Console.Clear();
            Console.WriteLine($" {owener}, на вашем счету {id}: {sheet} RUR");
        }

    }

}
