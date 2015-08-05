namespace BlackjackSimulator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCreateDeck = new System.Windows.Forms.Button();
            this.btnGetRandomCard = new System.Windows.Forms.Button();
            this.btnShuffleDeck = new System.Windows.Forms.Button();
            this.btnDealToPlayer = new System.Windows.Forms.Button();
            this.btnEmptyPlayerHand = new System.Windows.Forms.Button();
            this.btnEmptyDiscardPile = new System.Windows.Forms.Button();
            this.pctPlayerCard1 = new System.Windows.Forms.PictureBox();
            this.btnLoadCardImage = new System.Windows.Forms.Button();
            this.pctPlayerCard3 = new System.Windows.Forms.PictureBox();
            this.pctPlayerCard4 = new System.Windows.Forms.PictureBox();
            this.pctPlayerCard5 = new System.Windows.Forms.PictureBox();
            this.pctPlayerCard6 = new System.Windows.Forms.PictureBox();
            this.pctPlayerCard2 = new System.Windows.Forms.PictureBox();
            this.lblHandValueTitle = new System.Windows.Forms.Label();
            this.lblHandValueOutput = new System.Windows.Forms.Label();
            this.pctDealerCard6 = new System.Windows.Forms.PictureBox();
            this.pctDealerCard5 = new System.Windows.Forms.PictureBox();
            this.pctDealerCard4 = new System.Windows.Forms.PictureBox();
            this.pctDealerCard3 = new System.Windows.Forms.PictureBox();
            this.pctDealerCard2 = new System.Windows.Forms.PictureBox();
            this.pctDealerCard1 = new System.Windows.Forms.PictureBox();
            this.lblDealerHandValueTitle = new System.Windows.Forms.Label();
            this.lblDealerHandValueOutput = new System.Windows.Forms.Label();
            this.btnDealCardToDealer = new System.Windows.Forms.Button();
            this.btnEmptyDealerHand = new System.Windows.Forms.Button();
            this.btnStartNewGame = new System.Windows.Forms.Button();
            this.numBetAmount = new System.Windows.Forms.NumericUpDown();
            this.lblBetAmount = new System.Windows.Forms.Label();
            this.lblPlayer1Bet = new System.Windows.Forms.Label();
            this.lblPlayer1CurrentBetOutput = new System.Windows.Forms.Label();
            this.lblPlayerBankroll = new System.Windows.Forms.Label();
            this.lblPlayer1BankrollOutput = new System.Windows.Forms.Label();
            this.lblGameResultOutput = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctPlayerCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPlayerCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPlayerCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPlayerCard5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPlayerCard6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPlayerCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctDealerCard6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctDealerCard5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctDealerCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctDealerCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctDealerCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctDealerCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBetAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateDeck
            // 
            this.btnCreateDeck.Location = new System.Drawing.Point(133, 12);
            this.btnCreateDeck.Name = "btnCreateDeck";
            this.btnCreateDeck.Size = new System.Drawing.Size(75, 23);
            this.btnCreateDeck.TabIndex = 0;
            this.btnCreateDeck.Text = "Create Deck";
            this.btnCreateDeck.UseVisualStyleBackColor = true;
            this.btnCreateDeck.Click += new System.EventHandler(this.btnCreateDeck_Click);
            // 
            // btnGetRandomCard
            // 
            this.btnGetRandomCard.Location = new System.Drawing.Point(117, 41);
            this.btnGetRandomCard.Name = "btnGetRandomCard";
            this.btnGetRandomCard.Size = new System.Drawing.Size(116, 23);
            this.btnGetRandomCard.TabIndex = 1;
            this.btnGetRandomCard.Text = "Get Random Card";
            this.btnGetRandomCard.UseVisualStyleBackColor = true;
            this.btnGetRandomCard.Click += new System.EventHandler(this.btnGetRandomCard_Click);
            // 
            // btnShuffleDeck
            // 
            this.btnShuffleDeck.Location = new System.Drawing.Point(133, 70);
            this.btnShuffleDeck.Name = "btnShuffleDeck";
            this.btnShuffleDeck.Size = new System.Drawing.Size(75, 23);
            this.btnShuffleDeck.TabIndex = 2;
            this.btnShuffleDeck.Text = "Shuffle Deck";
            this.btnShuffleDeck.UseVisualStyleBackColor = true;
            this.btnShuffleDeck.Click += new System.EventHandler(this.btnShuffleDeck_Click);
            // 
            // btnDealToPlayer
            // 
            this.btnDealToPlayer.Location = new System.Drawing.Point(277, 12);
            this.btnDealToPlayer.Name = "btnDealToPlayer";
            this.btnDealToPlayer.Size = new System.Drawing.Size(122, 23);
            this.btnDealToPlayer.TabIndex = 3;
            this.btnDealToPlayer.Text = "Deal Card to Player";
            this.btnDealToPlayer.UseVisualStyleBackColor = true;
            this.btnDealToPlayer.Click += new System.EventHandler(this.btnDealToPlayer_Click);
            // 
            // btnEmptyPlayerHand
            // 
            this.btnEmptyPlayerHand.Location = new System.Drawing.Point(277, 41);
            this.btnEmptyPlayerHand.Name = "btnEmptyPlayerHand";
            this.btnEmptyPlayerHand.Size = new System.Drawing.Size(122, 23);
            this.btnEmptyPlayerHand.TabIndex = 4;
            this.btnEmptyPlayerHand.Text = "Empty Player\'s Hand";
            this.btnEmptyPlayerHand.UseVisualStyleBackColor = true;
            this.btnEmptyPlayerHand.Click += new System.EventHandler(this.btnEmptyPlayerHand_Click);
            // 
            // btnEmptyDiscardPile
            // 
            this.btnEmptyDiscardPile.Location = new System.Drawing.Point(277, 70);
            this.btnEmptyDiscardPile.Name = "btnEmptyDiscardPile";
            this.btnEmptyDiscardPile.Size = new System.Drawing.Size(122, 23);
            this.btnEmptyDiscardPile.TabIndex = 5;
            this.btnEmptyDiscardPile.Text = "Empty Discard Pile";
            this.btnEmptyDiscardPile.UseVisualStyleBackColor = true;
            this.btnEmptyDiscardPile.Click += new System.EventHandler(this.btnEmptyDiscardPile_Click);
            // 
            // pctPlayerCard1
            // 
            this.pctPlayerCard1.Location = new System.Drawing.Point(327, 453);
            this.pctPlayerCard1.Name = "pctPlayerCard1";
            this.pctPlayerCard1.Size = new System.Drawing.Size(72, 97);
            this.pctPlayerCard1.TabIndex = 6;
            this.pctPlayerCard1.TabStop = false;
            this.pctPlayerCard1.Visible = false;
            // 
            // btnLoadCardImage
            // 
            this.btnLoadCardImage.Location = new System.Drawing.Point(288, 99);
            this.btnLoadCardImage.Name = "btnLoadCardImage";
            this.btnLoadCardImage.Size = new System.Drawing.Size(111, 23);
            this.btnLoadCardImage.TabIndex = 7;
            this.btnLoadCardImage.Text = "Load Card Image";
            this.btnLoadCardImage.UseVisualStyleBackColor = true;
            this.btnLoadCardImage.Click += new System.EventHandler(this.btnLoadCardImage_Click);
            // 
            // pctPlayerCard3
            // 
            this.pctPlayerCard3.Location = new System.Drawing.Point(379, 453);
            this.pctPlayerCard3.Name = "pctPlayerCard3";
            this.pctPlayerCard3.Size = new System.Drawing.Size(72, 97);
            this.pctPlayerCard3.TabIndex = 9;
            this.pctPlayerCard3.TabStop = false;
            this.pctPlayerCard3.Visible = false;
            // 
            // pctPlayerCard4
            // 
            this.pctPlayerCard4.Location = new System.Drawing.Point(405, 453);
            this.pctPlayerCard4.Name = "pctPlayerCard4";
            this.pctPlayerCard4.Size = new System.Drawing.Size(72, 97);
            this.pctPlayerCard4.TabIndex = 10;
            this.pctPlayerCard4.TabStop = false;
            this.pctPlayerCard4.Visible = false;
            // 
            // pctPlayerCard5
            // 
            this.pctPlayerCard5.Location = new System.Drawing.Point(430, 453);
            this.pctPlayerCard5.Name = "pctPlayerCard5";
            this.pctPlayerCard5.Size = new System.Drawing.Size(72, 97);
            this.pctPlayerCard5.TabIndex = 11;
            this.pctPlayerCard5.TabStop = false;
            this.pctPlayerCard5.Visible = false;
            // 
            // pctPlayerCard6
            // 
            this.pctPlayerCard6.Location = new System.Drawing.Point(457, 453);
            this.pctPlayerCard6.Name = "pctPlayerCard6";
            this.pctPlayerCard6.Size = new System.Drawing.Size(72, 97);
            this.pctPlayerCard6.TabIndex = 12;
            this.pctPlayerCard6.TabStop = false;
            this.pctPlayerCard6.Visible = false;
            // 
            // pctPlayerCard2
            // 
            this.pctPlayerCard2.Location = new System.Drawing.Point(352, 453);
            this.pctPlayerCard2.Name = "pctPlayerCard2";
            this.pctPlayerCard2.Size = new System.Drawing.Size(72, 97);
            this.pctPlayerCard2.TabIndex = 8;
            this.pctPlayerCard2.TabStop = false;
            this.pctPlayerCard2.Visible = false;
            // 
            // lblHandValueTitle
            // 
            this.lblHandValueTitle.AutoSize = true;
            this.lblHandValueTitle.Location = new System.Drawing.Point(343, 418);
            this.lblHandValueTitle.Name = "lblHandValueTitle";
            this.lblHandValueTitle.Size = new System.Drawing.Size(98, 13);
            this.lblHandValueTitle.TabIndex = 13;
            this.lblHandValueTitle.Text = "Player Hand Value:";
            // 
            // lblHandValueOutput
            // 
            this.lblHandValueOutput.AutoSize = true;
            this.lblHandValueOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHandValueOutput.Location = new System.Drawing.Point(452, 418);
            this.lblHandValueOutput.Name = "lblHandValueOutput";
            this.lblHandValueOutput.Size = new System.Drawing.Size(14, 13);
            this.lblHandValueOutput.TabIndex = 14;
            this.lblHandValueOutput.Text = "0";
            // 
            // pctDealerCard6
            // 
            this.pctDealerCard6.Location = new System.Drawing.Point(457, 235);
            this.pctDealerCard6.Name = "pctDealerCard6";
            this.pctDealerCard6.Size = new System.Drawing.Size(72, 97);
            this.pctDealerCard6.TabIndex = 20;
            this.pctDealerCard6.TabStop = false;
            this.pctDealerCard6.Visible = false;
            // 
            // pctDealerCard5
            // 
            this.pctDealerCard5.Location = new System.Drawing.Point(430, 235);
            this.pctDealerCard5.Name = "pctDealerCard5";
            this.pctDealerCard5.Size = new System.Drawing.Size(72, 97);
            this.pctDealerCard5.TabIndex = 19;
            this.pctDealerCard5.TabStop = false;
            this.pctDealerCard5.Visible = false;
            // 
            // pctDealerCard4
            // 
            this.pctDealerCard4.Location = new System.Drawing.Point(405, 235);
            this.pctDealerCard4.Name = "pctDealerCard4";
            this.pctDealerCard4.Size = new System.Drawing.Size(72, 97);
            this.pctDealerCard4.TabIndex = 18;
            this.pctDealerCard4.TabStop = false;
            this.pctDealerCard4.Visible = false;
            // 
            // pctDealerCard3
            // 
            this.pctDealerCard3.Location = new System.Drawing.Point(379, 235);
            this.pctDealerCard3.Name = "pctDealerCard3";
            this.pctDealerCard3.Size = new System.Drawing.Size(72, 97);
            this.pctDealerCard3.TabIndex = 17;
            this.pctDealerCard3.TabStop = false;
            this.pctDealerCard3.Visible = false;
            // 
            // pctDealerCard2
            // 
            this.pctDealerCard2.Location = new System.Drawing.Point(352, 235);
            this.pctDealerCard2.Name = "pctDealerCard2";
            this.pctDealerCard2.Size = new System.Drawing.Size(72, 97);
            this.pctDealerCard2.TabIndex = 16;
            this.pctDealerCard2.TabStop = false;
            this.pctDealerCard2.Visible = false;
            // 
            // pctDealerCard1
            // 
            this.pctDealerCard1.Location = new System.Drawing.Point(327, 235);
            this.pctDealerCard1.Name = "pctDealerCard1";
            this.pctDealerCard1.Size = new System.Drawing.Size(72, 97);
            this.pctDealerCard1.TabIndex = 15;
            this.pctDealerCard1.TabStop = false;
            this.pctDealerCard1.Visible = false;
            // 
            // lblDealerHandValueTitle
            // 
            this.lblDealerHandValueTitle.AutoSize = true;
            this.lblDealerHandValueTitle.Location = new System.Drawing.Point(343, 186);
            this.lblDealerHandValueTitle.Name = "lblDealerHandValueTitle";
            this.lblDealerHandValueTitle.Size = new System.Drawing.Size(100, 13);
            this.lblDealerHandValueTitle.TabIndex = 21;
            this.lblDealerHandValueTitle.Text = "Dealer Hand Value:";
            this.lblDealerHandValueTitle.Visible = false;
            // 
            // lblDealerHandValueOutput
            // 
            this.lblDealerHandValueOutput.AutoSize = true;
            this.lblDealerHandValueOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealerHandValueOutput.Location = new System.Drawing.Point(452, 186);
            this.lblDealerHandValueOutput.Name = "lblDealerHandValueOutput";
            this.lblDealerHandValueOutput.Size = new System.Drawing.Size(14, 13);
            this.lblDealerHandValueOutput.TabIndex = 22;
            this.lblDealerHandValueOutput.Text = "0";
            this.lblDealerHandValueOutput.Visible = false;
            // 
            // btnDealCardToDealer
            // 
            this.btnDealCardToDealer.Location = new System.Drawing.Point(405, 12);
            this.btnDealCardToDealer.Name = "btnDealCardToDealer";
            this.btnDealCardToDealer.Size = new System.Drawing.Size(124, 23);
            this.btnDealCardToDealer.TabIndex = 23;
            this.btnDealCardToDealer.Text = "Deal Card to Dealer";
            this.btnDealCardToDealer.UseVisualStyleBackColor = true;
            this.btnDealCardToDealer.Click += new System.EventHandler(this.btnDealCardToDealer_Click);
            // 
            // btnEmptyDealerHand
            // 
            this.btnEmptyDealerHand.Location = new System.Drawing.Point(405, 41);
            this.btnEmptyDealerHand.Name = "btnEmptyDealerHand";
            this.btnEmptyDealerHand.Size = new System.Drawing.Size(124, 23);
            this.btnEmptyDealerHand.TabIndex = 24;
            this.btnEmptyDealerHand.Text = "Empty Dealer\'s Hand";
            this.btnEmptyDealerHand.UseVisualStyleBackColor = true;
            this.btnEmptyDealerHand.Click += new System.EventHandler(this.btnEmptyDealerHand_Click);
            // 
            // btnStartNewGame
            // 
            this.btnStartNewGame.Location = new System.Drawing.Point(84, 261);
            this.btnStartNewGame.Name = "btnStartNewGame";
            this.btnStartNewGame.Size = new System.Drawing.Size(124, 23);
            this.btnStartNewGame.TabIndex = 25;
            this.btnStartNewGame.Text = "Start New Game";
            this.btnStartNewGame.UseVisualStyleBackColor = true;
            this.btnStartNewGame.Click += new System.EventHandler(this.btnStartNewGame_Click);
            // 
            // numBetAmount
            // 
            this.numBetAmount.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numBetAmount.Location = new System.Drawing.Point(117, 235);
            this.numBetAmount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numBetAmount.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numBetAmount.Name = "numBetAmount";
            this.numBetAmount.Size = new System.Drawing.Size(120, 20);
            this.numBetAmount.TabIndex = 26;
            this.numBetAmount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lblBetAmount
            // 
            this.lblBetAmount.AutoSize = true;
            this.lblBetAmount.Location = new System.Drawing.Point(46, 237);
            this.lblBetAmount.Name = "lblBetAmount";
            this.lblBetAmount.Size = new System.Drawing.Size(65, 13);
            this.lblBetAmount.TabIndex = 27;
            this.lblBetAmount.Text = "Bet Amount:";
            // 
            // lblPlayer1Bet
            // 
            this.lblPlayer1Bet.AutoSize = true;
            this.lblPlayer1Bet.Location = new System.Drawing.Point(343, 369);
            this.lblPlayer1Bet.Name = "lblPlayer1Bet";
            this.lblPlayer1Bet.Size = new System.Drawing.Size(63, 13);
            this.lblPlayer1Bet.TabIndex = 28;
            this.lblPlayer1Bet.Text = "Current Bet:";
            // 
            // lblPlayer1CurrentBetOutput
            // 
            this.lblPlayer1CurrentBetOutput.AutoSize = true;
            this.lblPlayer1CurrentBetOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1CurrentBetOutput.Location = new System.Drawing.Point(441, 369);
            this.lblPlayer1CurrentBetOutput.Name = "lblPlayer1CurrentBetOutput";
            this.lblPlayer1CurrentBetOutput.Size = new System.Drawing.Size(21, 13);
            this.lblPlayer1CurrentBetOutput.TabIndex = 29;
            this.lblPlayer1CurrentBetOutput.Text = "$0";
            // 
            // lblPlayerBankroll
            // 
            this.lblPlayerBankroll.AutoSize = true;
            this.lblPlayerBankroll.Location = new System.Drawing.Point(46, 206);
            this.lblPlayerBankroll.Name = "lblPlayerBankroll";
            this.lblPlayerBankroll.Size = new System.Drawing.Size(51, 13);
            this.lblPlayerBankroll.TabIndex = 30;
            this.lblPlayerBankroll.Text = "Bankroll: ";
            // 
            // lblPlayer1BankrollOutput
            // 
            this.lblPlayer1BankrollOutput.AutoSize = true;
            this.lblPlayer1BankrollOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1BankrollOutput.Location = new System.Drawing.Point(114, 206);
            this.lblPlayer1BankrollOutput.Name = "lblPlayer1BankrollOutput";
            this.lblPlayer1BankrollOutput.Size = new System.Drawing.Size(21, 13);
            this.lblPlayer1BankrollOutput.TabIndex = 31;
            this.lblPlayer1BankrollOutput.Text = "$0";
            // 
            // lblGameResultOutput
            // 
            this.lblGameResultOutput.AutoSize = true;
            this.lblGameResultOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameResultOutput.Location = new System.Drawing.Point(46, 319);
            this.lblGameResultOutput.Name = "lblGameResultOutput";
            this.lblGameResultOutput.Size = new System.Drawing.Size(163, 25);
            this.lblGameResultOutput.TabIndex = 32;
            this.lblGameResultOutput.Text = "(Game Result)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 562);
            this.Controls.Add(this.lblGameResultOutput);
            this.Controls.Add(this.lblPlayer1BankrollOutput);
            this.Controls.Add(this.lblPlayerBankroll);
            this.Controls.Add(this.lblPlayer1CurrentBetOutput);
            this.Controls.Add(this.lblPlayer1Bet);
            this.Controls.Add(this.lblBetAmount);
            this.Controls.Add(this.numBetAmount);
            this.Controls.Add(this.btnStartNewGame);
            this.Controls.Add(this.btnEmptyDealerHand);
            this.Controls.Add(this.btnDealCardToDealer);
            this.Controls.Add(this.lblDealerHandValueOutput);
            this.Controls.Add(this.lblDealerHandValueTitle);
            this.Controls.Add(this.pctDealerCard6);
            this.Controls.Add(this.pctDealerCard5);
            this.Controls.Add(this.pctDealerCard4);
            this.Controls.Add(this.pctDealerCard3);
            this.Controls.Add(this.pctDealerCard2);
            this.Controls.Add(this.pctDealerCard1);
            this.Controls.Add(this.lblHandValueOutput);
            this.Controls.Add(this.lblHandValueTitle);
            this.Controls.Add(this.pctPlayerCard6);
            this.Controls.Add(this.pctPlayerCard5);
            this.Controls.Add(this.pctPlayerCard4);
            this.Controls.Add(this.pctPlayerCard3);
            this.Controls.Add(this.pctPlayerCard2);
            this.Controls.Add(this.btnLoadCardImage);
            this.Controls.Add(this.btnEmptyDiscardPile);
            this.Controls.Add(this.btnEmptyPlayerHand);
            this.Controls.Add(this.btnDealToPlayer);
            this.Controls.Add(this.btnShuffleDeck);
            this.Controls.Add(this.btnGetRandomCard);
            this.Controls.Add(this.btnCreateDeck);
            this.Controls.Add(this.pctPlayerCard1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pctPlayerCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPlayerCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPlayerCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPlayerCard5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPlayerCard6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPlayerCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctDealerCard6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctDealerCard5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctDealerCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctDealerCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctDealerCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctDealerCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBetAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateDeck;
        private System.Windows.Forms.Button btnGetRandomCard;
        private System.Windows.Forms.Button btnShuffleDeck;
        private System.Windows.Forms.Button btnDealToPlayer;
        private System.Windows.Forms.Button btnEmptyPlayerHand;
        private System.Windows.Forms.Button btnEmptyDiscardPile;
        private System.Windows.Forms.PictureBox pctPlayerCard1;
        private System.Windows.Forms.Button btnLoadCardImage;
        private System.Windows.Forms.PictureBox pctPlayerCard3;
        private System.Windows.Forms.PictureBox pctPlayerCard4;
        private System.Windows.Forms.PictureBox pctPlayerCard5;
        private System.Windows.Forms.PictureBox pctPlayerCard6;
        private System.Windows.Forms.PictureBox pctPlayerCard2;
        private System.Windows.Forms.Label lblHandValueTitle;
        private System.Windows.Forms.Label lblHandValueOutput;
        private System.Windows.Forms.PictureBox pctDealerCard6;
        private System.Windows.Forms.PictureBox pctDealerCard5;
        private System.Windows.Forms.PictureBox pctDealerCard4;
        private System.Windows.Forms.PictureBox pctDealerCard3;
        private System.Windows.Forms.PictureBox pctDealerCard2;
        private System.Windows.Forms.PictureBox pctDealerCard1;
        private System.Windows.Forms.Label lblDealerHandValueTitle;
        private System.Windows.Forms.Label lblDealerHandValueOutput;
        private System.Windows.Forms.Button btnDealCardToDealer;
        private System.Windows.Forms.Button btnEmptyDealerHand;
        private System.Windows.Forms.Button btnStartNewGame;
        private System.Windows.Forms.NumericUpDown numBetAmount;
        private System.Windows.Forms.Label lblBetAmount;
        private System.Windows.Forms.Label lblPlayer1Bet;
        private System.Windows.Forms.Label lblPlayer1CurrentBetOutput;
        private System.Windows.Forms.Label lblPlayerBankroll;
        private System.Windows.Forms.Label lblPlayer1BankrollOutput;
        private System.Windows.Forms.Label lblGameResultOutput;
    }
}

