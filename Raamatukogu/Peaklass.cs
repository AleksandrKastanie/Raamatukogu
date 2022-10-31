using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raamatukogu
{
    internal class Peaklass
    {
        public static List<Teos> loeTeosed() 
        {
            List<Teos> teos = new List<Teos>();
            using (StreamReader sr = new StreamReader(@"..\..\..\laenutus.txt"))
            {
                while (!sr.EndOfStream)
                {
                    string[] rida = sr.ReadLine().Split(";");
                    Teos teo = new Teos(rida[0].ToString(), Int32.Parse(rida[1]));
                    teos.Add(teo);
                }
            }
            return teos;
        }
    }
}
