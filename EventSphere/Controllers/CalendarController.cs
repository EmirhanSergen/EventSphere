﻿using Microsoft.AspNetCore.Mvc;

namespace EventSphere.Controllers
{
    public class CalendarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
