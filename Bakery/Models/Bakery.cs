using System;

namespace Bakery.Models
{
    // Order Class
    public class Order
    {

    }



    // Bread class
    public class Bread
    {
        // Auto-implemented fields
        public int BreadCost { get; set; }

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
    }
    
    


    // Pastry class
    public class Pastry
    {
        // Auto-implemented fields
        public int PastryCost { get; set; }

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

    }
}