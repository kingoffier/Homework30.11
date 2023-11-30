using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 6;
            int colvo = 0;
            int sum = 0;
            float arifm = 0;
            int[] array = new int[n];
            Console.WriteLine("Введите числа в массиве");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Массив:");
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
                Console.WriteLine(array[i]);
            }
            arifm = sum / array.Length;
            Console.WriteLine("Числа, которые меньше ср. арифметического:");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < arifm)
                {
                    Console.WriteLine(array[i]);
                }
            }
        
    }
    }
}
