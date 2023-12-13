
using System;

namespace DevelopmentChallenge.Data.Classes.Formas
{
    public class TrianguloEquilatero : IFormaGeometrica
    {
        private decimal _lado;

        public TrianguloEquilatero(decimal lado)
        {
            _lado = lado;
        }

        public decimal Area => ((decimal)Math.Sqrt(3) / 4) * _lado * _lado;
        public decimal Perimetro => _lado * 3;     
    }
}
