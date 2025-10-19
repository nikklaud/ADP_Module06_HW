namespace Module06_HW.Strategy;

public interface IPaymentStrategy
{
    decimal Pay(decimal amount);
}