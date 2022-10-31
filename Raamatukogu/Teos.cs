using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raamatukogu
{
    abstract class Teos : IComparable<Teos>
    {
        private string kirjeldus;
        private string teoseTähis;
        private string laenutaja;
        private int päevadeArv;



        public Teos(string kirjeldus, string teoseTähis, string laenutaja, int päevadeArv)
        {
            this.kirjeldus = kirjeldus;
            this.teoseTähis = teoseTähis;
            this.laenutaja = laenutaja;
            this.päevadeArv = päevadeArv;
        }

        public abstract bool KasHoidlast();

        public string getTeoseTähis()
        {
            return teoseTähis;
        }

        public int laenutusaeg()
        {
            switch (teoseTähis)
            {
                case "roheline":
                    return 1;
                case "kollane":
                    return 30;
                case "sinine":
                    return 60;
                case "puudub":
                    return 14;
                default:
                    return 0;
            };
        }

        public double päevaneViivis()
        {
            switch (teoseTähis)
            {
                case "roheline":
                    return 2;
                case "kollane":
                    return 0.05;
                case "sinine":
                    return 0.05;
                case "puudub":
                    return 0.15;
                default:
                    return 0;
            };
        }

        public void arvutaViivis(Kontrollija kontrollija)
        {
            int lubatud = laenutusaeg();
            if (päevadeArv > lubatud)
            {
                int üle = päevadeArv - lubatud;
                kontrollija.salvestaViivis(laenutaja, kirjeldus, üle * päevaneViivis());
            }
        }

       
        public string toString()
        {
            return "Teos{" +
                    "kirjeldus='" + kirjeldus + '\n' +
                    ", teoseTähis='" + teoseTähis + '\n' +
                    ", laenutaja='" + laenutaja + '\n' +
                    ", päevadeArv=" + päevadeArv + '\n' +
                    ", kashoidlast= " + KasHoidlast() +
                    '}';
        }

        public int CompareTo(Teos? other)
        {
            if (other == null) return 1;
            return kirjeldus.CompareTo(other.kirjeldus);
        }
    }
}

