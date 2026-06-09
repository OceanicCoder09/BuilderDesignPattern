namespace ObserverPattern.Observers
{
    public class MobileApp : IObserver
    {
        private readonly string _userName;

        public MobileApp(string userName)
        {
            _userName = userName;
        }

        public void Update(string stockName, double price)
        {
            Console.WriteLine(
                $"Mobile App [{_userName}] -> {stockName} price updated to ₹{price}");
        }
    }
}