using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;
namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        [Route("customers/index")]
        public ActionResult Index()
        {

            var customers = GetCustomers();

            return View(customers);
        }

        public ActionResult Detail(int id)
        {

            var customers = GetCustomers().SingleOrDefault(c => c.Id == id);
           
            if (customers==null)
            {
                return HttpNotFound();
            }
            return View(customers);
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer{Id=1, Name="Fulano da Silva"},
                new Customer{Id=2, Name="Sicrano da Costa"}
            };
        }

    }
}