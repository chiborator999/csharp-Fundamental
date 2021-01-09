using System;

namespace Average_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            double avergeSum = 0;
            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;
                avergeSum = sum / n;
            }
            Console.WriteLine($"{avergeSum:F2}");
        }
    }
}
