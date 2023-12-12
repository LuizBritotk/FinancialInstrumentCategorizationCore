// File: Models/Program.cs

using FinancialInstrument.Implementations;

class Program
{
    static void Main()
    {
        var instrument1 = new FinancialInstrument.Models.FinancialInstrument(new Guid(), "Stock", 800000);
        var instrument2 = new FinancialInstrument.Models.FinancialInstrument(new Guid(), "Bond", 2500000);
        var instrument3 = new FinancialInstrument.Models.FinancialInstrument(new Guid(), "Derivative", 7000000);

        var ruleConfigurations = new List<RuleConfiguration>
        {
            new RuleConfiguration { Category = "Low Value", MaxMarketValue = 1000000 },
            new RuleConfiguration { Category = "Medium Value", MinMarketValue = 1000000, MaxMarketValue = 5000000 },
            new RuleConfiguration { Category = "High Value", MinMarketValue = 5000000 },
        };

        var ruleLoader = new RuleLoader();
        var rules = ruleLoader.LoadRulesFromConfiguration(ruleConfigurations);

        var categorizer = new FinancialInstrumentCategorizer(rules);

        Console.WriteLine($"Instrument 1: {categorizer.Categorize(instrument1)}");
        Console.WriteLine($"Instrument 2: {categorizer.Categorize(instrument2)}");
        Console.WriteLine($"Instrument 3: {categorizer.Categorize(instrument3)}");

    }
}
