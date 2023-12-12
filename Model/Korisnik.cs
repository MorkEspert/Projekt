using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Model
{
    internal class Korisnik : IComparable
    {
        private string ime;

        private string oib;

        private string prezime;

        private string adresa;

        private string telefon;
        public string Ime { get { return ime; } set { ime = value; } }

        public string Oib { get { return oib; } set { oib = value; } }

        public string Prezime { get { return prezime; } set { prezime = value; } }

        public string Adresa { get { return adresa; } set { adresa = value; } }

        public string Telefon { get { return telefon; } set { telefon = value; } }

        public int CompareTo(object obj)
        {
            int rez = this.Prezime.CompareTo(((Korisnik)obj).Prezime);

            if (rez == 0)
            {
                rez = this.Ime.CompareTo(((Korisnik)obj).Ime);
                return rez;
            }

            return rez;

        }

        public override string ToString() => this.Prezime + " " + this.Ime;


    }

}
