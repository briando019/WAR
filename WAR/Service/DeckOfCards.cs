namespace WAR.Service
{
    public class DeckOfCards
    {
        List<Card> cardDeck = new List<Card>();

        public DeckOfCards(List<Card> cardDeck)
        {
            this.cardDeck = cardDeck;
        }
    }
}
