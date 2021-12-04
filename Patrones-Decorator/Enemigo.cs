using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_Decorator
{

    abstract class Enemigo
    {
        public abstract string Tipo { get; }
        public abstract string Descripcion { get;  }
    }
}
