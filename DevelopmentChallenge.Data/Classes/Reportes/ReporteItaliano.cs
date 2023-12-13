namespace DevelopmentChallenge.Data.Classes.Reportes
{
    public class ReporteItaliano : ReporteBase
    {
        public override string TituloListaVaciaTexto => "<h1>Elenco vuoto di forme!</h1>";
        public override string TituloTexto => "<h1>Rapporto sui moduli</h1>";
        public override string PieTexto => "TOTALE:<br/>";

        public override string ObtenerLinea(ResumenTipo resumen)
        {
            var tipoDescripcion = resumen.Cantidad > 1 ? TiposDescripcion.Italiano[resumen.Tipo].Plural : TiposDescripcion.Italiano[resumen.Tipo].Singular;
            return $"{resumen.Cantidad} {tipoDescripcion} | La zona {resumen.Area:#.##} | Perimetro {resumen.Perimetro:#.##} <br/>";            
        }

        public override string ObtenerCantidadTotalTexto(int cantidad)
        {
            return $"{cantidad} forme ";
        }

        public override string ObtenerAreaTotalTexto(decimal area)
        {
            return $"La zona {area.ToString("#.##")}";
        }
     
        public override string ObtenerPerimetroTotalTexto(decimal perimetro)
        {
            return $"Perimetro {perimetro.ToString("#.##")} ";
        }
    }
}
