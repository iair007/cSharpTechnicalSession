using System.Linq;

namespace cSharpPresentation;

internal class LinQExample
{
    internal static void Run()
    {
        var sales = new[]
            {
                new { Product = "A", Amount = 100 },
                new { Product = "B", Amount = 200 },
                new { Product = "A", Amount = 150 },
                new { Product = "A", Amount = 33 },
                new { Product = "B", Amount = 100 }
            };

        //using groupby and Select
        var totalSales = sales
            .GroupBy(sale => sale.Product)
            .Select(group => new
            {
                Product = group.Key,
                TotalAmount = group.Sum(sale => sale.Amount)
            });

        foreach (var sale in totalSales)
        {
            Console.WriteLine($"Product: {sale.Product}, Total Amount: {sale.TotalAmount}");
        }

        //using AggregateBy
        var totalSalesWithAggregateBy = sales.AggregateBy(
                                                    sale => sale.Product,
                                                    0,
                                                    (total, sale) => total + sale.Amount
                                                );

        foreach (var sale in totalSalesWithAggregateBy)
        {
            Console.WriteLine($"Product: {sale.Key}, Total Amount: {sale.Value}");
        }
    }

    internal static void RunCountBy()
    {
        string message = "welcomeWizardssssssssS";
        var characterOccurrences = message
            .GroupBy(c => c)
            .Select(g => new { Character = g.Key, Count = g.Count() });

        foreach (var occurrence in characterOccurrences)
        {
            Console.WriteLine($"Character: {occurrence.Character}, Count: {occurrence.Count}");
        }
        Console.WriteLine("****************************************");
        var characterOccurrencesCountBy = message.CountBy(c => c);

        foreach (var occurrence in characterOccurrencesCountBy)
        {
            Console.WriteLine($"Character: {occurrence.Key}, Count: {occurrence.Value}");
        }
    }
}

