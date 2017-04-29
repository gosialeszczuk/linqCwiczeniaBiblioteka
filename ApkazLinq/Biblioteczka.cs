using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApkazLinq
{
    class Biblioteczka
    {
        string tytulKsiazki;
        int rok;
        string kategoria;
        string autorKsiazki;
        public Biblioteczka()
        {

        }
        public Biblioteczka(string tytulKsiazki1, int rok1, string kategoria1, string autorKsiazki1)
        {
            tytulKsiazki = tytulKsiazki1;
            rok = rok1;
            kategoria = kategoria1;
            autorKsiazki = autorKsiazki1;
        }
        public string Tytul
        {
            get
            {
              return tytulKsiazki;
            }
            set
            {

            tytulKsiazki = value;
            }
        }

        public string KategoriaKsiazki
        {
            set
            {
                kategoria = value;
            }
            get
            {
                return kategoria;
            }
        }
        public string Autor
        {
            set
            {
                autorKsiazki = value;
            }
            get
            {
                return autorKsiazki;
            }
        }

        public int RokWydania
        {
            set
            { if(value>1900)
                rok = value;
            }
            get
            {
                return rok;
            }
        }
    }
}
