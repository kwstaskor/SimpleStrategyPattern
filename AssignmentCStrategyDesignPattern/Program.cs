using System;
using System.Collections.Generic;
using AssignmentCStrategyDesignPattern.Models;
using AssignmentCStrategyDesignPattern.PaymentStrategy;
using AssignmentCStrategyDesignPattern.PaymentStrategy.Strategies;
using AssignmentCStrategyDesignPattern.PricingStrategy;
using AssignmentCStrategyDesignPattern.PricingStrategy.Strategies;

namespace AssignmentCStrategyDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pricing Strategy
            var tshirt = new Tshirt(Color.Red, Size.S, Fabric.Cotton);

            var priceComputing = new PriceComputing();
            priceComputing.SetPricingFactor(new List<IProductPricing>
            {
                new PriceByColor() , new PriceByFabric() , new PriceBySize()
            });

            tshirt.Price = priceComputing.ComputePrice(tshirt);

            Console.WriteLine($"T-shirt with {tshirt.Color} color, {tshirt.Fabric} fabric , {tshirt.Size} size costs : {tshirt.Price} ");

            Console.WriteLine("---------------------------------------");

            //Payment Strategy
            var shop = new Shop();
            shop.ChoosePaymentMethod(new CreditCard());
            shop.BuyProduct(tshirt.Price , tshirt.Price);

        }
    }
}
