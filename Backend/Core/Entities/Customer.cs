namespace Core.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string ContactNumber { get; set; }

        public string Email { get; set; }

        public bool IsDeleted { get; set; } = false; // 0 = not deleted, 1 = deleted

        public Address Address { get; set; }

        public ICollection<Order> Orders { get; set; }

    }
}
