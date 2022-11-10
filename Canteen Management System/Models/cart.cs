namespace Canteen_Management_System.Models
{
    public class cart
    {
        public int CartId { get; set; }
        public string CustomerName { get; set; }
        public string OrderName { get; set; }
        public int Price { get; set; }
        public int Discount { get; set;}
        public DateTime? BillingDate { get; set; }
    }
}
