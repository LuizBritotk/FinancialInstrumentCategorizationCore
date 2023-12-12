using FinancialInstrument.Interfaces;

namespace FinancialInstrument.Implementations
{
    public class MinValueCategoryRule : ICategoryRule
    {
        public string Category { get; }
        private decimal MinMarketValue { get; }

        public MinValueCategoryRule(string category, decimal minMarketValue)
        {
            Category = category;
            MinMarketValue = minMarketValue;
        }

        public bool IsSatisfiedBy(IFinancialInstrument financialInstrument)
        {
            return financialInstrument.MarketValue >= MinMarketValue;
        }
    }
}
