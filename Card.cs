using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackSimulator
{
    class Card
    {
        private string suit;
        private string value;
        private string imagefilename;

        public string Suit
        {
            get
            {
                return suit;
            }

            set
            {
                suit = value;
            }
        }

        public string Value
        {
            get
            {
                return value;
            }
            set
            {
                Value = value;
            }
        }
        public string ImageFileName
        {
            get
            {
                return imagefilename;
            }
            set
            {
                imagefilename = value;
            }
        }

        public Card()
        {
            suit = "unknown";
            value = "unknown";
            imagefilename = "unknown";
        }

        public Card(string vl, string st)
        {
            suit = st;
            value = vl;
            imagefilename = "unknown";
        }

        public Card(int vl, string st)
        {
            suit = st;
            value = vl.ToString();
            imagefilename = "unknown";
        }

        
    }
}
