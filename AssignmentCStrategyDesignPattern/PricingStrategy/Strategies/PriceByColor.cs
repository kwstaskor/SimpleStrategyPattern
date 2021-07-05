using AssignmentCStrategyDesignPattern.Models;

namespace AssignmentCStrategyDesignPattern.PricingStrategy.Strategies
{
    public class PriceByColor : IProductPricing
    {
        private decimal price;
        public decimal ComputeTshirtPrice(Tshirt tshirt)
        {
            price += tshirt.Price;
            switch (tshirt.Color)
            {
                case Color.Blue: return price + 10;
                case Color.Green: return price + 11;
                case Color.Indigo: return price + 12;
                case Color.Orange: return price + 13;
                case Color.Red: return price + 14 ;
                case Color.Violet: return price + 15;
                case Color.Yellow: return price + 16;
                default: return price = 0;
            }
        }
    }
}