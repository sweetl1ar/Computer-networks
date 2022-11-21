/*using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UnitTestApp1.Models;

namespace UnitTestApp1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}*/
/*using Microsoft.AspNetCore.Mvc;

namespace UnitTestApp.Controllers {
    public class HomeController : Controller {
        public IActionResult Index() {
            ViewData["Message"] = "Hello!";
            return View("Index");
        }
    }
}*/

using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller {
    public IActionResult Index() {
        ViewData["Message"] = "Hello world!";
        return View("Index");
    }
}