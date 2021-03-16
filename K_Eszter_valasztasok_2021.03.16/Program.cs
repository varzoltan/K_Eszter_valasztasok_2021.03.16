using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace K_Eszter_valasztasok_2021._03._16
{
    class Program
    {
        struct Adat
        {
            public int v_kerulet;
            public int szavazatszam;
            public string nev;//Egybefogjuk kezelni a vezeték és keresztnevet!!!
            public string part;
        }
        static void Main(string[] args)
        {
            //1.lépés
            Adat[] adatok = new Adat[100];//Példányosítom a struktúrát!

            //2.lépés: Beolvasás
            //1.feladat
            StreamReader olvas = new StreamReader(@"C:\Users\Rendszergazda\Desktop\K_eszter_prog_erettsegi\2013-majus\szavazatok.txt");
            int n  =  0;
            while(!olvas.EndOfStream)
            {
                string sor  =  olvas.ReadLine();
                string[] db = sor.Split(' ');
                adatok[n].v_kerulet = int.Parse(db[0]);
                adatok[n].szavazatszam  = int.Parse(db[1]);
                adatok[n].nev = db[2] + " " + db[3];
                adatok[n].part = db[4];
                n++;
            }
            olvas.Close();
            Console.WriteLine("1.feladat\nBeolvasás kész!");

            //2.feladat
            Console.WriteLine($"2feladat\nA helyhatósági választáson {n} képviselőjelölt indult");

            //3.feladat
            Console.Write("Kérem adjon meg egy nevet: ");
            string nev = Console.ReadLine();
            bool volt = true;
            for (int i = 0;i<n;i++)
            {
                if (nev == adatok[i].nev)
                {
                    Console.WriteLine($"3.feladat\nAz adott képviselő {adatok[i].szavazatszam} szavazatot kapott!");
                    volt = false;
                }
            }
            if (volt)
            {
                Console.WriteLine("3.feladat\nIlyen nevű képviselőjelölt nem szerepel a nyilvántartásban!");
            }
            Console.ReadKey();
        }
    }
}
