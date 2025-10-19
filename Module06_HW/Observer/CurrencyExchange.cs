namespace Module06_HW.Observer;

class CurrencyExchange : ISubject
{
    private List<IObserver> _observers = new List<IObserver>();
    private decimal _usdRate;

    public void SetUsdRate(decimal newRate)
    {
        if (_usdRate != newRate)
        {
            _usdRate = newRate;
            Console.WriteLine($"USD rate updated: {_usdRate}");
            Notify();
        }
    }

    public void Attach(IObserver observer)
    {
        _observers.Add(observer);
        Console.WriteLine("Added new observer.");
    }

    public void Detach(IObserver observer)
    {
        _observers.Remove(observer);
        Console.WriteLine("Removed an observer.");
    }

    public void Notify()
    {
        Console.WriteLine("Notifying observers...");
        foreach (var observer in _observers)
        {
            observer.Update(_usdRate);
        }
    }
}