using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParcialUnoVerdadero.Entidades;

namespace ParcialUnoVerdadero.Negocio
{
    class NClsVenta
    {
        ClsVentas clsVentas = new ClsVentas();
       public string cobro(ClsVentas ventas)
        {
            
            
            ventas.Total = ventas.PrecioProducto * ventas.CantidadProducto;
            if (ventas.Total > 50)
            {
                double descuento;
                descuento = ventas.Total * 0.40;
                //en esta parte le puse un descuento del 40% por la compra de mas de $50.00 dolares
                return "El total es de $" + ventas.Total + " y el descuento es de $" + descuento;

            }
            else
            {
                return "El total es de $ " + ventas.Total;

            }
            
            
        }
        
    }
}
