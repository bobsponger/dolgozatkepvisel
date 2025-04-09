using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            int maxszavazat = 12345;
            string[] kepviselo = ["", ""];
            Console.WriteLine("Add meg a képviselők számát");
            int szama = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < szama; i++)
            {
                Console.WriteLine("Add meg a képviselő nevét");
                string kepviselo = Console.ReadLine();
                Console.WriteLine("Add meg a pártját");
                string partja = Console.ReadLine();
                Console.WriteLine("Add meg a szavazó kerületét");
                int kerulet = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Add meg hányan szavaztak a képviselőre");
                int szavazat = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(kepviselo);
            Console.ReadKey();
            
            
        }
    }
}
