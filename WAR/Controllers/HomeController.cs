using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WAR.Models;
using WAR.Service;
//Testing
//Testing again but from my side
namespace WAR.Controllers
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
            Player player = new Player();
            player.beenSlapped = 42;
            Computer computerq = new Computer();
            computerq.increaseSlapCount
            return View();
        }

        public IActionResult Rules()
        {

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}