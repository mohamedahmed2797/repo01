using Microsoft.AspNetCore.Mvc;
using repo.Models;

namespace repo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //return View("pota", new Movie());
            //return View("pota");
            //return View(new Movie());
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View();
        }
    }
    }
