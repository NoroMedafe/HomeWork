using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName;
            string userZodiac;
            string userAge;
            Console.Write("Как вас зовут? "); userName = Console.ReadLine();
            Console.Write("Сколько вам лет? "); userAge = Console.ReadLine();
            Console.Write("Какой у вас знак зодиака? "); userZodiac = Console.ReadLine();
            Console.WriteLine($"Вас зовут {userName},вам {userAge},вы {userZodiac}");

            Console.ReadKey();
        }
    }
}
