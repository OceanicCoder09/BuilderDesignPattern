using ObserverPattern.Observers;

namespace ObserverPattern.Subjects
{
    public class Stock : ISubject
    {
        private readonly List<IObserver> _observers;
        private readonly string _stockName;
        private double _price;

        public Stock(string stockName)
        {
            _stockName = stockName;
            _observers = new List<IObserver>();
        }

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_stockName, _price);
            }
        }

        public void SetPrice(double price)
        {
            _price = price;
            NotifyObservers();
        }
    }
}