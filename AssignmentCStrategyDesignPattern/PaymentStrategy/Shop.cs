using System;
using System.Threading;
using AssignmentCStrategyDesignPattern.PaymentStrategy.Strategies;

namespace AssignmentCStrategyDesignPattern.PaymentStrategy
{
    public class Shop
    {
        private IPaymentMethod _paymentMethod;

        public void ChoosePaymentMethod(IPaymentMethod paymentMethod)
        {
            _paymentMethod = paymentMethod;
        }

        public void BuyProduct(decimal amount , decimal price)
        {
            Thread.Sleep(3000);
            Console.WriteLine("Please Wait your order is processing.....");
            _paymentMethod.Pay(amount, price);
        }
    }
}