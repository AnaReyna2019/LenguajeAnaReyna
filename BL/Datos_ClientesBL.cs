using Reserva_de_Vuelos.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva_de_Vuelos.BL
{
   public class Datos_ClientesBL
    {
            public BindingList<Datos_Clientes> ListaClientes { get; set; }

            public Datos_ClientesBL()
            {

                ListaClientes = new BindingList<Datos_Clientes>();
                CrearDatos();
            }

      
        private void CrearDatos()
            {
                var cliente1 = new Datos_Clientes(180416036, "Ana", "Moreno", 21, "moreno@gmail", "Hondureña", 1);
                var cliente2 = new Datos_Clientes(170418200, "Carlos", "Cardona", 22, "cardona@yahoo", "Hondureño", 2);
                var cliente3 = new Datos_Clientes(180445525, "Ermes", "Hernandez", 23, "ermex@yahoo", "Hondureño", 2);
                var cliente4 = new Datos_Clientes(108594484, "Reyna", "Ramirez", 21, "reynao@gmail", "Hondureña", 1);
                var cliente5 = new Datos_Clientes(741369245, "Angela", "Posas", 22, "angela@yahoo", "Hondureño", 3);
                var cliente6 = new Datos_Clientes(104659548, "Sandy", "Discua", 23, "sandy@yahoo", "Hondureño", 2);

       

                ListaClientes.Add(cliente1);
                ListaClientes.Add(cliente2);
                ListaClientes.Add(cliente3);
                ListaClientes.Add(cliente4);
                ListaClientes.Add(cliente5);
                ListaClientes.Add(cliente6);
            }
        }
}
