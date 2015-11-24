using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackjackSimulator
{
    class Person
    {
        private List<Card> hand;
        private PictureBox[] cardimagearray;
        private bool isdealer;

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
        public bool IsDealer
        {
            get
            {
                return isdealer;
            }

            set
            {
                isdealer = value;
            }
        }

        public PictureBox[] CardImageArray
        {
            get
            {
                return cardimagearray;
            }

            set
            {
                cardimagearray = value;
            }
        }

        public Person(bool dealer, PictureBox[] imagearray)
        {
            hand = new List<Card>();
            isdealer = dealer;
            cardimagearray = imagearray;
        }
        public Person(bool dealer)
        {
            hand = new List<Card>();
            isdealer = dealer;
        }

        public Person()
        {
            hand = new List<Card>();
            isdealer = false;
            
        }

        public void AddCardToHand(Card c)
        {
            hand.Add(c);
        }

        public void ClearHand()
        {
            hand.Clear();
        }
    }
}
