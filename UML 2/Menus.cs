using System;
using System.Collections.Generic;
using System.Text;

namespace UML_2
{
    public class Menus
    {
        public string Name { get; private set; }
        public int Price { get; private set; }

        static Menus GetNewMenus()
        {
            Menus ffItem = new Menus();
            Console.Clear();
            Console.WriteLine("_______________________");
            Console.WriteLine();
            Console.WriteLine("Create your own Pizza!");
            Console.WriteLine("_______________________");
            Console.WriteLine();
            Console.WriteLine("Enter name: ");
            ffItem.Name = Console.ReadLine();

            string input = "";
            Console.WriteLine("Enter Price");
            try
            {
                input = Console.ReadLine();
                ffItem.Price = Int32.Parse(input);
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Error, no parse '{input}' - ErrorMsg: {e.Message}");
                throw;
            }

            return ffItem;
        }
        static int MainMenu( List<string> menuItems)
        {
            Console.Clear();
            Console.WriteLine("_______________________");
            Console.WriteLine();
            Console.WriteLine("MAMAS PIZZA CREATOR");
            Console.WriteLine("_______________________");
            Console.WriteLine();
            Console.WriteLine("Choose: ");
            foreach (string choice in menuItems)
            {
                Console.WriteLine(choice);
            }

            Console.Write("Enter Choice#: ");
            string input = Console.ReadKey().KeyChar.ToString();

            try
            {
                int result = Int32.Parse(input);
                return result;
            }

            catch (FormatException)
            {
                Console.WriteLine($"Error, no parse '{input}'");
            }
            return -1;
        }
        static public void Run()
        {
            bool proceed = true;
            List<string> mainMenulist = new List<string>()
            {
                "0. Quit",
                "1. Create new PIZZA!",
                "2. Other Menus"
            };
            while (proceed)
            {
                int MenuChoice = MainMenu(mainMenulist);
                Console.WriteLine();
                switch (MenuChoice)
                {
                    case 0:
                        proceed = false;
                        Console.WriteLine("Quitting");
                        break;

                    case 1:
                        try
                        {
                            Menus ff = GetNewMenus();
                            Console.WriteLine($"You created: {ff}");
                        }
                        catch (Exception)
                        {
                            Console.WriteLine($"No Menu created");
                        }
                        Console.WriteLine("Hit any key to continue");
                        Console.ReadKey();
                        break;

                    case 2:
                            Console.WriteLine($"You selected: {mainMenulist[MenuChoice]}");
                            Console.WriteLine("Hit any key to continue");
                            Console.ReadKey();
                            break;
                    default:    
                        Console.WriteLine("Hit any key to continue");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
