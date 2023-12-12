using System.Collections.Generic;
using FinancialInstrument.Interfaces;

namespace FinancialInstrument.Implementations
{
    public class FinancialInstrumentCategorizer
    {
        private readonly List<ICategoryRule> _categoryRules;

        public FinancialInstrumentCategorizer(List<ICategoryRule> categoryRules)
        {
            _categoryRules = categoryRules;
        }

        public string Categorize(IFinancialInstrument financialInstrument)
        {
            foreach (var rule in _categoryRules)
            {
                if (rule.IsSatisfiedBy(financialInstrument))
                    return rule.Category;
            }

            return "Uncategorized";
        }
    }
}
