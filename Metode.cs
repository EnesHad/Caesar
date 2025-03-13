using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caesar
{
    class Metode
    {
        char[] abcM = ['a', 'b', 'c', 'č', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'r', 's', 'š', 't', 'u', 'v', 'z', 'ž'];
        char[] abcV = ['A', 'B', 'C', 'Č', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'R', 'S', 'Š', 'T', 'U', 'V', 'Z', 'Ž'];
        string en = "";
        string de = "";
        char c;
        bool b;
        string space = " ";
        bool l;
        int vsotaZamika = 0;


        public string encript(string niz, int zamik) {
            //niz = niz.ToUpper();
            for (int i = 0; i < niz.Length; i++)
            {
                c = niz[i];
                if (Char.IsWhiteSpace(c)) { en = en + space; continue; }
                b = Char.IsUpper(c);
                if ( b == true) {
                    for (int k = 0; k <= 25; k++)
                    {
                        if (c == abcV[k])
                        {
                            vsotaZamika = k + zamik + 1;
                            if (vsotaZamika > 25) vsotaZamika -= 25;
                            en = en + abcV[vsotaZamika];
                            break;
                        }
                    }
                    b= false;
                }
                else
                {
                    for (int k = 0; k <= 25; k++)
                    {
                        if (c == abcM[k])
                        {
                            vsotaZamika = k + zamik + 1;
                            if (vsotaZamika > 25) vsotaZamika -= 25;
                            en = en + abcM[vsotaZamika];
                            break;
                        }
                    }
                }
                    
            }
            return en;

        }

        public string decode(string niz, int zamik) {
            //niz = niz.ToUpper();
            for (int i = 0; i < niz.Length; i++)
            {
                c = niz[i];
                if (Char.IsWhiteSpace(c)) { de = de + space; continue; }
                l = Char.IsUpper(c);
                if (l == true)
                {
                    for (int k = 0; k <= 25; k++)
                    {
                        if (c == abcV[k])
                        {
                            vsotaZamika = (k - zamik) - 1;
                            if (vsotaZamika < 0) vsotaZamika += 25;
                            de = de + abcV[vsotaZamika];
                            break;
                        }
                    }
                    l=false;

                }
                else { 
                 for (int k = 0; k <= 25; k++)
                    {
                        if (c == abcM[k])
                        {
                            vsotaZamika = (k - zamik) - 1;
                            if (vsotaZamika < 0) vsotaZamika += 25;
                            de = de + abcM[vsotaZamika];
                            break;
                        }
                    }
                }
                   
            }
            return de;
        }




    }
}
