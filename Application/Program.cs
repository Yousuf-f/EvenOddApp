namespace DemoProject02;

class Program
{
    static void Main(string[] args)
    {
        IEnumerable<int> numbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        PrintArray("Numbers", numbers);
        PrintArray("Even numbers", numbers.Where(x => IsEven(x)));
        PrintArray("Odd numbers", numbers.Where(x => IsOdd(x)));
    }
    static void PrintArray(string title, IEnumerable<int> numbers)
    {
        Console.Write($"{title}: [");
        foreach (int i in numbers)
        {
            Console.Write($" {i}");
        }
        Console.Write(" ]");
        Console.WriteLine();
    }
    static bool IsEven(int value) => value % 2 == 0;

    static bool IsOdd(int value) => !IsEven(value);
}
