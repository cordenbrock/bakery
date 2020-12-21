using System;

namespace Bakery.Models
{
    // Order Class
    public class Order
    {
        // Auto-implemented properties
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
}