using AdaTech.AdaShop.Domain.Contracts;

namespace AdaTech.AdaShop.Domain.Models.Order
{
    public class Product : IEntity
    {
        public Product(string name, decimal price, string? description)
        {
            ID = Guid.NewGuid().ToString();
            Name = name;
            Price = price;
            Description = description;
        }

        public string ID { get; private set; }
        public string Name { get; private set; }
        public decimal Price { get; private set; }
        public string? Description { get; set; }
    }
}