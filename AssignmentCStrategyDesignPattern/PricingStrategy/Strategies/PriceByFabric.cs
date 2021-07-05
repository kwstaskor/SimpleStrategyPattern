using AssignmentCStrategyDesignPattern.Models;

namespace AssignmentCStrategyDesignPattern.PricingStrategy.Strategies
{
    public class PriceByFabric : IProductPricing
    {
        private decimal price;
        public decimal ComputeTshirtPrice(Tshirt tshirt)
        {
            price += tshirt.Price;
            switch (tshirt.Fabric)
            {
                case Fabric.Wool: return price + 10m;
                case Fabric.Cotton: return price + 11m;
                case Fabric.Polyester: return price + 12m;
                case Fabric.Rayon: return price + 13m;
                case Fabric.Linen: return price + 14m;
                case Fabric.Cashmere: return price + 15m;
                case Fabric.Silk: return price + 16m;
                default: return price = 0;
            }
        }
    }
}