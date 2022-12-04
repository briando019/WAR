using Microsoft.AspNetCore.Mvc;
using WAR.Models;
using WAR.Service;

namespace WAR.Controllers
{
    public class PlayerVsComputerController : Controller
    {
        private static DeckOfCards deckOfCards = new DeckOfCards();
        public IActionResult Index()
        {
            deckOfCards.shuffle();
            return View(deckOfCards);
        }
    }
}
