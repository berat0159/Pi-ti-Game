using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PistiGameDomain
{
    public class Deck
    {
        public List<Card> CardDeck;
        public Stack<Card> ShuffleCard;
        public string closedCardPath;
        public String kuruKafa,matem,matem2,hope,leon;
        public Deck()
        {
            CardDeck = new List<Card>();
            ShuffleCard = new Stack<Card>();
            GenerateCards();
        }

        private void GenerateCards()
        {
            for (int CardType = 0; CardType < 4; CardType++)
            {
                for (int CardNumber = 1; CardNumber <= 13; CardNumber++)
                {
                    Card newCard = new Card((CardTypes)CardType, CardNumber, @"C:\Users\Berat\Desktop\PistiGame-master\PistiGame-master\PistiGameExample\PistiGameDomain\Resources\" + (CardType * 13 + CardNumber) + ".png");
                    CardDeck.Add(newCard);
                }
            }
            closedCardPath = @"C:\Users\Berat\Desktop\PistiGame-master\PistiGame-master\PistiGameExample\PistiGameDomain\Resources\closedCard.png";
            kuruKafa = @"C:\Users\Berat\Desktop\PistiGame-master\PistiGame-master\PistiGameExample\PistiGameDomain\Resources\kurukafa.png";
            matem = @"C:\Users\Berat\Desktop\PistiGame-master\PistiGame-master\PistiGameExample\PistiGameDomain\Resources\matem.png";
            matem2 = @"C:\Users\Berat\Desktop\PistiGame-master\PistiGame-master\PistiGameExample\PistiGameDomain\Resources\matem2.png";
            leon = @"C:\Users\Berat\Desktop\PistiGame-master\PistiGame-master\PistiGameExample\PistiGameDomain\Resources\leon.png";
            hope = @"C:\Users\Berat\Desktop\PistiGame-master\PistiGame-master\PistiGameExample\PistiGameDomain\Resources\hope.png";
        }


        public void ShuffleCards(List<Card> deck)
        {
            Random rnd = new Random();
            int p = 0;
            while (deck.Count() > 0)
            {
                p = rnd.Next(0, deck.Count());
                ShuffleCard.Push(deck[p]);
                deck.RemoveAt(p);
            }
        }
    }
}
