using EmpresaPlagas2.Models.Recursos;
using EmpresaPlagas2.Models.Servicios;
using EmpresaPlagas2.Models.Trabajadores;

namespace EmpresaPlagas2.Models
{
    public class Empresa
    {
        public List<ITrabajador> listaTrabajadores;
        public List<IRecurso> listaRecursos;
        public List<IServicio> listaServicios;

        public double DameGastoEmpresa()
        {
            return DameGastoEmpresa() + DameGastoTrabajadores();
        }
        public double DameGastoTrabajadores()
        {
            double gastoTotal = 0;
            foreach (ITrabajador trabajador in listaTrabajadores)
            {
                gastoTotal = trabajador.DameIngreso() + gastoTotal;
            }
            return gastoTotal;
        }
        public double DameGastoRecursos()
        {
            double gastoTotal = 0;
            foreach (IRecurso recurso in listaRecursos)
            {
                gastoTotal = recurso.DameCoste() + gastoTotal;
            }
            return gastoTotal;
        }

        public double DameIngresoEmpresa()
        {
            double ingresoTotal = 0;
            foreach (IServicio servicio in listaServicios)
            {
                ingresoTotal = servicio.DameIngreso() + ingresoTotal;
            }
            return ingresoTotal;
        }
        
        public double Beneficio()
        {
            return Beneficio() - DameGastoEmpresa();
        }
    }
}
