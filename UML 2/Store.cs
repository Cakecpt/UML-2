using System;
using System.Collections.Generic;
using System.Text;

namespace UML_2
{
    class Store
    {
        public void Start()
        {
            Test();
        }

        public void Test()
        {
            MenuCatalog menu = new MenuCatalog();

            Pizza p1 = new Pizza(1, "Pepperoni pizza", 65);
            Pizza p2 = new Pizza(2, "Skinke pizza", 60);
            menu.CreatePizza(p1);
            menu.CreatePizza(p2);

            Console.WriteLine("Pizza created:");
            Console.WriteLine(p1);
            Console.WriteLine(p2);

            Console.WriteLine("Reading pizza:");
            Console.WriteLine(menu.ReadPizza(1));
        }
    }
}
