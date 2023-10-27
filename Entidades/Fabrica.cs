using System.Runtime.CompilerServices;

namespace Entidades
{
    public class Fabrica
    {
        private int capacidad;
        private List<Vehiculo> vehiculos;

        public List<Vehiculo> Vehiculos
        {
            get
            {
                return this.vehiculos;
            }
        }

        private Fabrica()
        {
            this.vehiculos = new List<Vehiculo>();
        }
        public Fabrica(int capacidad) : this()
        {
            this.capacidad = capacidad;
        }

        /// <summary>
        /// Se utiliza para agregar un vehiculo a la fabrica
        /// </summary>
        /// <param name="fabrica"></param>
        /// <param name="vehiculo"></param>
        /// <returns> retorna una fabrica con su vehiculo añadido</returns>
        public static Fabrica operator +(Fabrica fabrica, Vehiculo vehiculo)
        {
            if (fabrica.capacidad < fabrica.vehiculos.Count)
            {
                fabrica.vehiculos.Add(vehiculo);
            }
            return fabrica;
        }
        public static Fabrica operator -(Fabrica fabrica, Vehiculo vehiculo)
        {

            Vehiculo Eliminar = fabrica.vehiculos.Find(v => v.DatosVehivulo() == vehiculo.DatosVehivulo());
            if (Eliminar is not null)
            {
                fabrica.vehiculos.Remove(Eliminar);
            }

            return fabrica;
        }
    }
}