using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Model
{
    internal class Racun
    {
        private int brojRacuna;
        private double stanje;

        public int BrojRacuna { get { return brojRacuna; } set { this.brojRacuna = value; } }
        public double Stanje { get { return stanje; } set { this.stanje = value; } }



        public int CompareTo(object obj) => this.BrojRacuna.CompareTo(((Racun)obj).BrojRacuna);


        public override string ToString() => this.BrojRacuna.ToString();


    }
}
