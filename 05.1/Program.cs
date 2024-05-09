using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._1
{
    internal class Program
    {
        static int Fact2(double n)
        {
            int result = 1;
            for (int i = n % 2 == 0 ? 2 : 1; i <= n; i += 2)
            {
                result *= i;
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.Write("Введіть факторіал числа : ");
            int factorial = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Fact2(factorial));

            Console.CursorVisible = false;
            Console.ReadKey();
        }
    }
}
