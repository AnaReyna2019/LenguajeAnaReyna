using Reserva_de_Vuelos.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva_de_Vuelos.BL
{
    public class UsuarioBL
    {
        public BindingList<Usuario> ListadeUsuario { get; set; }

        public UsuarioBL()
        {
            ListadeUsuario = new BindingList<Usuario>();
            CargarDatosdePrueba();
        }
        private void CargarDatosdePrueba()
        {
            var usuarioAdmin = new Usuario(1, "Ana", "123");
            usuarioAdmin.PuedeverFactura = true;
            usuarioAdmin.puedeverReporte = true;
            usuarioAdmin.PuedeverSelecciondeVuelo = true;
            usuarioAdmin.puedeverReservas = true;

            var usuarioCaja = new Usuario(2, "Reyna", "456");
            usuarioCaja.PuedeverFactura = true;
            usuarioCaja.puedeverReporte = true;
            usuarioCaja.puedeverReservas = true;

            var usuarioReservas = new Usuario(3, "Carlos", "789");
            usuarioReservas.PuedeverFactura = true;
            usuarioReservas.puedeverReporte = false;
            usuarioReservas.PuedeverSelecciondeVuelo = true;
            usuarioReservas.puedeverReservas = true;

            var usuarioReporte = new Usuario(4, "Ermex", "147");
            usuarioReporte.puedeverReporte = true;
            usuarioReporte.puedeverReservas = true;


            ListadeUsuario.Add(usuarioAdmin);
            ListadeUsuario.Add(usuarioCaja);
            ListadeUsuario.Add(usuarioReservas);
            ListadeUsuario.Add(usuarioReporte);

        }
        public Usuario Autenticar(string nombre, string contrasena)
        {
            foreach(var usuario in ListadeUsuario)
            {
               if (usuario.Nombre == nombre && usuario.Contrasena == contrasena)
                {
                    return usuario;
                }
            }
            return null;
        }
    }
}
