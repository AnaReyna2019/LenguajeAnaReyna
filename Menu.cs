using Reserva_de_Vuelos.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reserva_de_Vuelos
{
    public partial class Menu : Form
    {
        BusquedaVueloBL _BusquedaVueloBL;
        CategoriaBL _categoriaBL;
        Datos_ClientesBL _DatosClientesBL;
        FacturaBL _FacturasBL;
        UsuarioBL _usuarioBL;
        private object SelecciondeVueloToolStripMenuItem;

        public object End { get; private set; }

        public Menu()
        {
            InitializeComponent();
            _BusquedaVueloBL = new BusquedaVueloBL();
            _categoriaBL = new CategoriaBL();
            _DatosClientesBL = new Datos_ClientesBL();
            _FacturasBL = new FacturaBL();
            _usuarioBL = new BL.UsuarioBL();


        }

        private void seleccionDeVueloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formDestino = new Form1();
            formDestino.MdiParent = this;

            formDestino.CDatos(_BusquedaVueloBL, _categoriaBL);
            formDestino.Show();

        }

        private void reservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formReserva = new Form2();
            formReserva.MdiParent = this;
            formReserva.CargarDatos(_DatosClientesBL);
            formReserva.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            var login = new Login();
            login.CargarDatos(_usuarioBL);

            login.ShowDialog();

            seleccionDeVueloToolStripMenuItem.Visible = login.UsuarioAutenticado.PuedeverSelecciondeVuelo;
            facturaToolStripMenuItem.Visible = login.UsuarioAutenticado.PuedeverFactura;
            reporteToolStripMenuItem.Visible = login.UsuarioAutenticado.puedeverReporte;
            reservasToolStripMenuItem.Visible = login.UsuarioAutenticado.puedeverReservas;


        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formFactura = new Form3();
            formFactura.MdiParent = this;
            formFactura.CargarDatos(_FacturasBL, _DatosClientesBL, _BusquedaVueloBL);
            formFactura.Show();

        }
    }
}
