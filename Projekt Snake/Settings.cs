using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Snake
{
    public enum Direction
    {
        up,
        down,
        left,
        right
    };


    class Settings
    {
        //ustawienia pola gry, predkosc, polozenie , zakonczenie gry, punktacja
        public static int width;
        public static int height;
        public static int score;
        public static int speed;
        public static bool gameOver;
        public static Direction snakeDirection;
        

        public Settings()
        {
            //ustawienia domyślne wartości do zmienienia kiedy będzie można sprawdzić je na polu gry
            width = 16;
            height = 16;
            score = 0;
            speed = 50;
            gameOver = false;
            snakeDirection = Direction.right;

        }

    }
}
