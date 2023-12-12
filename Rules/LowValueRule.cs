using FinancialInstrument.Interfaces;

namespace FinancialInstrument.Implementations
{
    public class LowValueRule : ICategoryRule
    {
        public string Category => "Low Value";

        public bool IsSatisfiedBy(IFinancialInstrument financialInstrument)
        {
            return financialInstrument.MarketValue < 1000000;
        }
    }
}
