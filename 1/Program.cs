// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать цикл

Console.WriteLine("Введите значение M: ");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите значение N: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine($"Натуральные числа от {m} до {n}:");
PrintNaturalNumbers(Math.Min(m, n), Math.Max(m, n));

Console.ReadLine();

void PrintNaturalNumbers(int start, int end)
{
    if (start <= end)
    {
        Console.WriteLine(start);
        PrintNaturalNumbers(start + 1, end);
    }
}
