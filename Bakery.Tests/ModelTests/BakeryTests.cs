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
            // Teardown, if needed
        }
        //  Class Order tests
        [TestMethod]
        public void Order_ConstructsInstanceofOrder_ObjOrder()
        {
            Order newOrder = new Order(4, 12);
            Assert.AreEqual(typeof(Order), newOrder.GetType());
        }

        [TestMethod]
        public void CalcOrderTotalCost_CalculateCostOfBreadAndPastryOrders_Int()
        {
            int breadCount = 4;
            int pastryCount = 12;
            int expectedOrderTotalCost = 35;

            Order newOrder = new Order(breadCount, pastryCount);
            Bread bread = new Bread();
            Pastry pastry = new Pastry();
            int breadTotalCost = bread.CalcBreadTotalCost(newOrder.BreadOrderCount);
            int pastryTotalCost = pastry.CalcPastryTotalCost(newOrder.PastryOrderCount);
            int orderTotalCost = newOrder.CalcOrderTotalCost(breadTotalCost, pastryTotalCost);

            Assert.AreEqual(expectedOrderTotalCost, orderTotalCost);
        }


        // Class Bread tests
        [TestMethod]
        public void Bread_ConstructsInstanceofBread_ObjBread()
        {
            Bread bread = new Bread();
            Assert.AreEqual(typeof(Bread), bread.GetType());
        }
        [TestMethod]
        public void AdjustBreadCost_CalculateBreadDealAdjustment_IntAdjustment()
        {
            int expectedAdjustment = 10;

            Bread bread = new Bread();
            int loaves = 8;
            int adjustment = bread.AdjustBreadCost(loaves);

            Assert.AreEqual(expectedAdjustment, adjustment);
        }
        [TestMethod]
        public void CalcBreadTotalCost_CalculateTotalCostOfBreadOrder_IntSum()
        {
            int expectedBreadTotal = 35;

            Bread bread = new Bread();
            int loaves = 10;
            int breadTotal = bread.CalcBreadTotalCost(loaves);

            Assert.AreEqual(expectedBreadTotal, breadTotal);
        }


        // Class Pastry tests
        [TestMethod]
        public void Pastry_ConstructsInstanceofPastry_ObjPastry()
        {
            Pastry pastry = new Pastry();
            Assert.AreEqual(typeof(Pastry), pastry.GetType());
        }
        [TestMethod]
        public void AdjustPastryCost_CalculatePastryDealAdjustment_IntAdjustment()
        {
            int expectedAdjustment = 4;

            Pastry pastry = new Pastry();
            int pastries = 12;
            int adjustment = pastry.AdjustPastryCost(pastries);

            Assert.AreEqual(expectedAdjustment, adjustment);
        }
        [TestMethod]
        public void CalcPastryTotalCost_CalculateTotalCostOfPastryOrder_IntSum()
        {
            int expectedPastryTotal = 20;

            Pastry pastry = new Pastry();
            int pastries = 12;
            int pastryTotal = pastry.CalcPastryTotalCost(pastries);

            Assert.AreEqual(expectedPastryTotal, pastryTotal);
        }
    }
}