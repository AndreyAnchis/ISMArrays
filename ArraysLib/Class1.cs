using System;

namespace ArraysLib
{
    public class Array1
    {
        public static double SumOfNegativeElemInMassive(params double[] arr)
        {

            double sum = 0;
            if (arr.Length == 0)
            {
                Console.WriteLine("Пустой массив!");
                return sum;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    sum += arr[i];
                }
            }
            return sum;
        }
        public static void MaxArr(ref double max, params double[] arr)
        {
            if (arr.Length == 0)
            {
                Console.WriteLine("Пустой массив!");
                max = 0;
                return;
            }
            else
            {
                if (arr.Length == 1)
                {
                    max = arr[0];
                    return;
                }
            }
            max = arr[0];
            for (int i = 1; i < arr.Length; i++)
                if (arr[i] > max)
                    max = arr[i];
        }

        public static void IndexOfMaxElem(ref int index, params double[] arr)
        {
            double a = 0;
            if (arr.Length == 0)
            {
                Console.WriteLine("Пустой массив!");
                return;
            }
            else
            {
                if (arr.Length == 1)
                {
                    index = 0;
                    return;
                }
            }
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > a)
                {
                    a = arr[i];
                    index = i;
                }
            }
        }
        public static double MaxByModuleElemInArray(params double[] arr)
        {
            double maxElem = 0;
            if (arr.Length == 0)
            {
                Console.WriteLine("Пустой массив!");
                return 0;
            }
            else
            {
                if (arr.Length == 1)
                {
                    maxElem = arr[0];
                    return 0;
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (Math.Abs(arr[i]) > maxElem)
                {
                    maxElem = Math.Abs(arr[i]);
                }
            }
            return maxElem;
        }
        public static double SumOfIndex(params double[] arr)
        {
            int sumOfIndex = 0;
            if (arr.Length == 0)
            {
                Console.WriteLine("Пустой массив!");
                return 0;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    sumOfIndex += i;
                }
            }
            return sumOfIndex;
        }
        public static int CountOfFullNumbers(params double[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % Math.Round(arr[i], 0) == 0)
                    count++;
            }
            return count;
        }
    }
    public class Array2
    {
        public static int DobElemAfterMin(params int[] arr)
        {
            int index = 0;
            if (arr.Length == 0)
            {
                Console.WriteLine("Пустой массив!");
                return 0;
            }
           double min = 1e7;
            for (int i = 0; i < arr.Length; i++)
            {   
                if (min > arr[i])
                {
                    min = arr[i];
                    index = i;
                }
            }
            int dob = 1;
            for (int i = index; i < arr.Length; i++)
            {
                dob *= arr[i];
            }
            return dob;
        }
        public static int SumOfElemBetwFirstAndLastNull(params int[] arr)
        {
            int firstNull = 0, lastNull = 0, sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    firstNull = i;
                    break;
                }
            }

            for (int i = firstNull + 1; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    lastNull = i;
                    break;
                }
            }

            for (int i = firstNull; i <= lastNull; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        public static int SumBTWFirstNegAndSecondPositinve(params int[] arr)
        {
            int firstNegative = 0, tmp = 0, secPos = 0;
            int indexNeg = 0, indexPos = 0;
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    firstNegative = arr[i];
                    indexNeg = i;
                    break;
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    tmp++;
                }
                if (tmp == 2)
                {
                    secPos = arr[i];
                    indexPos = i;
                    break;
                }
            }
            if (indexNeg > indexPos)
            {
                for (int i = indexPos; i <= indexNeg; i++)
                {
                    sum += arr[i];
                }
            }
            else if (indexPos > indexNeg)
            {
                for (int i = indexNeg; i <= indexPos; i++)
                {
                    sum += arr[i];
                }
            }
            return sum;
        }
        public static int DobBTWMaxAndMinByModule(params int[] arr)
        {
            int dob = 1, maxElem = -20, minElem = 20;
            int indexMax = 0, indexMin = 0;
            if (arr.Length == 0)
            {
                Console.WriteLine("Пустой массив!");
                return 0;
            }
            else
            {
                if (arr.Length == 1)
                {
                    return 0;
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (Math.Abs(arr[i]) > maxElem)
                {
                    maxElem = Math.Abs(arr[i]);
                    indexMax = i;
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (Math.Abs(arr[i]) < minElem)
                {
                    minElem = Math.Abs(arr[i]);
                    indexMin = i;
                }
            }
            if (indexMin > indexMax)
            {
                for (int i = indexMax; i <= indexMin; i++)
                {
                    dob *= arr[i];
                }
            }
            else if (indexMax > indexMin)
            {
                for (int i = indexMin; i <= indexMax; i++)
                {
                    dob *= arr[i];
                }
            }
            return dob;
        }
    }
}
