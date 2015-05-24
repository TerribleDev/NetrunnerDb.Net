using System;
using System.Linq;
using NetrunnerDb.Net.Responses;
using NUnit.Framework;

namespace NetrunnerDb.Net.AcceptanceTests
{
    [TestFixture(Category = "Acceptance", Description = "Basic, hey can we do the things this project intends to do")]
    public class QueryThings
    {
        [Test]
        public void OneCard()
        {
            Assert.AreEqual(new Repository().GetCard("01001").First().Title, "Noise: Hacker Extraordinaire");
        }
        [Test]
        public void Cards()
        {
            Assert.IsTrue(new Repository().GetCards().Count > 100);
        }
        [Test]
        public void Set()
        {
            Assert.IsTrue(new Repository().GetSet("tsb").Count > 10);
        }
        [Test]
        public void Sets()
        {
            Assert.IsTrue(new Repository().GetSets().Count > 10);
        }
        [Test]
        public void Decklist()
        {
            Assert.AreEqual(20866, new Repository().GetRequest<Decklist>("20866").First().Id);
        }
        [Test]
        public void DecklistByDate()
        {
            var targetDate = new DateTime(2014, 01, 01);
            Assert.IsTrue(new Repository().GetRequest<DecklistByDate>(targetDate.ToString("MM/dd/yyyy")).All(a =>
            {
                var parseDate = DateTime.Parse(a.Creation);
                return (parseDate >= targetDate && parseDate <= parseDate.AddDays(1).AddMinutes(-1));
            }));
        }
    }
}
