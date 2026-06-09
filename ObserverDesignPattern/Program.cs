using ObserverPattern.Observers;
using ObserverPattern.Subjects;

namespace ObserverPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stock reliance = new Stock("Reliance");

            IObserver mobileApp =
                new MobileApp("Ashish");

            IObserver emailAlert =
                new EmailAlert("ashish@gmail.com");

            IObserver dashboard =
                new TradingDashboard();

            reliance.RegisterObserver(mobileApp);
            reliance.RegisterObserver(emailAlert);
            reliance.RegisterObserver(dashboard);

            Console.WriteLine("Price changed to 2500");
            reliance.SetPrice(2500);

            Console.WriteLine();

            Console.WriteLine("Price changed to 2600");
            reliance.SetPrice(2600);
        }
    }
}