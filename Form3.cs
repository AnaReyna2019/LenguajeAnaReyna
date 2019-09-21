using Reserva_de_Vuelos.BL;
using Reserva_de_Vuelos.Modelos;
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
    public partial class Form3 : Form
    {
        FacturaBL _facturaBL;

        public Form3()
        {
            InitializeComponent();
        }
        public void  CargarDatos(FacturaBL facturasBL, Datos_ClientesBL datos_clientes, BusquedaVueloBL BusquedaVueloBL)
        {
            _facturaBL = facturasBL;
            listadeFacturasBindingSource.DataSource = facturasBL.ListadeFacturas;
            listaClientesBindingSource.DataSource = datos_clientes.ListaClientes;
            listaVueloBindingSource.DataSource = BusquedaVueloBL.ListaVuelo;

        }

        private void facturaDetalleDataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
        }

        private void facturaDetalleDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            var Factura = (Factura)listadeFacturasBindingSource.Current;
            Factura.CalcularTotalFactura(Factura);

            listadeFacturasBindingSource.ResetBindings(false);
        }

        private void facturaDetalleDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
