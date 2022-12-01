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
        private static DeckOfCards deckOfCards = new DeckOfCards();
        public HomeController(ILogger<HomeController> logger)
        {
            
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Card> cards = new List<Card>();
           cards = deckOfCards.createDeck();
            return View(cards);
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