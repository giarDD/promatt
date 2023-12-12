

class Program
{
    static void Main()
    {
        
        int[] array = { 1, 7, 0, 4, 3 };

        Console.WriteLine("Исходный массив:");
        PrintArray(array, 0);

        Console.WriteLine("Развернутый массив:");
        PrintArrayReverse(array, array.Length - 1);

        Console.ReadLine();
    }

    static void PrintArray(int[] array, int index)
    {
        if (index < array.Length)
        {
            Console.Write(array[index] + " ");
            PrintArray(array, index + 1);
        }
        else
        {
            Console.WriteLine();
        }
    }

    static void PrintArrayReverse(int[] array, int index)
    {
        if (index >= 0)
        {
            Console.Write(array[index] + " ");
            PrintArrayReverse(array, index - 1);
        }
        else
        {
            Console.WriteLine();
        }
    }
}
