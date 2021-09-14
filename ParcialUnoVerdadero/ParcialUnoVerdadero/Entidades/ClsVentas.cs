using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialUnoVerdadero.Entidades
{
    class ClsVentas
    {
        private int idproducto;
        private string nombreProducto;
        private string descripcionProducto;
        private double precioProducto;
        private int cantidadProducto;
        private double total;
        //La variable total es la que almacenara la informacion del costo del producto
       
        

        

        public int Idproducto { get => idproducto; set => idproducto = value; }
        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public string DescripcionProducto { get => descripcionProducto; set => descripcionProducto = value; }
        public double PrecioProducto { get => precioProducto; set => precioProducto = value; }
        public int CantidadProducto { get => cantidadProducto; set => cantidadProducto = value; }
        public double Total { get => total; set => total = value; }

        public override string ToString()
        {

            return "Datos de la venta " +
               "\nIdentificador:" + Idproducto +
               "\nNombre: " + NombreProducto +
               "\nDescripcion:" + DescripcionProducto +
               "\nPrecio: " + PrecioProducto +
               "\nCantidad:" +CantidadProducto +
               "\nTotal:" + Total;



        }


    }
    
    
    
    


    

}
