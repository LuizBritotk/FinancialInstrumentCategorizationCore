using FinancialInstrument.Interfaces;

namespace FinancialInstrument.Implementations
{
    public class RangeCategoryRule : ICategoryRule
    {
        public string Category { get; }
        private decimal MinMarketValue { get; }
        private decimal MaxMarketValue { get; }

        public RangeCategoryRule(string category, decimal minMarketValue, decimal maxMarketValue)
        {
            Category = category;
            MinMarketValue = minMarketValue;
            MaxMarketValue = maxMarketValue;
        }

        public bool IsSatisfiedBy(IFinancialInstrument financialInstrument)
        {
            return financialInstrument.MarketValue >= MinMarketValue && financialInstrument.MarketValue <= MaxMarketValue;
        }
    }
}
