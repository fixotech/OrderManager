using Core.Entities;

namespace Core.Interfaces
{
    public interface IOrderService
    {
        public IQueryable<Order> GetOrders();
    }
}
