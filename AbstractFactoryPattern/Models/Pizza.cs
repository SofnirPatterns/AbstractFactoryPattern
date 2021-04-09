using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Models
{
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
}
