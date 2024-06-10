using EventSphere.Data;
using EventSphere.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Text.Encodings.Web;

namespace EventSphere.Controllers
{
    public class HomeController : Controller
    {

        private readonly EventSphereContext _context;

        public HomeController(EventSphereContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var events = await _context.Events.ToListAsync();
            return View(events);
        }




        // It gives opportunity to take an input from URL 
        /*public string Welcome(int ? ID ,string name = "Unknown", int numTimes = 1)
        {
            return $"Hello {name}, NumTimes is: {numTimes}\nSite's ID is {ID}";
        }*/
    }
}
