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
                return "El total es de $" + ventas.Total + " y el descuento es de $" + descuento;

            }
            else
            {
                return "El total es de $ " + ventas.Total;

            }
            
            
        }
        public override string ToString()
        {
            return "Datos de la venta " +
               "\n Identificador:"+ clsVentas.Idproducto + 
               "\nNombre: " + clsVentas.NombreProducto +
               "\nDescripcion:" + clsVentas.DescripcionProducto +
               "\nPrecio: "+ clsVentas.PrecioProducto+
               "\nCantidad:"+ clsVentas.CantidadProducto+
               "\n Total:"+clsVentas.Total;

        }

    }
}
