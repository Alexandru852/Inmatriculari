using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmatriculari
{
    public class NumarInmatriculare
    {
        
        public string Numar { get; set; }
        public string Valabilitate { get; set; }
        public int? Perioada { get; set; }
        public NumarInmatriculare(string _nr,string Val,int? _per)
        {
            Numar = _nr;
            Valabilitate = Val;
            Perioada = _per;
        }
        public bool VerificaValabilitate()
        {
            return Valabilitate != null;
        } 
        public bool ValidareNumar(string nr)
        {
            return nr==Numar;
        }
        public string toString()
        {
            if (VerificaValabilitate())
            {
                return "Numar inmatriculare existent. Acesta  are asiguare";
            }
            else
                return "Numarul de inmatriculare existent.Acesta nu are asiugare";
        }
    }
}
