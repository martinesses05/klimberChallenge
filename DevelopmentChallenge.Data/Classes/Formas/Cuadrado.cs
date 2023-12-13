
namespace DevelopmentChallenge.Data.Classes.Formas
{
    public class Cuadrado : IFormaGeometrica
    {
        private decimal _lado;

        public Cuadrado(decimal lado) 
        {
            _lado = lado;
        }
        
        public decimal Area => _lado * _lado;
        public decimal Perimetro => _lado * 4;     
    }
}
