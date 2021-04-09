using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Fatory
{
    public interface PizzaIngredientFactory
    {
        string CreateDough();
        string CreateSauce();
        string CreateCheese();
        List<string> CreateVeggies();
        string CreatePeperoni();
        string CreateClam();
    }
}
