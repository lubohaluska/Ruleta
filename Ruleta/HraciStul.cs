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
            Barva[] rozmisteniBarev = new Barva[37] {Barva.zelena, Barva.cervena, Barva.cerna, Barva.cervena, Barva.cerna, Barva.cervena, Barva.cerna, Barva.cervena, Barva.cerna, Barva.cervena, Barva.cerna, Barva.cervena, Barva.cerna, Barva.cervena, Barva.cerna, Barva.cervena, Barva.cerna, Barva.cervena, Barva.cerna, Barva.cervena, Barva.cerna, Barva.cervena, Barva.cerna, Barva.cervena, Barva.cerna, Barva.cervena, Barva.cerna, Barva.cervena, Barva.cerna, Barva.cervena, Barva.cerna, Barva.cervena, Barva.cerna, Barva.cervena, Barva.cerna, Barva.cervena, Barva.cerna };
            for (int i = 0; i < rozmisteniBarev.Length; i++)
            {
                HraciPolicka[i].Barva = rozmisteniBarev[i];
                if (i == 0)
                {
                    HraciPolicka[i] = Rada.zadna;
                    HraciPolicka[i] = Lichost.zadna;

                }
                else
                {
                    HraciPolicka[i].Cislo = i;
                    HraciPolicka[i].Rada = vratRadu(i);
                    HraciPolicka[i].Lichost = vratLichost(i);
                }

                private vratLichost(int i)
                {

                }
    }
        }
        
        
    }
}
