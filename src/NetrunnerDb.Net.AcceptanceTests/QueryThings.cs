using System;
using System.Linq;
using NUnit.Framework;

namespace NetrunnerDb.Net.AcceptanceTests
{
    [TestFixture(Category = "Acceptance", Description = "Basic, hey can we do the things this project intends to do")]
    public class QueryThings
    {
        [Test]
        public void OneCard()
        {
            var oneCards = new Repository().GetCard("01001");
            Assert.IsNotNull(oneCards);
            Assert.AreEqual(oneCards.First().Title, "Noise: Hacker Extraordinaire");
        }

        [Test]
        public void OneCardInvalid()
        {
            var oneCards = new Repository().GetCard("w00tcard");
            Assert.IsNull(oneCards);
        }

        [Test]
        public void Cards()
        {
            var result = new Repository().GetCards();
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Count > 100);
        }

        [Test]
        public void Set()
        {
            var sets = new Repository().GetSet("tsb");
            Assert.IsNotNull(sets);
            Assert.IsTrue(sets.Count > 10);
        }

        [Test]
        public void SetInvalid()
        {
            var set = new Repository().GetCard("I'm a set");
            Assert.IsNull(set);
        }

        [Test]
        public void Sets()
        {
            var setses = new Repository().GetSets();
            Assert.IsNotNull(setses);
            Assert.IsTrue(setses.Count > 10);
        }

        [Test]
        public void Decklist()
        {
            var decklists = new Repository().GetDecklist("20866");
            Assert.IsNotNull(decklists);
            Assert.AreEqual(20866, decklists.First().Id);
        }

        [Test]
        public void DecklistInvalid()
        {
            var card = new Repository().GetCard("I'm a bad decklist test");
            Assert.IsNull(card);
        }

        [Test]
        public void DecklistByDate()
        {
            var targetDate = new DateTime(2014, 01, 01);
            var decklistByDates = new Repository().GetDecklistForDay(targetDate);
            Assert.IsNotNull(decklistByDates);
            Assert.IsTrue(decklistByDates.All(a =>
            {
                var parseDate = DateTime.Parse(a.Creation);
                return (parseDate >= targetDate && parseDate <= parseDate.AddDays(1).AddMinutes(-1));
            }));
        }

        [Test]
        public void DecklistByDateInvalid()
        {
            var targetDate = new DateTime(1999,01,01);
            var decklistByDates = new Repository().GetDecklistForDay(targetDate);
            Assert.IsEmpty(decklistByDates);
        }
    }
}
