using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_103082400044
{
    internal class PosisiKarakterGame
    {
        enum Posisi
        {
            Berdiri,
            Jongkok,
            Terbang,
            Tengkurap
        }
        class Karakter
        {
            public Posisi state;

            public Karakter()
            {
                state = Posisi.Berdiri;
                Console.WriteLine("Posisi Sekarang : Posisi Standby");
            }

            public void InputTombol(char input)
            {
                switch (state)
                {
                    case Posisi.Berdiri:
                        if (input == 'W')
                        {
                            state = Posisi.Terbang;
                            Console.WriteLine("Input W : Posisi terbang");
                        }
                        else if (input == 'S')
                        {
                            state = Posisi.Jongkok;
                            Console.WriteLine("Input S : Posisi jongkok");
                        }
                        break;

                    case Posisi.Terbang:
                        if (input == 'S')
                        {
                            state = Posisi.Berdiri;
                            Console.WriteLine("Input S : Posisi Standby");
                        }
                        else if (input == 'X')
                        {
                            state = Posisi.Jongkok;
                            Console.WriteLine("Input S : Posisi Jongkok");
                        }
                        break;

                    case Posisi.Jongkok:
                        if (input == 'W')
                        {
                            state = Posisi.Berdiri;
                            Console.WriteLine("Input W : Posisi Standby");
                        }
                        else if (input == 'S')
                        {
                            state = Posisi.Tengkurap;
                            Console.WriteLine("Input S : Posisi istirahat");
                        }
                        break;
                }
            }
        }
        class Program
        {
            static void Main()
            {
                //////////
                Console.WriteLine("NIM % 3 == 1");
                Console.WriteLine();
                //////////

                Karakter p = new Karakter();

                
                p.InputTombol('W');
                p.InputTombol('S');
                p.InputTombol('S');
                p.InputTombol('S');

            }
        }
    }
}
