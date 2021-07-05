using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using AssignmentCStrategyDesignPattern.Models;
using AssignmentCStrategyDesignPattern.PricingStrategy.Strategies;

namespace AssignmentCStrategyDesignPattern.PricingStrategy
{
    public class PriceComputing
    {
        private IEnumerable<IProductPricing> _productPricingMethods;

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