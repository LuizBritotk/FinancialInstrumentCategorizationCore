using FinancialInstrument.Implementations;
using FinancialInstrument.Interfaces;

namespace FinancialInstrument.Tests
{
    public class FinancialInstrumentCategorizerTests
    {
        [Fact]
        public void Categorize_LowValue_ShouldReturnCorrectCategory()
        {
            // Preparação
            var instrument = new FinancialInstrument.Models.FinancialInstrument(Guid.NewGuid(), "Stock", 800000);
            var rules = new List<ICategoryRule> { new LowValueRule(), new MediumValueRule(), new HighValueRule() };
            var categorizer = new FinancialInstrumentCategorizer(rules);

            // Ação
            var category = categorizer.Categorize(instrument);

            // Afirmação
            Assert.Equal("Low Value", category);
        }

        [Fact]
        public void Categorize_MediumValue_ShouldReturnCorrectCategory()
        {
            // Preparação
            var instrument = new FinancialInstrument.Models.FinancialInstrument(Guid.NewGuid(), "Bond", 2500000);
            var rules = new List<ICategoryRule> { new LowValueRule(), new MediumValueRule(), new HighValueRule() };
            var categorizer = new FinancialInstrumentCategorizer(rules);

            // Ação
            var category = categorizer.Categorize(instrument);

            // Afirmação
            Assert.Equal("Medium Value", category);
        }

        [Fact]
        public void Categorize_HighValue_ShouldReturnCorrectCategory()
        {
            // Preparação
            var instrument = new FinancialInstrument.Models.FinancialInstrument(Guid.NewGuid(), "Derivative", 7000000);
            var rules = new List<ICategoryRule> { new LowValueRule(), new MediumValueRule(), new HighValueRule() };
            var categorizer = new FinancialInstrumentCategorizer(rules);

            // Ação
            var category = categorizer.Categorize(instrument);

            // Afirmação
            Assert.Equal("High Value", category);
        }
    }
}