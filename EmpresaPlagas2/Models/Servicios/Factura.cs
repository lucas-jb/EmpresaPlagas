namespace EmpresaPlagas2.Models.Servicios
{
    public class Factura : IServicio
    {
        public double ingreso { get; set; }
        public string nombreCliente = "John Doe";
        public string telefonoCliente = "+34 000 000 000";
        public string correoCliente = "johndoe@mail.com";
        public string cpCliente = "12345";
        public double DameIngreso()
        {
            return ingreso * 1.5;
        }
    }
}
