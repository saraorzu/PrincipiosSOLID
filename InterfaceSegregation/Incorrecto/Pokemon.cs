using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSOLID.InterfaceSegregation.Incorrecto
{
    /*
     
     Interfaz incorrecta, ya que si instanciamos un pokemon que no lance rayos esta interfaz nos obliga 
     a instanciar un método que lanza rayosy eso no lo necesitamos

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

        public void LanzarRayos()
        {
            Console.WriteLine("Lanzando rayos a enemigo");
        }
    }


    public interface IMovimientos
    {
        void Atacar();
        void Defender();
        void LanzarRayos();

    }


}
