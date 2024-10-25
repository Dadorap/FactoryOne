using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryOne
{
    public interface IPizza
    {

        public string PizzaName { get; set; }
        public List<string> Ingrediens { get; set; }
        void MakePizza();
    }
}
