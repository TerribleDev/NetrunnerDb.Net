using System;
using System.Linq;
using NetrunnerDb.Net.Responses;
using NUnit.Framework;

namespace NetrunnerDb.Net.UnitTests.RequestTests
{
    [TestFixture(Category = "Unit")]
    public class EndpointInterfaceTesting
    {
        [Test]
        public void TestSmallEndpoints()
        {
            Assert.Throws<ArgumentOutOfRangeException>(()=>new Cards().EndPoint("not null string"));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Sets().EndPoint("not null string"));
            Assert.Throws<ArgumentNullException>(() => new Decklist().EndPoint(String.Empty));
            Assert.Throws<ArgumentNullException>(() => new Set().EndPoint(String.Empty));
            Assert.Throws<ArgumentOutOfRangeException>(() => new OneCard().EndPoint(String.Empty));

        }

        [Test]
        public void TestDecklistEndpoint()
        {
            Assert.Throws<ArgumentNullException>(() => new DecklistByDate().EndPoint(String.Empty));
            Assert.Throws<FormatException>(() => new DecklistByDate().EndPoint("awesome"));
            var decklistByDate = new DecklistByDate();
            var decklistEndpoint = decklistByDate.EndPoint("01/01/2014");
            var date = decklistEndpoint.Split('/').Last();
            Assert.AreEqual(date, "2014-01-01");
        }
    }
}
