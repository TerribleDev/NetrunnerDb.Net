﻿using System;
using NetrunnerDb.Net.Responses;
using NUnit.Framework;

namespace NetrunnerDb.Net.UnitTests
{
    [TestFixture]
    public class Class1
    {
        [Test]
        [Ignore]
        public void Tst()
        {
           // var t = new BaseRequest();
            var cool = new Repository().GetRequest<Decklist>("20850");
            foreach (var x in cool[0].Cards)
            {
                Console.WriteLine(new Repository().GetRequest<OneCard>(x.Key)[0].Title + " x " + x.Value);
            }
        }
    }
}
