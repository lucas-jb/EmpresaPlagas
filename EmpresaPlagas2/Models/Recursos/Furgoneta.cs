namespace EmpresaPlagas2.Models.Recursos
{
    public class Furgoneta : IRecurso
    {
        public int idFugoneta { get; set; }
        public double DameCoste()
        {
            return 200;
        }

        public string DameTipo()
        {
            return "Furgoneta";
        }
    }
}
