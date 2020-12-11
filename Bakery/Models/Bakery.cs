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
        private static List<Bread> _instances = new List<Bread> {};

        // Bread constructor
        public Bread(int breadCost)
        {
            BreadCost = breadCost;
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
        public int CalcBreadTotal(int loaves) 
        {
            int adjustment = AdjustBreadCost(loaves);
            int breadTotal = (loaves) * BreadCost - adjustment;

            return breadTotal;
        }

        // Clear all current class instances
        public static void ClearAll()
        {
            _instances.Clear();
        }
    }



    // Pastry class
    public class Pastry
    {
        // Auto-implemented fields
        public int PastryCost { get; private set; }
        private static List<Pastry> _instances = new List<Pastry> {};

        // Pastry constructor
        public Pastry(int pastryCost)
        {
            PastryCost = pastryCost;
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
        public int CalcPastryTotal(int pastries) 
        {
            int adjustment = AdjustPastryCost(pastries);
            int pastryTotal = (pastries) * PastryCost - adjustment;

            return pastryTotal;
        }

        // Clear all current class instances
        public static void ClearAll()
        {
            _instances.Clear();
        }

    }
}