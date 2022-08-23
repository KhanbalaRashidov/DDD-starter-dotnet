using System.Threading.Tasks;
using MyCompany.Crm.TechnicalStuff.Metadata.DDD;

namespace MyCompany.Crm.Sales.Orders
{
    [DddRepository]
    public interface OrderRepository
    {
        Order New();
        Task<Order> GetBy(OrderId id);
        Task Save(Order order);
    }
}