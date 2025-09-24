using Microsoft.AspNetCore.Mvc;

namespace DotNetFrontend.Controllers
{
    // PUBLIC_INTERFACE
    public class HomeController : Controller
    {
        /// <summary>
        /// Landing page that demonstrates the Ocean Professional theme and theme toggle.
        /// </summary>
        /// <returns>Razor view for the Index page.</returns>
        public IActionResult Index()
        {
            ViewData["Title"] = "Home";
            return View();
        }

        /// <summary>
        /// Error page route.
        /// </summary>
        /// <returns>Error view.</returns>
        public IActionResult Error()
        {
            return View();
        }
    }
}
