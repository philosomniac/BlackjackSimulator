using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackjackSimulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static List<Card> Deck = new List<Card>();
        static List<Card> DiscardPile = new List<Card>();
        static List<Card> PlayerHand = new List<Card>();
        static List<Card> DealerHand = new List<Card>();
        static List<string> FaceCards = new List<string>() { "J", "Q", "K" };
        static List<string> PossibleSuits = new List<string>() { "Hearts", "Clubs", "Diamonds", "Spades" };
        static List<string> PossibleValues = new List<string>() { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

        private void btnCreateDeck_Click(object sender, EventArgs e)
        {
            Deck.Clear();
            DiscardPile.Clear();
            PlayerHand.Clear();
            DealerHand.Clear();
            foreach (string suit in PossibleSuits)
            {
                foreach (string value in PossibleValues)
                {
                    Deck.Add(new Card(value, suit));
                }
            }
        }

        private void btnGetRandomCard_Click(object sender, EventArgs e)
        {
            Random myrand = new Random();
            int CardToGet = myrand.Next(0, Deck.Count);
            Console.WriteLine("Random card is the " + Deck[CardToGet].value + " of " + Deck[CardToGet].suit + ".");
            Deck.RemoveAt(CardToGet);
        }
        private List<Card> Shuffle(List<Card> deck)
        {
            List<Card> DeckToShuffle = deck;
            List<Card> ShuffledDeck = new List<Card>();
            Random myrand = new Random();
            while (DeckToShuffle.Count > 0)
            {
                int CardToGet = myrand.Next(0, DeckToShuffle.Count);
                ShuffledDeck.Add(deck[CardToGet]);
                DeckToShuffle.RemoveAt(CardToGet);
            }
            return ShuffledDeck;
        }

        private void btnShuffleDeck_Click(object sender, EventArgs e)
        {
            Deck = Shuffle(Deck);
        }

        private void DealCard(List<Card> targetperson, List<Card> deck)
        {
            int LastIndex = deck.Count - 1;
            targetperson.Add(deck[LastIndex]);
            deck.RemoveAt(LastIndex);
        }

        private void EmptyHand(List<Card> targetperson, List<Card> discard)
        {
            while (targetperson.Count > 0)
            {
                Card CardToTransfer = targetperson[0];
                discard.Add(CardToTransfer);
                targetperson.RemoveAt(0);
            }
        }
        private void EmptyDiscardPile(List<Card> discard, List<Card> deck)
        {
            while (discard.Count > 0)
            {
                Card CardToTransfer = discard[0];
                deck.Add(CardToTransfer);
                discard.RemoveAt(0);
            }
        }
        private void btnDealToPlayer_Click(object sender, EventArgs e)
        {
            DealCard(PlayerHand,Deck);
        }

        private void btnEmptyPlayerHand_Click(object sender, EventArgs e)
        {
            EmptyHand(PlayerHand, DiscardPile);
        }

        private void btnEmptyDiscardPile_Click(object sender, EventArgs e)
        {
            EmptyDiscardPile(DiscardPile, Deck);
        }

        private int GetHandValue(List<Card> hand)
        {
            int handvalue = 0;
            int numberofsoftaces = 0;
            foreach (Card card in hand)
            {
                int numeric;
                if (int.TryParse(card.value, out numeric))
                {
                    handvalue += numeric;
                }
                else if (FaceCards.Contains(card.value))
                {
                    handvalue += 10;
                }
                else if (card.value == "A")
                {
                    handvalue += 11;
                    numberofsoftaces++;
                }
                else
                {

                }
            }

            while (numberofsoftaces > 0 && handvalue > 21)
            {
                numberofsoftaces--;
                handvalue -= 10;
            }
            return handvalue;
        }

        private void btnLoadCardImage_Click(object sender, EventArgs e)
        {
            pctPlayerCard1.Image = BlackjackSimulator.Properties.Resources._1;
        }
    }
}
