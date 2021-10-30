using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_Decorator
{
    class ArmaSecundaria : ArmaDecorator
    {

        public override string Tipo => enemigo.Tipo;

        public override string Descripcion => enemigo.Descripcion + ", preparado con un arma secundaria";

        public ArmaSecundaria(Enemigo enemigo) : base(enemigo)
        {

        }
    }
}
