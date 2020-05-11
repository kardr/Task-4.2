using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4._2
{
    class Program
    {
        private static void Rec(int n)
        {
            if (n > 0)
            {
                Console.Write("{0} ", n);
                Rec(n - 1);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число: ");
            int n = int.Parse(Console.ReadLine());
            
            if (n == 0)
                Console.WriteLine("Ошибка: N = 0");
            else if (n < 0)
                Console.WriteLine("Ошибка: N меньше 0");
            else if (n > 1000)
                Console.WriteLine("Ошибка: N больше 1000");
            else
                Rec(n);

            Console.ReadKey();
        }
    }
}
