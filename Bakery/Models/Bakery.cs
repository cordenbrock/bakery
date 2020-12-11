using System;
using System.Collections.Generic;

namespace Bakery.Models
{
    // Order Class
    public class Order
    {
        // Auto-implemented fields
        public int BreadOrderCount { get; set; }
        public int PastryOrderCount { get; set; }
        public int OrderCost { get; set; }

        // Order constructor
        public Order(int breadOrderCount, int pastryOrderCount)
        {
            BreadOrderCount = breadOrderCount;
            PastryOrderCount = pastryOrderCount;
        }
        
    }



    // Bread class
    public class Bread
    {
        // Auto-implemented fields
        public int BreadCost { get; private set; }

        // Bread constructor
        public Bread()
        {
            BreadCost = 5;
        }

        // Calculate bread deal adjustment
        public int AdjustBreadCost(int loaves)
        {
            int adjustment = 0;
            if (loaves >= 3)
            {
                double freeLoaves = loaves/3;
                adjustment = BreadCost * (int)(Math.Floor(freeLoaves)); 
            }

            return adjustment;
        }

        // Calculate total cost of bread order 
        public int CalcBreadTotalCost(int loaves) 
        {
            int adjustment = AdjustBreadCost(loaves);
            int breadTotal = (loaves) * BreadCost - adjustment;

            return breadTotal;
        }
    }



    // Pastry class
    public class Pastry
    {
        // Auto-implemented fields
        public int PastryCost { get; private set; }

        // Pastry constructor
        public Pastry()
        {
            PastryCost = 2;
        }

        // Calculate pastry deal adjustment
        public int AdjustPastryCost(int pastryCount)
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

            return adjustment;
        }

        // Calculate total cost of pastry order 
        public int CalcPastryTotalCost(int pastries) 
        {
            int adjustment = AdjustPastryCost(pastries);
            int pastryTotal = (pastries) * PastryCost - adjustment;

            return pastryTotal;
        }
    }
}