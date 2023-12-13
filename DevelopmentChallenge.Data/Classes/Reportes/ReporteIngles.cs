namespace DevelopmentChallenge.Data.Classes.Reportes
{
    public class ReporteIngles : ReporteBase
    {
        public override string TituloListaVaciaTexto => "<h1>Empty list of shapes!</h1>";
        public override string TituloTexto => "<h1>Shapes report</h1>";
        public override string PieTexto => "TOTAL:<br/>";

        public override string ObtenerLinea(ResumenTipo resumen)
        {
            var tipoDescripcion = resumen.Cantidad > 1 ? TiposDescripcion.Ingles[resumen.Tipo].Plural : TiposDescripcion.Ingles[resumen.Tipo].Singular;
            return $"{resumen.Cantidad} {tipoDescripcion} | Area {resumen.Area:#.##} | Perimeter {resumen.Perimetro:#.##} <br/>";            
        }

        public override string ObtenerCantidadTotalTexto(int cantidad)
        {
            return $"{cantidad} shapes ";
        }

        public override string ObtenerAreaTotalTexto(decimal area)
        {
            return $"Area {area.ToString("#.##")}";
        }
     
        public override string ObtenerPerimetroTotalTexto(decimal perimetro)
        {
            return $"Perimeter {perimetro.ToString("#.##")} ";
        }
    }
}
