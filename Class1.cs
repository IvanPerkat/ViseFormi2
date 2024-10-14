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

        public Class1(string ime, string prezime, string brojIndeksa, string smjer, DateTime datumRodenja)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.brojIndeksa = brojIndeksa;
            this.smjer = smjer;
            this.datumRodenja = datumRodenja;
        }

        public override string ToString()
        {
            return $"{ime} {prezime} | {smjer} | {brojIndeksa} | {datumRodenja.ToShortDateString()}";
        }
    }
}
