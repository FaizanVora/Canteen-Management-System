namespace Canteen_Management_System.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        public int Orderprice { get; set; }
        public string Orderphoto { get; set; }
        public string Ordername { get; set; }
        public string VegOrNonveg { get; set; }
        public int SelectCount { get; set; }

    }
}