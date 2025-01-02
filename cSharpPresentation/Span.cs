using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace cSharpPresentation;

internal class SpanExample
{
    internal static void Run()
    {
       // BenchmarkRunner.Run<StringManiplulationStartWith>();
        //BenchmarkRunner.Run<SrtingManipulationSpan>();
    }
}
public class StringManiplulationStartWith
{
    [Benchmark]
    public bool RunWithSpan()
    {
        string imput = "INV-123456456";
        ReadOnlySpan<char> imputSpan = imput.AsSpan();
        ReadOnlySpan<char> startWith = imputSpan.Slice(0, 4);
        ReadOnlySpan<char> comparationSpan = "inv-".AsSpan();
        return startWith.Equals(comparationSpan, StringComparison.OrdinalIgnoreCase);
    }

    [Benchmark]
    public bool RunWithStartWith()
    {
        var imput = "INV-123456456";
        return imput.StartsWith("INV-");
    }
}

[MemoryDiagnoser]
public class SrtingManipulationSpan
{
    string _dateAsText = "02 12 2024";

    [Benchmark]
    public (int day, int month, int year) DateFromString()
    {
        int day = int.Parse(_dateAsText.Substring(0, 2));
        int month = int.Parse(_dateAsText.Substring(3, 2));
        int year = int.Parse(_dateAsText.Substring(6));
        return (day, month, year);
    }

    [Benchmark]
    public (int day, int month, int year) DateFromStringWithSpan()
    {
        ReadOnlySpan<char> dateSpan = _dateAsText;
        int day = int.Parse(dateSpan.Slice(0, 2));
        int month = int.Parse(dateSpan.Slice(3, 2));
        int year = int.Parse(dateSpan.Slice(6));
        return (day, month, year);
    }
}



