using WAR.Interfaces;
using WAR.Models;
using WAR.Models.BaseModels;

namespace WAR.Service
{
    public class Computer : PlayerBaseModel, IPlayer

    {
        public Computer() {
            this.PlayerHand = new List<Card>();
            this.score = 0;
            this.blockedSlaps = 0;
            this.blockedSlaps = 0;
        }

        public int BlockSlap(int blockInt)
        {
            Random random = new Random();
            int blockDefenceNumber = random.Next(100);
            return blockDefenceNumber;
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
