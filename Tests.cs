using NUnit.Framework;
using System.Collections.Generic;

namespace GameOfWar
{
    public class Tests
    {
        [Test]
        public void Can_test()
        {
            var cards = new List<int>();
            Assert.That(cards.Count, Is.EqualTo(52));
        }
    }
}