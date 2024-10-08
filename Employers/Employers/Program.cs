﻿using System;
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

        public static void nyudijig()
        {
            foreach (var item in employers)
            {
                if (item.Age == 55)
                {
                    Console.WriteLine($"Dolgozo neve: {item.Name}, Dolgozó életkora: {item.Age}");
                }
            }
        }

        public static int keresetFelett()
        {
            int kereset = 0;

            foreach (var item in employers)
            {
                if (item.Sallery >= 50000)
                {
                    kereset++;
                }
            }

            return kereset;
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
            nyudijig();
            Console.WriteLine($"50000 vagy a felet keresők száma {keresetFelett()}");
        }
    }
}
