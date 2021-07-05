using AssignmentCStrategyDesignPattern.Models;

namespace AssignmentCStrategyDesignPattern.PricingStrategy.Strategies
{
    public interface IProductPricing
    {
        decimal ComputeTshirtPrice(Tshirt tshirt);
    }
}