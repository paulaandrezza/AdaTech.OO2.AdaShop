using AdaTech.AdaShop.Domain.Contracts;

namespace AdaTech.AdaShop.Domain.Models.Order
{
    public class Customer : IEntity, IPeople
    {
        public string ID { get; private set; }
        public string Name { get; private set; }
        public string CPF { get; private set; }
        public string Email { get; private set; }
        public string? PhoneNumber { get; private set; }

        public Customer(string name, string cpf, string email, string? phoneNumber) {
            ID = Guid.NewGuid().ToString();
            Name = name;
            CPF = cpf;
            Email = email;
            PhoneNumber = phoneNumber;
        }
    }
}