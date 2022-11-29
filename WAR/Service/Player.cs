using WAR.Interfaces;
using WAR.Models;

namespace WAR.Service
{
    public class Player : IPlayer

    {
        public List<Card> PlayerHand { get; set; }
        public int score { get; set; }
        public int beenSlapped { get; set; }
        public int blockedSlaps { get; set; }

        public int BlockSlap(int blockInt)
        {
            throw new NotImplementedException();
        }

        public void DrawCard(Card cardDrawn)
        {
            throw new NotImplementedException();
        }

        public int getSlapBlockCount()
        {
            throw new NotImplementedException();
        }

        public int getSlapCount()
        {
            throw new NotImplementedException();
        }

        public List<Card> LookAtHand()
        {
            throw new NotImplementedException();
        }

        public Card PickCard(int selectedCardFromHand)
        {
            throw new NotImplementedException();
        }

        public void resetPlayerHand()
        {
            throw new NotImplementedException();
        }

        public void increaseBlockCount()
        {
            throw new NotImplementedException();
        }

        public void increaseSlapCount()
        {
            throw new NotImplementedException();
        }

        public int SlapAttack()
        {
            throw new NotImplementedException();
        }
    }
}
