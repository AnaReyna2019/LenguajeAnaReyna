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
    public partial class FormReporteVuelo : Form
    {
        public FormReporteVuelo()
        {
            InitializeComponent();
        }
        public void CargarDatos(BusquedaVueloBL busquedaVueloBL)
        {
            var bindingSource = new BindingSource();
            bindingSource.DataSource =
                from p in busquedaVueloBL.ListaVuelo
                select new
                {
                    Id = p.Id,
                    Precio = p.Precio,
                    Categoria = p.Categoria,
                    Aerolinea = p.Aerolinea,
                    Clase = p.Clase,
                };

            var reporte = new ReporteVuelo();
            reporte.SetDataSource(bindingSource);

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
