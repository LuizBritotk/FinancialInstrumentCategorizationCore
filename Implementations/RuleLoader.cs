
using System.Collections.Generic;
using FinancialInstrument.Interfaces;

namespace FinancialInstrument.Implementations
{
    public class RuleLoader
    {
        public List<ICategoryRule> LoadRulesFromConfiguration(List<RuleConfiguration> ruleConfigurations)
        {
            var rules = new List<ICategoryRule>();

            foreach (var config in ruleConfigurations)
            {
                var rule = CreateRuleFromConfiguration(config);
                rules.Add(rule);
            }

            return rules;
        }

        private ICategoryRule CreateRuleFromConfiguration(RuleConfiguration config)
        {
            if (config.MinMarketValue.HasValue && config.MaxMarketValue.HasValue)
                return new RangeCategoryRule(config.Category, config.MinMarketValue.Value, config.MaxMarketValue.Value);
            else if (config.MinMarketValue.HasValue)
                return new MinValueCategoryRule(config.Category, config.MinMarketValue.Value);
            else if (config.MaxMarketValue.HasValue)
                return new MaxValueCategoryRule(config.Category, config.MaxMarketValue.Value);
            else
                return new DefaultCategoryRule(config.Category);
        }
    }
}
