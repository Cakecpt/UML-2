using System;
using System.Collections.Generic;
using System.Text;

namespace UML_2
{
    class Pizza
    {
        public Pizza()
        {
            Price = 0;
            Name = "";
        }
        

        public string Name { get; set; }
        public int Nr { get; set; }
        public double Price { get; set; }

        public Pizza(int nr, string name, double price)
        {
            Name = name;
            Nr = nr;
            Price = price; 
        }

        public override string ToString()
        {
            return $"Number: {Nr} Pizza Name: {Name} Price {Price}";
        }
    }
}
