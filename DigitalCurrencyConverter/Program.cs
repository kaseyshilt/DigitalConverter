using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalCurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal Cash = 5000;
            decimal Bitcoin = 0;
            decimal Etherium = 0;
            decimal Litecoin = 0;

            bool reload = false;
            do
            {
                Console.WriteLine("\n\nPlease choose an action:\n" +
                        "P) Purchase Digital Currency using Cash.\n" +
                        "S) Sell digital Currency for Cash.\n" +
                        "V) View all 4 accounts.\n" +
                        "T) Transfer between digital Currency types.\n");
                        

                ConsoleKey userChoice = Console.ReadKey(true).Key;

                Console.Clear();

                switch (userChoice)
                {

                    case ConsoleKey.P:
                        bool exit = false;
                        Console.WriteLine("Which Digital Currency would you like to purchase? Choose below.");
                        switch (digitcalCurrencies)
                        {
                            case ConsoleKey.B:
                                Console.WriteLine("Bitcoin");

                        } while ()
                        break;
                    case ConsoleKey.S:
                        break;
                    case ConsoleKey.V:
                        Console.WriteLine("Value of all balances\n\n");
                        Console.WriteLine("The value of Cash is, " + Cash + ".");
                        Console.WriteLine("The value of Bitcoin is, " + Bitcoin + ".");
                        Console.WriteLine("The value of Etherium is, " + Etherium + ".");
                        Console.WriteLine("The value of Litecoin is, " + Litecoin + ".");
                        break;
                    case ConsoleKey.T:
                        break;
                }
            } while (!reload);
        }

        
    }
}
