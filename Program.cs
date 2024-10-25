namespace FactoryOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PizzaFactory factory = new PizzaFactory();
            Console.Write("Hello,what kind of piza u want? ");
            string choice = Console.ReadLine();

           var pizza = factory.CreatePizza(choice);
            List<string> list = new List<string>() {"tomato sause", "onion", "cheese", "redlopster" };
            pizza.PizzaName = "Boro boro";
            pizza.Ingrediens = list;

            pizza.MakePizza();
        }
    }
}
