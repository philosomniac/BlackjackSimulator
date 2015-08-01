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
            ((System.ComponentModel.ISupportInitialize)(this.pctPlayerCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPlayerCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPlayerCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPlayerCard5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPlayerCard6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPlayerCard2)).BeginInit();
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
            this.lblHandValueTitle.Size = new System.Drawing.Size(103, 13);
            this.lblHandValueTitle.TabIndex = 13;
            this.lblHandValueTitle.Text = "Current Hand Value:";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 562);
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
            ((System.ComponentModel.ISupportInitialize)(this.pctPlayerCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPlayerCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPlayerCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPlayerCard5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPlayerCard6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPlayerCard2)).EndInit();
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
    }
}

