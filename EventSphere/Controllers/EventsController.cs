using Microsoft.AspNetCore.Mvc;

namespace EventSphere.Controllers
{
    public class EventsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Event(int eventId = 1)
        {
            ViewData["EventId"] = eventId;
            return View();
        }

    }
}
