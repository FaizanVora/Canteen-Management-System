using System.ComponentModel.DataAnnotations.Schema;

namespace Canteen_Management_System.Models
{
    public class cart
    {
        public int cartId { get; set; }
        public DateTime? Created { get; set; }
        


        [ForeignKey ("OrderId")]
        public Order Order { get; set; }


        [ForeignKey ("Id")]
        public Customer Customer { get; set; }
        

        public int discount { get; set; }  
        

    }
}
