using DemoFactoryMethod.Payment;
using Shouldly;

namespace DemoFactoryMethod.Tests;

public class CardPaymentTests
{
    [Fact]
    public void Pay_Should_Be_Success()
    {
        // Arrange
        var input = new CardPayInput("123321", "321123", 150, PaymentType.Card);

        
        //FactorMethod call
        IPayment payment = PaymentFactoryMethod.InitializePayment(input.Type);

        // Act
        var result = payment.Pay(input);

        // Assert
        result.ShouldNotBeNull();
        result.Type.ShouldBe(PaymentType.Card);



    }
}