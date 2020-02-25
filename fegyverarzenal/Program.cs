using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fegyverarzenal
{
    class Program
    {
        enum fegyverek {AK47, MAC10, M4A1S, AWP, GLOCK18, USPS};
        static void Main(string[] args)
        {
            fegyverek kezemben = fegyverek.AK47;
            List<fegyverek> taska = new List<fegyverek>();
            taska.Add(fegyverek.M4A1S);
            taska.Add(fegyverek.USPS);
            Console.WriteLine("A fegyverek a táskában:");
            foreach (fegyverek fegyo in taska)
            {
                Console.WriteLine(fegyo);
            }
            Console.ReadKey();
        }
    }
}
