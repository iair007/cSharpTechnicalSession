using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace cSharpPresentation;

[MemoryDiagnoser]
public class YieldReturnExampleBenchmark
{
    private int[] numbers = Enumerable.Range(1, 1000000).ToArray(); // Large dataset

    [Benchmark]
    public void TestGetEvenNumbersWithYield()
    {
        foreach (var number in GetEvenNumbers(numbers))
        {
            // Consume the result
        }
    }

    [Benchmark]
    public void TestGetEvenNumbersWithoutYield()
    {
        foreach (var number in GetEvenNumbersWithoutYield(numbers))
        {
            // Consume the result
        }
    }

    private static IEnumerable<int> GetEvenNumbersWithoutYield(int[] numbers)
    {
        var evenNumbers = new List<int>();
        foreach (var number in numbers)
        {
            if (number % 2 == 0)
            {
                evenNumbers.Add(number);
            }
        }
        return evenNumbers;
    }

    private static IEnumerable<int> GetEvenNumbers(int[] numbers)
    {
        foreach (var number in numbers)
        {
            if (number % 2 == 0)
            {
                yield return number;
            }
        }
    }
}
