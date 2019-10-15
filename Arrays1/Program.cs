using System;
using ArraysLib;

namespace Arrays1
{
    class Program
    {
        static void Main(string[] args)
        {
            int indexOfMaxElemInMassive = 0, countOfFullNumbersInMassive = 0;
            double sumOfNegativeElem, maxElem = 0, maxByModuleIndexOfMaxElem = 0, sumOfIndex = 0;

            int n = Convert.ToInt32(Console.ReadLine());
            double[] array = new double[n];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = rand.Next(-100, 100) + Math.Round(rand.NextDouble(), 1) * (rand.Next(0, 2) == 1 ? 1 : 0);
            }
            Console.WriteLine("Массив arr1: \n");
            foreach (double i in array)
                Console.Write("{0} ", i);
            Console.WriteLine("\n");

            sumOfNegativeElem = Array1.SumOfNegativeElemInMassive(array);
            Console.WriteLine("Сумма отрицательных елементов массива: {0} ", sumOfNegativeElem);

            Array1.MaxArr(ref maxElem, array);
            Console.WriteLine("Максимум: {0}", maxElem);

            Array1.IndexOfMaxElem(ref indexOfMaxElemInMassive, array);
            Console.WriteLine("Индекс максимального елемента: {0}", indexOfMaxElemInMassive);

            maxByModuleIndexOfMaxElem = Array1.MaxByModuleElemInArray(array);
            Console.WriteLine("Максимальный по модулю: {0}", maxByModuleIndexOfMaxElem);

            sumOfIndex = Array1.SumOfIndex(array);
            Console.WriteLine("Сумма индексов положительных элементов: {0}", sumOfIndex);

            countOfFullNumbersInMassive = Array1.CountOfFullNumbers(array);
            Console.WriteLine("Количество целых чисел в массиве: {0}", countOfFullNumbersInMassive);
            Console.ReadLine();
        }
    }
}