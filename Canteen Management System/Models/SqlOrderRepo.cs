using Canteen_Management_System.Models.DbModel;

namespace Canteen_Management_System.Models
{
    public class SqlOrderRepo
    {
        private readonly AppDbContext context;

        public SqlOrderRepo(AppDbContext context)
        {
            this.context = context;
        }
        public Order AddOrder(Order Order)
        {
            context.Orders.Add(Order);
            context.SaveChanges();
            return Order;
        }

        public Order DeleteOrder(int id)
        {
            Order Order = context.Orders.Find(id);
            if (Order != null)
            {
                context.Remove(Order);
            }
            context.SaveChanges();
            return Order;
        }

        public IEnumerable<Order> GetallOrder()
        {
            return context.Orders;
        }

        public Order GetOrderById(int id)
        {
            return context.Orders.Find(id);
        }

        public Order UpdateOrder(Order Orderchange)
        {
            var Order = context.Orders.Attach(Orderchange);
            Order.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return Orderchange;
        }
    }
}
