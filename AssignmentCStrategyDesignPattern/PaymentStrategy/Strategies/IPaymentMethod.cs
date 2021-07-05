namespace AssignmentCStrategyDesignPattern.PaymentStrategy.Strategies
{
    public interface IPaymentMethod
    {
        void Pay(decimal amount, decimal price);
    }
}