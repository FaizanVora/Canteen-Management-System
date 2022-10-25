using Canteen_Management_System.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Canteen_Management_System.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ICustomerRepo _customerepo;

        public HomeController(ILogger<HomeController> logger, ICustomerRepo customerRepo)
        {
            _logger = logger;
            _customerepo = customerRepo;
        }
       











        public IActionResult Index()
        {
            /*string str = "name:";*/

            var model = _customerepo.GetallCustomer();
            return View(model);
        }
        public IActionResult Details(int ?id)
        {
            Customer customer = _customerepo.GetCustomerById(id ?? 1);
           /* ViewBag.Customer = customer;  */  

            return View(customer);
            

        }
        public IActionResult Alldetails()
        {

            /* ViewBag.Customer = customer;  */
            IEnumerable<Customer> list=_customerepo.GetallCustomer();
            return View(list);


        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [HttpGet]
        public IActionResult Signup()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Signup(Customer customer)
        {
          Customer customer1 = _customerepo.AddCustomer(customer);
            
            
            return RedirectToAction("details",new {id=customer1.Id});
            
        }
    }
}