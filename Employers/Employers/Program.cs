using System;
using System.Collections.Generic;
using System.IO;

namespace Employers
{
    internal class Program
    {
        public static List<Employer> employers = new List<Employer>();

        public static void kiir()
        {
            Console.WriteLine("Az összes dolgozó neve:");
            foreach (var item in employers)
            {
                Console.WriteLine($"{item.Name}");
            }
        }

        public static void legjobbFizetes()
        {
            int max = employers[0].Sallery;
            int id = 0;

            foreach (var item in employers)
            {
                if (item.Sallery > max)
                {
                    max = item.Sallery;
                    id = item.Id;
                }
            }

            Console.WriteLine($"Azonosító: {id}, Fizetés: {max}");
        }
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("tulajdonsagok_100sor.txt");

            for (int i = 0; i < 100; i++)
            {
                Employer emp = new Employer(sr.ReadLine());
                employers.Add(emp);
            }

            kiir();
            legjobbFizetes();
        }
    }
}
