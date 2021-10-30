using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_Decorator
{
    class ArmaCuerpoACuerpo: ArmaDecorator
    {
        public override string Tipo => enemigo.Tipo;

        public override string Descripcion => enemigo.Descripcion + ", preparado con un arma cuerpo a cuerpo";

        public ArmaCuerpoACuerpo(Enemigo enemigo) : base(enemigo)
        {

        }

    }
}
