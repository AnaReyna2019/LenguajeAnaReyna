using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva_de_Vuelos.Modelos
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nombre{ get; set; }
        public string avion { get; set; }
        public string Nombre1 { get; set; }
        public Categoria()
        {

        }

        public Categoria(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }

       

       
    }
}
