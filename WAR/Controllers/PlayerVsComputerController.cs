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
            /*dealFiveCards(Player, Computer);
            dealFiveCards(Player, Player);
            dealFiveCards(Computer, Computer);
            dealFiveCards(Computer, Player);*/
            deckOfCards.dealCards(player);
            deckOfCards.dealCards(computer);
            return View(player);
        }
        /*public JsonResult dealFiveCards(IPlayer player1, IPlayer player2)
        {
            //@param Player,Computer
            //take the top 5 cards in the deck and add it to player hand
            //take the next 5 card to the computer hand
            bool isSuccessful = false;
            if(!isSuccessful)
            {
                for (int i = 0; i <= 4; i++)
                {
                    player1.DrawCard(deckOfCards);
                    player2.DrawCard(deckOfCards);
                }
                isSuccessful = true;
            }

            return Json(isSuccessful, new Newtonsoft.Json.JsonSerializerSettings());// jsonserializer is to convert to json
        }*/

        public JsonResult drawNewCard()
        {
            player.DrawCard(deckOfCards);
            return Json(null,null);
        }
    }
}
