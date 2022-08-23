namespace EmpresaPlagas2.Models.Trabajadores
{
    public class Peon : ITrabajador
    {
        public int IdPeon { get; set; }
        public int numTrabajos = 0;
        public double DameIngreso()
        {
            return numTrabajos * 20;
        }

        public string DameTipo()
        {
            return "Peón";
        }
    }
}
