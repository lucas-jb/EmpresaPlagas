namespace EmpresaPlagas2.Models.Trabajadores
{
    public class JefeEquipo : ITrabajador
    {
        public int IdEquipo;
        public List<Peon> peonList;
        public int numTrabajos = 0;
        
        public int DameGastoEquipo()
        {
            int gastoTotal = DameIngreso();
            foreach (Peon p in peonList)
            {
                gastoTotal = p.DameIngreso() + gastoTotal;
            }
            return gastoTotal;
        }

        public double DameIngreso()
        {
            return 40;
        }

        public string DameTipo()
        {
            return "Jefe de equipo";
        }

        public List<Peon> DamePeones()
        {
            List<Peon> peonList = new List<Peon>();
            return peonList;
        }

        public void RellenarLista()
        {
            peonList.Add(new Peon());
            peonList.Add(new Peon());
            peonList.Add(new Peon());
        }

        public void RealizarTrabajo()
        {
            this.numTrabajos++;
            foreach (Peon p in peonList)
            {
                p.numTrabajos++;
            }
        }
    }
}
