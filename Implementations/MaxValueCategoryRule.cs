using FinancialInstrument.Interfaces;

namespace FinancialInstrument.Implementations
{
    public class MaxValueCategoryRule : ICategoryRule
    {
        public string Category { get; }
        private decimal MaxMarketValue { get; }

        public MaxValueCategoryRule(string category, decimal maxMarketValue)
        {
            Category = category;
            MaxMarketValue = maxMarketValue;
        }

        public bool IsSatisfiedBy(IFinancialInstrument financialInstrument)
        {
            return financialInstrument.MarketValue <= MaxMarketValue;
        }
    }
}
