namespace EmpresaPlagas2.Models.Trabajadores
{
    public class Operario : ITrabajador
    {
        public int IdOperario { get; set; }
        public int numTrabajos = 0;
        public double DameIngreso()
        {
            return 35;
        }

        public string DameTipo()
        {
            return "Operario";
        }
        public void RealizarTrabajo()
        {
            this.numTrabajos++;
        }
    }
}
