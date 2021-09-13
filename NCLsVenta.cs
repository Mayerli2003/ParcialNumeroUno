using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrimerParcial.Entidades;

namespace PrimerParcial.Negocio
{
    class NCLsVenta
    {
        ClsVentas ventas = new ClsVentas();
        
         public ClsVentas  cobro(ClsVentas ventas)
        {
            ClsVentas producto1 = new ClsVentas(1,"churro", "Marca Diana", 00.50);
            ClsVentas producto2 = new ClsVentas(2, "Pan", "lilian", 1.50);
            ClsVentas producto3 = new ClsVentas(3, "agua ", "Cristal", 00.50);
            ClsVentas producto4 = new ClsVentas(4, "leche", "la vaquita", 1.00);
            Console.WriteLine("Ingrese el id del producto");
            Console.WriteLine("Productos a la venta" +
               "\n1 - Churro" +
               "\n2 - Pan" +
               "\n3 - Agua " +
               "\n4 - Lwche");
            ventas.Idproducto = int.Parse(Console.ReadLine());
           
            if (ventas.Idproducto==1)
            {
                return producto1;
            }
            else if (ventas.Idproducto == 2)
            {
                return producto2;
            }
            else if (ventas.Idproducto == 3)
            {
                return producto3;
            }
            else if (ventas.Idproducto == 4)
            {
                return producto4;

            }
            else
            {
                return null;
            }
            
        }
        public double total( ClsVentas ventas)
        {
            
            double Respuesta;
            Respuesta = ventas.PrecioProducto * ventas.CantidadProducto;
            if( Respuesta > 50)
            {
                double descuento;
                descuento = Respuesta * 0.40;
                return descuento  +  Respuesta;


            }
            else
            return Respuesta;
            

        }
        
    }
}
