using WAR.Interfaces;
using WAR.Models;

namespace WAR.Service
{
    public class Computer : IPlayer

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
            PlayerHand.Add(cardDrawn);       
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

        public int PickCard(int selectedCardFromHand)
        {
            throw new NotImplementedException();
        }

        public void resetPlayerHand()
        {
            throw new NotImplementedException();
        }

        public int SlapAttack(int slapAttackInt)
        {
            throw new NotImplementedException();
        }
    }
}
