using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace prepo1
{
    internal class Superheroe
    {
        public string nombre;
        public string poder;
        public Arma arma;
        public Superheroe() {}
        public Superheroe(string nombre, string poder, Arma arma)
        {
            this.nombre = nombre;
            this.poder = poder;
            this.arma = arma;
        }
        public virtual void Presentarse()
        {
            Console.WriteLine("Hola soy "+this.nombre+", mi poder es "+this.poder+" y mi arma es"+arma.nombre);
        }
    }
}
