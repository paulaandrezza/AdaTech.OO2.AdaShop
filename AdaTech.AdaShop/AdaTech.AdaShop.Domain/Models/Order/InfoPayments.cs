using AdaTech.AdaShop.Domain.Models.Enum;

namespace AdaTech.AdaShop.Domain.Models.Order
{
    public class InfoPayments
    {
        public string ID { get; set; }
        public PaymentMethods PaymentMethod { get; set; }
        public PaymentStatus PaymentStatus { get; set; }

        public InfoPayments(PaymentMethods paymentMethod) {
            ID = Guid.NewGuid().ToString();
            PaymentMethod = paymentMethod;
            PaymentStatus = PaymentStatus.Pending;
        }
    }
}