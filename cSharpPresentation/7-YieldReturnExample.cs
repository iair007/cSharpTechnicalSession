using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace cSharpPresentation;

public class YieldReturnExample
{
    private static int[] numbers = Enumerable.Range(1, 10).ToArray(); // Large dataset

    public static void Run()
    {
        Console.WriteLine("Running TestGetEvenNumbersWithoutYield...");
        TestGetEvenNumbersWithoutYield();

        Console.WriteLine("********************************");

        Console.WriteLine("Running TestGetEvenNumbersWithYield...");
        TestGetEvenNumbersWithYield();
    }
       
    public static void TestGetEvenNumbersWithoutYield()
    {
        foreach (var number in GetEvenNumbersWithoutYield(numbers))
        {
            Console.WriteLine($"No Yield: {number}");
        }
    }

    private static IEnumerable<int> GetEvenNumbersWithoutYield(int[] numbers)
    {
        var evenNumbers = new List<int>();
        foreach (var number in numbers)
        {
            if (number % 2 == 0)
            {
                Thread.Sleep(500);
                evenNumbers.Add(number);
            }
        }
        Console.WriteLine($"{DateTime.Now:HH:mm:ss.fff} - Finished processing all numbers without yield.");
        return evenNumbers;
    }

    public static void TestGetEvenNumbersWithYield()
    {
        foreach (var number in GetEvenNumbers(numbers))
        {
            Console.WriteLine($"Yield: {number}");
        }
    }


    private static IEnumerable<int> GetEvenNumbers(int[] numbers)
    {
        foreach (var number in numbers)
        {
            if (number % 2 == 0)
            {
                Thread.Sleep(500);
                yield return number;
            }
        }
        Console.WriteLine($"{DateTime.Now:HH:mm:ss.fff} - Finished processing all numbers with yield.");
    }
}
