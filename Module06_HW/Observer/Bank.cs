namespace Module06_HW.Observer;

class Bank : IObserver
{
    private string _name;
    public Bank(string name) { _name = name; }
    public void Update(decimal usdRate)
    {
        Console.WriteLine($"Bank {_name} Adjusting currency rates to new USD value: {usdRate}");
    }
}