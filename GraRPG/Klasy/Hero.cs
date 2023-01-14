using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraRPG.Klasy
{
    // abstract - oznaczenie klasy jako abstrakcyjna, dzięki czemu zostaje zablokowana możliwość tworzenia jej obiektów (pkt 4)
    public abstract class Hero
    {
        // stworzenie 3 pól opisujących własności każdego bohatera (pkt 4)
        public int Hp;
        public string Nazwa;
        public int Atak;

        // konstruktor przyjmujący wartości dla stworzonych własności (pkt 5)
        public Hero(int hp, string nazwa, int atak)
        {
            Hp = hp;
            Nazwa = nazwa;
            Atak = atak;
        }

        // metoda wyświetlająca w konsoli informacje o postaci (pkt 6)
        public void WyswietlStatystyki()
        {
            Console.WriteLine($"Postać {Nazwa} posiada {Hp} życia i {Atak} ataku.");
        }
    }
}
