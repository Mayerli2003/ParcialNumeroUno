using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialUnoVerdadero.Entidades
{
    class ClsUsuario
    {
        private string nombre;
        private string contraseña;
        private int x;

       // la variable x es la que me ayuda en la parte final en el ciclo while 

        public string Nombre { get => nombre; set => nombre = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public int X { get => x; set => x = value; }
    }
}

