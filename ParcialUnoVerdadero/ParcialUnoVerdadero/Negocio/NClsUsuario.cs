using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParcialUnoVerdadero.Entidades;

namespace ParcialUnoVerdadero.Negocio
{
    class NClsUsuario
    {
        ClsUsuario usuario = new ClsUsuario();
        public string acceso(ClsUsuario usuario)
        {
            
            if (usuario.Nombre == "Mayerli Azucena Montalvo" && usuario.Contraseña == "123")
            {
                usuario.X = 1;
                return usuario.Nombre + usuario.Contraseña;
            }
            else
            {
                usuario.X = 2;
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
