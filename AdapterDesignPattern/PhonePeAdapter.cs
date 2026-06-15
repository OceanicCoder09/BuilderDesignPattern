public class PhonePeAdapter : IPayment
{
    private readonly PhonePe phonePe;

    public PhonePeAdapter()
    {
        phonePe = new PhonePe();
    }

    public void Pay(double amount)
    {
        phonePe.SendMoney(amount);
    }
}