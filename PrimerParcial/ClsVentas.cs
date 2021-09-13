﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial.Entidades
{
    class ClsVentas
    {
        private int idproducto;
        private string nombreProducto;
        private string descripcionProducto;
        private double precioProducto;
        private int cantidadProducto;
        private int v1;
        private string v2;
        private string v3;
        private double v4;

        public ClsVentas() { }

        public ClsVentas(int v1, string v2, string v3, double v4)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
        }

        public ClsVentas(int idproducto, string nombreProducto, string descripcionProducto, double precioProducto, int cantidadProducto)
        {
            this.idproducto = idproducto;
            this.nombreProducto = nombreProducto;
            this.descripcionProducto = descripcionProducto;
            this.precioProducto = precioProducto;
            this.cantidadProducto = cantidadProducto;
        }

        public int Idproducto { get => idproducto; set => idproducto = value; }
        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public string DescripcionProducto { get => descripcionProducto; set => descripcionProducto = value; }
        public double PrecioProducto { get => precioProducto; set => precioProducto = value; }
        public int CantidadProducto { get => cantidadProducto; set => cantidadProducto = value; }
    }
}
