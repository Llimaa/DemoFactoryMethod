namespace DemoFactoryMethod.Payment;

public class CardPayment : IPayment
{
    public IPayOutput Pay(IPayInput payInput)
    {
        // Add pay logic using Card.
        return new CardPayOutput(payInput.OrderNumber, payInput.Price, PaymentType.Card);
    }
}