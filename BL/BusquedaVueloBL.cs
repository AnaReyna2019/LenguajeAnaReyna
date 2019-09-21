using Reserva_de_Vuelos.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Status;

namespace Reserva_de_Vuelos.BL
{
    public class BusquedaVueloBL
    {
      

        public BindingList<BusquedaVuelo> ListaVuelo { get; set; }

        public BusquedaVueloBL()
        {
            ListaVuelo = new BindingList<BusquedaVuelo>();
            CrearDatos();
        }

        public double ObtenerPrecio(int id)
        {
            double precio = 0;
            foreach (var BusquedaVuelo in ListaVuelo )
            {
                if(BusquedaVuelo.Id == id)
                {
                    precio = BusquedaVuelo.Precio;
                }

            }

            return precio;
        }


        private void CrearDatos()
        {
            var categoria1 = new Categoria(1, "Tela");
            var categoria2 = new Categoria(2, "Tegucigalpa");
            var categoria3 = new Categoria(3, "San Pedro Sula");

            var Vuelo1 = new BusquedaVuelo(1,"Avianca", 1600, "Economica", categoria1);
            
            

            var Vuelo2 = new BusquedaVuelo(2,"Aerolíneas Sosa", 1200, "Economica", categoria2);

       

            var Vuelo3 = new BusquedaVuelo(3,"Global Air", 2300, "Primera Clase", categoria3);
           
            

            ListaVuelo.Add(Vuelo1);
            ListaVuelo.Add(Vuelo2);
            ListaVuelo.Add(Vuelo3);
        }

    }
}
