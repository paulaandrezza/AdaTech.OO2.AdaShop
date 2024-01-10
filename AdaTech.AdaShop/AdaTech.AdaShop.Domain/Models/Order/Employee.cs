using AdaTech.AdaShop.Domain.Contracts;

namespace AdaTech.AdaShop.Domain.Models.Order
{
    //Emploee herda de uma interface IEntity, logo é obrigado a seguir o contrato de IEntity.
    //Ou seja, deve implementar os métodos e propriedade da interface IEntity
    public class Employee : IEntity, IPeople
    {
        public string ID { get; private set; }
        public string Name { get; private set; }
        public string CPF { get; private set; }
        public string Email { get; private set; }
        public string PhoneNumber { get; private set; }

        public Employee(string name, string cpf, string email, string phoneNumber)
        {
            ID = Guid.NewGuid().ToString();
            Name = name;
            CPF = cpf;
            Email = email;
            PhoneNumber = phoneNumber;
        }
    }
}