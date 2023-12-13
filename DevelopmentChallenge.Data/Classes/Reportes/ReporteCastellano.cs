
namespace DevelopmentChallenge.Data.Classes.Reportes
{
    public class ReporteCastellano : ReporteBase
    {
        public override string TituloListaVaciaTexto => "<h1>Lista vacía de formas!</h1>";
        public override string TituloTexto => "<h1>Reporte de Formas</h1>";
        public override string PieTexto => "TOTAL:<br/>";

        public override string ObtenerLinea(ResumenTipo resumen)
        {
            var tipoDescripcion = resumen.Cantidad > 1 ? TiposDescripcion.Castellano[resumen.Tipo].Plural : TiposDescripcion.Castellano[resumen.Tipo].Singular;
            return $"{resumen.Cantidad} {tipoDescripcion} | Area {resumen.Area:#.##} | Perimetro {resumen.Perimetro:#.##} <br/>";            
        }

        public override string ObtenerCantidadTotalTexto(int cantidad)
        {
            return $"{cantidad} formas ";
        }

        public override string ObtenerAreaTotalTexto(decimal area)
        {
            return $"Area {area.ToString("#.##")}";
        }
     
        public override string ObtenerPerimetroTotalTexto(decimal perimetro)
        {
            return $"Perimetro {perimetro.ToString("#.##")} ";
        }
    }
}
