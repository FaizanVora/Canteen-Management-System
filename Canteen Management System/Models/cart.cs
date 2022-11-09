namespace Canteen_Management_System.Models
{
    public class cart
    {
        public int cartId { get; set; }
        public DateTime? Created { get; set; }
        
        public Customer customers { get; set; }

        

        

        public int discount { get; set; }  
        

    }
}
