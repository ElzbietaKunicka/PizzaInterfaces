namespace PizzaInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var order  = new List<IPizza> { new NewYorkPizza(), new CheesePizza() };
            order.ForEach(pizza => pizza.Prepare());
        }
    }
}