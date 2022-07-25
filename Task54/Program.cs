// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по возрастанию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8
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
        public static int[,] OrderArray(int[,] incArray)
        {
            int[] line = new int[incArray.GetLength(0)];
            for (int i = 0; i < incArray.GetLength(0); i++)
            {
                for (int j = 0; j < incArray.GetLength(1); j++)
                {
                    line[j] = incArray[i, j];
                }
                line = line.OrderBy(x => x).ToArray();
                for (int j = 0; j < incArray.GetLength(1); j++)
                {
                    incArray[i, j] = line[j];
                }
            }
            return incArray;
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
            OrderArray(array);
            PrintArray(array);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}