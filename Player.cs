using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackjackSimulator
{
    class Player : Person
    {
        private int currentbet;
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

        public Player(PictureBox[] imagearray)
        {
            
            currentbet = 0;
            bankroll = 1000;
            this.CardImageArray = imagearray;
            this.IsDealer = false;
        }

        public Player()
        {
            currentbet = 0;
            bankroll = 1000;
            this.IsDealer = false;
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
