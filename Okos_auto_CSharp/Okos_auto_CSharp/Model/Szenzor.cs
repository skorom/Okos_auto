using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Okos_auto_CSharp
{
    class Szenzor
    {
        public Szenzor (string sor)
        {
            this.idopont = Convert.ToDouble(sor.Split(' ')[0].Replace('.',','));
            this.esemeny = sor.Split(' ')[1];
            if(esemeny == "KOORD")
            {
                double x = Convert.ToDouble(sor.Split(' ')[2].Replace('.', ','));
                double y = Convert.ToDouble(sor.Split(' ')[3].Replace('.', ','));
                this.koordinata = new Koordinata(x, y);
            }
            else
            {
                this.koordinata = null;
            }
        }
        public double idopont { get; }
        public string esemeny { get; }
        public Koordinata koordinata { get; }

        public static List<Szenzor> szenzorAdatokEloallitasFilebol(string filename)
        {
            List<Szenzor> szenzorAdatok = new List<Szenzor>();
            string[] file = File.ReadAllLines(filename);
            file.ToList().ForEach(sor => szenzorAdatok.Add(new Szenzor(sor)));
            return szenzorAdatok;
        }

    }
}
