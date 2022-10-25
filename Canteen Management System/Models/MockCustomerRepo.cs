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
           Customer customer= _list.FirstOrDefault(emp => emp.Id == id);
            if (customer!=null)
            {
                _list.Remove(customer);
            }
            return customer;
        }

        public IEnumerable<Customer> GetallCustomer()
        {
            return _list;
        }

        public Customer GetCustomerById(int id)
        {
            return _list.FirstOrDefault(cus => cus.Id == id);
        }

        public Customer UpdateCustomer(Customer customerchanges)
        {
            Customer customer = _list.FirstOrDefault(emp => emp.Id == customerchanges.Id);
            if (customer != null)
            {
               customer.Id = customerchanges.Id;    
               customer.Name = customerchanges.Name;   
               customer.Email = customerchanges.Email; 
            }
            return customer;
        }
    }
}
