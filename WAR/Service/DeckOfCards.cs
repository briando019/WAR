using System;
using WAR.Models;

namespace WAR.Service
{
    public class DeckOfCards
    {
        List<Card> cardDeck = new List<Card>();

        public DeckOfCards()
        {
            this.cardDeck = createDeck();
        }

        public Card removeFromTop()
        {
            //ToDo: return card removed
            Card cardRemoved = this.cardDeck[0];
            cardDeck.RemoveAt(0);
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

        public void dealCards(Player player)
        {
            while(player.PlayerHand.Count != 5)
            {
                Card cardDrawn = removeFromTop();
                player.DrawCard(cardDrawn);
            }
            
            //TODO: Deal Card out to the player
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
                new Card {cardNumber = 2, suit = 0, cardImage = "" },
                new Card {cardNumber = 3, suit = 0, cardImage = "" },
                new Card {cardNumber = 4, suit = 0, cardImage = "" },
                new Card {cardNumber = 5, suit = 0, cardImage = "" },
                new Card {cardNumber = 6, suit = 0, cardImage = "" },
                new Card {cardNumber = 7, suit = 0, cardImage = "" },
                new Card {cardNumber = 8, suit = 0, cardImage = "" },
                new Card {cardNumber = 9, suit = 0, cardImage = "" },
                new Card {cardNumber = 10, suit = 0, cardImage = "" },
                new Card {cardNumber = 11, suit = 0, cardImage = "" },
                new Card {cardNumber = 12, suit = 0, cardImage = "" },
                new Card {cardNumber = 13, suit = 0, cardImage = "" },
                new Card {cardNumber = 14, suit = 0, cardImage = "" },

                //Diamonds
                new Card {cardNumber = 2, suit = 1, cardImage = "" },
                new Card {cardNumber = 3, suit = 1, cardImage = "" },
                new Card {cardNumber = 4, suit = 1, cardImage = "" },
                new Card {cardNumber = 5, suit = 1, cardImage = "" },
                new Card {cardNumber = 6, suit = 1, cardImage = "" },
                new Card {cardNumber = 7, suit = 1, cardImage = "" },
                new Card {cardNumber = 8, suit = 1, cardImage = "" },
                new Card {cardNumber = 9, suit = 1, cardImage = "" },
                new Card {cardNumber = 14, suit = 1, cardImage = "" },
                new Card {cardNumber = 10, suit = 1, cardImage = "" },
                new Card {cardNumber = 11, suit = 1, cardImage = "" },
                new Card {cardNumber = 12, suit = 1, cardImage = "" },
                new Card {cardNumber = 13, suit = 1, cardImage = "" },

                //Hearts
                new Card {cardNumber = 2, suit = 2, cardImage = "" },
                new Card {cardNumber = 3, suit = 2, cardImage = "" },
                new Card {cardNumber = 4, suit = 2, cardImage = "" },
                new Card {cardNumber = 5, suit = 2, cardImage = "" },
                new Card {cardNumber = 6, suit = 2, cardImage = "" },
                new Card {cardNumber = 7, suit = 2, cardImage = "" },
                new Card {cardNumber = 8, suit = 2, cardImage = "" },
                new Card {cardNumber = 9, suit = 2, cardImage = "" },
                new Card {cardNumber = 14, suit = 2, cardImage = "" },
                new Card {cardNumber = 10, suit = 2, cardImage = "" },
                new Card {cardNumber = 11, suit = 2, cardImage = "" },
                new Card {cardNumber = 12, suit = 2, cardImage = "" },
                new Card {cardNumber = 13, suit = 2, cardImage = "" },

                //Spades
                new Card {cardNumber = 2, suit = 3, cardImage = "" },
                new Card {cardNumber = 3, suit = 3, cardImage = "" },
                new Card {cardNumber = 4, suit = 3, cardImage = "" },
                new Card {cardNumber = 5, suit = 3, cardImage = "" },
                new Card {cardNumber = 6, suit = 3, cardImage = "" },
                new Card {cardNumber = 7, suit = 3, cardImage = "" },
                new Card {cardNumber = 8, suit = 3, cardImage = "" },
                new Card {cardNumber = 9, suit = 3, cardImage = "" },
                new Card {cardNumber = 14, suit = 3, cardImage = "" },
                new Card {cardNumber = 10, suit = 3, cardImage = "" },
                new Card {cardNumber = 11, suit = 3, cardImage = "" },
                new Card {cardNumber = 12, suit = 3, cardImage = "" },
                new Card {cardNumber = 13, suit = 3, cardImage = "" },
            };

            return newDeck;
        }
    }
}
