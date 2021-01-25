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
            var deck = new Deck();
            Assert.That(deck.Cards.Count, Is.EqualTo(52));
        }

        [Test]
        public void Can_create_deck_with_four_of_each_number()
        {
            var deck = new Deck();
            for (var i = 2; i < 15; i++)
            {
                Assert.That(deck.Cards.Count(c => c.Equals(i)), Is.EqualTo(4), $"Card: {i}");
            }
        }

        [Test]
        public void Can_deal_cards_to_two_players()
        {
            var deck = new Deck();
            var playerOne = new List<int>();
            var playerTwo = new List<int>();
            Assert.That(playerOne.Count, Is.EqualTo(26));
            Assert.That(playerTwo.Count, Is.EqualTo(26));
        }
    }
}