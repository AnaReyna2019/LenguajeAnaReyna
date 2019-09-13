using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva_de_Vuelos.Modelos
{
    public class Datos_Clientes
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public string Email { get; set; }
        public string Nacionalidad { get; set; }
        public int Numero_Boletos { get; set; }

         public Datos_Clientes(int id, string nombre, string apellido, int edad, string email, string nacionalidad, int numero_boletos)
        { 
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            Email = email;
            Nacionalidad = nacionalidad;
            Numero_Boletos = numero_boletos;
        }
    }
}
