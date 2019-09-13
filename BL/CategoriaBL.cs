using Reserva_de_Vuelos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva_de_Vuelos.BL
{
    public class CategoriaBL
    {
        public List<Categoria> ListaCategoria { get; set; }
   

        public CategoriaBL()
        {
            ListaCategoria = new List<Categoria>();
            CrearDatos();
        }

        private void CrearDatos()
        {
            var categoria1 = new Categoria(1, "Tela");
            var categoria2 = new Categoria(2, "Tegucigalpa");
            var categoria3 = new Categoria(3, "San Pedro Sula");

            ListaCategoria.Add(categoria1);
            ListaCategoria.Add(categoria2);
            ListaCategoria.Add(categoria3);

        }
    }
}
