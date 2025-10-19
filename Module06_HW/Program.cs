using Module06_HW.Observer;
using Module06_HW.Strategy;

namespace Module06_HW;

internal class Program
{
    public static void Main(string[] args)
    {
        PaymnetContext context = new PaymnetContext();
        
        Console.WriteLine("Select payment method: 1-Paypal, 2-Visa, 3-Cripto");
        int choise =  Convert.ToInt32(Console.ReadLine());
        switch (choise)
        {
            case 1:
                context.SetPaymentStrategy(new PayPalPaymentStrategy());
                break;
            case 2:
                context.SetPaymentStrategy(new VisaPaymentStrategy());
                break;
            case 3:
                context.SetPaymentStrategy(new CriptoPaymentStrategy());
                break;
            default:
                throw new Exception("Invalid payment method");
        }
        
        Console.WriteLine("Enter amount to pay: ");
        decimal amount = decimal.Parse(Console.ReadLine()); 
        context.Pay(amount);

        CurrencyExchange exchange = new CurrencyExchange();

        IObserver bank = new Bank("Central Bank");
        IObserver investor = new Investor("Alice");
        IObserver news = new NewsAgency();

        exchange.Attach(bank);
        exchange.Attach(investor);
        exchange.Attach(news);

        exchange.SetUsdRate(445.75m);
        exchange.SetUsdRate(452.10m);

        exchange.Detach(investor);
        exchange.SetUsdRate(439.30m);
    }
}