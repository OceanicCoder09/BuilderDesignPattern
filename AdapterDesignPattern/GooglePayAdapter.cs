public class GooglePayAdapter : IPayment
{
    private readonly GooglePay googlePay;

    public GooglePayAdapter()
    {
        googlePay = new GooglePay();
    }

    public void Pay(double amount)
    {
        googlePay.Transfer(amount);
    }
}