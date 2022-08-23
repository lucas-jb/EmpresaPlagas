namespace EmpresaPlagas2.Models.Trabajadores
{
    public class Gerente : ITrabajador
    {
        public int IdGerente { get; set; }
        public double DameIngreso()
        {
            return 50;
        }

        public string DameTipo()
        {
            return "Gerente";
        }
    }
}
