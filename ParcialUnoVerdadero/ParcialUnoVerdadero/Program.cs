using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParcialUnoVerdadero.Entidades;
using ParcialUnoVerdadero.Negocio;

namespace ParcialUnoVerdadero
{
    class Program
    {
        static void Main(string[] args)
        {
            ClsUsuario clsUsuario = new ClsUsuario();
            NClsUsuario nClsUsuario = new NClsUsuario();
            Console.WriteLine("Ingrese su usuario");
            clsUsuario.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su contraseña");
            clsUsuario.Contraseña = Console.ReadLine();
            Console.WriteLine(nClsUsuario.acceso(clsUsuario));
            Console.WriteLine(nClsUsuario.ToString());
            clsUsuario.X = 1;
            while (clsUsuario.X == 1)
            {
                ClsVentas clsVentas = new ClsVentas();
                NClsVenta nClsVenta = new NClsVenta();
                Console.WriteLine("ingrese el identificador");
                clsVentas.Idproducto = int.Parse(Console.ReadLine());
                Console.WriteLine("ingrese el nombre producto");
                clsVentas.NombreProducto=Console.ReadLine();
                Console.WriteLine("ingrese la descripcion del producto");
                clsVentas.DescripcionProducto=Console.ReadLine();
                Console.WriteLine("ingrese el precio");
                clsVentas.PrecioProducto = double.Parse(Console.ReadLine());
                Console.WriteLine("ingrese la cantidad producto");
                clsVentas.CantidadProducto = int.Parse(Console.ReadLine());

                Console.WriteLine(nClsVenta.cobro(clsVentas));
                Console.WriteLine(nClsVenta.ToString());



            }
            Console.ReadLine();
           

            


        }
    }
}
