using System;
using System.Collections.Generic;
using System.Text;

namespace UML_2
{
    class MenuCatalog
    {
        Dictionary<int, Pizza> pizzas;

       public MenuCatalog()
        {
            pizzas = new Dictionary<int, Pizza>();
        }

        public void CreatePizza(Pizza pizza)
        {
            pizzas.Add(pizza.Nr, pizza);
        }

        public Pizza ReadPizza(int nr)
        {
            return pizzas[nr];       
        }

        public void UpdatePizza(Pizza pizza)
        {

        }

        public void DeletePizza(int nr)
        {
           
        }
    }
}
