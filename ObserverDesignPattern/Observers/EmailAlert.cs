namespace ObserverPattern.Observers
{
    public class EmailAlert : IObserver
    {
        private readonly string _email;

        public EmailAlert(string email)
        {
            _email = email;
        }

        public void Update(string stockName, double price)
        {
            Console.WriteLine(
                $"Email sent to {_email}: {stockName} new price = ₹{price}");
        }
    }
}