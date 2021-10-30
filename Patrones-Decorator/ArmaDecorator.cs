using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_Decorator
{
    abstract class ArmaDecorator : Enemigo
    {
        protected Enemigo enemigo;
        public ArmaDecorator(Enemigo enemigo) 
        {
            this.enemigo = enemigo;
        }
    }
}
