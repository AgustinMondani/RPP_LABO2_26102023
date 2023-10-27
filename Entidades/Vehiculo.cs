using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Vehiculo
    {
        protected bool esAWD;
        protected Guid numeroDeChasis;
        protected EPropulsion propulsion;

        public EPropulsion Propulsion { get { return propulsion; } }

        protected abstract string Tipo{ get; }

        protected Vehiculo(EPropulsion propulsion, bool esAWD) 
        {
            this.propulsion = propulsion;
            this.esAWD = esAWD;
        }
            
        protected Vehiculo(EPropulsion propulsion) 
            :this(propulsion, false) { }

        protected virtual string GetInfo()
        {
            return string.Format("{0} con propulsión a {1}, {2} es AWD, numero de chasis{3}",this.Tipo, this.propulsion, this.esAWD, this.numeroDeChasis);
        }

        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return v1.Tipo == v2.Tipo && v1.numeroDeChasis == v2.numeroDeChasis;
        }
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }

        public override string ToString()
        {
            return this.GetInfo();
        }

        public string DatosVehivulo() { return this.GetInfo(); }
    }
}
