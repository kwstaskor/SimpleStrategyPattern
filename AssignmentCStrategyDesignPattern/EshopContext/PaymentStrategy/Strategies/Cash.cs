using System;

namespace AssignmentCStrategyDesignPattern.EshopContext.PaymentStrategy.Strategies
{
    public class Cash : IPaymentMethod
    {
        public void Pay(decimal amount , decimal price)
        {
            Console.WriteLine(amount >= price ? "Payment Completed !" : "Payment Declined");
        }
    }
}