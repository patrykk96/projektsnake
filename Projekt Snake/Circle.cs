using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Snake
{
    class Circle
    {
        /// <summary>
        /// Wąż, którym będzie sterował gracz i pożywienie będą okręgami.
        /// </summary>
        public int x;
        public int y;

        public Circle()
        {
            x = 0;
            y = 0;
        }

        public Circle(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
