using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections; //potrzebne do uzyskania dostępu do klasy Hashtable
using System.Windows.Forms; //uzyskanie dostępu do zmiennej Keys

namespace Projekt_Snake
{
/// <summary>
/// Klasa posłuży do odczytania klawiszy na komputerze użytkownika, posłuży też do wykrywania czy dany klawisz jest wciśnięty 
/// </summary>
    class KeyInput
    {
        //odczytanie klawiszy z klawiatury użytkownika
        private static Hashtable keyboard = new Hashtable();

        //Metoda sprawdza czy dany klawisz jest wcisnięty
        public static bool isKeyPressed(Keys key)
        {
            if (keyboard[key] == null) return false;
            else return (bool) keyboard[key];
        }

        //ustala czy przycisk jest wciśnięty czy nie
        public static void StateOfKey(Keys key, bool state)
        {
            keyboard[key] = state;
        }
        
    }
}
