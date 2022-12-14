using WAR.Models;
using WAR.Service;

namespace WAR.Interfaces
{
    public interface IPlayer
    {

        public void DrawCard(DeckOfCards deckOfCards);

        public List<Card> LookAtHand();

        public Card PickCard(int selectedCardFromHand);

        public void addCardToHand(Card card);

        public int SlapAttack();
        public int BlockSlap(int blockInt);
        public int getSlapCount();
        public int getSlapBlockCount();
        public void resetPlayerHand();
        public void increaseSlapCount();
        public void increaseBlockCount();
        public int getScore();
        public void increaseScorePoints();
        public int handCardCount();
        public Card getCard(int index);








    }
}
