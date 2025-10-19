namespace Module06_HW.Strategy;

public class CriptoPaymentStrategy:  IPaymentStrategy
{
    public decimal Pay(decimal amount)
    {
        Console.WriteLine($"Cripto payment {amount}");
        return amount;
    }
}