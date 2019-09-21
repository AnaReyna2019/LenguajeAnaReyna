using Reserva_de_Vuelos.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva_de_Vuelos.Modelos
{
   public  class Factura
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int ClienteId { get; set; }
        public Datos_Clientes Datos_Clientes { get; set; }
        public double Subtotal { get; set; }
        public double Impuesto { get; set; }
        public double Total { get; set; }

        public bool  Activo { get; set; }

        public BindingList<FacturaDetalle> FacturaDetalle  { get; set; }

        public Factura()
        {
            Fecha = DateTime.Now;
            Activo = true;
            FacturaDetalle = new BindingList<FacturaDetalle>();
        
        }
        public void CalcularTotalFactura(Factura factura)
        {
            var BusquedadeVueloBL  = new BusquedaVueloBL();

            double Subtotal = 0;
            foreach (var detalle in factura.FacturaDetalle)
            {
                var precio = BusquedadeVueloBL.ObtenerPrecio(detalle.BusquedaVueloId);
                Subtotal = Subtotal + detalle.CalcularTotalDetalle(precio);

                Subtotal += detalle.Total; 
            }
            factura.Subtotal = Subtotal;
            factura.Impuesto = Subtotal * 0.15;
           factura.Total = Subtotal + Impuesto;
        }

    }
    public class FacturaDetalle
    {
        public int Id { get; set; }
        public BusquedaVuelo  BusquedadeVuelo { get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }
        public double Total { get; set; }
        public int BusquedaVueloId { get;  set; }


        public FacturaDetalle()
        {
            Cantidad = 1;
            BusquedaVueloId = 1;
        }
        public double CalcularTotalDetalle(double precio)
        {
            Precio = precio;
            Total = Cantidad * Precio;
            return Total;
        }

        }
    }

    

