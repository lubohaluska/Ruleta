using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ruleta
{
    class HraciStul
    {
        // hraci stol ma 36 cisiel a nulu a tu sa zaklada
        public HraciPole[] HraciPolicka = new HraciPole[37];
        public HraciStul()
        {
            Barva[] rozmisteniBarev = new Barva[37] { Barva.zelena, Barva.cervena, Barva.cerna, Barva.cervena, Barva.cerna, Barva.cervena, Barva.cerna, Barva.cervena, Barva.cerna, Barva.cervena, Barva.cerna, Barva.cervena, Barva.cerna, Barva.cervena, Barva.cerna, Barva.cervena, Barva.cerna, Barva.cervena, Barva.cerna, Barva.cervena, Barva.cerna, Barva.cervena, Barva.cerna, Barva.cervena, Barva.cerna, Barva.cervena, Barva.cerna, Barva.cervena, Barva.cerna, Barva.cervena, Barva.cerna, Barva.cervena, Barva.cerna, Barva.cervena, Barva.cerna, Barva.cervena, Barva.cerna };
            for (int i = 0; i < rozmisteniBarev.Length; i++)
            {
                HraciPolicka[i].Barva = rozmisteniBarev[i];

                {
                    HraciPolicka[i].Cislo = i;
                    HraciPolicka[i].Rada = vratRadu(i);
                    HraciPolicka[i].Lichost = vratLichost(i);
                }





            }


        }
        private Lichost vratLichost(int cislo)
        {
            if (cislo == 0)
            {
                return Lichost.zadna;
            }
            //kontolujeme ci je parne alebo nie

            if (cislo % 2 == 0) return Lichost.licha;
            return Lichost.suda;
        }

        private Rada vratRadu(int cislo)
        {
            if (cislo == 0) return Rada.zadna;
            if (cislo == 1 || (cislo - 1) % 3 == 0) return Rada.treti;
            if (cislo == 2 || (cislo - 2) % 3 == 0) return Rada.druha;
///            if (cislo == 3 || (cislo - 3) % 3 == 0) return Rada.treti; jednoduchsi zapis nasledujuci riadok
            return Rada.treti;

        }
    }
}
