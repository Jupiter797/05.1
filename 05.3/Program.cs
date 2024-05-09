using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._3
{
    internal class Program
    {
        static int FindMax(params int[] arguments)
        {
            int max = arguments[0];
            for (int i = 1; i < arguments.Length; i++)
            {
                if (arguments[i] > max)
                {
                    max = arguments[i];
                }
            }

            return max;
        }

        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.Write("Введіть числа, розділені пробілом : ");

            string input = Console.ReadLine();

            try
            {
                int number = Convert.ToInt32(input);
                string[] parts = input.Split(' ');

                int[] arguments = parts.Select(int.Parse).ToArray();

                int max = FindMax(arguments);
                Console.WriteLine("Максимальне значення з першого набору аргументів : " + max);
            }
            catch (Exception)
            {
                Console.WriteLine("Введені значення не є числами!");
            }

            Console.CursorVisible = false;
            Console.ReadKey();
        }
    }
}
