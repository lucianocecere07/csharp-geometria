using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusGeometria
{
    internal class BonusRettangolo
    {
        //proprietà (PARTE 1)
        public int baseBonusRettangolo;
        public int altezzaBonusRettangolo;

        //metodi
        public int CalcolaBonusArea()
        {
            int areaRettangolo = baseBonusRettangolo * altezzaBonusRettangolo;
            return areaRettangolo;
        }

        public int CalcolaBonusPerimetro()
        {
            int perimetroRettangolo = (baseBonusRettangolo + altezzaBonusRettangolo) * 2;
            return perimetroRettangolo;
        }

        public void StampaRettangolo()
        {
            Console.WriteLine("--- Rettangolo ---");
            Console.WriteLine("base: " + baseBonusRettangolo + " cm");
            Console.WriteLine("altezza: " + altezzaBonusRettangolo + " cm");
            Console.WriteLine("perimetro: " + CalcolaBonusPerimetro() + " cm");
            Console.WriteLine("area: " + CalcolaBonusArea() + " cm^2");
        }

        //BONUS
        public void DisegnoRettangolo()
        {
            for (int i = 0; i < altezzaBonusRettangolo; i++)
            {
                Console.Write("|");

                for (int j = 0; j < baseBonusRettangolo; j++)
                {
                    if (i >= 1 && i < altezzaBonusRettangolo - 1)
                    {
                        Console.Write("  ");
                    }
                    else
                    {
                        Console.Write("--");
                    }
                }

                Console.WriteLine("|");
            }
        }
    }
}
