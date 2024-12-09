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
        private string godina;

        public Class1(string ime, string prezime, string brojIndeksa, string smjer, DateTime datumRodenja, string studij, string godina)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.brojIndeksa = brojIndeksa;
            this.smjer = smjer;
            this.datumRodenja = datumRodenja;
            this.studij = studij;
            this.godina = godina;
        }

        public override string ToString()
        {
            return $"{ime} {prezime} | {smjer} | {godina}. | {studij.Substring(0, 1)} | {brojIndeksa} | {datumRodenja.ToShortDateString()}";
        }
    }
}
