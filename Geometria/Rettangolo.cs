using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Rettangolo
    {
        //proprietà
        public int baseRettangolo;
        public int altezzaRettangolo;

        //metodi
        public int calcolaArea()
        {
            int areaRettangolo = baseRettangolo * altezzaRettangolo;
            return areaRettangolo;
        }

        public int calcolaPerimetro()
        {
            int perimetroRettangolo = (baseRettangolo + altezzaRettangolo) * 2;
            return perimetroRettangolo;
        }
    }
}
