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
            Order newOrder = new Order();
            Assert.AreEqual(typeof(Order), newOrder.GetType());
        }

        [TestMethod]
        public void CalcOrderTotalCost_CalculateCostOfBreadAndPastryOrders_Int()
        {
            int loaves = 10;
            int pastries = 12;
            int expectedOrderTotalCost = 55;

            Order newOrder = new Order();
            Bread bread = new Bread();
            Pastry pastry = new Pastry();
            bread.AdjustBreadCost(loaves);
            pastry.AdjustPastryCost(pastries);
            bread.CalcBreadTotalCost(loaves);
            pastry.CalcPastryTotalCost(pastries);
            newOrder.CalcOrderTotalCost(bread.BreadOrderTotalCost, pastry.PastryOrderTotalCost);

            Assert.AreEqual(expectedOrderTotalCost, newOrder.OrderTotalCost);
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
            int loaves = 8;
            int expectedAdjustment = 10;

            Bread bread = new Bread();
            bread.AdjustBreadCost(loaves);

            Assert.AreEqual(expectedAdjustment, bread.DiscountAdjustment);
        }
        [TestMethod]
        public void CalcBreadTotalCost_CalculateTotalCostOfBreadOrder_IntSum()
        {
            int loaves = 10;
            int expectedBreadTotalCost = 35;

            Bread bread = new Bread();
            bread.AdjustBreadCost(loaves);
            bread.CalcBreadTotalCost(loaves);
            bread.CalcBreadTotalCost(loaves);

            Assert.AreEqual(expectedBreadTotalCost, bread.BreadOrderTotalCost);
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
            int pastries = 12;
            int expectedAdjustment = 4;

            Pastry pastry = new Pastry();
            pastry.AdjustPastryCost(pastries);

            Assert.AreEqual(expectedAdjustment, pastry.DiscountAdjustment);
        }
        [TestMethod]
        public void CalcPastryTotalCost_CalculateTotalCostOfPastryOrder_IntSum()
        {
            int pastries = 12;
            int expectedPastryTotal = 20;

            Pastry pastry = new Pastry();
            pastry.AdjustPastryCost(pastries);
            pastry.CalcPastryTotalCost(pastries);

            Assert.AreEqual(expectedPastryTotal, pastry.PastryOrderTotalCost);
        }
    }
}