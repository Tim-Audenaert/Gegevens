using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gegevens
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vooraam: ");
            string voornaam = Console.ReadLine();
            Console.Write("Naam: ");
            string naam = Console.ReadLine();
            Console.Write("Straat: ");
            string straat = Console.ReadLine();
            Console.Write("Huisnummer: ");
            string huisnummer = Console.ReadLine();
            Console.Write("Woonplaats: ");
            string woonplaats = Console.ReadLine();
            Console.Write("Postcode: ");
            string postcode = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine($"Naam: {voornaam} {naam}");
            Console.WriteLine($"Adres: {straat} {huisnummer}, {postcode} {woonplaats}");
            Console.ReadLine();


        }
    }
}
