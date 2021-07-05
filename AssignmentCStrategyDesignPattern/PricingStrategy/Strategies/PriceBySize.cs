using AssignmentCStrategyDesignPattern.Models;

namespace AssignmentCStrategyDesignPattern.PricingStrategy.Strategies
{
    public class PriceBySize : IProductPricing
    {
        private decimal price;
        public decimal ComputeTshirtPrice(Tshirt tshirt)
        {
            switch (tshirt.Size)
            {
                case Size.Xs: return price + 10m;
                case Size.S: return price + 11m ;
                case Size.M: return price + 12m ;
                case Size.L: return price + 13m ;
                case Size.Xl: return price + 14m;
                case Size.Xxl: return price + 15m;
                case Size.Xxxl: return price + 16m;
                default: return price = 0;
            }
        }
    }
}