using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raamatukogu
{
    internal class Raamat : Teos
    {
        public Raamat(string kirjeldus, string teoseTähis, string laenutaja, int päevadeArv) : base(kirjeldus, teoseTähis, laenutaja, päevadeArv)
        {

        }

        

        override public bool KasHoidlast()
        {
            return getTeoseTähis().Contains("sinine") || getTeoseTähis().Contains("kollane");
        }


        internal new string toString()
        {
            return toString().Replace("Teos", "Raamat");
        }
    }
}
