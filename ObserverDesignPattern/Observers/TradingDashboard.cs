namespace ObserverPattern.Observers
{
    public class TradingDashboard : IObserver
    {
        public void Update(string stockName, double price)
        {
            Console.WriteLine(
                $"Dashboard Updated -> {stockName}: ₹{price}");
        }
    }
}