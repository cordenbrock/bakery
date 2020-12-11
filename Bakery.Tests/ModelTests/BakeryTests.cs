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
        [TestMethod]
        public void AdjustBreadCost_CalculateBreadDealAdjustment_IntAdjustment()
        {
            int expectedAdjustment = 10;

            Bread bread = new Bread(5);
            int loaves = 8;
            bread.AdjustBreadCost(loaves);

            Assert.AreEqual(expectedAdjustment, bread.AdjustBreadCost(loaves));
        }
        [TestMethod]
        public void CalcBreadTotal_CalculateTotalCostOfBreadOrder_IntSum()
        {
            int expectedBreadTotal = 20;

            Bread bread = new Bread(5);
            int loaves = 6;
            bread.AdjustBreadCost(loaves);

            Assert.AreEqual(expectedBreadTotal, bread.CalcBreadTotal(loaves));
        }
    }
}