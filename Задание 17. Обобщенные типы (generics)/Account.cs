using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_17.Обобщенные_типы__generics_
{
    class Account<T>
    {
        private T Id { get; set; }
        private string Owner { get; set; }
        private double Sheet { get; set; }
        

        public Account(T id, string owner, double sheet)
        {
            Id = id;
            Owner = owner;
            Sheet = sheet;
        }

        public Account(string idInt, string owner, double sheet)
        {
            Owner = owner;
            Sheet = sheet;
        }

        public string GetInfo()
        {
            return $"{Id} {Owner} {Sheet}";
        }

        //public void Input()
        //{
        //    Console.WriteLine("\nВведите номер счёта");
        //    id = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
        //    Console.WriteLine("\nВведите владельца счёта");
        //    owner = Console.ReadLine();
        //    Console.WriteLine("\nВведите баланс счёта");
        //    sheet = Int32.Parse(Console.ReadLine());
        //}

    }
}
