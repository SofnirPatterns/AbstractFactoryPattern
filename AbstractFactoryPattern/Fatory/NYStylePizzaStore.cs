using AbstractFactoryPattern.Common;
using AbstractFactoryPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Fatory
{
    public class NYStylePizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(PizzaType type)
        {
            Pizza pizza = null;
            PizzaIngredientFactory ingredientFactory = new NYIPizzaIngridientFactory();
            switch (type)
            {
                case PizzaType.Cheese:
                    pizza = new CheesePizza(ingredientFactory);
                    pizza.Name = "New York Style Cheese Pizza";
                    break;
                case PizzaType.Clam:
                    pizza = new ClamPizza(ingredientFactory);
                    pizza.Name = "New York Style Clam Pizza";
                    break;
                default:
                    return null;
            }
            return pizza;
        }
    }
}
