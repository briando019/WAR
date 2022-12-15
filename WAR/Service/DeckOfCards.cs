using System;
using WAR.Interfaces;
using WAR.Models;

namespace WAR
{
    public class DeckOfCards
    {
        List<Card> cardDeck;
        private static readonly int dealOutLimit = 5;
        public DeckOfCards()
        {
            this.cardDeck = createDeck();
        }

        public Card getCard(int index)//view card
        {
            return cardDeck[index];
        }

        public int getCardCount()
        {
            return this.cardDeck.Count();
        }

        public Card removeFromTop()
        {
           
            Card cardRemoved = this.cardDeck[0];
            this.cardDeck.RemoveAt(0);
            return cardRemoved;
            
        }

        public void shuffle()
        {
            //Shuffle Current cardDeck
            Random rng = new Random();
            int currentCardToBeMoved = cardDeck.Count;
            while (currentCardToBeMoved > 1)
            {
                int newCardPosition = rng.Next(currentCardToBeMoved--);
                Card oldCard = this.cardDeck[currentCardToBeMoved];
                this.cardDeck[currentCardToBeMoved] = this.cardDeck[newCardPosition];
                this.cardDeck[newCardPosition] = oldCard;
            }
        }

        public void resetDeck()
        {
            this.cardDeck.Clear();
            this.cardDeck = createDeck();
        }

        /// <summary>
        /// This is used to deal out cards to the player passed in. 
        /// This will deal out 5 cards to a player
        /// </summary>
        /// <param name="player">Takes in a Player Object</param>
        public void dealCards(IPlayer player)
        {
            while(player.handCardCount() != dealOutLimit)
            {
                Card cardDrawn = this.removeFromTop();
                player.addCardToHand(cardDrawn);
            }     
        }

        /// <summary>
        /// This is a private method used to create a new deck of 52 cards
        /// </summary>
        /// <returns>Deck of cards</returns>
        private List<Card> createDeck()
        {
            List<Card> newDeck = new List<Card>
            {
                //Clubs
                new Card {cardNumber = 2, suit = 0, cardImage = "/Card/Clubs/Two.gif" },
                new Card {cardNumber = 3, suit = 0, cardImage = "/Card/Clubs/Three.gif" },
                new Card {cardNumber = 4, suit = 0, cardImage = "/Card/Clubs/Four.png" },
                new Card {cardNumber = 5, suit = 0, cardImage = "/Card/Clubs/Five.png" },
                new Card {cardNumber = 6, suit = 0, cardImage = "/Card/Clubs/Six.gif" },
                new Card {cardNumber = 7, suit = 0, cardImage = "/Card/Clubs/Seven.png" },
                new Card {cardNumber = 8, suit = 0, cardImage = "/Card/Clubs/Eight.png" },
                new Card {cardNumber = 9, suit = 0, cardImage = "/Card/Clubs/Nine.png" },
                new Card {cardNumber = 10, suit = 0, cardImage = "/Card/Clubs/Ten.png" },
                new Card {cardNumber = 11, suit = 0, cardImage = "/Card/Clubs/Jack.gif" },
                new Card {cardNumber = 12, suit = 0, cardImage = "/Card/Clubs/Queen.png" },
                new Card {cardNumber = 13, suit = 0, cardImage = "/Card/Clubs/King.png" },
                new Card {cardNumber = 14, suit = 0, cardImage = "/Card/Clubs/Ace.png" },

                //Diamonds
                new Card {cardNumber = 2, suit = 1, cardImage = "/Card/Diamond/Two.png" },
                new Card {cardNumber = 3, suit = 1, cardImage = "/Card/Diamond/Three.png" },
                new Card {cardNumber = 4, suit = 1, cardImage = "/Card/Diamond/Four.png" },
                new Card {cardNumber = 5, suit = 1, cardImage = "/Card/Diamond/Five.png" },
                new Card {cardNumber = 6, suit = 1, cardImage = "/Card/Diamond/Six.gif" },
                new Card {cardNumber = 7, suit = 1, cardImage = "/Card/Diamond/Seven.gif" },
                new Card {cardNumber = 8, suit = 1, cardImage = "/Card/Diamond/Eight.gif" },
                new Card {cardNumber = 9, suit = 1, cardImage = "/Card/Diamond/Nine.png" },
                new Card {cardNumber = 10, suit = 1, cardImage = "/Card/Diamond/Ten.gif" },
                new Card {cardNumber = 11, suit = 1, cardImage = "/Card/Diamond/Jack.gif" },
                new Card {cardNumber = 12, suit = 1, cardImage = "/Card/Diamond/Queen.gif" },
                new Card {cardNumber = 13, suit = 1, cardImage = "/Card/Diamond/King.png" },
                new Card {cardNumber = 14, suit = 1, cardImage = "/Card/Diamond/Ace.png" },

                //Hearts
                new Card {cardNumber = 2, suit = 2, cardImage = "/Card/Hearts/Two.png" },
                new Card {cardNumber = 3, suit = 2, cardImage = "/Card/Hearts/Three.png" },
                new Card {cardNumber = 4, suit = 2, cardImage = "/Card/Hearts/Four.png" },
                new Card {cardNumber = 5, suit = 2, cardImage = "/Card/Hearts/Five.gif" },
                new Card {cardNumber = 6, suit = 2, cardImage = "/Card/Hearts/Six.gif" },
                new Card {cardNumber = 7, suit = 2, cardImage = "/Card/Hearts/Seven.png" },
                new Card {cardNumber = 8, suit = 2, cardImage = "/Card/Hearts/Eight.png" },
                new Card {cardNumber = 9, suit = 2, cardImage = "/Card/Hearts/Nine.png" },
                new Card {cardNumber = 10, suit = 2, cardImage = "/Card/Hearts/Ten.gif" },
                new Card {cardNumber = 11, suit = 2, cardImage = "/Card/Hearts/Jack.png" },
                new Card {cardNumber = 12, suit = 2, cardImage = "/Card/Hearts/Queen.gif" },
                new Card {cardNumber = 13, suit = 2, cardImage = "/Card/Hearts/King.gif" },
                new Card {cardNumber = 14, suit = 2, cardImage = "/Card/Hearts/Ace.gif" },

                //Spades
                new Card {cardNumber = 2, suit = 3, cardImage = "/Card/Spades/Two.png" },
                new Card {cardNumber = 3, suit = 3, cardImage = "/Card/Spades/Three.png" },
                new Card {cardNumber = 4, suit = 3, cardImage = "/Card/Spades/Four.gif" },
                new Card {cardNumber = 5, suit = 3, cardImage = "/Card/Spades/Five.png" },
                new Card {cardNumber = 6, suit = 3, cardImage = "/Card/Spades/Six.gif" },
                new Card {cardNumber = 7, suit = 3, cardImage = "/Card/Spades/Seven.png" },
                new Card {cardNumber = 8, suit = 3, cardImage = "/Card/Spades/Eight.png" },
                new Card {cardNumber = 9, suit = 3, cardImage = "/Card/Spades/Nine.png" },
                new Card {cardNumber = 10, suit = 3, cardImage = "/Card/Spades/Ten.png" },
                new Card {cardNumber = 11, suit = 3, cardImage = "/Card/Spades/Jack.png" },
                new Card {cardNumber = 12, suit = 3, cardImage = "/Card/Spades/Queen.png" },
                new Card {cardNumber = 13, suit = 3, cardImage = "/Card/Spades/King.png" },
                new Card {cardNumber = 14, suit = 3, cardImage = "/Card/Spades/Ace.gif" },
            };

            return newDeck;
        }
    }
}
