using AbstractFactoryPattern.Fatory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Models
{
    public class CheesePizza : Pizza
    {
        PizzaIngredientFactory IngredientFactory;

        public CheesePizza(PizzaIngredientFactory ingredientFactory)
        {
            this.IngredientFactory = ingredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing {this.Name}");
            this.Dough = this.IngredientFactory.CreateDough();
            this.Sauce = this.IngredientFactory.CreateSauce();
            this.Cheese = this.IngredientFactory.CreateCheese();
            Console.WriteLine($"{this.Dough}, {this.Sauce}, {this.Cheese}");
        }
    }
}
