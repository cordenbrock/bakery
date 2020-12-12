using System;
using Bakery.Models;


namespace Bakery
{
    public class Program
    {
        static Order newOrder = new Order();
        static Bread bread = new Bread();
        static Pastry pastry = new Pastry();
        static void Main()
        {            

            GreetUser();
            DisplayMenu();
            TakeUserOrder();
            DisplayTransactionMessage(newOrder.OrderTotalCost);
        }
        
        // Greet User
        static void GreetUser() 
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            string welcomeMessage = "Bonjour! Bienvenue à la boulangerie Pierre!";
            DisplayColoredMessage(ConsoleColor.DarkMagenta, welcomeMessage.ToUpper());
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        }

        // Menu
        static void DisplayMenu() 
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Breads, Pastries, Deals, Pierre's got 'em");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Bread -- 1 for $5 -- Buy 2, Get 1 Free!");
            Console.WriteLine("Pastries -- 1 for $2, Buy 2, Get another 1/2 price!");
        }

        // Get User order
        static void TakeUserOrder() 
        {
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Enter the number of loaves you belly desires:");
            newOrder.BreadOrderCount = Int32.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Enter the number of pastries your heart desires:");
            newOrder.PastryOrderCount = Int32.Parse(Console.ReadLine());

            // Set current cost adjustments
            bread.AdjustBreadCost(newOrder.BreadOrderCount);
            pastry.AdjustPastryCost(newOrder.PastryOrderCount);

            //  Calculate current order costs
            int breadTotalCost = bread.CalcBreadTotalCost(newOrder.BreadOrderCount);
            int pastryTotalCost = pastry.CalcPastryTotalCost(newOrder.PastryOrderCount);
            int orderTotalCost = newOrder.CalcOrderTotalCost(breadTotalCost, pastryTotalCost);

            // Set total cost of order
            newOrder.OrderTotalCost = orderTotalCost;
        }

        // Tell user order cost
        static void DisplayTransactionMessage(int orderTotalCost)
        {
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("That'll be a whopping: ${0}", orderTotalCost);
            Console.WriteLine("Thanks for stopping by!");
        }

        // Set/Reset color for message
        static void DisplayColoredMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }

    }
}