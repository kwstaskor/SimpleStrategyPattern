using AssignmentCStrategyDesignPattern.Models;

namespace AssignmentCStrategyDesignPattern.EshopContext.PricingStrategy.Strategies
{
    public interface IProductPricing
    {
        decimal ComputeTshirtPrice(Tshirt tshirt);
    }
}