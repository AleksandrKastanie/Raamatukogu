using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raamatukogu 
{
    internal class ViiviseHoiataja : Kontrollija
    {
        double lubatudViivis;
        List<string> hoiatatavadLaenutajad;
        public ViiviseHoiataja(double lubatudViivis)
        {
            this.lubatudViivis = lubatudViivis;
            hoiatatavadLaenutajad = new List<string>();
        }

        public  void salvestaViivis(string laenutajaNimi, string teoseKirjeldus, double viiviseSuurus)
        {
            if (viiviseSuurus > lubatudViivis)
            {
                if (!hoiatatavadLaenutajad.Contains(laenutajaNimi))
                {
                    hoiatatavadLaenutajad.Add(laenutajaNimi);
                }
            }
        }
        public List<string> getHoiatatavadLaenutajad()
        {
            return hoiatatavadLaenutajad;
        }

    }
}
