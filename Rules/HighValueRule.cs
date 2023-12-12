    using FinancialInstrument.Interfaces;

namespace FinancialInstrument.Implementations
{
    public class HighValueRule : ICategoryRule
    {
        public string Category => "High Value";

        public bool IsSatisfiedBy(IFinancialInstrument financialInstrument)
        {
            return financialInstrument.MarketValue > 5000000;
        }
    }
}
