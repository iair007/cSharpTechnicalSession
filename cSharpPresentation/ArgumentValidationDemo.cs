namespace cSharpPresentation;

    internal static class ArgumentValidationDemo
    {
        internal static void Run()
        {
         
                ValidateInputs(null,"   ",  0, -1, 6); // Example invalid inputs
          
                ValidateInputs("ValidName","not empty", 5, 3, 4); // Example valid inputs
        }

    private static void ValidateInputs(string? name, string nameEmpty, int someNumber, int negativeCheck, int rangeCheck)
    {
        // Check if the name is null or contains only whitespace
        try
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(name, nameof(name));
        }
        catch (ArgumentException ex)
        {
          Console.WriteLine($"Exception caught: {ex.Message}");
        }

        // Check if the name is null or contains only whitespace
        try
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(nameEmpty, nameof(nameEmpty));
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Exception caught: {ex.Message}");
        }

        // Check if the number is zero
        try
        {
            ArgumentOutOfRangeException.ThrowIfZero(someNumber, nameof(someNumber));
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"Exception caught: {ex.Message}");
        }

        // Check if the number is negative
        try
        {
            ArgumentOutOfRangeException.ThrowIfNegative(negativeCheck, nameof(negativeCheck));
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"Exception caught: {ex.Message}");
        }

        // Check if the number is greater than a specified value
        try
        {
            ArgumentOutOfRangeException.ThrowIfGreaterThan(rangeCheck, 5, nameof(rangeCheck));
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"Exception caught: {ex.Message}");
        }
    }
}