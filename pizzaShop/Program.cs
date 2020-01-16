using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;

namespace pizzaShop
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a console app to allow your user order a pizza
             * 1. You have got a menu of five pizza types. Each pizza has four ingredients
             * 2. A user can choose from two types of pizza dough
             * 3. A user can add some additional ingredients to their order
             * 4. A user can choose a custom pizza with four ingredients
             * 5. A user can order more than one pizza
             * 6. After the user confirms their order, the total is displayed */

            Menu PizzasInStock = new Menu();
          

           
            Cart cart = new Cart();
            PizzasInStock.PrintTypes();
            AddTypesToCart(PizzasInStock, cart);
         
            Start:

            while (true)
            {
                Console.WriteLine("Do you want to add, remove or confirm? (Press a, r or c)" );
                string userAnswer = Console.ReadLine().ToLower();
                if (userAnswer == "a")
                {
                    AddTypesToCart(PizzasInStock, cart);
                    Console.WriteLine();
                }
                else if (userAnswer == "r")
                {
                    Console.WriteLine("Enter the id of the product what you want to remove: ");
                    int itemIdToRemove = int.Parse(Console.ReadLine());
                    cart.RemoveFromCart(itemIdToRemove);
                    Console.WriteLine();
                }
                else if (userAnswer == "c")
                {
                    Console.WriteLine();
                    Console.WriteLine("In your shoppingchart are: ");
                    cart.PrintTotal();
                    Console.WriteLine($"Shopping cart total: {Math.Round(cart.Total, 2)}");
                    break;
                }
                else
                {
                    Console.WriteLine("Please press a, r or c!");
                    goto Start;
                }

            }


        }

        public static void AddTypesToCart(Menu PizzasInStock, Cart cart)
        {
            Console.WriteLine("Enter the id of the product to add it to the shopping cart: ");
            int productID = int.Parse(Console.ReadLine());
 
            Console.WriteLine("Enter the number of items to add to the shopping cart: ");
            int quantity = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Types typesToAdd = PizzasInStock.GetFromStockTypes(productID);
            cart.AddToCart(typesToAdd, quantity);
            cart.PrintCart();

        }

     
    }
    }