namespace FinancialInstrument.Interfaces
{
    public interface ICategoryRule
    {
        string Category { get; }
        bool IsSatisfiedBy(IFinancialInstrument financialInstrument);
    }
}
