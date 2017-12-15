using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ruleta
{
    class Ruleta
    {
        public Hrac Hrac;
        // tymto si hned inacializujeme stol, kedze ho mame skor vytvoreny
        public HraciStul HraciStul = new HraciStul();

        public void Zahraj(Sazka sazka, Hrac hrac)
        {
            // najprv sa pytam na co stavis, farbu?, cislo? ....
            // vytoci cislo
            // HraciPole vytoceneHp = VytocCislo()

            // porovna jestli vyhral ci ne
            //  hrac.Bank += VratVyhru(sazka, vytoceneHp);

            // uprav hracovi banka

            // sazku zaznamena do historie



        }

    }
}
