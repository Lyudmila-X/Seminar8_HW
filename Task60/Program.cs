// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)
namespace Seminar8
{
    class Program
    {
        public static void PrintArray (int[,,] incomeArray)
        {
            for (int i = 0; i < incomeArray.GetLength(0); i++)
            {
                for (int j = 0; j < incomeArray.GetLength(1); j++)
                {
                    for (int k = 0; k < incomeArray.GetLength(2); k++)
                    {
                        Console.Write($" {incomeArray[i,j,k]} ({i}, {j}, {k})  ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();

            }

        }
        public static void Main()
        {
            int[,,] array =
            {
                {
                    {23, 15, 26},
                    {11, 18, 90}
                },
                {
                    {24, 16, 27},
                    {12, 19, 91}
                },
                {
                    {25, 17, 28},
                    {13, 20, 93}
                }
            };
            Console.Clear();
            PrintArray(array);
            Console.WriteLine("");
            Console.ReadKey(); 
        }
    }
}