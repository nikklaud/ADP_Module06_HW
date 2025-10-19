namespace Module06_HW.Observer;

class NewsAgency : IObserver
{
    public void Update(decimal usdRate)
    {
        Console.WriteLine($"Breaking news: USD exchange rate is now {usdRate}.");
    }
}