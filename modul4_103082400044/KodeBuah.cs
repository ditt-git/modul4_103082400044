// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_103082400044
{
    enum Buah
    {
        Apel,
        Aprikot,
        Alpukat,
        Pisang,
        Paprika,
        Blackberry,
        Ceri,
        Kelapa,
        Jagung
    }

    class KodeBuah
    {
        private string[] kodeBuah =
        {
            "A00",
            "B00",
            "C00",
            "D00",
            "E00",
            "F00",
            "H00",
            "I00",
            "J00"
        };

        public string getKodeBuah(Buah buah)
        {
            return kodeBuah[(int)buah];
        }
    }

    class Program
    {
        static void Main()
        {
            KodeBuah kb = new KodeBuah();

            string kode = kb.getKodeBuah(Buah.Ceri);

            Console.WriteLine("Kode Buah Ceri : " + kode);
        }
    }
}
