using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraRPG.Klasy
{
    // klasa Wojownik dzieczy po klasie Hero (pkt 7)
    public class Wojownik : Hero
    {
        // dodatkowa własność obrona (pkt 7)
        private int Obrona;

        // dodanie konstruktora i odziedziczenie własności z konstruktora bazowego (pkt 7)
        public Wojownik(int hp, string nazwa, int atak, int obrona) : base(hp, nazwa, atak)
        {
            Obrona = obrona;
        }

        // metoda nic nie zwraca ponieważ ma tylko obniżyć życie postaci (pkt 9)
        public void OdejmijHp(int zycieDoOdjecia)
        {
            // zmniejszenie życia wojownika o przesłaną wartość pomniejszoną o wartość obrony/3
            Hp -= zycieDoOdjecia - (Obrona/3);
        }

        // metoda zwraca typ int ponieważ musi zwrócić siłę postaci (pkt 10)
        public int PobierzSileAtaku()
        {
            return Atak;
        }
    }
}
