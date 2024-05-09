using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._2
{
    internal class Program
    {
        static int[] OddArray(int arraySize)
        {
            if (arraySize <= 0)
            {
                Console.WriteLine("Розмір масиву повинен бути більше нуля.");
            }

            int[] oddNumbersArray = new int[arraySize];
            int odd = 1;

            for (int i = 0; i < arraySize; i++)
            {
                oddNumbersArray[i] = odd;
                odd += 2;
            }

            return oddNumbersArray;
        }

        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.Write("Вкажіть розмір масиву : ");
            int arraySize = Convert.ToInt32(Console.ReadLine());

            int[] array = OddArray(arraySize);

            Console.Write("Масив із непарних чисел : ");
            foreach (int number in array)
            {
                Console.Write(number + " ");
            }

            Console.ReadKey();
        }
    }
}
