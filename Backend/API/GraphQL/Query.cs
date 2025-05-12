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
        //public IQueryable<Customer> GetCustomers([Service] OMAContext context)
        public IQueryable<Customer> GetCustomers([Service] ICustomerService customerService)
        {
            /*context.Database.EnsureCreated();
            return context.Customers
                .Include(o => o.Orders)
                .Include(a => a.Address);*/
            return customerService.GetCustomersAndOrders();

        }
        [UseFiltering]
        //public IQueryable<Order> GetOrders([Service] OMAContext context)
        public IQueryable<Order> GetOrders([Service] IOrderService orderService)
        {
            /*context.Database.EnsureCreated();
            return context.Orders
                .Include(o => o.Customer);*/
            return orderService.GetOrders();

        }
    }
}
