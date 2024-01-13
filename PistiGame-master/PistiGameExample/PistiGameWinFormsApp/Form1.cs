using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PistiGameDomain;


namespace PistiGameWinFormsApp
{
    public partial class Form1 : Form
    {
        
        Game newGame = new Game();
        List<String> pictureItems;
        int winPoint = 0;


        
        public Form1( )
        {




            InitializeComponent();
        }

        private void Players_Click(object sender, EventArgs e)
        {
            var card = sender as PictureBox;
            if (card.ImageLocation!= null && Convert.ToInt32(card.Tag)==1)
            {
                newGame.PutCardAtTable(card.ImageLocation, newGame.Player1);
                pBoxMiddle.ImageLocation = card.ImageLocation;
                if (newGame.IsHit())
                {
                    pBoxMiddle.ImageLocation = null;
                }
                newGame.ChangeActivePlayer(newGame.Player1);              
                card.ImageLocation = null;
                grpPlayer1.Visible = false;
                grpPlayer2.Visible = true;                
            }
            else if (card.ImageLocation != newGame.myDeck.closedCardPath && Convert.ToInt32(card.Tag) == 2)
            {
                newGame.PutCardAtTable(card.ImageLocation, newGame.Player2);
                pBoxMiddle.ImageLocation = card.ImageLocation;
                if (newGame.IsHit())
                {
                    pBoxMiddle.ImageLocation = null;
                }
                newGame.ChangeActivePlayer(newGame.Player2);
                card.ImageLocation = null;
                grpPlayer1.Visible = true;
                grpPlayer2.Visible = false;
            }

            if (pBoxPlayer1Card1.ImageLocation==null &&
                pBoxPlayer1Card2.ImageLocation == null &&
                pBoxPlayer1Card3.ImageLocation == null &&
                pBoxPlayer1Card4.ImageLocation == null &&
                pBoxPlayer2Card1.ImageLocation==null &&
                pBoxPlayer2Card2.ImageLocation == null &&
                pBoxPlayer2Card3.ImageLocation == null &&
                pBoxPlayer2Card4.ImageLocation == null )

            {
                btnDeal.Enabled = true;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            grpPlayer2.Visible = false;
            newGame.StartGame();
            pBoxMiddle.ImageLocation = newGame.CardsOfTable[3].CardImagePath;

            PutCardsOfPlayers();

        }
        public void winningPoint(int point)
        {

            winPoint = point;

        }

        public void listPicture(List<string> pictures)
        {
            pictureItems = pictures;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            


            foreach (PictureBox picture in grpPlayer2.Controls)
            {
                picture.ImageLocation = newGame.myDeck.closedCardPath;
            }
            foreach (PictureBox picture in grpPlayer1.Controls)
            {
                picture.ImageLocation = newGame.myDeck.closedCardPath;
            }
            pBoxMiddle.ImageLocation = newGame.myDeck.closedCardPath;


        }

        private void btnDeal_Click(object sender, EventArgs e)
        {
            int winScore = newGame.playerScore(newGame.ActivePlayer);
            int winScore2 = newGame.playerScore(newGame.ActivePlayer2);
            
               if (winScore < winPoint && winScore2 < winPoint)
                {
                     newGame.GiveCardOfPlayers();
                     PutCardsOfPlayers();
                }
              else
                 {

                     lblPlayer1Score.Text = "Player 1 Score: " + newGame.playerScore(newGame.ActivePlayer).ToString();
                     lblPlayer2Score.Text = "Player 2 Score: " + newGame.playerScore(newGame.ActivePlayer2).ToString();
                      MessageBox.Show("Oyun Sona Erdi ");

                 }
        }

        private void PutCardsOfPlayers()
        {
            pBoxPlayer1Card1.ImageLocation = newGame.Player1.PlayerCards[0].CardImagePath;
            pBoxPlayer1Card2.ImageLocation = newGame.Player1.PlayerCards[1].CardImagePath;
            pBoxPlayer1Card3.ImageLocation = newGame.Player1.PlayerCards[2].CardImagePath;
            pBoxPlayer1Card4.ImageLocation = newGame.Player1.PlayerCards[3].CardImagePath;

            pBoxPlayer2Card1.ImageLocation = newGame.Player2.PlayerCards[0].CardImagePath;
            pBoxPlayer2Card2.ImageLocation = newGame.Player2.PlayerCards[1].CardImagePath;
            pBoxPlayer2Card3.ImageLocation = newGame.Player2.PlayerCards[2].CardImagePath;
            pBoxPlayer2Card4.ImageLocation = newGame.Player2.PlayerCards[3].CardImagePath;
        }

        public void changeUsername(string username)
        {
            grpPlayer1.Text = username;
        }
        public void changeUsername2(string username)
        {
            grpPlayer2.Text = username;
        }



        private void btnAyarlar_Click(object sender, EventArgs e)
        {


            Ayarlar ayarlar = new Ayarlar(this);
            
            ayarlar.Show();
            
        }
    }
}
