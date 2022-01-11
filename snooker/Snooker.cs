using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace snooker
{
    class Snooker
    {
        static void Main(string[] args)
        {
            List<Versenyzo> Versenyzok = new List<Versenyzo>();
            foreach (var sor in File.ReadAllLines("snooker.txt").Skip(1)) //sorok -> string tömb
            {
                Versenyzok.Add(new Versenyzo(sor));
            }
            //test Console.WriteLine(Versenyzok[0].nev);
            
            //3.feladat egy darab kiiras lesz.
            Console.WriteLine($"3. feladat: a vilagranglistan {Versenyzok.Count} versenyzo szerepel.");

            //4.
            double atlag;
            int osszeg = 0;
            foreach (var vmintversenyzo in Versenyzok)
            {
                osszeg += vmintversenyzo.nyeremeny;
            }
            atlag = (double)osszeg / Versenyzok.Count; //double - kényszerítés
            Console.WriteLine($"4. feladat: a versenyzők átlagosan {atlag:0.00} fontot kerestek");
            //vagy
            Console.WriteLine($"4. feladat: a versenyzők átlagosan {Versenyzok.Average(versenyzo => versenyzo.nyeremeny):0.00} fontot kerestek");

            //5. noeware
            int maxNyer = 0;
            Versenyzo maxV = Versenyzok[0];
            foreach (var v in Versenyzok)
            {
                if (v.orszag == "Kína" && v.nyeremeny > maxV.nyeremeny)
                {
                    maxV = v;
                }

            }
            Console.WriteLine($"A legjobban kereső kínai tányér:");
            Console.WriteLine($"\tHelyezés: {maxV.helyezes}");
            Console.WriteLine($"\tNév: {maxV.nev}");
            Console.WriteLine($"\tOrszág: {maxV.orszag}");
            Console.WriteLine($"\tNyeremény: {(maxV.nyeremeny * 380).ToString("C0")} ");
            //vagy
                maxV = Versenyzok
                .Where(v => v.orszag == "Kína")
                .OrderBy(v => v.nyeremeny)
                .Last(); //csak az utolsó kell
            Console.WriteLine($"A legjobban kereső kínai tányér:");
            Console.WriteLine($"\tHelyezés: {maxV.helyezes}");
            Console.WriteLine($"\tNév: {maxV.nev}");
            Console.WriteLine($"\tOrszág: {maxV.orszag}");
            Console.WriteLine($"\tNyeremény: {(maxV.nyeremeny * 380).ToString("C0")} ");

            //6.
        }
    }
}
