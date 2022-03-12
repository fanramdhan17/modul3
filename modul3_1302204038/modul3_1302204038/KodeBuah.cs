using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul3_1302204038
{
    public class KodeBuah
    {
        enum State
        {
            Apel, Aprikot, Alpukat, Pisang, Paprika, Blackberry,
            Ceri, Kelapa, Jagung, Kurma, Durian, Anggur, Melon, Semangka
        };

        public void getKodeBuah()
        {
            State state = State.Apel;
            State buah = State.Apel;
            string[] screenName = {"A00", "B00", "C00", "D00", "E00","F00",
            "H00", "I00", "J00", "K00", "L00", "M00", "N00", "000"
        };
            while (state != State.Pisang)
            {
                Console.WriteLine("Ketik Nama Buah");
                Console.Write("Buah :");
                string command = Console.ReadLine();
                switch (state)
                {
                    case State.Apel:
                        if (command == "Apel")
                        {
                            buah = State.Apel;
                        }
                        else if (command == "Aprikot")
                        {
                            buah = State.Aprikot;
                        }
                        else if (command == "Alpukat")
                        {
                            buah = State.Alpukat;
                        }
                        else if (command == "Pisang")
                        {
                            buah = State.Pisang;
                        }
                        else if (command == "Paprika")
                        {
                            buah = State.Paprika;
                        }
                        else if (command == "Blackberry")
                        {
                            buah = State.Blackberry;
                        }
                        else if (command == " Ceri")
                        {
                            buah = State.Ceri;
                        }
                        else if (command == "Kelapa")
                        {
                            buah = State.Kelapa;
                        }
                        else if (command == "Jagung")
                        {
                            buah = State.Jagung;
                        }
                        else if (command == "Kurma")
                        {
                            buah = State.Kurma;
                        }
                        else if (command == "Durian")
                        {
                            buah = State.Durian;
                        }
                        else if (command == "Anggur")
                        {
                            buah = State.Anggur;
                        }
                        else if (command == "Melon")
                        {
                            buah = State.Melon;
                        }
                        else if (command == "Semangka")
                        {
                            buah = State.Semangka;
                        }
                        else
                        {
                            state = State.Apel;
                            command = "QUIT";

                        }
                        break;
                }
                if (command != "QUIT")
                    Console.WriteLine("Kode Buah" + command + " : " + screenName[(int)buah]);
            }
            Console.WriteLine("Close");
            }
    }
}
