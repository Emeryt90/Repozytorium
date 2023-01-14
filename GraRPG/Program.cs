using GraRPG.Klasy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            // tworzymy obiekt generatora (trzeba pamiętac o dodaniu dostepu do folderu Klasy - using GraRPG.Klasy;)
            GeneratorPostaci generator = new GeneratorPostaci();

            Console.WriteLine("Witaj w grze Wojownik vs Mag");

            // tworzymy gracza (wojownik) i przeciwnika (mag) (pkt 12)
            Wojownik gracz = generator.GenerujWojownika();
            Mag przeciwnik = generator.GenerujMaga();

            // pkt 13
            Console.WriteLine("Na swojej drodze spotkałeś przeciwnika.");
            przeciwnik.WyswietlStatystyki();

            // pkt 13
            Console.WriteLine("Czy chcesz zaatakować (wpisz: atak) czy uciekać (wpisz: ucieczka)?");
            string odp = Console.ReadLine();
            if (odp != "atak")
            {
                Console.WriteLine("Uciekasz...");
                Console.ReadKey();
                return;
            }

            // if się nie spelnił więc rozpoczynamy walkę (pkt 14)
            Console.WriteLine("Do ataku!!!");
            while (gracz.Hp > 0 && przeciwnik.Hp > 0)
            {
                // przeciwnik atakuje
                Console.WriteLine($"Przeciwnik {przeciwnik.Nazwa} atakuje.");
                int atakPrzeciwnika = przeciwnik.PobierzSileAtaku();
                gracz.OdejmijHp(atakPrzeciwnika);
                Console.WriteLine($"Pozostało Ci {gracz.Hp} życia. \n");

                // sprawdzamy czy po ataku czasem nie zginęliśmy
                // jeżeli tak to kończymy walkę
                if (gracz.Hp <= 0)
                {
                    break;
                }

                // zatrzymujemy na pól sekundy program dla ciekawszego efektu
                System.Threading.Thread.Sleep(500);

                // gracz atakuje
                Console.WriteLine($"Gracz {gracz.Nazwa} atakuje.");
                int atakGracza = gracz.PobierzSileAtaku();
                przeciwnik.OdejmijHp(atakGracza);
                Console.WriteLine($"Przeciwnikowi zostało {przeciwnik.Hp} życia.\n");

                // sprawdzamy czy po ataku czasem nie pokonaliśmy wroga
                // jeżeli tak to kończymy walkę
                if (przeciwnik.Hp <= 0)
                {
                    break;
                }

                // zatrzymujemy na pól sekundy program dla ciekawszego efektu
                System.Threading.Thread.Sleep(500);
            }

            // wyłonienie zwycięzcy (pkt 15)
            if (gracz.Hp <= 0)
            {
                Console.WriteLine($"Niestety zostałeś pokonany. Przeciwnik {przeciwnik.Nazwa} wygrał.");
            }
            else
            {
                Console.WriteLine($"Gratulację. Pokonałeś przeciwnika {przeciwnik.Nazwa}");
            }

            Console.ReadKey();
        }
    }
}
