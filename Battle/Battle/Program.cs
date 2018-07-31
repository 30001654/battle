using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle
{
    class Program
    {
        static void Main(string[] args)
        {
            string menu;
            do
            {
                Console.WriteLine("");
                menu = Console.ReadLine();
                switch (menu)
                {
                    case "1":
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "e":
                        break;
                    default:
                        Console.WriteLine("Error invalid input!");
                        break;
                }
            } while (menu != "e");
        }
    }
}
