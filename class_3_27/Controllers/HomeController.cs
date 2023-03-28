using class_3_27.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace class_3_27.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
    }
}