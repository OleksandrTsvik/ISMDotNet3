using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMDotNet3
{
    class Program
    {
        static double[] ReadArray()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            int numberElementsArray;
            Console.Write("Введіть яку кількість елементів Ви бажаєте записати в масив: ");
            numberElementsArray = int.Parse(Console.ReadLine());

            double[] arrayNumbers = new double[numberElementsArray];
            for (int i = 0; i < numberElementsArray; i++)
            {
                Console.Write($"a[{i}] = ");
                arrayNumbers[i] = double.Parse(Console.ReadLine());
            }

            return arrayNumbers;
        }

        static void PrintArray(double[] arrayNumbers)
        {
            for (int i = 0; i < arrayNumbers.Length - 1; i++) // щоб після кожного елемента масива, крім останнього, стояла крапка з комой
                Console.Write(arrayNumbers[i] + ";  ");       // масив потрібно виводити у циклі до передостаннього елемета
            Console.Write(arrayNumbers[arrayNumbers.Length - 1]); // останній елемент масива вивести поза циклом, без крапки з комой
            Console.Write("\n\n");
        }

        static double SumNegativeElements(double[] arrayNumbers)
        {
            double sum = 0;
            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                if (arrayNumbers[i] < 0)
                    sum += arrayNumbers[i];
            }
            return sum;
        }

        static double MaxElementArray(double[] arrayNumbers)
        {
            double MaxElementArray = arrayNumbers[0]; // припускаємо, що нульовий елемент є найбільшим числом(максимальним)
            for (int i = 1; i < arrayNumbers.Length; i++) // розпочати пошук максимального числа з елемента під індексом 1(i = 1)
                if (arrayNumbers[i] > MaxElementArray)
                    MaxElementArray = arrayNumbers[i];
            return MaxElementArray;
        }

        static int IndexMaxElementArray(double[] arrayNumbers)
        {
            double MaxElementArray = arrayNumbers[0]; // припускаємо, що нульовий елемент є найбільшим числом(максимальним)
            int IndexMaxElementArray = 0;
            for (int i = 1; i < arrayNumbers.Length; i++) // розпочати пошук максимального числа з елемента під індексом 1(i = 1)
            {
                if (arrayNumbers[i] > MaxElementArray)
                {
                    MaxElementArray = arrayNumbers[i];
                    IndexMaxElementArray = i;
                }
            }
                return IndexMaxElementArray;
        }

        static double MaxModuloElementArray(double[] arrayNumbers)
        {
            double MaxModuloElementArray = arrayNumbers[0]; // припускаємо, що нульовий елемент є найбільшим числом по модулю(максимальним)
            for (int i = 1; i < arrayNumbers.Length; i++) // розпочати пошук максимального числа по модулю з елемента під індексом 1(i = 1)
                if (Math.Abs(arrayNumbers[i]) > Math.Abs(MaxModuloElementArray))
                    MaxModuloElementArray = arrayNumbers[i];
            return MaxModuloElementArray;
        }

        static int SumIndicesPositiveElements(double[] arrayNumbers)
        {
            int sum = 0;
            for (int i = 0; i < arrayNumbers.Length; i++)
                if (arrayNumbers[i] > 0)
                    sum += i;
            return sum;
        }

        static int CountIntegersArray(double[] arrayNumbers)
        {
            int count = 0;
            for (int i = 0; i < arrayNumbers.Length; i++)
                if (arrayNumbers[i] - (int)arrayNumbers[i] == 0)
                    count += 1;
            return count;
        }

        static double[] SortAndReverseArray(double[] arrayNumbers)
        {
            Array.Sort(arrayNumbers);
            Array.Reverse(arrayNumbers);
            return arrayNumbers;
        }

        static int CountZeroAndPositiveElementsArray(double[] arrayNumbers)
        {
            int count = 0;
            for (int i = 0; i < arrayNumbers.Length; i++)
                if (arrayNumbers[i] >= 0)
                    count += 1;
            return count;
        }

        static double[] RemoveNegativeElementsArray(double[] arrayNumbers)
        {
            int j = 0;
            double[] arrayNumbersWithoutNegativeNumbers = new double[CountZeroAndPositiveElementsArray(arrayNumbers)];
            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                if (arrayNumbers[i] >= 0)
                {
                    arrayNumbersWithoutNegativeNumbers[j] = arrayNumbers[i];
                    j += 1;
                }
            }
            return arrayNumbersWithoutNegativeNumbers;
        }

        static void Main(string[] args)
        {
            double[] arrayNumbers = ReadArray();

            double sumNegativeElements = SumNegativeElements(arrayNumbers);
            Console.WriteLine($"\nThe sum of negative numbers = {sumNegativeElements}\n");

            double maxElementArray = MaxElementArray(arrayNumbers);
            Console.WriteLine($"The maximum element of the array = {maxElementArray}\n");

            int indexMaxElementArray = IndexMaxElementArray(arrayNumbers);
            Console.WriteLine($"Index of the maximum element of the array = {indexMaxElementArray}\n");

            double maxModuloElementArray = MaxModuloElementArray(arrayNumbers);
            Console.WriteLine($"The maximum modulo element of the array = {maxModuloElementArray}\n");

            int sumIndicesPositiveElements = SumIndicesPositiveElements(arrayNumbers);
            Console.WriteLine($"The sum of the indices of positive elements = {sumIndicesPositiveElements}\n");

            int countIntegersArray = CountIntegersArray(arrayNumbers);
            Console.WriteLine($"Count of integers in the array = {countIntegersArray}\n");

            arrayNumbers = SortAndReverseArray(arrayNumbers);
            Console.WriteLine("Sorted array in descending order of array element values:");
            PrintArray(arrayNumbers);

            double[] arrayNumbersWithoutNegativeNumbers = RemoveNegativeElementsArray(arrayNumbers);
            Console.WriteLine("Array without negative numbers:");
            PrintArray(arrayNumbersWithoutNegativeNumbers);
        }
    }
}
