using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests 
{
    [TestClass] 
    public class BakeryTests
    {
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
        [TestMethod]
        public void CalcOrderTotalCost_CalculateCostOfBreadAndPastryOrdersWithZeroLoafCount_Int()
        {
            int loaves = 0;
            int pastries = 6;
            int expectedOrderTotalCost = 10;

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
                [TestMethod]
        public void CalcOrderTotalCost_CalculateCostOfBreadAndPastryOrdersWithZeroPastryCount_Int()
        {
            int loaves = 6;
            int pastries = 0;
            int expectedOrderTotalCost = 20;

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
        public void AdjustBreadCost_CalculateBreadDealAdjustmentWithZeroCount_IntAdjustment()
        {
            int loaves = 0;
            int expectedAdjustment = 0;

            Bread bread = new Bread();
            bread.AdjustBreadCost(loaves);

            Assert.AreEqual(expectedAdjustment, bread.DiscountAdjustment);
        }
        [TestMethod]
        public void AdjustBreadCost_CalculateBreadDealAdjustmentWithSmallCount_IntAdjustment()
        {
            int loaves = 8;
            int expectedAdjustment = 10;

            Bread bread = new Bread();
            bread.AdjustBreadCost(loaves);

            Assert.AreEqual(expectedAdjustment, bread.DiscountAdjustment);
        }
        [TestMethod]
        public void AdjustBreadCost_CalculateBreadDealAdjustmentWithLargeCount_IntAdjustment()
        {
            int loaves = 50;
            int expectedAdjustment = 80;

            Bread bread = new Bread();
            bread.AdjustBreadCost(loaves);

            Assert.AreEqual(expectedAdjustment, bread.DiscountAdjustment);
        }
        [TestMethod]
        public void CalcBreadTotalCost_CalculateTotalCostOfBreadOrderWithZeroCount_IntSum()
        {
            int loaves = 0;
            int expectedBreadTotalCost = 0;

            Bread bread = new Bread();
            bread.AdjustBreadCost(loaves);
            bread.CalcBreadTotalCost(loaves);
            bread.CalcBreadTotalCost(loaves);

            Assert.AreEqual(expectedBreadTotalCost, bread.BreadOrderTotalCost);
        }
        [TestMethod]
        public void CalcBreadTotalCost_CalculateTotalCostOfBreadOrderWithSmallCount_IntSum()
        {
            int loaves = 10;
            int expectedBreadTotalCost = 35;

            Bread bread = new Bread();
            bread.AdjustBreadCost(loaves);
            bread.CalcBreadTotalCost(loaves);
            bread.CalcBreadTotalCost(loaves);

            Assert.AreEqual(expectedBreadTotalCost, bread.BreadOrderTotalCost);
        }
        [TestMethod]
        public void CalcBreadTotalCost_CalculateTotalCostOfBreadOrderWithLargeCount_IntSum()
        {
            int loaves = 50;
            int expectedBreadTotalCost = 170;

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
        public void AdjustPastryCost_CalculatePastryDealAdjustmentWithZeroCount_IntAdjustment()
        {
            int pastries = 0;
            int expectedAdjustment = 0;

            Pastry pastry = new Pastry();
            pastry.AdjustPastryCost(pastries);

            Assert.AreEqual(expectedAdjustment, pastry.DiscountAdjustment);
        }
        [TestMethod]
        public void AdjustPastryCost_CalculatePastryDealAdjustmentWithSmallCount_IntAdjustment()
        {
            int pastries = 12;
            int expectedAdjustment = 4;

            Pastry pastry = new Pastry();
            pastry.AdjustPastryCost(pastries);

            Assert.AreEqual(expectedAdjustment, pastry.DiscountAdjustment);
        }
        [TestMethod]
        public void AdjustPastryCost_CalculatePastryDealAdjustmentWithLargeCount_IntAdjustment()
        {
            int pastries = 50;
            int expectedAdjustment = 16;

            Pastry pastry = new Pastry();
            pastry.AdjustPastryCost(pastries);

            Assert.AreEqual(expectedAdjustment, pastry.DiscountAdjustment);
        }
                [TestMethod]
        public void CalcPastryTotalCost_CalculateTotalCostOfPastryOrderWithZeroCount_IntSum()
        {
            int pastries = 0;
            int expectedPastryTotal = 0;

            Pastry pastry = new Pastry();
            pastry.AdjustPastryCost(pastries);
            pastry.CalcPastryTotalCost(pastries);

            Assert.AreEqual(expectedPastryTotal, pastry.PastryOrderTotalCost);
        }
        [TestMethod]
        public void CalcPastryTotalCost_CalculateTotalCostOfPastryOrderWithSmallCount_IntSum()
        {
            int pastries = 12;
            int expectedPastryTotal = 20;

            Pastry pastry = new Pastry();
            pastry.AdjustPastryCost(pastries);
            pastry.CalcPastryTotalCost(pastries);

            Assert.AreEqual(expectedPastryTotal, pastry.PastryOrderTotalCost);
        }
        [TestMethod]
        public void CalcPastryTotalCost_CalculateTotalCostOfPastryOrderWithLargeCount_IntSum()
        {
            int pastries = 50;
            int expectedPastryTotal = 84;

            Pastry pastry = new Pastry();
            pastry.AdjustPastryCost(pastries);
            pastry.CalcPastryTotalCost(pastries);

            Assert.AreEqual(expectedPastryTotal, pastry.PastryOrderTotalCost);
        }
    }
}