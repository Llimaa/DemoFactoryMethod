using DemoFactoryMethod;
using DemoFactoryMethod.Payment;


// Example Use
var cardPayInput = new CardPayInput("123", "321", 100, PaymentType.Card);

IPayment payment = PaymentFactoryMethod.InitializePayment(cardPayInput.Type);

IPayOutput payOutputModel = payment.Pay(cardPayInput);
Console.WriteLine(payOutputModel.TransactionId);
