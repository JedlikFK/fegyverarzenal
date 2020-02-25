using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fegyverarzenal
{
    class Program
    {
        enum fegyverek {AK47, MAC10, M4A1S, AWP, GLOCK18, USPS, REVOLVER, MAG7};
        static void Main(string[] args)
        {
            List<fegyverek> taska = new List<fegyverek>();
            //egy fegyvert csak 1 példányban tárolhatunk
            Felpakol(taska); //összesfegyvert berakja a fegyvertárba
            istáLzó(taska); //aktuálisan milyen fegyver van nálam
            Console.WriteLine($"Atuálisan {Fegyverszám(taska)} db fegyver van nálad.");
            Kivesz(taska, fegyverek.AWP);//egy fegyvert kivesz a fegyvertárból
            Kivesz(taska, fegyverek.M4A1S);
            istáLzó(taska);
            Console.WriteLine($"Atuálisan {Fegyverszám(taska)} db fegyver van nálad.");
            Felvesz(taska, fegyverek.AWP); //egy fegyvert betesz a fegyvertárba
            istáLzó(taska);
            Console.WriteLine($"Atuálisan {Fegyverszám(taska)} db fegyver van nálad.");
            FelveszIndex(taska, 2, fegyverek.M4A1S); //egy fegyvert berak egy meghatározott helyre
            istáLzó(taska);
            Console.WriteLine($"Atuálisan {Fegyverszám(taska)} db fegyver van nálad.");
            Kiürít(taska); // kiüríti a fegyvertárat
            istáLzó(taska);
            Console.WriteLine($"Atuálisan {Fegyverszám(taska)} db fegyver van nálad.");
            int darab = Fegyverszám(taska); //hány fegyver van a tárba
            
            Console.ReadKey();
        }

        private static void Kiürít(List<fegyverek> taska)
        {
            
        }

        static void FelveszIndex(List<fegyverek> taska, int v, fegyverek m4a1)
        {
            taska.Insert(v, m4a1);
        }

        private static void Felvesz(List<fegyverek> taska, fegyverek aWP)
        {
            taska.Add(fegyverek.AWP);
        }

        static void Kivesz(List<fegyverek> taska, fegyverek aWP)
        {
            taska.Remove(fegyverek.AWP);
            taska.Remove(fegyverek.M4A1S);
        }

        static int Fegyverszám(List<fegyverek> taska)
        {
            return taska.Count();
        }

        private static void istáLzó(List<fegyverek> taska)
        {
            Console.WriteLine("-----------------------------------");
            foreach (fegyverek fegyo in taska)
            {
                Console.WriteLine(fegyo);
            }
            
        }

        static void Felpakol(List<fegyverek> taska)
        {
            taska.Add(fegyverek.AK47);
            taska.Add(fegyverek.AWP);
            taska.Add(fegyverek.M4A1S);
            taska.Add(fegyverek.MAC10);
            taska.Add(fegyverek.MAG7);
            taska.Add(fegyverek.GLOCK18);
            taska.Add(fegyverek.USPS);
            taska.Add(fegyverek.REVOLVER);
        }
    }
}
