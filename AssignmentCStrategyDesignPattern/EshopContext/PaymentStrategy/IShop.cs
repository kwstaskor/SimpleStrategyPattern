using AssignmentCStrategyDesignPattern.EshopContext.PaymentStrategy.Strategies;

namespace AssignmentCStrategyDesignPattern.EshopContext.PaymentStrategy
{
    public interface IShop
    {
        void ChoosePaymentMethod(IPaymentMethod paymentMethod);
        void BuyProduct(decimal amount , decimal price);
    }

   
}