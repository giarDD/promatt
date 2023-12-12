class Program
{
    static void Main()
    {
        Random random = new Random();

        int m = 3;
        int n = 5;

        Console.WriteLine($"Заданы случайные неотрицательные числа: m={m}, n={n}");
        int result = AckermannFunction(m, n);

        Console.WriteLine($"Результат функции Аккермана для m={m} и n={n}: {result}");

        Console.ReadLine();
    }

    static int GetRandomNonNegativeNumber(Random random)
    {
        return random.Next(0, int.MaxValue);
    }

    static int AckermannFunction(int m, int n)
    {
        Console.WriteLine($"Вычисление для m={m}, n={n}");

        if (m == 0)
        {
            return n + 1;
        }
        else if (n == 0)
        {
            return AckermannFunction(m - 1, 1);
        }
        else
        {
            return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
        }
    }
}
