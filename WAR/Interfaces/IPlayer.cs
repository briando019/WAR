﻿using WAR.Models;
using WAR.Service;

namespace WAR.Interfaces
{
    public interface IPlayer
    {
        public List<Card> PlayerHand { get; set; }
        public int score { get; set; }
        public int beenSlapped { get; set; }
        public int blockedSlaps { get; set; }

        public void DrawCard(Card cardDrawn);

        public List<Card> LookAtHand();

        public int PickCard(int selectedCardFromHand);

        public int SlapAttack(int slapAttackInt);
        public int BlockSlap(int blockInt);
        public int getSlapCount();
        public int getSlapBlockCount();
        public void resetPlayerHand();
        public void setSlapCount();
        public void setBlockCount();

        

            
                
            

    }
}
