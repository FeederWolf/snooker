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
        }
    }
}
