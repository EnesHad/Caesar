using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caesar
{
    class Metode
    {
        char[] abeceda = ['A', 'B', 'C', 'Č', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'R', 'S', 'Š', 'T', 'U', 'V', 'Z', 'Ž'];
        string en = "";
        string de = "";
        char c;
        int vsotaZamika = 0;
        public string encript(string niz, int zamik) {
            niz = niz.ToUpper();
            for (int i = 0; i < niz.Length; i++)
            {
                c = niz[i];
                for (int k = 0; k <= 25; k++)
                {
                    if (c == abeceda[k])
                    {
                        vsotaZamika = k + zamik + 1;
                        if (vsotaZamika > 25) vsotaZamika -= 25;
                        en = en + abeceda[vsotaZamika];
                        break;
                    }
                }
            }
            return en;

        }

        public string decode(string niz, int zamik) {
            niz = niz.ToUpper();
            for (int i = 0; i < niz.Length; i++)
            {
                c = niz[i];
                for (int k = 0; k <= 25; k++)
                {
                    if (c == abeceda[k])
                    {
                        vsotaZamika = (k - zamik) - 1;
                        if (vsotaZamika < 0) vsotaZamika += 25;
                        de = de + abeceda[vsotaZamika];
                        break;
                    }
                }
            }
            return de;
        }




    }
}
