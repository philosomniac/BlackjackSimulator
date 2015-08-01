using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackSimulator
{
    class Player
    {
        private int currentbet;
        private List<Card> hand;
        private int bankroll;

        public int CurrentBet
        {
            get
            {
                return currentbet;
            }

            set
            {
                currentbet = value;
            }
        }

        public int Bankroll
        {
            get 
            {
                return bankroll;
            }
            set
            {
                bankroll = value;
            }
        }

        public List<Card> Hand
        {
            get
            {
                return hand;
            }
            set
            {
                hand = value;
            }
        }

        public void AddCardToHand(Card c)
        {
            hand.Add(c);
        }

        public void ClearHand()
        {
            hand.Clear();
        }

        public void AddToBankroll(int m)
        {
            bankroll += m;
        }
        public void SubtractFromBankroll(int m)
        {
            bankroll -= m;
        }
    }
}
