using JetBrains.Annotations;
using MyCompany.ECommerce.TechnicalStuff.Metadata;

namespace MyCompany.ECommerce.Sales.Orders;

[DataStructure]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public class OrderItemDetails
{
    public Guid ProductId { get; set; }
    public int Amount { get; set; }
    public string AmountUnit { get; set; }
    public decimal Price { get; set; }
}