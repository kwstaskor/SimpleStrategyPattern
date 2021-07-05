using System.Collections.Generic;
using AssignmentCStrategyDesignPattern.EshopContext.PricingStrategy.Strategies;
using AssignmentCStrategyDesignPattern.Models;

namespace AssignmentCStrategyDesignPattern.EshopContext.PricingStrategy
{
    public interface IPriceComputing
    {
        void SetPricingFactor(IEnumerable<IProductPricing> productPricingMethod);
        decimal ComputePrice(Tshirt tshirt);
    }
}