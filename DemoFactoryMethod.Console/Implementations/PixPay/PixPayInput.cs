namespace DemoFactoryMethod.Payment;

public class PixPayInput : IPayInput
{
    public PixPayInput(string key, string orderNumber, decimal price, PaymentType type)
    {
        Key = key;
        OrderNumber = orderNumber;
        Price = price;
        Type = type;
    }

    public string Key { get; set; } = null!;
    public string OrderNumber { get; set;  } = null!;
    public decimal Price { get; set;  }
    public PaymentType Type { get; set;  }
}