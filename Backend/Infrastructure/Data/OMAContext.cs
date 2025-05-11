using Core.Entities;
using Core.Enums;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class OMAContext : DbContext
    {

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Address> Addresses { get; set; }

        public OMAContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(
            new Customer
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                ContactNumber = "1234567890",
                Email = "marcos@aol.com",
                IsDeleted = false,
            },
            new Customer
            {
                Id = 2,
                FirstName = "Simone",
                LastName = "Ribeiro",
                ContactNumber = "21999998838",
                Email = "arq.simoneribeiro@gmail.com",
                IsDeleted = false,
            }
            );

            modelBuilder.Entity<Address>().HasData(
                new Address
                {
                    Id = 1,
                    CustomerId = 1,
                    AddressLine1 = "Rua 07 de Setembro, 212",
                    AddressLine2 = "Centro",
                    City = "Ourinhos",
                    State = "SP",
                    Country = "Brasil",


                },

                 new Address
                 {
                     Id = 2,
                     CustomerId = 2,
                     AddressLine1 = "Rua Sá Carvalho, 250 - Apto. 07 - Bl. 02",
                     AddressLine2 = "Brasilandia",
                     City = "Rio de Janeiro",
                     State = "RJ",
                     Country = "Brasil",


                 });

            modelBuilder.Entity<Order>().HasData(
                new Order
                {
                    Id = 1,
                    CustomerId = 1,
                    OrderDate = DateTime.Now.AddDays(-10),
                    Description = "Primeiro pedido referente a novos produtos",
                    TotalAmount = 150,
                    DepositAmount = 50,
                    IsDelivery = false,
                    Status = Status.Pending,
                    OtherNotes = "First order",
                    IsDeleted = false,
                },
                new Order
                {
                    Id = 2,
                    CustomerId = 2,
                    OrderDate = DateTime.Now.AddDays(-10),
                    Description = "Compra de prendedores com elastico",
                    TotalAmount = 450,
                    DepositAmount = 500,
                    IsDelivery = true,
                    Status = Status.Completed,
                    OtherNotes = "First order",
                    IsDeleted = false,
                }

                );
        }
    }
}
