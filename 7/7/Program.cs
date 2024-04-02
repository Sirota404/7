using System;
using System.Diagnostics;

class Program
{
    static uint FibonacciNumIterative(uint n)
    {
        if (n == 0 || n == 1)
        {
            return 1;
        }

        uint a = 1;
        uint b = 1;

        for (uint i = 2; i <= n; i++)
        {
            uint temp = a + b;
            a = b;
            b = temp;
        }

        return b;
    }

    static uint FibonacciNumRecursive(uint n)
    {
        if (n == 0 || n == 1)
        {
            return 1;
        }

        return FibonacciNumRecursive(n - 1) + FibonacciNumRecursive(n - 2);
    }

    static void Main(string[] args)
    {
        var values = new uint[] { 5, 10, 20 };

        foreach (var n in values)
        {
            Console.WriteLine($"N = {n}");

            var stopwatch1 = new Stopwatch();
            stopwatch1.Start();
            var result1 = FibonacciNumIterative(n);
            stopwatch1.Stop();
            Console.WriteLine($"Итеративный метод: {result1}, время выполнения: {stopwatch1.Elapsed}");

            var stopwatch2 = new Stopwatch();
            stopwatch2.Start();
            var result2 = FibonacciNumRecursive(n);
            stopwatch2.Stop();
            Console.WriteLine($"Рекурсивный метод: {result2}, время выполнения: {stopwatch2.Elapsed}");

            Console.WriteLine();
        }

        Console.ReadLine();
    }
}