using PistiGameDomain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PistiGameWinFormsApp
{
    public partial class Ayarlar : Form
    {

        String playerName;
        String playerName2;
        int point;
        
        private Form1 form1Reference;
        String winNo;
        
        Game newgame= new Game();
        
        public Ayarlar(Form1 form1)
        {

            InitializeComponent();

            form1Reference = form1;

            

            pictureUpDown.Items.Add("Kuru Kafa");
            pictureUpDown.Items.Add("Matem");
            pictureUpDown.Items.Add("Matem2");
            pictureUpDown.Items.Add("Leon");
            pictureUpDown.Items.Add("Hope");





            this.pictureUpDown.Text = "Klasik";
            
            


        }




        private void btnDegis_Click(object sender, EventArgs e)
        {
            
            if (txtName1.Text == null || txtName2.Text == null)
            {
                MessageBox.Show("Oyuncu İsimleri Varsayılan Olarak Ayarlandı !");
                playerName = "Player 1";
                playerName2 = "Player 2";
            }else
            {
                playerName = txtName1.Text; playerName2 = txtName2.Text;
            }


            


            winNo = txtPoint.Text;
            MessageBox.Show("Player 1 :"+ playerName + "/n" + "Player 2 :" + playerName2 + "/n" +  "Galibiyet Puanı :" + winNo + " Olarak Ayarlandı");
            point = int.Parse(winNo);

            form1Reference.winningPoint(point);

                form1Reference.changeUsername(playerName);
                form1Reference.changeUsername2(playerName2);

           
            
            if (this.pictureUpDown.Text== "Klasik")
            {
                foreach (PictureBox picture in form1Reference.grpPlayer2.Controls)
                {
                    picture.ImageLocation = newgame.myDeck.closedCardPath;
                }
                foreach (PictureBox picture in form1Reference.grpPlayer1.Controls)
                {
                    picture.ImageLocation = newgame.myDeck.closedCardPath;
                }
                form1Reference.pBoxMiddle.ImageLocation = newgame.myDeck.closedCardPath;

            }
            else
            {
                String items = pictureUpDown.SelectedItem.ToString();

                switch (items)
                {
                    case "Kuru Kafa":

                        foreach (PictureBox picture in form1Reference.grpPlayer2.Controls)
                        {
                            picture.ImageLocation = newgame.myDeck.kuruKafa;
                        }
                        foreach (PictureBox picture in form1Reference.grpPlayer1.Controls)
                        {
                            picture.ImageLocation = newgame.myDeck.kuruKafa;
                        }
                        form1Reference.pBoxMiddle.ImageLocation = newgame.myDeck.kuruKafa;
                        break;


                    case "Matem":
                        foreach (PictureBox picture in form1Reference.grpPlayer2.Controls)
                        {
                            picture.ImageLocation = newgame.myDeck.matem;
                        }
                        foreach (PictureBox picture in form1Reference.grpPlayer1.Controls)
                        {
                            picture.ImageLocation = newgame.myDeck.matem;
                        }
                        form1Reference.pBoxMiddle.ImageLocation = newgame.myDeck.matem;
                        break;
                    case "Matem2":
                        foreach (PictureBox picture in form1Reference.grpPlayer2.Controls)
                        {
                            picture.ImageLocation = newgame.myDeck.matem2;
                        }
                        foreach (PictureBox picture in form1Reference.grpPlayer1.Controls)
                        {
                            picture.ImageLocation = newgame.myDeck.matem2;
                        }
                        form1Reference.pBoxMiddle.ImageLocation = newgame.myDeck.matem2;
                        break;

                    case "Leon":
                        foreach (PictureBox picture in form1Reference.grpPlayer2.Controls)
                        {
                            picture.ImageLocation = newgame.myDeck.leon;
                        }
                        foreach (PictureBox picture in form1Reference.grpPlayer1.Controls)
                        {
                            picture.ImageLocation = newgame.myDeck.leon;
                        }
                        form1Reference.pBoxMiddle.ImageLocation = newgame.myDeck.leon;
                        break;

                    case "Hope":
                        foreach (PictureBox picture in form1Reference.grpPlayer2.Controls)
                        {
                            picture.ImageLocation = newgame.myDeck.hope;
                        }
                        foreach (PictureBox picture in form1Reference.grpPlayer1.Controls)
                        {
                            picture.ImageLocation = newgame.myDeck.hope;
                        }
                        form1Reference.pBoxMiddle.ImageLocation = newgame.myDeck.hope;
                        break;
                    default:
                        foreach (PictureBox picture in form1Reference.grpPlayer2.Controls)
                        {
                            picture.ImageLocation = newgame.myDeck.closedCardPath;
                        }
                        foreach (PictureBox picture in form1Reference.grpPlayer1.Controls)
                        {
                            picture.ImageLocation = newgame.myDeck.closedCardPath;
                        }
                        form1Reference.pBoxMiddle.ImageLocation = newgame.myDeck.closedCardPath;
                        break;


                }
            }

                



                    
                          


       
            this.Close();
            form1Reference.Show();


        }

        private void pictureUpDown_SelectedItemChanged(object sender, EventArgs e)
        {

        }
    }
}
