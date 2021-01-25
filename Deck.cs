using System.Collections.Generic;

namespace GameOfWar
{
    public class Deck
    {
        public List<int> Cards { get; set; }

        public Deck()
        {
            Cards = new List<int>();
            for (var i = 2; i < 15; i++)
            {
                for (var j = 0; j < 4; j++)
                {
                    Cards.Add(i);
                }
            }
        }
    }
}