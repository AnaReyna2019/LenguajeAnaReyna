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
    public partial class FromReportedeReservas : Form
    {
        public FromReportedeReservas()
        {
            InitializeComponent();
        }
        public void CargarDatos(FacturaBL facturaBL, Datos_ClientesBL datos_ClientesBL) 

        {
            var bindingSource = new BindingSource();
            bindingSource.DataSource =
                from f in facturaBL.ListadeFacturas
                select new
                {
                    Id = f.Id,
                    Fecha = f.Fecha,
                    ClienteId = f.ClienteId,
                    Datos_Cliente = datos_ClientesBL
                                    .ListaClientes
                                    .FirstOrDefault(r => r.Id == f.ClienteId)
                                    .Nombre,
                    Subtotal = f.Subtotal,
                    Impuesto = f.Impuesto,
                    Total = f.Total,
               
                };

            var reporte = new ReporteFactura();
            reporte.SetDataSource(bindingSource);

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();
        }
    }

}
    

