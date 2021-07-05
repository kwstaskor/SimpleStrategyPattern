namespace AssignmentCStrategyDesignPattern.EshopContext.PaymentStrategy.Strategies
{
    public interface IPaymentMethod
    {
        void Pay(decimal amount, decimal price);
    }
}