using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_Decorator
{
    class ArmaPrincipal : ArmaDecorator
    {

        public override string Tipo => enemigo.Tipo;

        public override string Descripcion => enemigo.Descripcion + ", preparado con un arma principal";

        public ArmaPrincipal(Enemigo enemigo) : base(enemigo)
        {

        }



    }
}
