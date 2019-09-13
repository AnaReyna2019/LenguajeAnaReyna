using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva_de_Vuelos.Modelos
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Contrasena { get; set; }

        public bool PuedeverSelecciondeVuelo { get; set; }
        public bool PuedeverFactura { get; set;  }
        public bool puedeverReservas { get; set; }
        public bool puedeverReporte { get; set; }

        public Usuario(int id, string nombre, string contrasena)
        {
            Id = id;
            Nombre = nombre;
            Contrasena = contrasena;
        }
    }
}
