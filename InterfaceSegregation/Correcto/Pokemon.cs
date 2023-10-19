using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSOLID.InterfaceSegregation.Correcto
{
    /*
     * De esta manera creamos dos interfaces, una contiene los movimientos que haran cualquier pokemon, y la otra 
     * contiene los movimientos de un tipo de pokemon especifico
    */

    public class Pokemon : IMovimientos
    {
        public void Atacar()
        {
            Console.WriteLine("Atacando a enemigo!");
        }

        public void Defender()
        {
            Console.WriteLine("Defendiendome del ataque");

        }
    }

    public class Pikachu : Pokemon, IPokemonElectrico
    {
        public void LanzarRayos()
        {
            Console.WriteLine("Lanzando inpactrueno");
        }
    }


    public interface IMovimientos
    {
        void Atacar();
        void Defender();

        void Dormir();
       

    }

    public interface IPokemonElectrico
    {
        void LanzarRayos();

    }
}
