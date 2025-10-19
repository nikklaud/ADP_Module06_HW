namespace Module06_HW.Observer;

class Investor : IObserver
{
    private string _name;
    public Investor(string name) { _name = name; }
    public void Update(decimal usdRate)
    {
        if (usdRate > 450)
            Console.WriteLine($"Investor {_name} USD is high ({usdRate}). Selling dollars.");
        else
            Console.WriteLine($"Investor {_name} USD is low ({usdRate}). Buying dollars.");
    }
}