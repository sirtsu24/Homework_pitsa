using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;

namespace pizzaShop
{
    class Menu
    {
        List<Types> InShop;
 
        public Menu()
        {
            InShop = new List<Types>();
            Types mafiosoThin = new Types(1, "Mafioso", "pizzasauce, cheese, chicken, ananas", "thin", Category.POULTRY, 8.30);
            InShop.Add(mafiosoThin);
            Types mafiosoThick = new Types(2, "Mafioso", "pizzasauce, cheese, chicken, ananas", "thick", Category.POULTRY, 10.30);
            InShop.Add(mafiosoThick);
            Types beconareThin = new Types(3, "Beconare", "pizzasauce, cheese, bacon, paprika", "thin", Category.PORK, 6.59);
            InShop.Add(beconareThin);
            Types beconareThick = new Types(4, "Beconare", "pizzasauce, cheese, bacon, paprika", "thick", Category.PORK, 8.45);
            InShop.Add(beconareThick);
            Types carneoliThin = new Types(5, "Carneoli", "pizzasauce, salami, cheese, champingon", "thin", Category.BEEF, 7.32);
            InShop.Add(carneoliThin);
            Types carneoliThick = new Types(6, "Carneoli", "pizzasauce, salami, cheese, champingon", "thick", Category.BEEF, 8.15);
            InShop.Add(carneoliThick);
            Types jolantaThin = new Types(7, "Jolanta", "pizzasauce, tuna, blue cheese, peach", "thin", Category.SEAFOOD, 9.67);
            InShop.Add(jolantaThin);
            Types jolantaThick = new Types(8, "Jolanta", "pizzasauce, tuna, blue cheese, peach", "thick", Category.SEAFOOD, 11.05);
            InShop.Add(jolantaThick);
            Types vegetarianaThin = new Types(9, "Vegetariana", "pizzasauce, olive, tomato, ananas", "thin", Category.VEGGIE, 5.43);
            InShop.Add(vegetarianaThin);
            Types vegetarianaThick = new Types(10, "Vegetariana", "pizzasauce, olive, tomato, ananas", "thick", Category.VEGGIE, 5.43);
            InShop.Add(vegetarianaThick);
            Types cheese = new Types(11, "Cheese", "", "", Category.EXTRAS, 0.60);
            InShop.Add(cheese);
            Types ananas = new Types(12, "Ananas", "", "", Category.EXTRAS, 0.40);
            InShop.Add(ananas);
            Types chicken = new Types(13, "Chicken", "", "", Category.EXTRAS, 0.80);
            InShop.Add(chicken);
            Types bacon = new Types(14, "Bacon", "", "", Category.EXTRAS, 0.55);
            InShop.Add(bacon);
            Types tomato = new Types(15, "Tomato", "", "", Category.EXTRAS, 0.25);
            InShop.Add(tomato);
            Types salami = new Types(16, "Salami", "", "", Category.EXTRAS, 0.65);
            InShop.Add(salami);
            Types tuna = new Types(17, "Tuna", "", "", Category.EXTRAS, 0.73);
            InShop.Add(tuna);
            Types peach = new Types(18, "Peach", "", "", Category.EXTRAS, 0.43);
            InShop.Add(peach);
            Types pizzasauce = new Types(19, "Sauce", "", "", Category.EXTRAS, 0.25);
            InShop.Add(pizzasauce);
            Types jalopeno = new Types(20, "Jalopeno", "", "", Category.EXTRAS, 0.15);
            InShop.Add(jalopeno);
            Types garlic = new Types(21, "Garlic", "", "", Category.EXTRAS, 0.12);
            InShop.Add(garlic);
            Types ham = new Types(22, "Ham", "", "", Category.EXTRAS, 0.15);
            InShop.Add(ham);

        }
        public void PrintTypes()
        {
            foreach (Types types in InShop)
            {
                Console.WriteLine($"ID: {types.Id}");
                Console.WriteLine($"Product: {types.Name}");
                if (types.Ingredients != "")
                Console.WriteLine($"Ingredients: {types.Ingredients}");
                if(types.Dough != "")
                Console.WriteLine($"Dough: {types.Dough}");
                Console.WriteLine($"Category: {types.Category}");
                Console.WriteLine($"Price: {types.Price}");
                Console.WriteLine();
                
                   
            }
           
        }

      
        public Types GetFromStockTypes(int id)
        {
            return InShop[id - 1];
         
        }
       
      
    }

}