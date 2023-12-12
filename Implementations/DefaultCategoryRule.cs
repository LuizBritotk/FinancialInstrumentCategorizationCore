
using FinancialInstrument.Interfaces;

namespace FinancialInstrument.Implementations
{
    public class DefaultCategoryRule : ICategoryRule
    {
        public string Category { get; }

        public DefaultCategoryRule(string category)
        {
            Category = category;
        }

        public bool IsSatisfiedBy(IFinancialInstrument financialInstrument)
        {
            return true;    
        }
    }
}
