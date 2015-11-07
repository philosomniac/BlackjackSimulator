﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CardImageFiles = BlackjackSimulator.Properties.Resources;

namespace BlackjackSimulator
{

    //TODO: Add double-down button and method. Only available on player's first action
    //TODO: Add split functionality. Need another row of cards on form, button, method. Available only on player's first action, and when card values match.
    //TODO: Remove hardcoded 6-card hand limit. Allow for arbitrary number of cards--create new picture box in appropriate position when card is dealt.
    //TODO: Add gameplay options:
        // Dealer behavior variance for 16s and 17s
        // Number of decks
        // Double after split
        // Surrender
        // Insurance
        // Deck penetration: automatically run Shuffle() method after game is over and penetration % reached
    //TODO: "advanced" features:
        // Basic strategy tables. Vary on number of decks and gameplay options
        // Tell player what correct strategy is if asked.
        // Once strategy is in, run simulations of game automatically. Track results.
        // Keep track of card count
        // Vary bet based on card count in simulation

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static List<Card> Deck = new List<Card>();
        static List<Card> DiscardPile = new List<Card>();
        static Person Dealer = new Person(true);
        static Player Player1 = new Player();
        static List<string> FaceCards = new List<string>(){ "J", "Q", "K" };
        static List<string> PossibleSuits = new List<string>() { "H", "C", "D", "S" };
        static List<string> PossibleValues = new List<string>() { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        static PictureBox[] PlayerHandPictureBoxes = new PictureBox[6];
        static PictureBox[] DealerHandPictureBoxes = new PictureBox[6];


        private void btnCreateDeck_Click(object sender, EventArgs e)
        {
            CreateDeck();
        }

        private void CreateDeck()
        {
            Deck.Clear();
            DiscardPile.Clear();
            Dealer.ClearHand();
            Player1.ClearHand();
            foreach (string suit in PossibleSuits)
            {
                foreach (string value in PossibleValues)
                {
                    Deck.Add(new Card(value, suit));
                }
            }

            foreach (Card cd in Deck)
            {
                cd.ImageFileName = AssignCardImageFile(cd);
            }
        }

        private void btnGetRandomCard_Click(object sender, EventArgs e)
        {
            Random myrand = new Random();
            int CardToGet = myrand.Next(0, Deck.Count);
            Console.WriteLine("Random card is the " + Deck[CardToGet].Value + " of " + Deck[CardToGet].Suit + ".");
            Deck.RemoveAt(CardToGet);
        }

        private List<Card> Shuffle(List<Card> deck)
        {
            // TODO: Create a deck class, and make this method a member of deck
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

        private void DealCard(Person targetperson, List<Card> deck)
        {
            int LastIndex = deck.Count - 1;
            targetperson.AddCardToHand(deck[LastIndex]);
            string filename = deck[LastIndex].ImageFileName;
            PictureBox[] ImageArray = targetperson.CardImageArray;

            for (int indexcounter = 0; indexcounter < ImageArray.Length; indexcounter++)
            {
                if (ImageArray[indexcounter] == null || ImageArray[indexcounter].Image == null)
                {
                    if (targetperson.IsDealer && indexcounter == 0) // dealer's first card is facedown. All other cards are faceup.
                    {
                        ImageArray[indexcounter].Image = (Image)CardImageFiles.ResourceManager.GetObject("RedBackVert");
                    }
                    else
                    {
                        ImageArray[indexcounter].Image = (Image)CardImageFiles.ResourceManager.GetObject(filename);
                    }

                    ImageArray[indexcounter].Visible = true;
                    ImageArray[indexcounter].BringToFront();
                    break;
                }
            }

            deck.RemoveAt(LastIndex);
            if (deck.Count == 0)
            {
                Shuffle(deck);
            }
            // UpdateDealerHandValue();
            UpdatePlayerHandValue();
        }

        private void StartNewGame()
        {
            if (Deck.Count == 0)
                CreateDeck();

            EmptyHand(Player1, DiscardPile);
            EmptyHand(Dealer, DiscardPile);

            lblGameResultOutput.Text = "";

            DealCard(Player1, Deck);
            DealCard(Dealer, Deck);
            DealCard(Player1, Deck);
            DealCard(Dealer, Deck);
            // UpdatePlayerHandValue();
            // UpdateDealerHandValue();

            int CurrentBet = (int)numBetAmount.Value;
            Player1.CurrentBet = CurrentBet;
            Player1.Bankroll -= CurrentBet;
            UpdatePlayer1Bet();
            UpdatePlayer1Bankroll();

            if (GetHandValue(Dealer.Hand) == 21) //blackjack handling
            {
                if (GetHandValue(Player1.Hand) == 21)
                    Push();
                else
                    Lose();
            }
        }

        //TODO: Add this method to the Player class. 
        private void Hit(Person targetperson, List<Card> deck)
        {
            DealCard(targetperson, deck);

            if (GetHandValue(targetperson.Hand) > 21)
            {
                if (targetperson.IsDealer)
                    Win();
                else if (!targetperson.IsDealer)
                    Lose();
            }
        }

        //TODO: Add this method to the player class.
        private void Win()
        {
            Player1.Bankroll += Player1.CurrentBet * 2;
            Player1.CurrentBet = 0;
            lblGameResultOutput.Text = "Win!";
        }

        //TODO: Add this method to the player class.
        private void Lose()
        {
            Player1.CurrentBet = 0;
            lblGameResultOutput.Text = "Lose!";
        }

        //TODO: Add this method to the player class.
        private void Push()
        {
            Player1.Bankroll += Player1.CurrentBet;
            Player1.CurrentBet = 0;
            lblGameResultOutput.Text = "Push!";
        }

        private void CheckForWinner()
        {
            if (GetHandValue(Player1.Hand) > GetHandValue(Dealer.Hand))
                Win();
            else if (GetHandValue(Player1.Hand) < GetHandValue(Dealer.Hand))
                Lose();
            else if (GetHandValue(Player1.Hand) == GetHandValue(Dealer.Hand))
                Push();
            else
                MessageBox.Show("Unable to determine winner.");
        }

        private void DealerTurn()
        {
            //need to reveal the dealer's first card
            string filename = Dealer.Hand[0].ImageFileName;
            Dealer.CardImageArray[0].Image = (Image)CardImageFiles.ResourceManager.GetObject(filename);

            int DealerHandValue = GetHandValue(Dealer.Hand);

            while (DealerHandValue <= 16) //TODO: Add a "strategy" to the dealer class (and make a dealer class) to vary this behavior
            {
                Hit(Dealer, Deck);
                DealerHandValue = GetHandValue(Dealer.Hand);
            }

            CheckForWinner();
        }

        //TODO: Add this method to the player class. Link controls to class directly.
        private void UpdatePlayerHandValue()
        {
            int CurrentHandValue = GetHandValue(Player1.Hand);
            if (CurrentHandValue <= 21)
            {
                lblHandValueOutput.Text = CurrentHandValue.ToString();
            }
            else
            {
                lblHandValueOutput.Text = "Bust!";
            }
        }

        //TODO: Create dealer class. Add this method there. Link controls to class directly.
        private void UpdateDealerHandValue()
        {
            int CurrentHandValue = GetHandValue(Dealer.Hand);
            if (CurrentHandValue <= 21)
            {
                lblDealerHandValueOutput.Text = CurrentHandValue.ToString();
            }
            else
            {
                lblDealerHandValueOutput.Text = "Bust!";
            }

        }

        //TODO: Add this method to the player class. Link controls to class directly.
        private void UpdatePlayer1Bankroll()
        {
            int CurrentBankroll = Player1.Bankroll;
            lblPlayer1BankrollOutput.Text = CurrentBankroll.ToString("c");
        }

        //TODO: Add this method to the player class. Link controls to class directly.
        private void UpdatePlayer1Bet()
        {
            int CurrentBet = Player1.CurrentBet;
            lblPlayer1CurrentBetOutput.Text = CurrentBet.ToString("c");
        }

        //TODO: Add this method to the person class. Link controls to class directly.
        private void EmptyHand(Person targetperson, List<Card> discard)
        {
            List<Card> CurrentHand = targetperson.Hand;
            PictureBox[] CardImageDisplay = targetperson.CardImageArray;
            while (targetperson.Hand.Count > 0)
            {
                Card CardToTransfer = CurrentHand[0];
                discard.Add(CardToTransfer);
                CurrentHand.RemoveAt(0);
            }

            for (int indexcounter = 0; indexcounter < CardImageDisplay.Length; indexcounter++)
            {
                CardImageDisplay[indexcounter].Image = null;
                CardImageDisplay[indexcounter].Visible = false;
            }

            UpdatePlayerHandValue();
            UpdateDealerHandValue();
        }

        //TODO: Create Cardcollection class. Add this method there.
        private void EmptyDiscardPile(List<Card> discard, List<Card> deck)
        {
            while (discard.Count > 0)
            {
                Card CardToTransfer = discard[0];
                deck.Add(CardToTransfer);
                discard.RemoveAt(0);
            }
        }

        //TODO: Create Hand class that inherits from CardCollection. Add this method there.
        private int GetHandValue(List<Card> hand)
        {
            int handvalue = 0;
            int numberofsoftaces = 0;

            if (hand.Count == 0)
                return 0;

            foreach (Card card in hand)
            {
                int numeric;
                if (int.TryParse(card.Value, out numeric))
                {
                    handvalue += numeric;
                }
                else if (FaceCards.Contains(card.Value))
                {
                    handvalue += 10;
                }
                else if (card.Value == "A")
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

        //TODO: Do something different with this. Research.
        private string AssignCardImageFile(Card c)
        {
            string filename = "";
            string[] NumericValues = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10" };

            filename += c.Value + c.Suit;
            return filename;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //TODO: Don't like that the values are hardcoded. Should allow for an arbitrary number of cards.
            PlayerHandPictureBoxes[0] = pctPlayerCard1;
            PlayerHandPictureBoxes[1] = pctPlayerCard2;
            PlayerHandPictureBoxes[2] = pctPlayerCard3;
            PlayerHandPictureBoxes[3] = pctPlayerCard4;
            PlayerHandPictureBoxes[4] = pctPlayerCard5;
            PlayerHandPictureBoxes[5] = pctPlayerCard6;
            Player1.CardImageArray = PlayerHandPictureBoxes;

            DealerHandPictureBoxes[0] = pctDealerCard1;
            DealerHandPictureBoxes[1] = pctDealerCard2;
            DealerHandPictureBoxes[2] = pctDealerCard3;
            DealerHandPictureBoxes[3] = pctDealerCard4;
            DealerHandPictureBoxes[4] = pctDealerCard5;
            DealerHandPictureBoxes[5] = pctDealerCard6;
            Dealer.CardImageArray = DealerHandPictureBoxes;

        }

        //TODO: section off these test and debug functions. Hide buttons when not in "test mode"? Or just remove?
        private void btnDealCardToDealer_Click(object sender, EventArgs e)
        {
            DealCard(Dealer, Deck);
        }

        private void btnEmptyDealerHand_Click(object sender, EventArgs e)
        {
            EmptyHand(Dealer, DiscardPile);
        }

        private void btnStartNewGame_Click(object sender, EventArgs e)
        {
            StartNewGame();
        }

        private void btnDealToPlayer_Click(object sender, EventArgs e)
        {

            DealCard(Player1, Deck);
        }

        private void btnEmptyPlayerHand_Click(object sender, EventArgs e)
        {
            EmptyHand(Player1, DiscardPile);
        }

        private void btnEmptyDiscardPile_Click(object sender, EventArgs e)
        {
            EmptyDiscardPile(DiscardPile, Deck);
        }

        private void btnLoadCardImage_Click(object sender, EventArgs e)
        {
            // pctPlayerCard1.Image = BlackjackSimulator.Properties.Resources._1;
        }

        private void Form1_Shown(object sender, EventArgs e) 
        {
            //TODO: This isn't working. Fix or move elsewhere (depending on if multiple deck option can be set somewhere before the game starts).
            CreateDeck();
            Shuffle(Deck);
        }

        private void btnHit_Click(object sender, EventArgs e)
        {
            Hit(Player1, Deck);
        }

        private void btnStand_Click(object sender, EventArgs e)
        {
            DealerTurn();
        }

    }
}
