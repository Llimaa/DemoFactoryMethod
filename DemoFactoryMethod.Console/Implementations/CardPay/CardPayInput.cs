namespace DemoFactoryMethod.Payment;

public class CardPayInput : IPayInput
{
    public CardPayInput(string cardNumber, string orderNumber, decimal price, PaymentType type)
    {
        CardNumber = cardNumber;
        OrderNumber = orderNumber;
        Price = price;
        Type = type;
    }

    public string CardNumber { get; set; } = null!;
    public string OrderNumber { get; set;  } = null!;
    public decimal Price { get; set;  }
    public PaymentType Type { get; set;  }
}