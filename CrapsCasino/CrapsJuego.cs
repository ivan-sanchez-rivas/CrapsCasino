using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrapsCasino
{
    class CrapsJuego
    {
        public static Random NumerosAleatorios = new Random();
        public enum Estado { CONTINUAR, GANAR, PERDIO }
        public enum NombreDados
        {
            SNAKE_EYES = 2,
            TREY = 3,
            SEVEN = 7,
            YO_LEVEN = 11,
            BOX_CARS = 12
        }
    }
}
