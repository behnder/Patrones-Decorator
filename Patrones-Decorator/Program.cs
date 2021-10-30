using System;

namespace Patrones_Decorator
{
    class Program
    {
        static void Main(string[] args)
        {

            Enemigo enemigo1 = new Bestia();
            Enemigo enemigo2 = new Insecto();
            Enemigo enemigo3 = new Robot();

            Console.WriteLine(enemigo1.Descripcion);
            Console.WriteLine(enemigo2.Descripcion);
            Console.WriteLine(enemigo3.Descripcion);

            Console.WriteLine("===============");

            ArmaDecorator enemigoConArmaPrincipal = new ArmaPrincipal(enemigo1);
            ArmaDecorator enemigoConArmaSecundaria = new ArmaSecundaria(enemigo2);
            ArmaDecorator enemigoConArmaCuerpoACuerpo = new ArmaCuerpoACuerpo(enemigo3);

            Console.WriteLine(enemigoConArmaPrincipal.Descripcion);
            Console.WriteLine(enemigoConArmaSecundaria.Descripcion);
            Console.WriteLine(enemigoConArmaCuerpoACuerpo.Descripcion);

            Console.ReadKey();




        }
    }
}
