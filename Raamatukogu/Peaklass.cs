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
                    string typ = sr.ReadLine();
                    if (typ == null) throw new Exception();
                    string[] rida = typ.Split("; ");
                    if (rida.Length != 4) throw new Exception();
                    {
                        if (rida.Contains("/"))
                        {
                            int aasta = int.Parse(rida[0].Split("/")[1].Split(",")[0]);
                            teos.Add(new Ajakiri(rida[0], rida[1], rida[2], int.Parse(rida[3]), aasta));
                        }
                        else
                        {
                            teos.Add(new Raamat(rida[0], rida[1], rida[2], int.Parse(rida[3])));
                        }
                    }
                }
            }
            return teos;


        }
        public static void Starts1()
        {
            List<Teos> too = loeTeosed();
            too.Sort();
            int a = 0;
            ViiviseHoiataja vh = new ViiviseHoiataja(0.2);
            SuurimaViiviseLeidja svl = new SuurimaViiviseLeidja();
            foreach (Teos tooded in too)
            {
                tooded.arvutaViivis(vh);
                tooded.arvutaViivis(svl);
            }
            Console.WriteLine("Kõik laenuvõtjad: ");
            foreach (string nimi in vh.getHoiatatavadLaenutajad())
            {
                a++;
                Console.WriteLine(a + ") " + nimi);
            }
            svl.saadaHoiatus();
        }
        public static void Start()
        {
            while (true)
            {
                Console.WriteLine("Kas soovite märguannet näha? Y/N");
                if (Console.ReadKey().Key == ConsoleKey.Y)
                {
                    Console.Clear();
                    Starts1();
                }
                else
                {
                    break;
                }
            }
        }
    }
}
