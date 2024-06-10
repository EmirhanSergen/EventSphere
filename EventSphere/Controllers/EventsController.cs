using EventSphere.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks; // Add this line for async methods

namespace EventSphere.Controllers
{
    [Authorize]
    public class EventsController : Controller
    {
        private readonly EventSphereContext _context;

        public EventsController(EventSphereContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var events = await _context.Events.ToListAsync(); // Add using System.Linq;
            return View(events);
        }

        [AllowAnonymous]
        public IActionResult Participate(int eventId)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier); // Get current user ID
            if (userId == null)
            {
                return RedirectToAction("Login", "Account"); // Redirect to login if not authenticated
            }

            // Logic to add the user to the event participation list
            // ...

            return RedirectToAction("Index");
        }

    }
}
