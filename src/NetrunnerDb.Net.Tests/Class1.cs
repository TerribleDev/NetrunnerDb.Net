using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetrunnerDb.Net.Responses;
using NUnit.Framework;

namespace NetrunnerDb.Net.Tests
{
    [TestFixture]
    public class Class1
    {
        [Test]
        [Ignore]
        public void Tst()
        {
            var cool = new Repository().GetRequest<Cards>("tsb");
        }
    }
}
