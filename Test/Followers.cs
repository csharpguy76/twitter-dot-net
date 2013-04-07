using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class Followers
    {
        [TestMethod]
        public void IdList()
        {
            var results = Twitter.Library.Followers.Ids("david_loo");
            Assert.IsNotNull(results);
        }
    }
}
