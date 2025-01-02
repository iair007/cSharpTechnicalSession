using System.Runtime.CompilerServices;

namespace cSharpPresentation;

internal class SwitchExpression
{

    internal static void Run()
    {
        string message = "Hello";
        string result = message switch
        {
            "Hello" => "World",
            "World" => "Hello",
            _ => "No Match"
        };
        Console.WriteLine(result);

        int number = 10;
        string description = number switch
        {
            > 0 and <= 10 => "Number is between 1 and 10",
            > 10 and <= 20 => "Number is between 11 and 20",
            > 20 => "Number is greater than 20",
            _ => "Number is less than or equal to 0"
        };

        Console.WriteLine(description);

        Console.WriteLine(GetSeason(1));
        string GetSeason(int month) =>
            month switch
            {
                12 or 1 or 2 => "Winter",
                3 or 4 or 5 => "Spring",
                6 or 7 or 8 => "Summer",
                9 or 10 or 11 => "Autumn",
                _ => "Invalid month"
            };
    }
}

