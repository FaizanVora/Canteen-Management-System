namespace Canteen_Management_System.Models
{
    public class SqlCustomerRepo : ICustomerRepo
    {
        private readonly AppDbContext context;

        public SqlCustomerRepo(AppDbContext context)
        {
            this.context = context;
        }
        public Customer AddCustomer(Customer customer)
        {
            context.Customers.Add(customer);
            context.SaveChanges();
            return customer;
        }

        public Customer DeleteCustomer(int id)
        {
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            Customer customer=context.Customers.Find(id);
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            if (customer!=null)
            {
                context.Remove(customer);
            }
            context.SaveChanges();
#pragma warning disable CS8603 // Possible null reference return.
            return customer;
#pragma warning restore CS8603 // Possible null reference return.
        }

        public IEnumerable<Customer> GetallCustomer()
        {
            return context.Customers;
        }

        public Customer GetCustomerById(int id)
        {
#pragma warning disable CS8603 // Possible null reference return.
            return context.Customers.Find(id);
#pragma warning restore CS8603 // Possible null reference return.
        }

        public Customer UpdateCustomer(Customer customerchange)
        {
         var customer= context.Customers.Attach(customerchange);
            customer.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return customerchange;
        }
    }
}
