using System;
using Bakery.Models;


namespace Bakery
{
    public class Program
    {
    // Static Variables
        static Order newOrder = new Order();
        static Bread bread = new Bread();
        static Pastry pastry = new Pastry();
        
    // Init App, i.e. launch
        static void Main()
        {
            while(true)
            {
                GreetUser();
                DisplayMenu();
                TakeUserOrder();

                DisplayTransactionMessage(newOrder.OrderTotalCost);

            }
        }
        


    // UI logic

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
            string subheader = "Breads, Pastries, Deals, Pierre's got 'em";
            DisplayColoredMessage(ConsoleColor.DarkCyan, subheader);
            Console.WriteLine("-------------------------------------------");
            string breadDeal = "Bread -- 1 for $5 -- Buy 2, Get 1 Free!";
            DisplayColoredMessage(ConsoleColor.Green, breadDeal);
            string pastryDeal = "Pastries -- 1 for $2, Buy 2, Get another 1/2 Off!";
            DisplayColoredMessage(ConsoleColor.Green, pastryDeal);
        }

        // Get User order
        static void TakeUserOrder() 
        {
            Console.WriteLine("----------------------------------------------");
            string breadPrompt = "Enter the number of loaves your belly desires:";
            DisplayColoredMessage(ConsoleColor.Yellow, breadPrompt);
            newOrder.BreadOrderCount = Int32.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------------------------");
            string pastryPrompt = "Enter the number of pastries your heart desires:";
            DisplayColoredMessage(ConsoleColor.Yellow, pastryPrompt);

            newOrder.PastryOrderCount = Int32.Parse(Console.ReadLine());

            // Set current cost adjustments
            bread.AdjustBreadCost(newOrder.BreadOrderCount);
            pastry.AdjustPastryCost(newOrder.PastryOrderCount);

            //  Calculate current order costs
            bread.CalcBreadTotalCost(newOrder.BreadOrderCount);
            pastry.CalcPastryTotalCost(newOrder.PastryOrderCount);
            newOrder.CalcOrderTotalCost(bread.BreadOrderTotalCost, pastry.PastryOrderTotalCost);
        }

        // Tell user order cost
        static void DisplayTransactionMessage(int orderTotalCost)
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~");
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