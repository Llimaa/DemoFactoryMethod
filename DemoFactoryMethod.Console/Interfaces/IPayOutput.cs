namespace DemoFactoryMethod;

public interface IPayOutput 
{
    public string TransactionId { get; set; }
    public decimal Price { get; set; }
    public PaymentType Type { get; set; }
}
