namespace Canteen_Management_System.Models
{
    public class MockCustomerRepo : ICustomerRepo
    {   List<Customer> _list;
        public MockCustomerRepo()
        {
            _list = new List<Customer>()
            {
                new Customer(){Id=1,Name="faizan",Email="faizan@gmail.com",Password="123456"},
                new Customer(){Id=2,Name="Khushal",Email="Khushal@gmail.com",Password="123456"}
            };
              
        }

        public Customer AddCustomer(Customer customer)
        {   customer.Id=_list.Max(x => x.Id)+1;
            _list.Add(customer);
            Console.WriteLine(_list);
            return customer;
        }

        public Customer DeleteCustomer(int id)
        {
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
           Customer customer= _list.FirstOrDefault(emp => emp.Id == id);
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            if (customer!=null)
            {
                _list.Remove(customer);
            }
#pragma warning disable CS8603 // Possible null reference return.
            return customer;
#pragma warning restore CS8603 // Possible null reference return.
        }

        public IEnumerable<Customer> GetallCustomer()
        {
            return _list;
        }

        public Customer GetCustomerById(int id)
        {
#pragma warning disable CS8603 // Possible null reference return.
            return _list.FirstOrDefault(cus => cus.Id == id);
#pragma warning restore CS8603 // Possible null reference return.
        }

        public Customer UpdateCustomer(Customer customerchanges)
        {
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            Customer customer = _list.FirstOrDefault(emp => emp.Id == customerchanges.Id);
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            if (customer != null)
            {
               customer.Id = customerchanges.Id;    
               customer.Name = customerchanges.Name;   
               customer.Email = customerchanges.Email; 
            }
#pragma warning disable CS8603 // Possible null reference return.
            return customer;
#pragma warning restore CS8603 // Possible null reference return.
        }
    }
}
