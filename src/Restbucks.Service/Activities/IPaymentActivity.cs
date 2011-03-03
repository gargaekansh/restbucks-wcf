using Restbucks.Service.Representations;

namespace Restbucks.Service.Activities
{
    public interface IPaymentActivity
    {
        PaymentRepresentation Pay(int orderId, PaymentRepresentation paymentRepresentation, string baseUri);
    }
}