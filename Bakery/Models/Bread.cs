using System;

namespace Bakery.Models
{
    public class Bread
    {
        // Auto-implemented properties
        public int BreadCost { get; private set; }
        public int DiscountAdjustment { get; set; }
        public int BreadOrderTotalCost { get; set; }

        // Bread constructor
        public Bread()
        {
            BreadCost = 5;
        }

        // Calculate bread deal adjustment
        public void AdjustBreadCost(int loaves)
        {
            int discountAdjustment = 0;
            if (loaves >= 3)
            {
                double freeLoaves = loaves/3;
                discountAdjustment = BreadCost * (int)(Math.Floor(freeLoaves)); 
            }
            // Set DiscountAdjustment Property
            DiscountAdjustment = discountAdjustment;
        }

        // Calculate total cost of bread order 
        public void CalcBreadTotalCost(int loaves) 
        {
            int breadOrderTotalCost = (loaves) * BreadCost - DiscountAdjustment;
            // Set BreadOrderTotalCost Property
            BreadOrderTotalCost = breadOrderTotalCost;
        }
    }
}