using System.Collections.Generic;

namespace GameOfWar
{
    public class Deck
    {
        public int Count { get; set; }
        public List<int> Cards { get; set; }
        

        public Deck()
        {
            Count = 52;
        }
    }
}