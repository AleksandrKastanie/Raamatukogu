using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raamatukogu
{
    internal class Ajakiri : Teos
    {
        private int aasta;

        public Ajakiri(string kirjeldus, string teoseTähis, string laenutaja, int päevadeArv) : base(kirjeldus, teoseTähis, laenutaja, päevadeArv)
        {
        }
        override public bool KasHoidlast()
        {
            return aasta < 2001;
        }
        internal new string toString()
        {
            return toString().Replace("Teos", "Ajakiri");
        }
    }
}
