namespace DemoFactoryMethod.Payment;

public class PixPayOutput : IPayOutput
{
    public PixPayOutput(string transactionId, decimal price, PaymentType type)
    {
        TransactionId = transactionId;
        Price = price;
        Type = type;
    }

    public string TransactionId { get; set; } = null!;
    public decimal Price { get; set; }
    public PaymentType Type { get; set; }
}