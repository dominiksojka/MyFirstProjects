using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_PrzyszlyStanKonta
{
    class Program
    {
        static void Main(string[] args)
        {//deklaracje lokalne
            float K0, Kn, p; //K0=lokata inwestycyjna, p=pocz stopa procentowa
            int n;
            // wypisanie metryk programu
            Console.WriteLine("\n\n\t\tProgram umożliwiający obliczanie przyszłego stanu konta");
            // wczytanie danych wejściowych
            // wczytanie wysokości lokaty kapitałowej
            do
            {
                //wypisanie zaproszenia do podania lokaty kapitałowej
                Console.Write("\n\n\t\tPodaj wysokość lokaty kapitałowej (inwestycyjnej):");
                // wczytanie z kontrolą poprawności zapisu (składni)

                //INFO PĘTLA WHILE: 
                //Pętla while powtarza blok kodu tak długo, aż warunek jest prawidłowy. Składnia pętli while jest następująca. 
                //        while (warunekbool)
                //{
                //    operacje
                //}

                while (!float.TryParse(Console.ReadLine(), out K0))
                {
                    Console.WriteLine("\n\n\t\tBłąd: wystąpił niedozwolony znak w zapisie podanej wysokości lokaty kapitałowej (inwestycyjnej).");
                    Console.Write("\n\n\t\tPodaj wysokość lokaty kapitałowej (inwestycyjnej) jeszcze raz, ale poprawnie:");
                }

                if (K0 <= 0) // sprawdzenie warunku wejściowego na wartość K0
                    Console.WriteLine("\n\n\t\tBłąd: Lokata Kapitałowa musi być > 0");

            } while (K0 <= 0);
            // wczytanie rocznej stopy procentowej
            do
            {
                // wypisanie zaproszenia dla podania rocznej stopy procentowej
                Console.Write("\n\n\t\tPodaj roczną stopę procentową (np. 0,03): ");
                while (!float.TryParse(Console.ReadLine(), out p))
                {
                    Console.WriteLine("\n\n\t\tERROR: wystąpił niedozwolony znak w zapisie rocznej stopy procentowej.");
                    Console.Write("\n\n\t\tPodaj roczną stopę procentową jeszcze raz, ale poprawnie:");
                }
                // sprawdzenie warunku wejściowego na wartość p
                if (p <= 0 || p >= 1)
                    Console.WriteLine("\n\n\t\tERROR: Roczna stopa procentowa musi być w przedziale: (0,1)");
            } while (p <= 0 || p >= 1);
            // wczytanie liczby lat lokaty
            do
            {
                // wypisanie zaproszenia dla podania n
                Console.Write("\n\n\t\tPodaj liczbę lat lokaty: ");
                while (!int.TryParse(Console.ReadLine(), out n))
                {
                    Console.WriteLine("\n\n\t\tERROR: wystąpił niedozwolony znak w zapisie podanej liczby lat lokaty.");
                    Console.Write("\n\n\t\tPodaj liczbę lat lokaty jeszcze raz, ale poprawnie:");
                }
                // sprawdzenie warunku wejściowego na wartość n
                if (n <= 0)
                    Console.WriteLine("\n\n\t\tERROR: Liczba lat lokaty n musi być > 0");
            } while (n < 0);
            // obliczenie przyszłego stanu konta
            Kn = K0 * (float)Math.Pow(1 + p, n);
            Console.WriteLine("\n\n\t\tWYNIK OBLICZEŃ: przyszły stan konta Kn = {0}", Kn);
            // chwilowe zatrzymanie programu dla obejrzenia wyniku
            Console.WriteLine("\n\n\t\tDla zakończenia działania programu naciśnij dowolny klawisz");
            Console.ReadKey();
        }
    }
}