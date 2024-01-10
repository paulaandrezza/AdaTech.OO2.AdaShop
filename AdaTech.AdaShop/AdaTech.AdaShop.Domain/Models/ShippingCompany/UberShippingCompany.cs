
namespace AdaTech.AdaShop.Domain.Models.ShippingCompany
{
    using AdaTech.AdaShop.Domain.Contracts;
    using AdaTech.AdaShop.Domain.Models.Order;

    public class UberShippingCompany : ShippingCompany
    {
        public UberShippingCompany() : base(id: Guid.NewGuid().ToString()) { }

        public override DateTime CalculeDeliveryDate(OrderAggregate order)
        {
            return order.OrderDate.AddHours(3);
        }

        public override decimal CalculeShipping(OrderAggregate order)
        {
            throw new NotImplementedException();
        }
    }
}
