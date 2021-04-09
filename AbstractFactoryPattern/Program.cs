using AbstractFactoryPattern.Common;
using AbstractFactoryPattern.Fatory;
using AbstractFactoryPattern.Models;
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
    }
}
