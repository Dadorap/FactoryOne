using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryOne.PizzaFolder
{
    internal class VeggiePizza : IPizza
    {
        public string PizzaName { get; set; }
        public List<string> Ingrediens { get; set; }

        public void MakePizza()
        {
            Console.WriteLine(PizzaName + " with ");
            Ingrediens.ForEach(x => Console.WriteLine( x));

        }

    }
}
