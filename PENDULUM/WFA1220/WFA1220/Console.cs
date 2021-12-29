using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using WFA1220;

namespace Console
{
    class Program
    {
        public static List<albumclass> albumlista = new List<albumclass>();
        public static List<truckclass> trucklista = new List<truckclass>();
        public static List<addurlclass> urllista = new List<addurlclass>();
        public string ConnectionString { private get; set; }

        static void Main(string[] args)
        {
            addurlc();
            addD_beolvasas();
            beolvasas();
            tablafeltoltes();
            bekert();
        }

        private static void addurlc()
        {
            
        }

        private static void addD_beolvasas()
        {
            StreamReader sr = new StreamReader("Meghivass");
            string sor = ""; string vege = "[tracks]";
            if (sor != vege)
            {
                while (!sr.EndOfStream)
                {
                    sor = sr.ReadLine();
                    albumclass a = new albumclass(sor);
                    albumlista.Add(a);
                }
            }
            string kezdes = "[tracks]";
            if (sor == kezdes)
            {
                while (!sr.EndOfStream)
                {
                    sor = sr.ReadLine();
                    truckclass t = new truckclass(sor);
                    trucklista.Add(t);
                }
            }
        }

        private static void bekert()
        {
            StreamReader sr = new StreamReader("pendulum.txt");
            string sor = ""; string vege = "[tracks]";
            if (sor != vege)
            {
                while (!sr.EndOfStream)
                {
                    sor = sr.ReadLine();
                    albumclass a = new albumclass(sor);
                    albumlista.Add(a);
                }
            }
            string kezdes = "[tracks]";
            if (sor == kezdes)
            {
                while (!sr.EndOfStream)
                {
                    sor = sr.ReadLine();
                    truckclass t = new truckclass(sor);
                    trucklista.Add(t);
                }
            }
        }

        private static void tablafeltoltes()
        {
            string cmd = "";
            for (int i = 0; i < albumlista.Count; i++)
            {
                cmd = " INSERT INTO Albums (id, Artist, Title, Relase) VALUES (albumlista[i].Pnd, ,albumlista[i].Szerzo,albumlista[i].Cim,albumlista[i].Datum )";

            }
            for (int i = 0; i < trucklista.Count; i++)
            {
                cmd = " INSERT INTO Tracks (id ,title, length ,album ,url) VALUSES (trucklista[i]).Cime, trucklista[i]).Hossz, trucklista[i]).Azon, trucklista[i]).Link;";

            }
            for (int i = 0; i < urllista.Count; i++)
            {
                cmd = " INSERT INTO Tracks (url) VALUEES";

            }

        }

        private static void beolvasas()
        {
            StreamReader sr = new StreamReader("pendulum.txt", Encoding.UTF8);
            string sor = ""; string vege = "[tracks]";
            if (sor != vege)
            {
                while (!sr.EndOfStream)
                {
                    sor = sr.ReadLine();
                    albumclass a = new albumclass(sor);
                    albumlista.Add(a);
                }
            }
            string kezdes = "[tracks]";
            if (sor == kezdes)
            {
                while (!sr.EndOfStream)
                {
                    sor = sr.ReadLine();
                    truckclass t = new truckclass(sor);
                    trucklista.Add(t);
                }
            }
        }
    }
}
