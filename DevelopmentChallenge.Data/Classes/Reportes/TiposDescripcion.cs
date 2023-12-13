
using System.Collections.Generic;

namespace DevelopmentChallenge.Data.Classes.Reportes
{
    public class TipoDescripcion
    {
        public string Singular { get; set; }
        public string Plural { get; set; }
    }

    public static class TiposDescripcion
    {
        public static Dictionary<string, TipoDescripcion> Castellano = new Dictionary<string, TipoDescripcion>()
        {
            { "Cuadrado", new TipoDescripcion { Singular = "Cuadrado", Plural = "Cuadrados" }},
            { "Circulo", new TipoDescripcion { Singular = "Círculo", Plural = "Círculos" }},
            { "TrianguloEquilatero", new TipoDescripcion { Singular = "Triángulo", Plural = "Triángulos" }},
        };

        public static Dictionary<string, TipoDescripcion> Ingles = new Dictionary<string, TipoDescripcion>()
        {
            { "Cuadrado", new TipoDescripcion { Singular = "Square", Plural = "Squares" }},
            { "Circulo", new TipoDescripcion { Singular = "Circle", Plural = "Circles" }},
            { "TrianguloEquilatero", new TipoDescripcion { Singular = "Triangle", Plural = "Triangles" }},
        };
    }
}
