using System;
using System.Collections.Generic;
using System.Text;

namespace pizzaShop
{
    class Cart
    {
        List<Item> cart;
        double total;
       

        public Cart()
        {
            cart = new List<Item>();
            total = 0;
        }

        public double Total
        {
            get { return total; }
        }

        public void AddToCart(Types types, int quantity)
        {
            Item newItem = new Item(types, quantity);
            cart.Add(newItem);
        }


        public void RemoveFromCart(int id)
        {
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].Types.Id == id)
                {
                    Console.WriteLine($"{cart[i].Types.Name} has been removed.");
                    cart.Remove(cart[i]);
                }

            }
            PrintCart();
        }
        public void PrintCart()
        {
            if (cart.Count == 0)
            {
                Console.WriteLine("Shopping Cart is empty");
            }
            else
            {
                foreach (Item item in cart)
                {
                    item.PrintItem();

                }
            }

        }
        
        public void PrintTotal()
        {

            foreach (Item item in cart)
            {
                
                item.PrintItemInCart();
                total += Math.Round(item.CalculateItemTotal(), 2);

            }
        }
    }
}
