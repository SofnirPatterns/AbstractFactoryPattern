using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Fatory
{
    public class NYIPizzaIngridientFactory : PizzaIngredientFactory
    {
        public string CreateDough()
        {
            return "Thin Crust Dough";
        }
        public string CreateSauce()
        {
            return "Marinara Sauce";
        }
        public string CreateCheese()
        {
            return "Reggiano Cheese";
        }
        public List<string> CreateVeggies()
        {
            return new List<string>(new string[] { "Garlic", "Onion",
                    "Mushroom", "Red Pepper" });
        }
        public string CreatePeperoni()
        {
            return "Sliced Pepperoni";
        }
        public string CreateClam()
        {
            return "Fresh Clams";
        }
    }
}
