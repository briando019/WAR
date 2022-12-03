using WAR.Models;
using WAR.Service;

namespace WAR.Interfaces
{
    public interface IPlayer
    {

        public void DrawCard(Card cardDrawn, DeckOfCards deckOfCards);

        public List<Card> LookAtHand();

        public Card PickCard(int selectedCardFromHand);

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

        

            
                
            

    }
}
