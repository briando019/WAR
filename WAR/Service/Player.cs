using WAR.Interfaces;
using WAR.Models;
using WAR.Models.BaseModels;

namespace WAR
{
    public class Player : PlayerBaseModel, IPlayer

    {
        public Player() {
            this.PlayerHand = new List<Card>();
            this.score = 0;
            this.blockedSlaps = 0;
            this.beenSlapped = 0;
            this.SlapsRemaining= 0;
            
        }

        public int BlockSlap(int blockInt)
        {
            Random random= new Random();
            int blockDefenceNumber = random.Next(100);
            return blockDefenceNumber;
        }

        public void DrawCard(DeckOfCards deckOfCards)
        {
            if (deckOfCards.getCardCount() != 0)
            {
                PlayerHand.Add(deckOfCards.removeFromTop());
            }

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
            this.blockedSlaps = this.blockedSlaps++;
        }

        public void increaseSlapCount()
        {
            this.beenSlapped = this.beenSlapped++;
        }

        public int SlapAttack()
        {
            Random random= new Random();
            int slapAttackDmg = random.Next(100);
            return slapAttackDmg;
        }
        public int getScore()
        {
            return this.score;
        }

        public void increaseScorePoints()
        {
             this.score = this.score++;
        }

        public int handCardCount()
        {
            return this.PlayerHand.Count;
        }
        public int slapsRemainingCount()
        {
            return this.SlapsRemaining--;
        }

        public void addCardToHand(Card card)
        {
            this.PlayerHand.Add(card);   
        }
        public Card getCard(int index)
        {
            return this.PlayerHand[index];
        }
    }
}
