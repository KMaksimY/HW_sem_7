// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество строк: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Введите количество столбцов: ");
        int n = int.Parse(Console.ReadLine());

        int[,] arr = new int[m, n];
        Random rnd = new Random();

        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                arr[i, j] = rnd.Next(100); // генерируем случайное число в диапазоне от 0 до 99
                Console.Write("{0}\t", arr[i, j]);
            }
            Console.WriteLine();
        }

        Console.WriteLine("Средние арифметические элементов в каждом столбце:");
        for (int j = 0; j < n; j++)
        {
            int sum = 0;
            for (int i = 0; i < m; i++)
            {
                sum += arr[i, j];
            }
            double avg = (double)sum / m;
            Console.WriteLine("Столбец {0}: {1}", j + 1, avg);
        }
    }
}

