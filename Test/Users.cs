using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Test
{
    [TestClass]
    public class Users
    {
        [TestMethod]
        public void Show()
        {
            var result = Twitter.Library.Users.Show("david_loo");
            Assert.IsNotNull(result, "returned a null user object.");
        }

        [TestMethod]
        public void Lookup()
        {
            var result = Twitter.Library.Users.Lookup("david_loo, twitter");
            Assert.IsNotNull(result, "returned a null user object.");
        }
    }
}
