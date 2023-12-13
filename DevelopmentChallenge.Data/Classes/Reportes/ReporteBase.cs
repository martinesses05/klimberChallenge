
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevelopmentChallenge.Data.Classes.Reportes
{
    public abstract class ReporteBase
    {
        public string Imprimir(IList<IFormaGeometrica> formas) 
        {
            var sb = new StringBuilder();

            if (!formas.Any())
            {
                sb.Append(TituloListaVaciaTexto);
            }
            else
            {
                sb.Append(TituloTexto);

                var resumenTipos = formas.GroupBy(e => e.GetType().Name).Select(g => new ResumenTipo
                {
                    Tipo = g.Key,
                    Area = g.Sum(f => f.Area),
                    Cantidad = g.Count(),
                    Perimetro = g.Sum(f => f.Perimetro)
                });

                foreach (var resumen in resumenTipos)
                {
                    sb.Append(ObtenerLinea(resumen));
                }

                sb.Append(PieTexto);

                var cantidadTotal = resumenTipos.Sum(e => e.Cantidad);
                var areaTotal = resumenTipos.Sum(e => e.Area);
                var permimetroTotal = resumenTipos.Sum(e => e.Perimetro);

                sb.Append(ObtenerCantidadTotalTexto(cantidadTotal));
                sb.Append(ObtenerPerimetroTotalTexto(permimetroTotal));
                sb.Append(ObtenerAreaTotalTexto(areaTotal));
            }


            return sb.ToString();
        }

        public abstract string TituloListaVaciaTexto { get; }
        public abstract string TituloTexto { get; }
        public abstract string PieTexto { get; }
        public abstract string ObtenerLinea(ResumenTipo resumen);
        public abstract string ObtenerCantidadTotalTexto(int cantidad);
        public abstract string ObtenerAreaTotalTexto(decimal area);
        public abstract string ObtenerPerimetroTotalTexto(decimal perimetro);        
    }
}
