using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_Decorator
{
    class Bestia : Enemigo
    {
        public override string Tipo => "Bestia";

        public override string Descripcion => "Un enemigo tipo Bestia";
    }
}
