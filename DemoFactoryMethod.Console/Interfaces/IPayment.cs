namespace DemoFactoryMethod;

public interface IPayment 
{
    public IPayOutput Pay(IPayInput payInput);
}
