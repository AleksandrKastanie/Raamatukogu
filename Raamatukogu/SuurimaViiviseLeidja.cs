using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raamatukogu
{
    internal class SuurimaViiviseLeidja : Kontrollija
    {
        string laenutaja;
        string teoseKirjeldus;
        double suurimViivis;
        public SuurimaViiviseLeidja()
        {
            suurimViivis = 0;
        }
        void saadaHoiatus()
        {
            Console.WriteLine(laenutaja + ", " + teoseKirjeldus);
        }
        
        public void salvestaViivis(String laenutajaNimi, String teoseKirjeldus, double viiviseSuurus)
        {
            if (viiviseSuurus > suurimViivis)
            {
                this.laenutaja = laenutajaNimi;
                this.teoseKirjeldus = teoseKirjeldus;
                this.suurimViivis = viiviseSuurus;
            }
        }
    }
}
