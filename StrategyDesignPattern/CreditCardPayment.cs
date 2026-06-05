using System;

public class CreditCardPayment : IPaymentStrategy
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"₹{amount} paid using Credit Card");
    }
}