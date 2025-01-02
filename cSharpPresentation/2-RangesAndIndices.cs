

namespace cSharpPresentation;

internal static class RangesAndIndices
{
    static string[] words = ["The", "quick", "brown", "fox", "jumped", "over", "the", "lazy", "dog"];
    public static void Run()
    {
        //IndexFromEnd();
        IndexFromStart();
    }

    #region operator
    public static void IndexFromEnd()
    {


        Console.WriteLine($"The last word is '{words[^1]}'");

        Console.WriteLine($"The second last word is '{words[^2]}'");

        Console.WriteLine($"The second word is '{words[1]}'");

        //what will be ?
       // Console.WriteLine($"'{words[^10]}'");

        //what will be ?
        Console.WriteLine($"'{words[^9]}'");
    }

    #endregion

    #region RangeOperator
    private static void IndexFromStart()
    {
        string[] allValues = words[..];
        Console.WriteLine(allValues == words);
        foreach (var word in allValues)
        {
            Console.WriteLine(word);
        }
        PrintSeparator();

        // Extracts elements from index 1 to 3 (exclusive of 4)
        var quickBrownFox = words[1..4];
        foreach (var word in quickBrownFox)
        {
            Console.WriteLine(word);
        }
        PrintSeparator();

        // Extracts elements from the second last to the end
        var lazyDog = words[^2..^0];
        foreach (var word in lazyDog)
        {
            Console.WriteLine(word);
        }
        PrintSeparator();

        // Extracts elements from the start to index 3 (exclusive of 4)
        var firstPhrase = words[..4];
        foreach (var word in firstPhrase)
        {
            Console.WriteLine(word);
        }
        PrintSeparator();

        // Extracts elements from index 6 to the end
        var lastPhrase = words[6..];
        foreach (var word in lastPhrase)
        {
            Console.WriteLine(word);
        }
        int start = 2;
        //using Range
        Write(words, ..);
        Write(words, start..4);
      //  Write(words, ^2..^0);
        //Write(words, 4..4);
        //Write(words, ..4);
    }
    static void Write(string[] values, Range range) =>
    Console.WriteLine($"{range}:\t{string.Join(", ", values[range])}");

    #endregion

    static void PrintSeparator()
    {
        Console.WriteLine(new string('-', 40));
    }
}
