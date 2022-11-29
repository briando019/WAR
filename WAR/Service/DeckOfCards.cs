namespace WAR.Service
{
    public class DeckOfCards
    {
        List<Card> cardDeck = new List<Card>();

        public DeckOfCards(List<Card> cardDeck)
        {
            this.cardDeck = cardDeck;
        }

        public Card removeFromDeck()
        {
            //ToDo: return card removed
            Card cardRemoved = this.cardDeck[0];
            return cardRemoved;
            
        }

        public void shuffle()
        {
            //Shuffle Current cardDeck
        }

        public void resetDeck()
        {
            this.cardDeck.Clear();
        }

        public void DealCards(string playersList)
        {
            //Deal Card out to the player
        }
    }
}
