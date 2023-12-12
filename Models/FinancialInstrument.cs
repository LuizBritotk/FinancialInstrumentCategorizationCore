// File: Models/FinancialInstrument.cs

using System;
using FinancialInstrument.Interfaces;


namespace FinancialInstrument.Models
{
    public class FinancialInstrument : IFinancialInstrument
    {
        public Guid InstrumentGuid { get; }
        public string Type { get; }
        public decimal MarketValue { get; }

        public FinancialInstrument(Guid instrumentGuid, string type, decimal marketValue)
        {
            ValidateType(type);
            ValidateMarketValue(marketValue);

            InstrumentGuid = instrumentGuid;
            Type = type;
            MarketValue = marketValue;
        }

        private void ValidateType(string type)
        {
            if (string.IsNullOrWhiteSpace(type))
            {
                throw new ArgumentException("Instrument type cannot be null or empty.", nameof(type));
            }
        }

        private void ValidateMarketValue(decimal marketValue)
        {
            if (marketValue < 0)
            {
                throw new ArgumentException("Market value cannot be negative.", nameof(marketValue));
            }
        }

        public override string ToString()
        {
            return $"InstrumentGuid: {InstrumentGuid}, Type: {Type}, MarketValue: {MarketValue:C}";
        }
    }
}

