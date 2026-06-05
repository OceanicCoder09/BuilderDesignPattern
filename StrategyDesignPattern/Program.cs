using System;

class Program
{
    static void Main()
    {
        PaymentProcessor processor =
            new PaymentProcessor(new UpiPayment());

        processor.ProcessPayment(1000);

        processor.SetPaymentMethod(
            new CreditCardPayment());

        processor.ProcessPayment(2500);
    }
}