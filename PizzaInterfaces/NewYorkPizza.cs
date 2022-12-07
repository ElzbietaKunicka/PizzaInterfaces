using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaInterfaces
{
    public class NewYorkPizza : IPizza
    {
        public void Prepare()
        {
            Console.WriteLine("Preparing New York Pizza");
        }
    }
}
