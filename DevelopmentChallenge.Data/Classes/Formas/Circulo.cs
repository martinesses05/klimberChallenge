
using System;

namespace DevelopmentChallenge.Data.Classes.Formas
{
    public class Circulo : IFormaGeometrica
    {
        private decimal _lado;

        public Circulo(decimal lado)
        {
            _lado = lado;
        }

        public decimal Area => (decimal)Math.PI * (_lado / 2) * (_lado / 2);
        public decimal Perimetro => (decimal)Math.PI * _lado;     
    }
}
