namespace DemoFactoryMethod.Payment;

public class PixPayment : IPayment
{
    public IPayOutput Pay(IPayInput payInput)
    {
        // Add pay logic using PIX.
        return new PixPayOutput(payInput.OrderNumber, payInput.Price, payInput.Type);
    }
}