using FinancialInstrument.Interfaces;

namespace FinancialInstrument.Implementations
{
    public class MediumValueRule : ICategoryRule
    {
        public string Category => "Medium Value";

        public bool IsSatisfiedBy(IFinancialInstrument financialInstrument)
        {
            return financialInstrument.MarketValue >= 1000000 && financialInstrument.MarketValue <= 5000000;
        }
    }
}
