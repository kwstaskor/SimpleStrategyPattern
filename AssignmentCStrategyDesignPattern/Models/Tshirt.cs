namespace AssignmentCStrategyDesignPattern.Models
{
    public class Tshirt
    {
        public Color Color { get; set; }
        public Size Size { get; set; }
        public Fabric Fabric { get; set; }
        public decimal Price { get; set; }

        public Tshirt(Color color , Size size ,Fabric fabric)
        {
            Color = color;
            Size = size;
            Fabric = fabric;
        }
    }
}