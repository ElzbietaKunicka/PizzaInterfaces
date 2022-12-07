using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaInterfaces
{
    public class CheesePizza : IPizza
    {
        public void Prepare()
        {
            Console.WriteLine("Preparing cheese pizza");
        }
    }
}
