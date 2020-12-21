using System;

namespace Bakery.Models
{
    public class Pastry
    {
    // Auto-implemented properties
        public int PastryCost { get; private set; }
        public int DiscountAdjustment { get; set; }
        public int PastryOrderTotalCost { get; set; }

        // Pastry constructor
        public Pastry()
        {
            PastryCost = 2;
        }

        public void AdjustPastryCost(int pastryCount)
        {
            int discountAdjustment = 0;
            if (pastryCount >= 3)
            {
            double unroundedPastriesCountToDiscount = pastryCount/3;
            int pastriesToDiscount = (int)(Math.Floor(unroundedPastriesCountToDiscount));
            int discount = 1;
            int discountFactor = (PastryCost - discount); 
            discountAdjustment =  discountFactor * pastriesToDiscount; 
            }
            DiscountAdjustment = discountAdjustment;
        }

        public void CalcPastryTotalCost(int pastries) 
        {
            int pastryOrderTotalCost = (pastries) * PastryCost - DiscountAdjustment;
            PastryOrderTotalCost = pastryOrderTotalCost;
        }
    }
}
