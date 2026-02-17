using datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class CNHabitaciones
    {
        CDHabitaciones _habitaciones = new CDHabitaciones();
        public DataTable ObtenerhabitacionesN()
        {
            return _habitaciones.ObtenerHabitaciones();
        }

        public bool agregar_habitaciones(int numero, string descripcion, int cant)
        {
            return _habitaciones.AgregarHabitacion(numero, descripcion, cant);
        }
        public bool Modificar_habitaciones(int id, int numero, string description, int cant)
        {
            return _habitaciones.ModificarHabitacion(id, numero, description, cant);
        }
        public bool Eliminar_habitaciones(int id)
        {
            return _habitaciones.EliminarHabitacion(id);
        }
    }
}
