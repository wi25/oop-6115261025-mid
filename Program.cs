using System;

namespace oop_6115261025_mid
{
    class Program
    {
            static void Main(string[] args)
            {
                Village a = new Village("a", 15000);
                Village b = new Village("b", 50000);
                Village c = new Village("c", 100000);
                Decoration Gangnam = new Decoration("Gangnam", 100000);
                Decoration Ascard = new Decoration("Ascard", 20000);
                Decoration Winterfell = new Decoration("Winterfell", 1000000);
                House h1 = new House(1, 1, 100, Gangnam, a);
                Console.WriteLine(h1.ToString());
            }
        }
    }
    
