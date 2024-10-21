using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViseFormi
{
    public class Class1
    {
        private string ime;
        private string prezime;
        private string brojIndeksa;
        private string smjer;
        private DateTime datumRodenja;
        private string studij;

        public Class1(string ime, string prezime, string brojIndeksa, string smjer, DateTime datumRodenja, string studij)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.brojIndeksa = brojIndeksa;
            this.smjer = smjer;
            this.datumRodenja = datumRodenja;
            this.studij = studij;
        }

        public override string ToString()
        {
            return $"{ime} {prezime} | {smjer} | {studij.Substring(0, 1)} | {brojIndeksa} | {datumRodenja.ToShortDateString()}";
        }
    }
}
