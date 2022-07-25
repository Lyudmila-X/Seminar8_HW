// Задача 58: Задайте две матрицы. Напишите программу,
// которая выведет матрицу произведения элементов двух предыдущих матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49
using System.Linq;
using System;
namespace Seminar8
{
    class Program
    {
        public static int[,] FillArray(int[,] incomeArray)
        {
            for (int i = 0; i < incomeArray.GetLength(0); i++)
            {
                for (int j = 0; j < incomeArray.GetLength(1); j++)
                {
                    incomeArray[i, j] = new Random().Next(-9, 10);
                }
            }
            return incomeArray;
        }
        public static void PrintArray(int[,] incomeArray)
        {
            for (int i = 0; i < incomeArray.GetLength(0); i++)
            {
                for (int j = 0; j < incomeArray.GetLength(1); j++)
                {
                    if (Convert.ToString(incomeArray[i, j]).Length == 1)
                    {
                        Console.Write("  " + incomeArray[i, j]);
                    }
                    else
                    {
                        Console.Write(" " + incomeArray[i, j]);
                    }

                }
                Console.WriteLine();
            }
        }
        public static int[,] MultipliedArray(int[,] incArrayFirst, int[,] incArraySecond)
        {

            for (int i = 0; i < incArrayFirst.GetLength(0); i++)
            {
                for (int j = 0; j < incArrayFirst.GetLength(1); j++)
                {
                    incArrayFirst[i, j] = incArrayFirst[i, j] * incArraySecond[i, j];
                }
            }
            return incArrayFirst;
        }
        public static void Main()
        {
            Console.Clear();
            Console.WriteLine("Введите количество строк: ");
            int str = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов: ");
            int col = Convert.ToInt32(Console.ReadLine());
            int[,] arrayFirst = new int[str, col];
            int[,] arraySecond = new int[str, col];
            FillArray(arrayFirst);
            Console.WriteLine("Массив №1:");
            PrintArray(arrayFirst);
            FillArray(arraySecond);
            Console.WriteLine("Массив №2:");
            PrintArray(arraySecond);
            Console.WriteLine();
            Console.WriteLine("Произведение массивов:");
            PrintArray(MultipliedArray(arrayFirst, arraySecond));
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}