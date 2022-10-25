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
            Customer customer=context.Customers.Find(id);
            if (customer!=null)
            {
                context.Remove(customer);
            }
            context.SaveChanges();
            return customer;
        }

        public IEnumerable<Customer> GetallCustomer()
        {
            return context.Customers;
        }

        public Customer GetCustomerById(int id)
        {
            return context.Customers.Find(id);
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
