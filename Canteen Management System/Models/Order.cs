namespace Canteen_Management_System.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        public int Orderprice { get; set; }
#pragma warning disable CS8618 // Non-nullable property 'Orderphoto' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public string Orderphoto { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'Orderphoto' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
#pragma warning disable CS8618 // Non-nullable property 'Ordername' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public string Ordername { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'Ordername' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
#pragma warning disable CS8618 // Non-nullable property 'VegOrNonveg' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public string VegOrNonveg { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'VegOrNonveg' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public int SelectCount { get; set; }

    }
}