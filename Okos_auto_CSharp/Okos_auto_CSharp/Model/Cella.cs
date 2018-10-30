using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okos_auto_CSharp
{
    public class Cella
    {
        public Cella (int s)
        {
            this.sebessegKorlat = s;
        }
        public Cella (string s)
        {
            this.sebessegKorlat = Convert.ToInt32(s);
        }
        public int sebessegKorlat { get; set; }
    }
}
