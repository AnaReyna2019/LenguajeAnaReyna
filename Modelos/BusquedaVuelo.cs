using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva_de_Vuelos.Modelos
{
    public class BusquedaVuelo
    {
        public string Aerolinea { get; set; }
        public double Precio { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
        public string Clase { get; set; }
        public int Id { get; set; }

        public BusquedaVuelo()
        {
            Categoria = new Categoria();
        }

        public BusquedaVuelo(int id,string aerolinea, double precio, string clase, Categoria categoria)
        {
            Id = id;
            Aerolinea = aerolinea;
            Precio = precio;
            Clase = clase;
            Categoria = categoria;
            CategoriaId = Categoria.Id; 
        }

        public static implicit operator BusquedaVuelo(int v)
        {
            throw new NotImplementedException();
        }
    }
}
