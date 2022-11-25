using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Rettangolo
    {
        //proprietà (PARTE 1)
        public int baseRettangolo;
        public int altezzaRettangolo;

        //metodi
        public int CalcolaArea()
        {
            int areaRettangolo = baseRettangolo * altezzaRettangolo;
            return areaRettangolo;
        }

        public int CalcolaPerimetro()
        {
            int perimetroRettangolo = (baseRettangolo + altezzaRettangolo) * 2;
            return perimetroRettangolo;
        }

        public void StampaRettangolo()
        {
            Console.WriteLine("base: " + baseRettangolo + " cm");
            Console.WriteLine("altezza: " + altezzaRettangolo + " cm");
            Console.WriteLine("perimetro: " + CalcolaPerimetro() + " cm");
            Console.WriteLine("area: " + CalcolaArea() + " cm^2");
        }
    }
}
