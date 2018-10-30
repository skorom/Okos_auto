using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.IO;

namespace Okos_auto_CSharp
{
    public class Terkep
    {
        public Terkep (string[] fajl)
        {
            int sorhossz = fajl[0].Split(' ').Length;
            if (fajl.Length<5 || fajl.Length>20 || sorhossz < 5 || sorhossz > 20)
            {
                throw new IOException("A táblázat hosszai nem a megadott tartományon belül vannak");
            }

            Cella[,] _tablazat = new Cella[fajl.Length, sorhossz];

            for (int i = 0; i < tablazat.GetLength(0); i++)
            {
                for (int j = 0; j < tablazat.GetLength(1); j++)
                {
                    tablazat[i, j] = new Cella(fajl[i].Split(' ')[j]);
                }
            }
        }
        public Cella[,] tablazat { get; set; }

        public static Terkep terkepEloallitasFilebol(string filename)
        {
            string[] file = File.ReadAllLines(filename);
            return new Terkep(file);
        }
    }
}
