using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Camioneta : Vehiculo
    {
        private bool cabinaSimple;
        public Camioneta(EPropulsion propulsion, bool cabinaSimple) : base(propulsion, true)
        {
            this.cabinaSimple = cabinaSimple;
        }

        protected override string Tipo
        {
            get { return "Camioneta"; }
        }

        protected override string GetInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.GetInfo());
            sb.Append($"con cabina simple: {this.cabinaSimple} o doble: {!this.cabinaSimple}");
            return sb.ToString();
        }
    }
}
