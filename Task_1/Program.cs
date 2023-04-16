using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите количество строк m: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Введите количество столбцов n: ");
        int n = int.Parse(Console.ReadLine());

        double[,] matrix = new double[m, n];
        Random random = new Random();

        Console.WriteLine("Исходная матрица:");

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = random.NextDouble() * (10 - (-10)) + (-10);
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}