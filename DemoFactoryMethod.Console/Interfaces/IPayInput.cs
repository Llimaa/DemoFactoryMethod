namespace DemoFactoryMethod;

public interface IPayInput
{    
    public string OrderNumber { get; set; }
    public decimal Price { get; set; }
    public PaymentType Type { get; set; }
}