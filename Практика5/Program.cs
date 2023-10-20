using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Выводится цикл dowhile: ");
            do
            {
                Console.WriteLine(a);
                a--;
            }
            while (a > 0);
            Console.WriteLine("Введите такое же число, как и первое: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Выводится цикл while: ");
            while (b > 0)
            {
                Console.WriteLine(b);
                b--;
            }
        }
    }
}
