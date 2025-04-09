using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Kepviselo> kepviselok = new List<Kepviselo>();
            Console.WriteLine("Add meg a képviselők számát");
            int szama = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < szama; i++)
            {
                Console.WriteLine("Add meg a képviselő nevét");
                string nev = Console.ReadLine() ?? string.Empty;
                Console.WriteLine("Add meg a pártját");
                string partja = Console.ReadLine() ?? string.Empty;
                Console.WriteLine("Add meg a szavazó kerületét");
                int kerulet = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Add meg hányan szavaztak a képviselőre");
                int szavazat = Convert.ToInt32(Console.ReadLine());

                kepviselok.Add(new Kepviselo
                {
                    Nev = nev,
                    Partja = partja,
                    Kerulet = kerulet,
                    Szavazat = szavazat
                });
            }

            foreach (var kepviselo in kepviselok)
            {
                Console.WriteLine($"Név: {kepviselo.Nev}, Párt: {kepviselo.Partja}, Kerület: {kepviselo.Kerulet}, Szavazat: {kepviselo.Szavazat}");
            }

            Console.ReadKey();
        }
    }

    public class Kepviselo
    {
        public string Nev { get; set; }
        public string Partja { get; set; }
        public int Kerulet { get; set; }
        public int Szavazat { get; set; }
    }
}
