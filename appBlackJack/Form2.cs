using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appBlackJack
{
    public partial class Form2 : Form
    {

        public string PlayerName { get; set; }
        public Form2()
        {
            InitializeComponent();
           
        }

        //Initializing
        int cardNumber, cardValue, dealerCardNumber, dealerCardValue;

        Random randomGen = new Random();
        
        private int currentCardIndex = -1;
        private int playerTotal = 0;
        private int dealerTotal = 0;

        //Hit button
        private void btnHit_Click(object sender, EventArgs e)
        {
            //If card hand 3-5 is empty it will loop to keep adding cards everytime "hit" is pressed

            do
            {
                cardNumber = randomGen.Next(0,52);
            }while(cardNumber == cardValue ||
            (picPHand3.Image != null && picPHand4.Image != null && picPHand5.Image != null));

            //Taking a random value and displaying the card with that value
            if(picPHand3.Image == null )
            {
                picPHand3.Image = imgCardList.Images[cardNumber];
                picPHand3.Visible = true;
                cardValue = cardNumber;
            }
            else if(picPHand4.Image == null)
            {
                picPHand4.Image = imgCardList.Images[cardNumber];
                picPHand4.Visible = true;
                cardValue = cardNumber;
            }

            else if (picPHand5.Image == null)
            {
                picPHand5.Image = imgCardList.Images[cardNumber];
                picPHand5.Visible = true;
                cardValue = cardNumber;
            }

            //Getting the numerical value of the card
            cardValue = calcCardValue(cardNumber);

            //Calculating and displaying the total
            playerTotal += cardValue;

            lblYourScore.Text = "Your score: " + playerTotal;

            //Checking for an instant win
            instantWin();
            
        }
        
        //stand button
        private void btnStand_Click(object sender, EventArgs e)
        {
            //Checking for the winner when "stand" is pressed and hiding/showing buttons/labels
            determineWinner();

            btnHit.Visible = false;
            btnStand.Visible = false;
            lblResult.Visible = true;

        }

       
        //Play again button
        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            //Resseting Totals
            playerTotal = 0;
            dealerTotal = 0;

            //Resetting card images
            picPHand1.Image = null;
            picPHand2.Image = null;
            picPHand3.Image = null;
            picPHand4.Image = null;
            picPHand5.Image = null;
            picDCard1.Image = null;
            picDCard2.Image = null;

            //Hiding cards
            picPHand3.Visible = false;
            picPHand4.Visible = false;
            picPHand5.Visible = false;

            //Resseting card index
            currentCardIndex = -1;

            //Hiding the Play Again button
            btnPlayAgain.Visible = false;

            //Displaying the start button again
            btnStart.Visible = true;

            //Resseting the score labels and result label
            lblYourScore.Text = "Your score: 0";
            lblDealerScore.Text = "Dealers score: 0";
            lblResult.Visible = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //Draw 2 cards for player
            drawPlayerCard(picPHand1);
            drawPlayerCard(picPHand2);

           
           //Display the player score
            lblYourScore.Text = "Your score: " + playerTotal;

            //Check for instant win
            instantWin();
           
        }

        //Assigning values to each index in the image list / giving the cards values
        private int calcCardValue(int cardNumber) {
            switch (cardNumber)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                    cardValue = 2;
                    break;

                case 4:
                case 5:
                case 6:
                case 7:
                    cardValue = 3;
                    break;

                case 8:
                case 9:
                case 10:
                case 11:
                    cardValue = 4;
                    break;




                case 12:
                case 13:
                case 14:
                case 15:
                    cardValue = 5;
                    break;



                case 16:
                case 17:
                case 18:
                case 19:
                    cardValue = 6;
                    break;




                case 20:
                case 21:
                case 22:
                case 23:
                    cardValue = 7;
                    break;



                case 24:
                case 25:
                case 26:
                case 27:
                    cardValue = 8;
                    break;

                case 28:
                case 29:
                case 30:
                case 31:
                    cardValue = 9;
                    break;
                case 32:
                case 33:
                case 34:
                case 35:
                case 36:
                case 37:
                case 38:
                case 39:
                case 40:
                case 41:
                case 42:
                case 43:
                case 44:
                case 45:
                case 46:
                case 47:
                    cardValue = 10;
                    break;
                case 48:
                case 49:
                case 50:
                case 51:
                    cardValue = 11;
                    break;


                default:
                    cardValue = 0;
                    break;
            }

            //Returning the card value
            return cardValue;
        }

     
        //Method to draw a card for the player
        private void drawPlayerCard(PictureBox pictureBox)
        {
            //A loop checking if hand 3-5 is empty and showing/hiding buttons and picture boxes
            do
            {
                cardNumber = randomGen.Next(0, 52);
            }while(cardNumber == currentCardIndex ||
            picPHand3.Image != null && picPHand4.Image != null && picPHand5.Image != null);

            pictureBox.Image = imgCardList.Images[cardNumber];
            pictureBox.Visible = true;
            currentCardIndex = cardNumber;


        cardValue = calcCardValue(cardNumber);

            picDCard1.Visible = true;
            picDCard2.Visible = true;
            btnStart.Visible = false;
            btnHit.Visible = true;
            btnStand.Visible = true;

            playerTotal += cardValue;
        }

        //Taking the players first name from form1 and displaying it
        private void Form2_Load(object sender, EventArgs e)
        {
            lblYourCards.Text = PlayerName + "'s Cards";
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            StringBuilder messageBuilder = new StringBuilder();
           messageBuilder.AppendLine($"Hello { PlayerName}" );
            messageBuilder.AppendLine($"The rules of the game are easy.");
            messageBuilder.AppendLine($"Press Start.");
            messageBuilder.AppendLine("If the two cards you are giving are close to 21, press stand.");
            messageBuilder.AppendLine("If the cards are not close to 21 press hit.");
            messageBuilder.AppendLine("If the value of your cards is 21, you win!");
            messageBuilder.AppendLine("If the value of your cards exceeds 21, you lose.");
            messageBuilder.AppendLine("If the value of your cards is the same as the dealers, its a tie.");

            MessageBox.Show(messageBuilder.ToString(), "Help Facility", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        //Method to draw dealer cards
        private void drawDealerCard(PictureBox pictureBox)
        {
            //A loop giving the dealer a card with an index between 24 and 52
            
            do
            {
                dealerCardNumber = randomGen.Next(24, 52);
                dealerCardValue = calcCardValue(dealerCardNumber);
            } while (dealerCardValue > 32);

            pictureBox.Image = imgCardList.Images[dealerCardNumber];

            //Storing the dealers score
            dealerTotal += dealerCardValue;
        }

        //Checking for an instant win
        private void instantWin()
        {
            if (playerTotal > 21 || playerTotal == 21 || picPHand5.Image != null)
            {
                determineWinner();
            }

            else if (dealerTotal > 21 || dealerTotal == 21)
            {
                determineWinner();
            }
        }

        //Determining a winner when "stand" is pressed
        private void determineWinner()
        {
            

            lblResult.Visible = true;

            //Draw 2 cards for dealer
            drawDealerCard(picDCard1);
            drawDealerCard(picDCard2);

            //Displaying it in a label and making the text colour different depending on the outcome
            if (playerTotal > 21)
            {
                lblResult.Text = "Player Bust! Dealer Wins!";
                lblResult.ForeColor = Color.Red;
            }

            else if(playerTotal == 21 && dealerTotal == 21)
            {
                lblResult.Text = "Its a tie!";
                lblResult.ForeColor = Color.Red;
            }

            else if (playerTotal == 21 || dealerTotal > 21 || playerTotal > dealerTotal)
            {
                lblResult.Text = "Player Wins!";
                lblResult.ForeColor = Color.Green;
            }

            else if (dealerTotal == 21 || playerTotal < dealerTotal )
            {
                lblResult.Text = "Dealer Wins!";
                lblResult.ForeColor = Color.Red;
            }

            else
            {
                lblResult.Text =  "Its a tie!";
                lblResult.ForeColor = Color.Red;
            }


            //Showing the dealers score
            lblDealerScore.Text = "Dealers score: " + dealerTotal;

            //Hiding and displaying buttons allowing the user to play again
            btnStand.Visible = false;
            btnHit.Visible = false;
            btnPlayAgain.Visible = true;
            }

      

        
    }
}
