using System;

namespace Bakery.Models
{
    // Order Class
    public class Order
    {
        // Auto-implemented fields
        public int BreadOrderCount { get; set; }
        public int PastryOrderCount { get; set; }
        public int OrderTotalCost { get; set; }

        // Order constructor
        public Order() // int breadOrderCount, int pastryOrderCount
        {
            // BreadOrderCount = breadOrderCount;
            // PastryOrderCount = pastryOrderCount;
        }
        public int CalcOrderTotalCost(int breadTotalCost, int pastryTotalCost)
        {
            int orderTotalCost = breadTotalCost + pastryTotalCost;

            return orderTotalCost;
        }
        
    }



    // Bread class
    public class Bread
    {
        // Auto-implemented fields
        public int BreadCost { get; private set; }
        public int Adjustment { get; set; }

        // Bread constructor
        public Bread()
        {
            BreadCost = 5;
        }

        // Calculate bread deal adjustment
        public void AdjustBreadCost(int loaves)
        {
            int adjustment = 0;
            if (loaves >= 3)
            {
                double freeLoaves = loaves/3;
                adjustment = BreadCost * (int)(Math.Floor(freeLoaves)); 
            }

            Adjustment = adjustment;
        }

        // Calculate total cost of bread order 
        public int CalcBreadTotalCost(int loaves) 
        {
            int breadTotal = (loaves) * BreadCost - Adjustment;
            return breadTotal;
        }
    }



    // Pastry class
    public class Pastry
    {
        // Auto-implemented fields
        public int PastryCost { get; private set; }
        public int Adjustment { get; set; }

        // Pastry constructor
        public Pastry()
        {
            PastryCost = 2;
        }

        // Calculate pastry deal adjustment
        public void AdjustPastryCost(int pastryCount)
        {
            int adjustment = 0;
            if (pastryCount >= 3)
            {
                double unroundedPastryCountToDiscount = pastryCount/3;
                int pastriesToDiscount = (int)(Math.Floor(unroundedPastryCountToDiscount));
                int discount = 1;
                int discountCost = (PastryCost - discount); 
                adjustment =  discountCost * pastriesToDiscount; 
            }

            Adjustment = adjustment;
        }

        // Calculate total cost of pastry order 
        public int CalcPastryTotalCost(int pastries) 
        {
            int pastryTotal = (pastries) * PastryCost - Adjustment;
            return pastryTotal;
        }
    }
}