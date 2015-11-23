using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackSimulator
{
    public static class Deck
    {
        private static List<Card> _cards;
        //TODO: These should probably be enums...
        static List<string> _facecards = new List<string>() { "J", "Q", "K" };
        static List<string> _possiblesuits = new List<string>() { "H", "C", "D", "S" };
        static List<string> _possiblevalues = new List<string>() { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };


        public static void Create(int numberofdecks = 1)
        {
            Cards = new List<Card>();
            for (int counter = 1; counter <= numberofdecks; counter++)
            {
                
                foreach (string suit in _possiblesuits)
                {
                    foreach (string value in _possiblevalues)
                    {
                        Cards.Add(new Card(value, suit));
                    }
                }
            }

            foreach (Card cd in Cards)
            {
                cd.ImageFileName = AssignCardImageFile(cd);
            }
        }

        public static void Shuffle()
        {
            List<Card> SourceDeck = Cards;
            List<Card> ShuffledDeck = new List<Card>();
            Random myrand = new Random();
            while (SourceDeck.Count > 0)
            {
                int CardToGet = myrand.Next(0, SourceDeck.Count);
                ShuffledDeck.Add(Cards[CardToGet]);
                SourceDeck.RemoveAt(CardToGet);
            }
            Cards = ShuffledDeck;
        }
        //TODO: Do something different with this. Research.
        private static string AssignCardImageFile(Card c)
        {
            string filename = "";
            filename += c.Value + c.Suit;
            return filename;
        }

        internal static List<Card> Cards
        {
            get
            {
                return _cards;
            }

            set
            {
                _cards = value;
            }
        }

        public static List<string> FaceCards
        {
            get
            {
                return _facecards;
            }
        }
    }
}
