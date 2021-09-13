using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrimerParcial.Entidades;


namespace PrimerParcial.Negocio
{
    class NClsUsuario
    {
        ClsUsuario usuario = new ClsUsuario();
        public string  acceso(ClsUsuario usuario)
        {
            ClsUsuario Administrador = new ClsUsuario("Mayerli Azucena Montalvo ", "123");
            Console.WriteLine("Ingrese su usuario");
            usuario.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su contraseña");
            usuario.Contraseña = Console.ReadLine();
            if(usuario.Nombre== "Mayerli Azucena Montalvo" && usuario.Contraseña=="123")
            {
                return usuario.Nombre + usuario.Contraseña;
            }
            else
            {
                return "El usuario ingresado es incorrecto intentelo de nuevo ";
            }
            


        }
        public override string ToString()
        {
            return "Datos del usuario" +
               "\nUsuario: Mayerli Azucena Montalvo Martinez" +
               "\nContraseña: 123";
               

        }


    }
}
