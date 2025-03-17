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


        public string encript(string niz, int zamik, int dim) {
            for (int i = 0; i < niz.Length; i++)
            {
                c = niz[i];

                if (Char.IsSymbol(c) || Char.IsPunctuation(c)) { en = en + c; continue; }
                if (Char.IsNumber(c)) { en = en + c;  continue; }
                if (Char.IsWhiteSpace(c)) { en = en + space; continue; }
                b = Char.IsUpper(c);
                if ( b == true) {
                    for (int k = 0; k < 25; k++)
                    {
                        if (c == abcV[k])
                        {
                            vsotaZamika = k +1 + zamik + dim;
                            while (vsotaZamika >= 25 ) { 
                                vsotaZamika -= 25;
                            }
                            en = en + abcV[vsotaZamika];
                            dim =dim + 2;
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
                            vsotaZamika = k + zamik + 1 + dim;
                            while (vsotaZamika >= 25)
                            {
                                vsotaZamika -= 25;
                                //Console.WriteLine(vsotaZamika);
                            }
                            //Console.WriteLine("neki je prou "+vsotaZamika);
                            en = en + abcM[vsotaZamika];
                            dim =dim + 2;
                            break;
                        }
                    }
                }
                    
            }
            return en;

        }

        public string decode(string niz, int zamik, int dim) {
            for (int i = 0; i < niz.Length; i++)
            {
                c = niz[i];
                if (Char.IsSymbol(c) || Char.IsPunctuation(c)) { de = de + c; continue; }
                if (Char.IsNumber(c)) { de = de + c; continue; }
                if (Char.IsWhiteSpace(c)) { de = de + space; continue; }
                l = Char.IsUpper(c);
                if (l == true)
                {
                    for (int k = 0; k < 25; k++)
                    {
                        if (c == abcV[k])
                        {
                            vsotaZamika = (k - zamik) - (1 + dim);
                            while (vsotaZamika < 0)
                            {
                                vsotaZamika += 25;
                            }
                            de = de + abcV[vsotaZamika];
                            dim =dim + 2;
                            break;
                        }
                    }
                    l=false;

                }
                else { 
                 for (int k = 0; k < 25; k++)
                    {
                        if (c == abcM[k])
                        {
                            vsotaZamika = (k - zamik) - (1 + dim);
                            while (vsotaZamika < 0)
                            {
                                vsotaZamika += 25;
                            }
                            de = de + abcM[vsotaZamika];
                            dim =dim + 2;
                            break;
                        }
                    }
                }
                   
            }
            return de;
        }




    }
}
