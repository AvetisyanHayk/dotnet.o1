using Oefening1;
using Oefening2;
using Oefening3;
using Oefening4;
using Oefening5;
using Oefening6;
using System;
using System.Collections.Generic;
using System.IO;

namespace OefeningenLes1
{
    class Program
    {
        static void Main(string[] args)
        {
            Oefening1_Faculteit();
            Oefening2_Temperatuur();
            Oefening3_en_4_Hogeschool();
            Oefening5_Vierkantsvergelijking();
            Oefening6_Frequentietabel();
        }

        private static void Oefening1_Faculteit()
        {
            Faculteit faculteit = new Faculteit(7);
            Console.WriteLine(faculteit.Bereken());
        }

        private static void Oefening2_Temperatuur()
        {
            Temperatuur temp = new Temperatuur(23);
            Console.WriteLine(temp.ToString());
        }

        private static void Oefening3_en_4_Hogeschool()
        {
            Hogeschool hogeschool = new Hogeschool();
            Lector lector = new Lector(1, "Frédéric", "Vlummens");
            Klasgroep klas = new Klasgroep(lector);
            klas.Studenten = new List<Student>
            {
                new Student(1, "Hayk", "Avetisyan", "SSE"),
                new Student(2, "Wolker", "Lemahieu", "CCCP"),
                new Student(3, "Dr. Jonas", "Anseel", "SSE"),
                new Student(4, "Prof. Sven", "Depickere", "ITC")
            };
            hogeschool.AddKlasgroep(klas);
            Console.WriteLine(hogeschool.ToString());
        }

        private static void Oefening5_Vierkantsvergelijking()
        {
            Vierkantsvergelijking vergelijking = new Vierkantsvergelijking(1, 4, -5);
            Console.WriteLine(vergelijking.ToString());
        }

        private static void Oefening6_Frequentietabel()
        {
            Frequentietabel frequentietabel = new Frequentietabel();
            string woord = "";
            bool gestopt = false;
            while (!gestopt)
            {
                Console.Write("Tik een woord: ");
                woord = Console.ReadLine().ToLower();
                gestopt = string.Equals(woord, "stop", StringComparison.OrdinalIgnoreCase);
                if (!gestopt)
                {
                    frequentietabel.Add(woord);
                }
            }
            foreach (string key in frequentietabel.Tabel.Keys)
            {
                Console.WriteLine($"{key}: {frequentietabel.Get(key)}");
            }
        }
    }
}
