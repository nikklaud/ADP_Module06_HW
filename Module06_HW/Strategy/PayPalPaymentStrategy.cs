namespace Module06_HW.Strategy;

public class PayPalPaymentStrategy: IPaymentStrategy
{
    public decimal Pay(decimal amount)
    {
        Console.WriteLine($"PayPal payment {amount}");
        return amount;
    }
}