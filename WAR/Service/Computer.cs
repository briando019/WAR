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
            return this.blockedSlaps;
        }

        public int getSlapCount()
        {
            return this.beenSlapped;
        }

        public List<Card> LookAtHand()
        {
            return this.PlayerHand;
        }

        public Card PickCard(int selectedCardFromHand)
        {
            Card cardPicked = PlayerHand[selectedCardFromHand];
            return cardPicked;
        }

        public void resetPlayerHand()
        {
            PlayerHand.Clear();
        }

        public void increaseBlockCount()
        {
            this.blockedSlaps++;
        }

        public void increaseSlapCount()
        {
            this.beenSlapped++;
        }

        public int SlapAttack()
        {
            Random random = new Random();
            int slapAttackDmg = random.Next(100);
           return slapAttackDmg;
        }
    }
}
