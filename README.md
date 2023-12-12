# Categorização de Instrumentos Financeiros
Este projeto demonstra uma implementação simples de categorização de instrumentos financeiros com base no valor de mercado usando C# e .NET Core (8.0).

## Estrutura do Projeto
O projeto está organizado nas seguintes pastas:

 - **FinancialInstrumentCategorization** Pasta principal do projeto.
 - **Implementations**: Contém as classes de implementação.
 - **Interfaces**: Contém as interfaces para categorização de instrumentos financeiros.
 - **Models**:  Contém a classe de modelo que representa instrumentos financeiros.
 - **Rules**: Contém as regras para categorização de instrumentos financeiros.

## Classes

### FinancialInstrument
A classe `FinancialInstrument` representa um instrumento financeiro e implementa a interface IFinancialInstrument.


### FinancialInstrumentCategorizer
A classe `FinancialInstrumentCategorizer` categoriza instrumentos financeiros com base em um conjunto de regras.


### IFinancialInstrument
A interface `IFinancialInstrument` define as propriedades necessárias para um instrumento financeiro.

### ICategoryRule
A interface `ICategoryRule` define as propriedades e métodos necessários para uma regra de categoria.

## Uso

1. Crie instâncias de FinancialInstrument.
2. Crie regras de categoria (por exemplo, LowValueRule, MediumValueRule, HighValueRule).
3. Crie uma instância de FinancialInstrumentCategorizer com as regras de categoria.
4. Categorize os instrumentos financeiros usando o método Categorize.

```C#
Copy code
var instrument1 = new FinancialInstrument { Type = "Ação", MarketValue = 800000 };
var instrument2 = new FinancialInstrument { Type = "Título", MarketValue = 2500000 };
var instrument3 = new FinancialInstrument { Type = "Derivativo", MarketValue = 7000000 };

var regraBaixoValor = new LowValueRule();
var regraMedioValor = new MediumValueRule();
var regraAltoValor = new HighValueRule();

var categorizador = new FinancialInstrumentCategorizer(new List<ICategoryRule> { regraBaixoValor, regraMedioValor, regraAltoValor });

Console.WriteLine($"Instrumento 1: {categorizador.Categorize(instrument1)}");
Console.WriteLine($"Instrumento 2: {categorizador.Categorize(instrument2)}");
Console.WriteLine($"Instrumento 3: {categorizador.Categorize(instrument3)}");

# Testes Unitários
O projeto inclui testes unitários na pasta Tests. Você pode executar os testes usando um framework de teste (por exemplo, xUnit).

**Observação:** Atualmente, o projeto de teste em xUnit não esta compilando corretamente.

## Contribuições
Sinta-se à vontade para contribuir abrindo problemas ou solicitações de pull.

## Licença
Este projeto é licenciado sob a Licença MIT.
