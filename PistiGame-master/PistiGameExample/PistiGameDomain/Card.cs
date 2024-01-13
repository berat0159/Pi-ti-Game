using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PistiGameDomain
{
    public class Card
    {
        public CardTypes CardType { get;}
        public int CardNumber { get;}
        public string CardImagePath { get;}
        public int CardValue
        {
            get
            {
                return CalculateNumberValue();
            }
        }

        private int CalculateNumberValue()
        {
            int value = 0;
            if (CardNumber == 1 || CardNumber==14 || CardNumber==27 || CardNumber==40)
                value = 1;
            else if (CardType == CardTypes.Club && CardNumber == 2)
                value = 2;
            else if (CardType == CardTypes.Diamond && CardNumber == 10)
                value = 3;
            else if (CardNumber == 11 || CardNumber==24 || CardNumber==37 || CardNumber==50)
                value = 1;
            else
                value = 0;
            return value;
        }

        public Card(CardTypes cardType, int cardNumber, string cardImagePath)
        {
            this.CardType = cardType;
            this.CardNumber = cardNumber;
            this.CardImagePath = cardImagePath;
        }
    }
}
