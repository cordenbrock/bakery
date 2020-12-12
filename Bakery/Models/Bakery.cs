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
        public Order() {}

        // Calculate order
        public void CalcOrderTotalCost(int breadTotalCost, int pastryTotalCost)
        {
            int orderTotalCost = breadTotalCost + pastryTotalCost;

             OrderTotalCost = orderTotalCost;
        }
        
    }



    // Bread class
    public class Bread
    {
        // Auto-implemented fields
        public int BreadCost { get; private set; }
        public int Adjustment { get; set; }
        public int BreadOrderTotalCost { get; set; }

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
        public void CalcBreadTotalCost(int loaves) 
        {
            int breadOrderTotalCost = (loaves) * BreadCost - Adjustment;
            BreadOrderTotalCost = breadOrderTotalCost;
        }
    }



    // Pastry class
    public class Pastry
    {
        // Auto-implemented fields
        public int PastryCost { get; private set; }
        public int Adjustment { get; set; }
        public int PastryOrderTotalCost { get; set; }

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
                int discountFactor = (PastryCost - discount); 
                adjustment =  discountFactor * pastriesToDiscount; 
            }
            // Set Adjustment Property
            Adjustment = adjustment;
        }

        // Calculate total cost of pastry order 
        public void CalcPastryTotalCost(int pastries) 
        {
            int pastryOrderTotalCost = (pastries) * PastryCost - Adjustment;
            // Set PastryOrderTotalCost Property
            PastryOrderTotalCost = pastryOrderTotalCost;
        }
    }
}