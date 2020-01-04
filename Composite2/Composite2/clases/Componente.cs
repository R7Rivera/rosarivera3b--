using System;
using System.Collections.Generic;
using System.Text;
 
namespace Composite2.clases
{
    //implementa un comportamiento por defectocomun a las subclases 
    public abstract class Componente
    {
        public abstract string Nombre { get; }

        public abstract void Añadir(Componente componente);

        public abstract void Quitar(Componente componente);

        public abstract decimal CalcularCoste(int nivel);
    }
}
