using Microsoft.AspNetCore.Mvc;

namespace DotnetFrontend.Controllers
{
    public class HomeController : Controller
    {
        // PUBLIC_INTERFACE
        /// <summary>
        /// Returns the homepage with Ocean Professional theme and light/dark toggle.
        /// </summary>
        /// <returns>Index view displaying the main landing content.</returns>
        public IActionResult Index()
        {
            return View();
        }
    }
}
