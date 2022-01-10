using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snooker
{
    class Versenyzo
    {
        public int helyezes { get; set; }
        public string nev { get; set; }
        public string orszag { get; set; }
        public int nyeremeny { get; set; }
        public Versenyzo(string sor)
        {
            string[] t = sor.Split(';');
            helyezes = int.Parse(t[0]);
            nev = t[1];
            orszag = t[2];
            nyeremeny = int.Parse(t[3]);

        }
    }
}
