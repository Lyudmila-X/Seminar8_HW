// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер 
// строки с наименьшей суммой элементов: 1 строка
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
        public static int StringNumber(int[,] incArray)
        {
            int strNum = 1;
            int sum = 0;
            int[] line = new int[incArray.GetLength(0)];
            for (int i = 0; i < incArray.GetLength(0); i++)
            {
                for (int j = 0; j < incArray.GetLength(1); j++)
                {
                    line[j] = incArray[i, j];
                }
                if (line.Sum() < sum)
                {
                    sum = line.Sum();
                    strNum = i + 1;
                }
            }
            return strNum;
        }
        public static void Main()
        {
            Console.Clear();
            Console.WriteLine("Введите количество строк: ");
            int str = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов: ");
            int col = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[str, col];
            FillArray(array);
            PrintArray(array);
            Console.WriteLine();
            Console.WriteLine(StringNumber(array));
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}