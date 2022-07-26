// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1   2  3 4
// 12 13 14 5
// 11 16 15 6
// 10  9  8 7
namespace Seminar8
{
    class Program
    {
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
        public static int[,] SpiralArray(int[,] array)
        {
            int strLength = array.GetLength(0);
            int colLength = array.GetLength(1);
            int row = 0;
            int col = 0;
            int dx = 1;
            int dy = 0;
            int direction = 0;
            int count = colLength;
            for (int i = 0; i < array.Length; i++)
            {
                array[row, col] = i + 1;
                if (--count == 0)
                {
                    count = colLength * (direction % 2) + strLength * ((direction + 1) % 2) - (direction / 2 - 1) - 2;
                    int temp = dx;
                    dx = -dy;
                    dy = temp;
                    direction++;
                }

                col += dx;
                row += dy;
            }
            return array;
        }
        public static void Main(string[] args)
        {
            Console.Clear();
            int[,] newArray = new int[5, 7];
            newArray = SpiralArray(newArray);
            PrintArray(newArray);
        }
    }
}