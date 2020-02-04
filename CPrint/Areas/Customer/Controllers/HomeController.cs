using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CPrint.Models;
using CPrint.Models.ViewModels;

namespace CPrint.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        // functions for all the navbar links
        // products will require db and controller 
        public IActionResult Products()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult Quotation()
        {
            return View();
        }

        public IActionResult Templates()
        {
            return View();
        }

        public IActionResult Bespoke()
        {
            return View();
        }

        public IActionResult Design()
        {
            return View();
        }

        public IActionResult FAQs()
        {
            return View();
        }


        public IActionResult ContactUs()
        {
            return View();
        }





        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
