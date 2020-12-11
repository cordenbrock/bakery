using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests 
{
    [TestClass] 
    public class BakeryTests : IDisposable
    {
        public void Dispose()
        {
            Bread.ClearAll();
            Pastry.ClearAll();
        }
        //  Class Order tests
        [TestMethod]
        public void Test()
        {
            Order newOrder = new Order(10, 12);
            Assert.AreEqual(typeof(Order), newOrder.GetType());
        }


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
            int adjustment = bread.AdjustBreadCost(loaves);

            Assert.AreEqual(expectedAdjustment, adjustment);
        }
        [TestMethod]
        public void CalcBreadTotal_CalculateTotalCostOfBreadOrder_IntSum()
        {
            int expectedBreadTotal = 35;

            Bread bread = new Bread(5);
            int loaves = 10;
            int breadTotal = bread.CalcBreadTotal(loaves);

            Assert.AreEqual(expectedBreadTotal, breadTotal);
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
            int adjustment = pastry.AdjustPastryCost(pastries);

            Assert.AreEqual(expectedAdjustment, adjustment);
        }
        [TestMethod]
        public void CalcPastryTotal_CalculateTotalCostOfPastryOrder_IntSum()
        {
            int expectedPastryTotal = 20;

            Pastry pastry = new Pastry(2);
            int pastries = 12;
            int pastryTotal = pastry.CalcPastryTotal(pastries);

            Assert.AreEqual(expectedPastryTotal, pastryTotal);
        }
    }
}