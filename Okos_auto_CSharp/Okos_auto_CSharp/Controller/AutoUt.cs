using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okos_auto_CSharp
{
    class AutoUt
    {
        public AutoUt(Terkep terkep, List<Szenzor> szenzorAdatok)
        {
            this.idopillanatok = new List<Auto>();
            Koordinata lastPos = new Koordinata(0, 0);
            foreach (Szenzor item in szenzorAdatok)
            {
                Auto a = new Auto();
                if (item.koordinata == null)
                {
                    a.koord = lastPos;
                } else
                {
                    a.koord = item.koordinata;
                }
                a.motorAllapot = null;
                lastPos = a.koord;
                this.idopillanatok.Add(a);
            }
        }
        public List<Auto> idopillanatok { get; set; }
        public int incidensekSzama { get; set; }
    }
}
