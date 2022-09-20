using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataImport
{
    internal class Program
    {
        public static object SteamReader { get; private set; }

        static void Main(string[] args)
        {
            //004 Aufgaben Wiederholung Tag 1
            //Seite 7, Aufgabe 2 & 3
            //FileInfo fi = new FileInfo("T:/WKH_EXC/Trash/cbec/BMI-data.csv");
            //fi.CopyTo("C:/001Projects/meine_datei.csv");
            //Console.ReadKey();

            //Seite 7, Aufgabe 4
            //FileInfo fi_neu = new FileInfo("C:/001Projects/meine_datei.csv");
            //fi_neu.Delete();
            //Console.ReadKey();

            //Seite 7, Aufgabe 5
            //FileInfo fi = new FileInfo("T:/WKH_EXC/Trash/cbec/BMI-data.csv");

            //Console.WriteLine("Gebe mir den Pfad an, wohin die Datei geschrieben werden soll!");
            //string path = Console.ReadLine();
            //path.Replace("\\", "\\\\");
            //DirectoryInfo di = new DirectoryInfo(path.Replace("\\", "\\\\"));
            //while (di.Exists == false)
            //{
            //    Console.WriteLine("Dein Pfad existiert nicht, gib mir einen neuen!");
            //    path = Console.ReadLine();
            //    di = new DirectoryInfo(path.Replace("\\", "\\\\"));
            //}
            //Console.WriteLine("Wie soll die Datei heißen?");
            //string fileName = Console.ReadLine();
            //fi.CopyTo(path + fileName);
            //Console.ReadKey();

            //Seite 7, Aufgabe 6
            //FileInfo fi = new FileInfo("T:/WKH_EXC/Trash/cbec/BMI-data.csv");
            //if (fi.Exists)
            //{
            //    fi.CopyTo("C:/001Projects/meine_datei.csv");
            //}
            //Console.ReadKey();

            //Seite 7, Aufgabe 7
            //string path = @"C:/001Projects/neue_datei.csv";
            //StreamReader sr = new StreamReader(path);
            //while (!sr.EndOfStream)
            //{
            //    Console.WriteLine(sr.ReadLine());
            //}
            //Console.ReadKey();

            //Seite 7, Aufgabe 8
            //string path = @"C:/001Projects/neue_datei.csv";
            //StreamReader sr = new StreamReader(path);
            //List<string[]> eintraege = new List<string[]>();
            //while (!sr.EndOfStream)
            //{
            //    eintraege.Add(sr.ReadLine().Split(';'));
            //}
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(string.Join("\t", eintraege[i]));
            //}
            //Console.ReadKey();

            //Seite 8, Aufgabe 8
            string path = @"C:/001Projects/neue_datei.csv";
            StreamReader sr = new StreamReader(path);
            List<string[]> eintraege = new List<string[]>();
            //Remove Header
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                eintraege.Add(sr.ReadLine().Split(';'));
            }
            for (int i = 0; i < eintraege.Count; i++)
            {
                if (Convert.ToInt32(eintraege[i][2]) < 20 && eintraege[i][0] == "m")
                {
                    Console.WriteLine(string.Join("\t", eintraege[i]));
                }
            }
            Console.ReadKey();



        }
    }
}
