using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
    [TestClass]
    public class BakeryTests
    {

        // Class Bread tests
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
            int expectedBreadTotal = 35;

            Bread bread = new Bread(5);
            int loaves = 10;
            bread.AdjustBreadCost(loaves);

            Assert.AreEqual(expectedBreadTotal, bread.CalcBreadTotal(loaves));
        }

        // Class Pastry tests
        [TestMethod]
        public void Pastry_ConstructsInstanceofPastry_ObjPastry()
        {
            Pastry pastry = new Pastry(2);
            Assert.AreEqual(typeof(Pastry), pastry.GetType());
        }
        [TestMethod]
        public void AdjustPastryCost_CalculatePastryDealAdjustment_IntAdjustment()
        {
            int expectedAdjustment = 4;

            Pastry pastry = new Pastry(2);
            int pastries = 12;
            pastry.AdjustPastryCost(pastries);

            Assert.AreEqual(expectedAdjustment, pastry.AdjustPastryCost(pastries));
        }
    }
}