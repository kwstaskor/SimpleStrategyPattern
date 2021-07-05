using System;

namespace AssignmentCStrategyDesignPattern.PaymentStrategy.Strategies
{
    public class BankTransfer : IPaymentMethod
    {
        public void Pay(decimal amount , decimal price)
        {
            Console.WriteLine(amount >= price ? $"Payment Completed {price}€ withdrawn from your bank account !" : "Payment Declined");
        }
    }
}