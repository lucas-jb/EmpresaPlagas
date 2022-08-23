namespace EmpresaPlagas2.Models.Recursos
{
    public class Veneno : IRecurso
    {
        public int idVeneno { get; set; }
        public string nombre = string.Empty;
        public double coste { get; set; }
        public List<Medida> listaMedidas;
        public double DameCoste()
        {
            return coste;
        }

        public string DameTipo()
        {
            return nombre;
        }
    }
}
