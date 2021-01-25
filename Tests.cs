using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace GameOfWar
{
    public class Tests
    {
        [Test]
        public void Can_create_deck_of_52_count()
        {
            var cards = new Deck();
            Assert.That(cards.Count, Is.EqualTo(52));
        }

        [Test]
        public void Can_Test()
        {
          var deck = new Deck();
          Assert.That(deck.Cards.Count(c => c.Equals(2)), Is.EqualTo(4));
        }
    }
}