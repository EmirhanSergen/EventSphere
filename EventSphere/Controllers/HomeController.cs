using EventSphere.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using System.Diagnostics;

namespace EventSphere.Controllers
{
    public class HomeController : Controller
    {

        // IActionResult gives opportunity to return a controller action, such as views, JSON, redirects, etc.
        public IActionResult Index()
        {
            
            // It goes to Views folder and execute file which name is same as route
            return View();
        }

        public IActionResult Harun()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        
    }
}
