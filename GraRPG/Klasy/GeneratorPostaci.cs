using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraRPG.Klasy
{
    // klasa która postaci do tworzenia postaci
    public class GeneratorPostaci
    {
        private Random _random;
        // deklarujemy nową listę (pkt 15)
        private List<string> _imiona;

        public GeneratorPostaci()
        {
            // tworzymy nowy obiekt klasy Random
            _random = new Random();

            // tworzymy nową listę oraz dodajemy kilka elementów do niej (pkt 17)
            _imiona = new List<string>();
            _imiona.Add("Vladimir");
            _imiona.Add("Nieznajomy");
            _imiona.Add("Max");
            _imiona.Add("Veigar");
            _imiona.Add("Gerard");
        }

        // pkt 11
        public Mag GenerujMaga()
        {
            // losujemy wartość hp
            int hp = _random.Next(150, 300);
            // losujemy wartość ataku
            int atak = _random.Next(5, 15);
            string imie = _imiona[_random.Next(0, _imiona.Count)];

            // usuwamy imię z listy by Wojownik nie mógł posiadać takiego imienia 
            _imiona.Remove(imie);

            //tworzymy maga
            Mag mag = new Mag(hp, imie, atak, 10);

            // zwracamy stworzony obiekt maga
            return mag;
        }

        // pkt 11
        public Wojownik GenerujWojownika()
        {
            int hp = _random.Next(150, 300);
            int atak = _random.Next(5, 15);
            string imie = _imiona[_random.Next(0, _imiona.Count)];

            // usuwamy imię z listy by Wojownik nie mógł posiadać takiego imienia
            _imiona.Remove(imie);

            //tworzymy wojownika
            Wojownik wojownik = new Wojownik(hp, imie, atak, 5);

            // zwracamy stworzony obiekt wojownika
            return wojownik;
        }

    }
}
