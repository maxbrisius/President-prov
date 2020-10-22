using System.Runtime.InteropServices;
using System;

namespace cod
{
    class Program
    {
        static void Main(string[] args)
        {
            president pres = new president();
            legislation leg = new legislation(); 
            country count = new country();

            Console.WriteLine("Vad ska presiDent heta?");

            pres.name = Console.ReadLine();

            Console.WriteLine(pres.name + " vilken fin namnen.");
            Console.WriteLine("Detta är president åsikter:");
            Console.WriteLine("Miljö: " + pres.environmentPriority);
            Console.WriteLine("Försvar: " + pres.defensePriority);
            Console.WriteLine("Vård: " + pres.healthcarePriority);
            Console.WriteLine();
            Console.WriteLine("Presidenten är " + pres.corruption + "% korrupt");
            Console.WriteLine("Presidenten har " + pres.money + " miljarder $");
            Console.ReadLine();
            Console.WriteLine("Write: New Legislation to propose a legislation");

            string newLeg = Console.ReadLine();

            while(newLeg != "New Legislation")
            {
                Console.WriteLine("Try again.");

                newLeg = Console.ReadLine();
            }
            Console.WriteLine("The new legislation will improve:");
            Console.WriteLine("Environment by " + leg.legEnvironment);
            Console.WriteLine("Defense by " + leg.legDefense);
            Console.WriteLine("Healthcare by " + leg.legHealthcare);
            Console.ReadLine();
        }
    }
}