using Core.Entities;
using Core.Interfaces;
using HotChocolate;
using HotChocolate.Data;
using System.Linq;

namespace API.GraphQL
{
    public class Query
    {
        [UseFiltering]
        public IQueryable<Customer> GetCustomers([Service] ICustomerService customerService)
        {
            return customerService.GetCustomersAndOrders();

        }
        [UseFiltering]
        public IQueryable<Order> GetOrders([Service] IOrderService orderService)
        {
            return orderService.GetOrders();

        }
    }
}
