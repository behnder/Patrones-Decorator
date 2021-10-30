using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_Decorator
{
    class Robot : Enemigo
    {
        public override string Tipo => "Robot";

        public override string Descripcion => "Un enemigo tipo Robot";

    }
}
