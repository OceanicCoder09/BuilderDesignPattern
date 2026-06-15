using System;

class Program
{
    static void Main()
    {
        IPayment payment;

        payment = new PhonePeAdapter();
        payment.Pay(500);

        payment = new GooglePayAdapter();
        payment.Pay(1000);
    }
}