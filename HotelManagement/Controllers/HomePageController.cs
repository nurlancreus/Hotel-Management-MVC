using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HotelManagement.Controllers
{
    [AllowAnonymous]
    public class HomePageController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Active = "homePage";

            return View();
        }
    }
}
