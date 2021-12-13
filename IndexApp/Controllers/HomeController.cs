using IndexApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace IndexApp.Controllers
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

        [HttpPost]
        public IActionResult Index(DateTime dateTime, int Number)
        {
            var date = dateTime == DateTime.MinValue ? DateTime.Now.AddDays(Number) : dateTime.AddDays(Number);
            ViewBag.Date = dateTime == DateTime.MinValue ? DateTime.Now.ToString("dd/MM/yyyy") : dateTime.ToString("dd/MM/yyyy");
            ViewBag.Number = Number.ToString();
            ViewBag.Resullt = date.ToString("dd/MM/yyyy");
            return View();
        }
    }
}
