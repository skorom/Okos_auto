using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okos_auto_CSharp
{
    class Koordinata
    {
        public Koordinata(int _x, int _y)
        {
            this.x = _x;
            this.y = _y;
        }

        public int x { get; set; }
        public int y { get; set; }
    }
}
