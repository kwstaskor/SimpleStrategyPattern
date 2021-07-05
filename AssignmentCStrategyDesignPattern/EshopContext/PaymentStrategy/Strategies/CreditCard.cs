using System;

namespace AssignmentCStrategyDesignPattern.EshopContext.PaymentStrategy.Strategies
{
    public class CreditCard : IPaymentMethod
    {
        public void Pay(decimal amount , decimal price)
        {
            Console.WriteLine(amount >= price ? $"Payment Completed {price}€ withdrawn from your credit card" : "Payment Declined");
        }
    }
}