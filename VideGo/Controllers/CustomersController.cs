using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VideGo.Models;
using VideGo.ViewModels;

namespace VideGo.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        
        public ActionResult Index()
        {
            var customers = new List<Customer>
            {
                new Customer { Name = "Brian" },
                new Customer { Name = "Todd" }
            };

            var customerViewModel = new CustomerViewModel
            {
                Customers = customers
            };

            return View(customerViewModel);
        }

    }
}