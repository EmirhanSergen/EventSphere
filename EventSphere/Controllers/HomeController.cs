using EventSphere.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using System.Diagnostics;
using System.Text.Encodings.Web;

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

        // It gives opportunity to take an input from URL 
        public string Welcome(int ? ID ,string name = "Unknown", int numTimes = 1)
        {
            return $"Hello {name}, NumTimes is: {numTimes}\nSite's ID is {ID}";
        }
    }
}
