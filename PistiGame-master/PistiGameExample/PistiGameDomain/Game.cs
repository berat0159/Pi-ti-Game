using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PistiGameDomain
{
    public class Game
    {
        public CardTypes CardTypes { get; set; }
        public Deck myDeck;
        public List<CardTypes> player1Cards;
        public List<CardTypes> player2Cards;
        public Player Player1;
        public Player Player2;
        public Player ActivePlayer;
        public Player ActivePlayer2;
        public List<Card> CardsOfTable;

        public int pistiSayısı = 0;

        public Game()
        {
            myDeck = new Deck();
            myDeck.ShuffleCards(myDeck.CardDeck);
            Player1 = new Player("Serdar");
            Player2 = new Player("Kemal");
            ActivePlayer = Player1;
            ActivePlayer2 = Player2;
            CardsOfTable = new List<Card>();

        }

        public void StartGame()
        {
            PutCardsOnTable();
            GiveCardOfPlayers();
        }



        public void PutCardsOnTable()
        {
            for (int i = 0; i < 4; i++)
            {
                CardsOfTable.Add(myDeck.ShuffleCard.Pop());
            }
        }



        public bool IsHit()
        {
            bool result = false;
            if (CardsOfTable.Count() >= 2)
            {
                if (CardsOfTable.Count() == 2 && CardsOfTable[CardsOfTable.Count() - 1].CardNumber == CardsOfTable[CardsOfTable.Count() - 2].CardNumber)
                {
                    ActivePlayer.CountOfPisti++;
                    ActivePlayer.WinCards.AddRange(CardsOfTable);
                    CardsOfTable.Clear();
                    result = true;
                }
                else if (CardsOfTable[CardsOfTable.Count() - 1].CardNumber == CardsOfTable[CardsOfTable.Count() - 2].CardNumber
                    || CardsOfTable[CardsOfTable.Count() - 1].CardNumber % 13 == 11)
                {
                    result = true;
                    ActivePlayer.WinCards.AddRange(CardsOfTable);
                    CardsOfTable.Clear();
                }
            }
            return result;
        }





        public int playerScore(Player player)
        {
            int playerScore=(player.WinCards.Count/2)*10;

            foreach (Card card in player.WinCards)
            {
                CardTypes cardTypes = card.CardType;
                int cardNumber = card.CardNumber;
                // sinek ikili
                if (cardNumber == 2 && cardTypes == CardTypes.Club)
                {

                    playerScore += 2;

                }

                // Vale (J)
                if (cardTypes == CardTypes.Vale)
                {

                    playerScore += 1;
                }

                // As (A)

                if (cardTypes == CardTypes.As)
                {
                    playerScore += 1;
                }

                // Karo onlu
                if (cardNumber == 10 && cardTypes == CardTypes.Diamond)
                {

                    playerScore += 3;
                }



                // Vale Piştisi
                if (ActivePlayer.CountOfPisti > 0 && cardTypes == CardTypes.Vale)
                {

                    playerScore += 20;
                }

            }

            return playerScore;
        }
        
        

        public void GiveCardOfPlayers()
        {




            if (myDeck.ShuffleCard.Count()>0)
            {


                for (int i = 0; i < 4; i++)
                {
                    Player1.PlayerCards.Add(myDeck.ShuffleCard.Pop());
                }
                for (int i = 0; i < 4; i++)
                {
                    Player2.PlayerCards.Add(myDeck.ShuffleCard.Pop());
                }
            }
            else
            {

                    GameOver();

                
            }
        }

        private void GameOver()
        {
            throw new NotImplementedException();
        }

        public void PutCardAtTable(string imageLocation,Player Player)
        {
            int index = 0;
            for (int i = 0; i < Player.PlayerCards.Count; i++)
            {                
                if (Player.PlayerCards[i].CardImagePath==imageLocation)
                {
                    index = i;
                    break;
                }
            }
            CardsOfTable.Add(Player.PlayerCards[index]);
            Player.PlayerCards.Remove(Player.PlayerCards[index]);
        }

        public void ChangeActivePlayer(Player player)
        {
            if (player == Player1)
                ActivePlayer = Player2;
            else
                ActivePlayer = Player1;
        }
    }
}
