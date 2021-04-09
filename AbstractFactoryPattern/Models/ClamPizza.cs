using AbstractFactoryPattern.Fatory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Models
{
    public class ClamPizza : Pizza
    {
        PizzaIngredientFactory IngredientFactory;

        public ClamPizza(PizzaIngredientFactory ingredientFactory)
        {
            this.IngredientFactory = ingredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing {this.Name}");
            this.Dough = this.IngredientFactory.CreateDough();
            this.Sauce = this.IngredientFactory.CreateSauce();
            this.Cheese = this.IngredientFactory.CreateCheese();
            this.Clam = this.IngredientFactory.CreateClam();
            Console.WriteLine($"{this.Dough}, {this.Sauce}, {this.Cheese}, {this.Clam}");
        }
    }
}
