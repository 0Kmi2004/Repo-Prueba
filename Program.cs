using System;

namespace prepo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Superheroe[] ligaJusticia = new Superheroe[2];

            Arma arcoFlecha = new Arma("Arco y Flecha", 20);
            Arma espada = new Arma("Espada", 15);

            ligaJusticia[0] = new Superheroe("Patoruzu", "Super fuerza", espada);
            ligaJusticia[1] = new Superheroe("Ronin", "Super iq", arcoFlecha);

            foreach (Superheroe sh in ligaJusticia)
            {
                sh.Presentarse();
            }
        }
    }
}



