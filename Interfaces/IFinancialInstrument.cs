namespace FinancialInstrument.Interfaces
{
    public interface IFinancialInstrument
    {
        Guid InstrumentGuid { get;}
        decimal MarketValue { get; }
        string Type { get; }
    }
}