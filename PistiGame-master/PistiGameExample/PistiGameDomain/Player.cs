using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PistiGameDomain
{
    public class Player
    {
        public string Name { get;}
        public int Score { get; set; }
        public int CountOfPisti { get; set; } 
        public List<Card> PlayerCards { get; set; }
        public List<Card> WinCards { get; set; }


        public Player(string name)
        {
            Name = name;
            PlayerCards = new List<Card>();
            WinCards = new List<Card>();
            CountOfPisti = 0;
        }
    }
}
