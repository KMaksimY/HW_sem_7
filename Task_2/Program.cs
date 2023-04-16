using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество строк: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Введите количество столбцов: ");
        int n = int.Parse(Console.ReadLine());

        double[,] arr = new double[m, n];
        Random rnd = new Random();

Console.WriteLine();

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                arr[i, j] = rnd.NextDouble();
                Console.Write("{0}\t", arr[i, j]);
            }
            Console.WriteLine();
        }



        Console.Write("Введите номер строки: ");
        int row = int.Parse(Console.ReadLine());

        Console.Write("Введите номер столбца: ");
        int col = int.Parse(Console.ReadLine());

        if (row < 0 || row >= m || col < 0 || col >= n)
        {
            Console.WriteLine("Элемент с такими координатами не найден");
        }
        else
        {
            Console.WriteLine("Элемент [{0}, {1}] = {2}", row, col, arr[row, col]);
        }
    }
}


// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Введите количество строк: ");
//         int m = int.Parse(Console.ReadLine());

//         Console.Write("Введите количество столбцов: ");
//         int n = int.Parse(Console.ReadLine());

//         int[,] arr = new int[m, n];
//         Random rnd = new Random();

//         Console.WriteLine("Исходный массив:");
//         for (int i = 0; i < m; i++)
//         {
//             for (int j = 0; j < n; j++)
//             {
//                 arr[i, j] = rnd.Next(100); // генерируем случайное число в диапазоне от 0 до 99
//                 Console.Write("{0}\t", arr[i, j]);
//             }
//             Console.WriteLine();
//         }

//         Console.Write("Введите номер строки: ");
//         int row = int.Parse(Console.ReadLine());

//         Console.Write("Введите номер столбца: ");
//         int col = int.Parse(Console.ReadLine());

//         if (row < 0 || row >= m || col < 0 || col >= n)
//         {
//             Console.WriteLine("Элемент с такими координатами не найден");
//         }
//         else
//         {
//             Console.WriteLine("Элемент [{0}, {1}] = {2}", row, col, arr[row, col]);
//         }
//     }
// }
