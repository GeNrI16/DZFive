using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZFive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int d = 0;
            int c = 0;
            Console.WriteLine("Введите начало диапазона");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите конец диапазона");
            int b = int.Parse(Console.ReadLine());
            while (a <= b)
            {

                if (a % 2 == 0)
                {
                    c++;
                }

                else
                { d++; }
                a++;
            }
            Console.WriteLine("четных чисел в диапазоне " + c);
            Console.WriteLine("нечетных  чисел в диапазоне " + d);

        }
    }
}
