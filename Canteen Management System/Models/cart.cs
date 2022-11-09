using System.ComponentModel.DataAnnotations.Schema;

namespace Canteen_Management_System.Models
{
    public class cart
    {
        public int cartId { get; set; }
        public DateTime? billingTime { get; set; }
        
        public string CustomerName { get; set; }
        public int price { get; set; }
        public string  OrderName { get; set; }

        public int discount { get; set; }  
        

    }
}
