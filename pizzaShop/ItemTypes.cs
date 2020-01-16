using System;
using System.Collections.Generic;
using System.Text;

namespace pizzaShop
{
    class Item
    {
        Types types;
        int quantity;
        

        public Item(Types _types, int _quantity)
        {
            types = _types;
            quantity = _quantity;
        }

        public Types Types
        {
            get { return types; }
        }


        public void PrintItem()
        {
            Console.WriteLine($"ID: {types.Id} \n Name: {types.Name} \n Dough: {types.Dough} \n Category: {types.Category} " +
                    $"\n Price: {types.Price}\n Quantity: {quantity} \n " +
                    $"Total: {Math.Round(CalculateItemTotal(), 2)}");
        }

        public void PrintItemInCart()  //Shows items list in shopping cart
        {
           
                Console.WriteLine($"  Name: {types.Name} \n  Quantity: {quantity} \n Price: {Math.Round(CalculateItemTotal(), 2)} ");
           
            
        }
        public double CalculateItemTotal()
        {
           
           return types.Price * quantity;
            
        }
    }
}
