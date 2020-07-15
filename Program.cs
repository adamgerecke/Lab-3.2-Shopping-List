using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab_3._2_Shopping_List
{
    class Program
    {
        static void Main(string[] args)
        {

            /*          
            Dictionary<string, double> menuData = new Dictionary<string, double>();
            menuData["Tent"] = 99.99;
            menuData["Sleeping Bag"] = 74.99;
            menuData["Air Matress"] = 35.95;
            menuData["Matches"] = 15.45;
            menuData["Hatchet"] = 12.75;
            menuData["Fishing Pole"] = 22.53;
            menuData["Flash Light"] = 26.92;
            menuData["Whisky"] = 54.99;

            
            purchaseItems.Add("Tent");
            purchaseItems.Add("Sleep Bag");
            purchaseItems.Add("Air Matress");
            purchaseItems.Add("Matches");
            purchaseItems.Add("Hatchet");
            purchaseItems.Add("Fishing Pole");
            purchaseItems.Add("Flash Light");
            purchaseItems.Add("Whisky");

            itemPrice.Add(99.99);
            itemPrice.Add(74.99);
            itemPrice.Add(35.95);
            itemPrice.Add(15.45);
            itemPrice.Add(12.75);
            itemPrice.Add(22.53);
            itemPrice.Add(26.92);
            itemPrice.Add(54.99);
            */

            bool continueShopping = true;
            
            ArrayList purchaseItems = new ArrayList();
            ArrayList itemPrice = new ArrayList();

            Console.WriteLine("Welcome to Cobalt's Camping Supplies!");
            Console.WriteLine();

            while (continueShopping)
            {
                CallMenu();

                Console.WriteLine();
                Console.Write("What item would you like to order?:");
                string order = Console.ReadLine();

                if (order == "Tent" || order == "Sleeping Bag" || order == "Air Matress" || order == "Matches" || order == "Hatchet" || order == "Fishing Pole" || order == "Flash Light" || order == "Whisky")
                {
                    switch (order)
                    {
                        case "Tent":
                            if (!purchaseItems.Contains("Tent"))
                            {
                                purchaseItems.Add("Tent");
                                itemPrice.Add(99.99);
                                Console.WriteLine("Adding Tent to cart at $99.99");
                            }
                            break;
                        case "Sleeping Bag":
                            if (!purchaseItems.Contains("Sleeping Bag"))
                            {
                                purchaseItems.Add("Sleeping Bag");
                                itemPrice.Add(74.99);
                                Console.WriteLine("Adding Sleeping Bag to cart at $74.99");
                            }
                            break;
                        case "Air Matress":
                            if (!purchaseItems.Contains("Air Matress"))
                            {
                                purchaseItems.Add("Air Matress");
                                itemPrice.Add(35.95);
                                Console.WriteLine("Adding Air Matress to cart at $35.95");
                            }
                            break;
                        case "Matches":
                            if (!purchaseItems.Contains("Matches"))
                            {
                                purchaseItems.Add("Matches");
                                itemPrice.Add(15.45);
                                Console.WriteLine("Adding Matches to cart at $15.45");
                            }
                            break;
                        case "Hatchet":
                            if (!purchaseItems.Contains("Hatchet"))
                            {
                                purchaseItems.Add("Hatchet");
                                itemPrice.Add(12.75);
                                Console.WriteLine("Adding Hatchet to cart at $12.75");
                            }
                            break;
                        case "Fishing Pole":
                            if (!purchaseItems.Contains("Fishing Pole"))
                            {
                                purchaseItems.Add("Fishing Pole");
                                itemPrice.Add(22.53);
                                Console.WriteLine("Adding Fishing Pole to cart at $23.53");
                            }
                            break;
                        case "Flash Light":
                            if (!purchaseItems.Contains("Flash Light"))
                            {
                                purchaseItems.Add("Flash Light");
                                itemPrice.Add(26.92);
                                Console.WriteLine("Adding Flash Light to cart at $26.92");
                            }
                            break;
                        case "Whisky":
                            if (!purchaseItems.Contains("Whisky"))
                            {
                                purchaseItems.Add("Whisky");
                                itemPrice.Add(54.99);
                                Console.WriteLine("Adding Whisky to cart at $54.99");
                            }
                            break;

                    }

                }
                else
                {

                    Console.WriteLine("Please pick a item we carry!");
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.Write("Would you like to continue shopping? (y/n):");
                string keepShopping = Console.ReadLine();
                string upperShopping = keepShopping.ToUpper();
                
                if(upperShopping == "N")
                {
                    continueShopping = false;
                    Console.WriteLine();
                    Console.WriteLine("Thank for your order!");
                    Console.WriteLine("Here is what you got:");
                    Console.WriteLine("===============================");

                    double sum = 0;
                    double average = 0;

                    for (int i = 0; i<purchaseItems.Count; i++)
                    {
                        Console.WriteLine($"{purchaseItems[i]}${itemPrice[i]}");
                    }

                  
                    Console.WriteLine();
                    Console.WriteLine($"The average price of item in your order was: I could not figure out how to calculate the average.");

                }
                else if(upperShopping != "Y")
                {
                    Console.WriteLine("Please make a valid choice. You can continue shopping.");
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadLine();
                    Console.Clear();
                }

            }//End of while
        }
            
            

        private static void CallMenu()
        {

            Dictionary<string, double> items = new Dictionary<string, double>();
            items["Tent        "] = 99.99;
            items["Sleeping Bag"] = 74.99;
            items["Air Matress "] = 35.95;
            items["Matches     "] = 15.45;
            items["Hatchet     "] = 12.75;
            items["Fishing Pole"] = 22.53;
            items["Flash Light "] = 26.92;
            items["Whisky      "] = 54.99;




            Console.WriteLine("Item\t\t\tPrice");
            Console.WriteLine("===============================");

            foreach (KeyValuePair<string, double> item in items)
            {
                Console.WriteLine($"{item.Key}\t\t${item.Value}");
            }
        }
    }
}
