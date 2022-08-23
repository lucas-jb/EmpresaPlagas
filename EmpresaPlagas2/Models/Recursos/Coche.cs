namespace EmpresaPlagas2.Models.Recursos
{
    public class Coche : IRecurso
    {
        public int idCoche { get; set; }
        public double DameCoste()
        {
            return 150;
        }

        public string DameTipo()
        {
            return "Coche";
        }
    }
}
