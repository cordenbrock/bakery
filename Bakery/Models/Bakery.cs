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
                adjustment = 5 * (int)(Math.Floor(freeLoaves)); 
            }
            return adjustment;
        }
    }
    
    


    // Pastry class
    public class Pastry
    {
        // code
    }
}