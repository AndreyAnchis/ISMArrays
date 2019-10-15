using System;
using ArraysLib;

namespace Arrays2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumBTWFirstAndLastNull = 0, multiplAfterMin, sumBTWNegAndSecondPos, multiplBTWMaxAndMinByModule;

            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
                array[i] = rand.Next(-20, 20);
            Console.WriteLine("Массив arr1: \n");
            foreach (double i in array)
                Console.Write("{0} ", i);
            Console.WriteLine("\n");

            multiplAfterMin = Array2.DobElemAfterMin(array);
            Console.WriteLine("Произведение елементов после минимального: {0}", multiplAfterMin);

            sumBTWFirstAndLastNull = Array2.SumOfElemBetwFirstAndLastNull(array);
            Console.WriteLine("Сумма чисел между нулями: {0}", sumBTWFirstAndLastNull);

            sumBTWNegAndSecondPos = Array2.SumBTWFirstNegAndSecondPositinve(array);
            Console.WriteLine("Сумма между отрицательным и вторым положительным: {0}", sumBTWNegAndSecondPos);

            multiplBTWMaxAndMinByModule = Array2.DobBTWMaxAndMinByModule(array);
            Console.WriteLine("Произведение елементов между макс и мин по модулю: {0}", multiplBTWMaxAndMinByModule);
        }
    }
}