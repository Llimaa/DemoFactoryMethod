using DemoFactoryMethod.Payment;
using Shouldly;

namespace DemoFactoryMethod.Tests;

public class PixPaymentTests
{
    [Fact]
    public void Pay_Should_Be_Success()
    {
        // Arrange
        var input = new PixPayInput("lima@gmail.com", "321123", 150, PaymentType.Pix);

        
        //FactorMethod call
        IPayment payment = PaymentFactoryMethod.InitializePayment(input.Type);

        // Act
        var result = payment.Pay(input);

        // Assert
        result.ShouldNotBeNull();
        result.Type.ShouldBe(PaymentType.Pix);
    }
}