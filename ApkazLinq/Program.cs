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
            /*
            notacja bez kropeczki

            */
            var szukajKSiegi =
                from ksi in MojaBiblioteczka
                where ksi.Autor == "Lois Lowry"
                select ksi.Autor;
        foreach(var ks2 in szukajKSiegi)
            {
                Console.WriteLine("Szukany autor to: " + ks2);
            }
            Console.ReadKey();

            //posortujemy tytuły książek

            var sortowankoKsiazek = MojaBiblioteczka.Select(n => n.Autor).ToArray().OrderBy(b => b);

            foreach(var ks3 in sortowankoKsiazek)
            {
                Console.WriteLine("posortowane: " + ks3);
            }

            var sortowankoKsiazekpo2015 = MojaBiblioteczka.Select(n => n).Where(n => n.RokWydania >= 2015).ToList();

            var sortowanieKsiagW = MojaBiblioteczka.Select(n => n).Where(n => n.RokWydania < 2006).ToList();

            Console.WriteLine("Ksiazki napisane w 2015 i po ..: ");
            foreach (var ks4 in sortowankoKsiazekpo2015)
            {
                Console.WriteLine(ks4.RokWydania +" "+ ks4.Tytul);
            }

            foreach (var ks5 in sortowanieKsiagW)
            {
                Console.WriteLine("Szukana ksiazka to: " + ks5.Tytul + " napisana w :" + ks5.RokWydania);
            }
            Console.ReadKey();

        }


    }
}
