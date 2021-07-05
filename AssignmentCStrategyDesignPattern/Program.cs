using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using AssignmentCStrategyDesignPattern.EshopContext;
using AssignmentCStrategyDesignPattern.EshopContext.PaymentStrategy.Strategies;
using AssignmentCStrategyDesignPattern.EshopContext.PricingStrategy.Strategies;
using AssignmentCStrategyDesignPattern.Models;

namespace AssignmentCStrategyDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello Client! Create TShirt!!\n");
           
            var colorInput = ColorInput();

            var fabricInput = FabricInput();

            var sizeInput = SizeInput();

            var tshirt = new Tshirt((Color)colorInput, (Size)sizeInput, (Fabric)fabricInput);

            var shop = new Shop();
            
            PricingStrategy(shop, tshirt);

            var iPaymentMethod = PaymentStrategy();

            shop.ChoosePaymentMethod(iPaymentMethod);
            
            shop.BuyProduct(100, tshirt.Price);
        }

        private static IPaymentMethod PaymentStrategy()
        {
            //Payment Strategy
            Console.WriteLine("Choose Payment Method");

            Console.WriteLine("1    CreditCard");
            Console.WriteLine("2    BankTransfer");
            Console.WriteLine("3    Cash");

            var paymentMethod = Console.ReadLine();

            IPaymentMethod iPaymentMethod;

            switch (paymentMethod)
            {
                case "1":
                    iPaymentMethod = new CreditCard();
                    break;
                case "2":
                    iPaymentMethod = new BankTransfer();
                    break;
                case "3":
                    iPaymentMethod = new Cash();
                    break;
                default:
                    iPaymentMethod = new CreditCard();
                    break;
            }

            return iPaymentMethod;
        }

        private static void PricingStrategy(Shop shop, Tshirt tshirt)
        {
            shop.SetPricingFactor(new List<IProductPricing>
            {
                new PriceByColor(), new PriceByFabric(), new PriceBySize()
            });

            tshirt.Price = shop.ComputePrice(tshirt);

            Console.WriteLine(
                $"T-shirt with {tshirt.Color} color, {tshirt.Fabric} fabric , {tshirt.Size} size costs : {tshirt.Price} ");
            Console.WriteLine("---------------------------------------");
        }

        private static int SizeInput()
        {
            Console.WriteLine("Choose Size");

            var sizes = Enum.GetNames((typeof(Size)));
            for (var i = 0; i < sizes.Length; i++)
            {
                Console.WriteLine($"{i,-5} {sizes[i]}");
            }

            var sizeInput = Convert.ToInt32(Console.ReadLine());
            return sizeInput;
        }

        private static int FabricInput()
        {
            Console.WriteLine("Choose Fabric");

            var fabrics = Enum.GetNames((typeof(Fabric)));
            for (var i = 0; i < fabrics.Length; i++)
            {
                Console.WriteLine($"{i,-5} {fabrics[i]}");
            }
            var fabricInput = Convert.ToInt32(Console.ReadLine());
            return fabricInput;
        }

        private static int ColorInput()
        {
            Console.WriteLine("Choose Color");
            var colors = Enum.GetNames((typeof(Color)));
            for (var i = 0; i < colors.Length; i++)
            {
                Console.WriteLine($"{i,-5} {colors[i]}");
            }

            var colorInput = Convert.ToInt32(Console.ReadLine());
            return colorInput;
        }
    }
}
