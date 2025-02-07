﻿using Canteen_Management_System.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
#pragma warning disable CS0105 // The using directive for 'Microsoft.EntityFrameworkCore' appeared previously in this namespace
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Bcpg;
#pragma warning restore CS0105 // The using directive for 'Microsoft.EntityFrameworkCore' appeared previously in this namespace
namespace Canteen_Management_System.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ICustomerRepo _customerepo;
        private readonly AppDbContext _appDbContext;
#pragma warning disable CS0169 // The field 'HomeController.customer1' is never used
        private  Customer customer1;
#pragma warning restore CS0169 // The field 'HomeController.customer1' is never used

        /* private readonly SqlOrderRepo _orderRepo;*/

#pragma warning disable CS0169 // The field 'HomeController._signin' is never used
        private readonly SignInManager<Customer> _signin;
#pragma warning restore CS0169 // The field 'HomeController._signin' is never used

#pragma warning disable CS8618 // Non-nullable field 'customer1' must contain a non-null value when exiting constructor. Consider declaring the field as nullable.
#pragma warning disable CS8618 // Non-nullable field '_signin' must contain a non-null value when exiting constructor. Consider declaring the field as nullable.
        public HomeController(ILogger<HomeController> logger, ICustomerRepo customerRepo,
#pragma warning restore CS8618 // Non-nullable field '_signin' must contain a non-null value when exiting constructor. Consider declaring the field as nullable.
#pragma warning restore CS8618 // Non-nullable field 'customer1' must contain a non-null value when exiting constructor. Consider declaring the field as nullable.
            AppDbContext appDbContext)
        {
            _logger = logger;
            _customerepo = customerRepo;

            _appDbContext = appDbContext;

            Login();
            

            /*_signin = signin;*/
        }
        public IActionResult Payment()
        {
            return View();
        }
        public IActionResult menu()
        {
            return View();
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
        public IActionResult vieworder(int? id)
        {
            Order order = _appDbContext.Orders.Find(id);
            
            /* ViewBag.Customer = customer;  */

            return View(order);


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
        [HttpDelete]
        public IActionResult Signup(int id)
        {
            Customer customer1 = _customerepo.DeleteCustomer(id);


            return RedirectToAction("details", new { id = customer1.Id });

        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var customer = _customerepo.GetCustomerById(id);

            return View(customer);
        }


        [HttpPost]
        public IActionResult Edit(Customer customer)
        {
            Customer customer1=_customerepo.GetCustomerById(customer.Id);
            customer1.Email = customer.Email; 
            customer1.Name = customer.Name;
            customer1.Password= customer.Password;
            _customerepo.UpdateCustomer(customer1);
            
            return RedirectToAction("index", new { id = customer1.Id });

        }
        [HttpGet]
        public IActionResult Menu()
        {
            var model = _appDbContext.Orders;
            return View(model);
        }


        /*public async Task<IActionResult> Logout()
        {
            _signin.SignOutAsync();
            return RedirectToAction("index");
        }*/
        

        [HttpGet]
        public IActionResult CreateOrder() {
            return View();
                
         }
        [HttpPost]
        public IActionResult CreateOrder(Order order)
        {

            Order order1 = new Order
            {
                OrderId = order.OrderId,
                VegOrNonveg=order.VegOrNonveg,
                Ordername = order.Ordername,
                Orderphoto = order.Orderphoto,
                Orderprice = order.Orderprice,
            };

            _appDbContext.Orders.Add(order1);
            _appDbContext.SaveChanges();
            return RedirectToAction("menu");
            /*    Response.WriteAsJsonAsync(order1.Ordername);
                _appDbContext.Orders.Add(order1);
                return RedirectToAction("menu");*/



        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult>  Login(Customer customer)
        {
            if (customer != null)
            {
                var userDetails = await _appDbContext.Customers.FirstOrDefaultAsync(u => u.Email == customer.Email);
                
                var userDetails1 =await _appDbContext.Customers.FirstOrDefaultAsync(u => u.Password == customer.Password);
                if(userDetails1 == userDetails)
                {
                    /*customer1.Password = userDetails1.Password;
                    customer1.Email = userDetails1.Email;   */
                    // Response.WriteAsJsonAsync(userDetails);
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                    return RedirectToAction("edit"  , new {id = userDetails1.Id});
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                }
                
                else
                {
                    return RedirectToAction("login");
                }
                //khushal
                
                
              /*  var role = userDetails.Isadmin;
                if (role == 2)
                {
                    return RedirectToAction("Staff", "Index");
                }
                else if (role == 0)
                {
                    return RedirectToAction("Home", "Index");
                }
                else
                {
                    return RedirectToAction("Admin", "Index");
                }*/
            }
            return RedirectToAction("Index");
        }
        public IActionResult cart(cart Cart1)
        {
            /*Cart1.customers.Email = customer1.Email;
            Cart1.customers.Password = customer1.Password;*/
            var model = _appDbContext.carts;
            return View(model);
        }

        // GET: Car/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cust1 = await _appDbContext.Customers.FirstOrDefaultAsync(m => m.Id == id);
            if (cust1 == null)
            {
                return NotFound();
            }

            return View(cust1);
        }

        // POST: Car/Delete/5
        [HttpPost]
        
        public IActionResult Delete(int id)
        {
           /* var cust1 = await _appDbContext.Customers.FindAsync(id);
            _appDbContext.Customers.Remove(cust1);*/
            _customerepo.DeleteCustomer(id);
             _appDbContext.SaveChangesAsync();
            return RedirectToAction("index");
        }


/*
        
        public  IActionResult DeleteOrder(int orderId)
        {
            var order1 =  _appDbContext.Orders.Find(orderId);
            _appDbContext.Orders.Remove(order1);
            _appDbContext.SaveChanges();

            return RedirectToAction("index");
        }*/

        public IActionResult EditOrder(int orderId)
        {
           

            return RedirectToAction("index");
        }
    }
}