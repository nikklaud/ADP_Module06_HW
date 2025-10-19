namespace Module06_HW.Strategy;

public class PaymnetContext
{
    private IPaymentStrategy? _strategy;
    
    public void SetPaymentStrategy(IPaymentStrategy? strategy)
    {
        _strategy = strategy;
    }

    public decimal Pay(decimal amount)
    {
        if (_strategy != null)
        {
            return _strategy.Pay(amount);
        }
        else
        {
            throw new Exception("Strategy not set");
        }
    }
}