using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
    [TestClass]
    public class BakeryTests
    {
        [TestMethod]
        public void Bread_ConstructsInstanceofBread_ObjBread()
        {
            Bread bread = new Bread(5);
            Assert.AreEqual(typeof(Bread), bread.GetType());
        }
    }
}