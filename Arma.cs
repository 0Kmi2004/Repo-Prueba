using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace prepo1
{
    internal class Arma
    {
        public string nombre;
        public int cant_disparos;
        public Arma() {}
        public Arma(string nombre, int cant_disparos)
        {
            this.nombre = nombre;
            this.cant_disparos = cant_disparos;
        }
    }
}
