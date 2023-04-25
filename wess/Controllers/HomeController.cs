﻿using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using wess.Models;

namespace wess.Controllers
{
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public ActionResult MyAction(string param)
        {
            // Do some processing using the parameter
            string result = "The parameter value is: " + param;

            // Return the result as a string response
            return Content(result);
        }
    }
}