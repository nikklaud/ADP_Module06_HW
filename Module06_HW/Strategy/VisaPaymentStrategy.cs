namespace Module06_HW.Strategy;

public class VisaPaymentStrategy: IPaymentStrategy
{
    public decimal Pay(decimal amount)
    {
        Console.WriteLine($"Visa payment {amount}");
        return amount;
    }
}