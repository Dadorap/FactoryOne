using FactoryOne.PizzaFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryOne
{
    public class PizzaFactory
    {
        public IPizza CreatePizza(string s)
        {
            return s.ToLower() switch
            {
                "m" => new MargheritaPizza(),
                "p" => new PepperoniPizza(),
                "v" => new VeggiePizza(),
                _ => null
            };
        }
    }

}
