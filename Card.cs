using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackSimulator
{
    class Card
    {
        public string suit;
        public string value;

        public Card()
        {
            suit = "unknown";
            value = "unknown";
        }

        public Card(string vl, string st)
        {
            suit = st;
            value = vl;
        }

        public Card(int vl, string st)
        {
            suit = st;
            value = vl.ToString();
        }
    }
}
