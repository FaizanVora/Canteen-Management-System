namespace Canteen_Management_System.Models
{
    public class cart
    {public DateTime? Created { get; set; }
     public Customer Customer { get; set; }
    public List<Order> Orders { get; set; }

    }
}
