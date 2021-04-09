using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore nyStylePizzaStore = new NYStylePizzaStore();
            Pizza pizza = nyStylePizzaStore.OrderPizza(PizzaType.Cheese);
            Console.WriteLine($"Ordered a {pizza.Name}\n");
            pizza = nyStylePizzaStore.OrderPizza(PizzaType.Clam);
            Console.WriteLine($"Ordered a {pizza.Name}\n");

            Console.ReadKey();
        }

        public abstract class Pizza
        {
            public string Name { get; set; }
            protected string Dough;
            protected string Sauce;
            protected List<string> Veggies;
            protected string Cheese;
            protected string Pepperoni;
            protected string Clam;

            public abstract void Prepare();               

            public void Bake()
            {
                Console.WriteLine("Bake for 25 miutes at 350");
            }

            public void Cut()
            {
                Console.WriteLine("Cutting the pizza into diagonal slices");
            }

            public void Box()
            {
                Console.WriteLine("Place pizza in offical PizzaStore box");
            }               
        }

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

        public enum PizzaType
        {
            Cheese,
            Clam
        }

        public abstract class PizzaStore
        {
            public Pizza OrderPizza(PizzaType type)
            {
                Pizza pizza = CreatePizza(type);

                pizza.Prepare();
                pizza.Bake();
                pizza.Cut();
                pizza.Box();

                return pizza;
            }

            protected abstract Pizza CreatePizza(PizzaType type);
        }

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

        public interface PizzaIngredientFactory
        {
            string CreateDough();
            string CreateSauce();
            string CreateCheese();
            List<string> CreateVeggies();
            string CreatePeperoni();
            string CreateClam();
        }

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
}
