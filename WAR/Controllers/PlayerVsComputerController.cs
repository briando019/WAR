using Microsoft.AspNetCore.Mvc;
using WAR.Interfaces;
using WAR.Models;
using WAR.Service;

namespace WAR.Controllers
{
    public class PlayerVsComputerController : Controller
    {
        private static DeckOfCards deckOfCards = new DeckOfCards();
        private static IPlayer  player= new Player();
        private static IPlayer computer = new Computer(); 
        public IActionResult Index()
        {
            deckOfCards.resetDeck();
            deckOfCards.shuffle();
            deckOfCards.dealCards(player);
            deckOfCards.dealCards(computer);
            return View(player);
        }
        


        [HttpGet]
        public IActionResult drawNewCard()
        {
            player.DrawCard(deckOfCards);
            return PartialView("~/Views/PlayerVsComputer/CardInHand.cshtml", (Player)player);
        }


        


    }
}
