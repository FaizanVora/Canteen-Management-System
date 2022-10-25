namespace Canteen_Management_System.Models
{
    public interface ICustomerRepo
    {
        Customer GetCustomerById(int id);
        Customer AddCustomer(Customer customer);    
        Customer UpdateCustomer(Customer customer);
        Customer DeleteCustomer(int id);
        IEnumerable<Customer> GetallCustomer();
    }
}
