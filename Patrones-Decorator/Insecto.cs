using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_Decorator
{
    class Insecto : Enemigo
    {
        public override string Tipo => "insecto";

        public override string Descripcion => "Un enemigo tipo insecto";

    }
}
