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
    }
}
