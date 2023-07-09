using DemoFactoryMethod.Payment;

namespace DemoFactoryMethod;

public static class PaymentFactoryMethod
{
    public static IPayment InitializePayment(PaymentType type) 
    {
        IPayment payment = type switch
        {
            var _type when _type == PaymentType.Pix => new PixPayment(),
            var _type when _type == PaymentType.Card => new CardPayment(),
            _ => new PixPayment(),
        };

        return payment;
    }
}
