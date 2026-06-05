using System;

public class UpiPayment : IPaymentStrategy
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"₹{amount} paid using UPI");
    }
}