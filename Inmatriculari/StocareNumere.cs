using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmatriculari
{
    internal class StocareNumere
    {
        public NumarInmatriculare[] numere = new NumarInmatriculare[100000];
        public int contor=0;
        List<string> NumereInmatriculariValabile = new List<string>() { "B","AB", "AG", "AR", "BC", "BH", "BN", "BR", "BT", "BV", "BZ", "CJ", "CL", "CS", "CT", "CV", "DB", "DJ", "GJ", "GL", "GR", "HD", "HR", "IF", "IL", "IS", "MH", "MM", "MS", "NT", "OT", "PH", "SB", "SJ", "SM", "SV", "TL", "TM", "TR", "VL", "VN", "VS" };



        public bool Valideaza(string s)
        {
         
            foreach (var numere in NumereInmatriculariValabile)
            {
                if (s.Contains(numere))
                      return true;
            }
            return false;
        }
        public void AdaugaNumar(NumarInmatriculare nr)
        {
            foreach (var numerei in NumereInmatriculariValabile)
            {
                if ((nr.Numar.Contains(numerei)))
                {
                    numere[contor] = nr;
                    nr.Numar.ToUpper();
                    contor++;
                    break;
                }
            }
        }
        /// <summary>
        /// Aceasta functie simuleaza o baza de date
        /// </summary>
        public void Stocare()
        {
            AdaugaNumar(new NumarInmatriculare("SV02PRA", null,null));
            AdaugaNumar(new NumarInmatriculare("SV15YAL", "10.20.2021",6));
            AdaugaNumar(new NumarInmatriculare("SV19PVA", "10.05.2021",12));
            AdaugaNumar(new NumarInmatriculare("SV95GEO", "04.01.2021",12));
            AdaugaNumar(new NumarInmatriculare("BT23CAT", "11.05.2021",6));
        }
    }
}
