using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using AssignmentCStrategyDesignPattern.EshopContext.PaymentStrategy;
using AssignmentCStrategyDesignPattern.EshopContext.PaymentStrategy.Strategies;
using AssignmentCStrategyDesignPattern.EshopContext.PricingStrategy;
using AssignmentCStrategyDesignPattern.EshopContext.PricingStrategy.Strategies;
using AssignmentCStrategyDesignPattern.Models;

namespace AssignmentCStrategyDesignPattern.EshopContext
{
    public class Shop : IPriceComputing, IShop
    {
        private IPaymentMethod _paymentMethod;
        private IEnumerable<IProductPricing> _productPricingMethods;

        public void ChoosePaymentMethod(IPaymentMethod paymentMethod)
        {
            _paymentMethod = paymentMethod;
        }

        public void BuyProduct(decimal amount, decimal price)
        {
            Console.WriteLine("Please Wait your order is processing.....");
            Thread.Sleep(3000);
            _paymentMethod.Pay(amount, price);
        }

        public void SetPricingFactor(IEnumerable<IProductPricing> productPricingMethod)
        {
            _productPricingMethods = productPricingMethod;
        }

        public decimal ComputePrice(Tshirt tshirt)
        {
            Console.WriteLine("Computing Price.....Please Wait......");
            Thread.Sleep(5000);
            return _productPricingMethods.Sum(pr => pr.ComputeTshirtPrice(tshirt));
        }
    }
}
