using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab_3._2_Shopping_List
{
    class Program
    {
        static void Main(string[] args)
        {

            bool continueShopping = true; // flag to keep shopping
            
            ArrayList purchaseItems = new ArrayList(); //Array list to hole items
            ArrayList itemPrice = new ArrayList(); //array lit to hole prices

            Console.WriteLine("Welcome to Cobalt's Camping Supplies!");
            Console.WriteLine();

            while (continueShopping)
            {
                CallMenu(); // Calls method that displays the menu

                Console.WriteLine();
                Console.Write("What item would you like to order?:");
                string order = Console.ReadLine();

                
                //Switch Statement to check for a valid inut, if an item is selected that does not exist, the program aks if you want to keep shopping
                if (order == "Tent" || order == "Sleeping Bag" || order == "Air Matress" || order == "Matches" || order == "Hatchet" || order == "Fishing Pole" || order == "Flash Light" || order == "Whisky")
                {
                    switch (order)
                    {
                        case "Tent":
                            if (!purchaseItems.Contains("Tent")) // if the Array does not contain tent, it adds it to the array, and adds the price to the price array
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

                    Console.WriteLine("Please pick a item we carry!"); // checks against availible items
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.Write("Would you like to continue shopping? (y/n):"); // breaks if user does not want to keep shopping
                string keepShopping = Console.ReadLine();
                string upperShopping = keepShopping.ToUpper();
                
                if(upperShopping == "N")
                {
                    continueShopping = false;
                    Console.WriteLine();
                    Console.WriteLine("Thank for your order!");
                    Console.WriteLine("Here is what you got:");
                    Console.WriteLine("===============================");

                    //double sum = 0;    Could not think of a way to extract the doubles from the price Array list, and calculate the sun and average
                    //double average = 0;  

                    for (int i = 0; i<purchaseItems.Count; i++)
                    {
                        Console.WriteLine($"{purchaseItems[i]}${itemPrice[i]}"); // displays items added to the cart.
                    }

                  
                    Console.WriteLine();
                    Console.WriteLine($"The average price of item in your order was: I could not figure out how to calculate the average.");

                }
                else if(upperShopping != "Y")
                {
                    Console.WriteLine("Please make a valid choice. You can continue shopping."); // checks for valid continue shopping, and defaults to continue shopping if a invalid choice is made
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadLine();
                    Console.Clear();
                }

            }//End of while
        }
            
            

        private static void CallMenu() // Metod Created to cut down on redundent code
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
