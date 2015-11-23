using System;
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
    //TODO: Add split functionality. Need another row of cards on form, button, method. Available only on player's first action, and when card values match. Face cards (even if different) count too.
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

    enum GameResults { Win, Lose, Push };

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //static List<Card> Deck = new List<Card>();
        static List<Card> DiscardPile = new List<Card>();
        static Person Dealer = new Person(true);
        static Player Player1 = new Player();
        //TODO: These should probably be enums...
        /* deprecated. moved to deck class
        static List<string> FaceCards = new List<string>(){ "J", "Q", "K" };
        static List<string> PossibleSuits = new List<string>() { "H", "C", "D", "S" };
        static List<string> PossibleValues = new List<string>() { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        */
        static PictureBox[] PlayerHandPictureBoxes = new PictureBox[6];
        static PictureBox[] DealerHandPictureBoxes = new PictureBox[6];
        


        private void btnCreateDeck_Click(object sender, EventArgs e)
        {
            //CreateDeck();
            Deck.Create();
        }

        /* deprecating this. moving to static class method
        private void CreateDeck()
        {
            Deck.Cards.Clear();
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
        */
        /* deprecating this.
        private void btnGetRandomCard_Click(object sender, EventArgs e)
        {
            Random myrand = new Random();
            int CardToGet = myrand.Next(0, Deck.Cards.Count);
            Console.WriteLine("Random card is the " + Deck[CardToGet].Value + " of " + Deck[CardToGet].Suit + ".");
            Deck.RemoveAt(CardToGet);
        }
        */
        /* deprecating this. Moving method to static deck class
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
        */
        /* deprecating this.
        private void btnShuffleDeck_Click(object sender, EventArgs e)
        {
            Deck = Shuffle(Deck);
        }
        */

        private void DealCard(Person targetperson)
        {
            int LastIndex = Deck.Cards.Count - 1;
            targetperson.AddCardToHand(Deck.Cards[LastIndex]);
            string filename = Deck.Cards[LastIndex].ImageFileName;
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

            Deck.Cards.RemoveAt(LastIndex);
            if (Deck.Cards.Count == 0)
            {
                Deck.Shuffle();
            }
            // UpdateDealerHandValue();
            UpdatePlayerHandValue();
        }

        private void StartNewGame()
        {
            if (Deck.Cards.Count == 0)
            {
                Deck.Create();
                Deck.Shuffle();
            }

            EmptyHand(Player1, DiscardPile);
            EmptyHand(Dealer, DiscardPile);

            lblGameResultOutput.Text = "";
            btnStartNewGame.Enabled = false;

            DealCard(Player1);
            DealCard(Dealer);
            DealCard(Player1);
            DealCard(Dealer);
            // UpdatePlayerHandValue();
            // UpdateDealerHandValue();

            int CurrentBet = (int)numBetAmount.Value;
            Player1.CurrentBet = CurrentBet;
            Player1.Bankroll -= CurrentBet;
            UpdatePlayer1Bet();
            UpdatePlayer1Bankroll();
            numBetAmount.Enabled = false;

            //blackjack handling
            if (GetHandValue(Dealer.Hand) == 21 && GetHandValue(Player1.Hand) == 21) // tie
                EndGame(GameResults.Push);
            else if (GetHandValue(Dealer.Hand) == 21) //dealer blackjack
                EndGame(GameResults.Lose);
            else if (GetHandValue(Player1.Hand) == 21) // player blackjack
                EndGame(GameResults.Win,true);
            else //no blackjacks. enable form controls and start game.
            {
                btnHit.Enabled = true;
                btnStand.Enabled = true;
                btnDoubleDown.Enabled = true;
            }
            
        }

        //TODO: Add this method to the Player class. 
        private void Hit(Person targetperson)
        {
            if (btnDoubleDown.Enabled)
                btnDoubleDown.Enabled = false;

            DealCard(targetperson);

            if (GetHandValue(targetperson.Hand) > 21)
            {
                if (targetperson.IsDealer)
                    EndGame(GameResults.Win);
                else 
                    EndGame(GameResults.Lose);
            }
        }

        private void DoubleDown(Player targetplayer)
        {
            int modifyBetAmount = targetplayer.CurrentBet; // need to check if player has enough money to double down. if not, then increase the bet by whatever they have remaining.
            if (targetplayer.Bankroll < modifyBetAmount)
                modifyBetAmount = targetplayer.Bankroll;

            targetplayer.CurrentBet += modifyBetAmount;
            targetplayer.Bankroll -= modifyBetAmount;

            //form updates
            lblPlayer1BankrollOutput.Text = Player1.Bankroll.ToString("c");
            lblPlayer1CurrentBetOutput.Text = Player1.CurrentBet.ToString("c");

            Hit(targetplayer);
            
        }

        private void EndGame(GameResults result, bool isBlackjack = false)
        {
            RevealDealerFirstCard();
            if (result == GameResults.Win)
            {
                if (isBlackjack)
                {
                    Player1.Bankroll += Player1.CurrentBet * 3; // blackjack pays 2 to 1
                    lblGameResultOutput.Text = "Blackjack!";
                    
                }
                else
                {
                    
                    Player1.Bankroll += Player1.CurrentBet * 2;
                    lblGameResultOutput.Text = "Win!";
                }
            }

            else if (result == GameResults.Lose)
            {
                lblGameResultOutput.Text = "Lose!";
            }

            else if (result == GameResults.Push)
            {
                lblGameResultOutput.Text = "Push!";
                Player1.Bankroll += Player1.CurrentBet;
            }
            Player1.CurrentBet = 0;
            btnHit.Enabled = false;
            btnStand.Enabled = false;
            btnDoubleDown.Enabled = false;
            btnStartNewGame.Enabled = true;
            numBetAmount.Enabled = true;
        }

        private void CheckForWinner()
        {
            if (GetHandValue(Player1.Hand) > GetHandValue(Dealer.Hand))
                EndGame(GameResults.Win);
            else if (GetHandValue(Player1.Hand) < GetHandValue(Dealer.Hand))
                EndGame(GameResults.Lose);
            else if (GetHandValue(Player1.Hand) == GetHandValue(Dealer.Hand))
                EndGame(GameResults.Push);
            else
                MessageBox.Show("ERROR: Unable to determine winner.");
        }

        private void DealerTurn()
        {
            //need to reveal the dealer's first card
            RevealDealerFirstCard();

            int DealerHandValue = GetHandValue(Dealer.Hand);

            while (DealerHandValue <= 16) //TODO: Add a "strategy" to the dealer class (and make a dealer class) to vary this behavior
            {
                Hit(Dealer);
                DealerHandValue = GetHandValue(Dealer.Hand);
            }

            CheckForWinner();
        }

        private void RevealDealerFirstCard()
        {
            string filename = Dealer.Hand[0].ImageFileName;
            Dealer.CardImageArray[0].Image = (Image)CardImageFiles.ResourceManager.GetObject(filename);
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
                Deck.Cards.Add(CardToTransfer);
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
                else if (Deck.FaceCards.Contains(card.Value))
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
        /* deprecating.
        private void btnDealCardToDealer_Click(object sender, EventArgs e)
        {
            DealCard(Dealer, Deck);
        }

        private void btnEmptyDealerHand_Click(object sender, EventArgs e)
        {
            EmptyHand(Dealer, DiscardPile);
        }
        */
        private void btnStartNewGame_Click(object sender, EventArgs e)
        {
            StartNewGame();
        }
        /* deprecating.
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
        */
        private void Form1_Shown(object sender, EventArgs e) 
        {
            //TODO: This isn't working. Fix or move elsewhere (depending on if multiple deck option can be set somewhere before the game starts).
            Deck.Create();
            Deck.Shuffle();
        }

        private void btnHit_Click(object sender, EventArgs e)
        {
            Hit(Player1);
        }

        private void btnStand_Click(object sender, EventArgs e)
        {
            DealerTurn();
        }

        private void btnDoubleDown_Click(object sender, EventArgs e)
        {
            DoubleDown(Player1);
        }

    }
}
