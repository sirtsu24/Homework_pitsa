using System;
using System.Collections.Generic;
using System.Text;

namespace pizzaShop
{
    enum Category
    { 
      VEGGIE,
      POULTRY,
      SEAFOOD,
      PORK,
      BEEF,
      EXTRAS

    }
    class Types
    {
        int id;
        string name;
        string ingredients;
        string dough;
        Category category;
        double price;

        public Types(int _id, string _name, string _ingredients,string _dough, Category _category, double _price)
        {
            id = _id;
            name = _name;
            ingredients = _ingredients;
            dough = _dough;
            category = _category;
            price = _price;

        }


        public int Id
        {
            get { return id; }
        }
        public string Name
        {
            get { return name; }
        }

        public string Ingredients
        {
            get { return ingredients; }
        }

        public string Dough
        {
            get { return dough; }
        }

        public string Category
        {
            get { return category.ToString(); }
        }

        public double Price
        {
            get { return price; }
        }

    }
}
