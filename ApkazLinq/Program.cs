using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApkazLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //tworzenie listy ksiazek w mojej bibliotece
            List<Biblioteczka> MojaBiblioteczka = new List<Biblioteczka>()
            {
                new Biblioteczka("Mężczyźni którzy nienawidzą kobiet",2004,"kryminał","Stieg Larsson"),
                new Biblioteczka("Sześć lat później",2016,"kryminał","Harlan Coben"),
                new Biblioteczka("Klinika śmierci",2015,"kryminał","Harlan Coben"),
                new Biblioteczka("Futu.re",2017,"fantastyka","Dmitry Glukhovsky"),
                new Biblioteczka("Dawca",2015,"sc-fi","Lois Lowry")
            };
            Console.WriteLine("Witaj w wspaniałej aplikacji, jaka pokazuję Ci moją biblioteczkę: ");
            foreach(var ks in MojaBiblioteczka)
            {
                // Console.WriteLine(ks + " ");
          Console.WriteLine("Tytul ksiazki: {0}, Autor: {1}, Rok wydania: {2}, Gatunek: {3}",ks.Tytul,ks.Autor,ks.RokWydania,ks.KategoriaKsiazki);

            }
            
            Console.ReadKey();

            Console.WriteLine("Zabawa z linq");

            var szukajKsiazki1 = MojaBiblioteczka.Select(n => n).Where(n => n.KategoriaKsiazki == "sc-fi").ToList();

            foreach(var ks1 in szukajKsiazki1)
            {
                Console.WriteLine("Szukana ksiega to: "+ ks1.Tytul);
            }
            Console.ReadKey();

        }
    }
}
