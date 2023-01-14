using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraRPG.Klasy
{
    // klasa Mag dzieczy po klasie Hero (pkt 8)
    public class Mag : Hero
    {
        // dodatkowa własność atak (pkt 8)
        private int Moc;

        // dodanie konstruktora i odziedziczenie własności z konstruktora bazowego (pkt 8)
        public Mag(int hp, string nazwa, int atak, int moc) : base(hp, nazwa, atak)
        {
            Moc = moc;
        }

        // pkt 9
        public void OdejmijHp(int zycieDoOdjecia)
        {
            // zmniejszenie życia maga o przesłaną wartość
            Hp -= zycieDoOdjecia;
        }

        // metoda zwraca typ int ponieważ musi zwrócić siłę postaci (pkt 10)
        public int PobierzSileAtaku()
        {
            // Atak postaci zwiększony o 1/5 Mocy
            return Atak + (Moc / 5);
        }
    }
}
