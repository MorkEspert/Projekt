using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Model
{
    internal class Transakcija
    {
        private double racun;
        private string korisnik;
        private DateTime datumTransakcije;
        
        public double Racun { get { return racun; } set {  racun = value; } }
        public string Korisnik { get { return korisnik; } set{ korisnik = value; } }

        public DateTime DatumTransakcije { get { return datumTransakcije; } set { this.datumTransakcije = value; } }

        
        public int CompareTo(object obj)
        {

            int rez = this.DatumTransakcije.CompareTo(((Transakcija)obj).DatumTransakcije);

            if (rez == 0)
            {
                rez = this.Racun.CompareTo(((Transakcija)obj).Racun);
                return rez;
            }
            return rez;
        }
        public override string ToString() => this.Racun + " " + this.DatumTransakcije;

    }
}
