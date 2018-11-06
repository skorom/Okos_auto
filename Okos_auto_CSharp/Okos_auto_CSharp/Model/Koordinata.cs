using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okos_auto_CSharp
{
    class Koordinata
    {
        public Koordinata(double _x, double _y)
        {
            this.x = _x;
            this.y = _y;
        }

        public double x { get; set; }
        public double y { get; set; }
    }
}
