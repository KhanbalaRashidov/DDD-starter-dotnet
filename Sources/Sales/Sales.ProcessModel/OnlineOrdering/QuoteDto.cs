namespace MyCompany.ECommerce.Sales.OnlineOrdering;

public readonly struct QuoteDto(Guid productId, int amount, decimal price, string currencyCode)
{
    public Guid ProductId { get; } = productId;
    public int Amount { get; } = amount;
    public decimal Price { get; } = price;
    public string CurrencyCode { get; } = currencyCode;
}