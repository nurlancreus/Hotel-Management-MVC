﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HotelManagement.Controllers
{
    [AllowAnonymous]
    public class AboutPageController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Active = "about";
            return  View();
        }
    }
}
