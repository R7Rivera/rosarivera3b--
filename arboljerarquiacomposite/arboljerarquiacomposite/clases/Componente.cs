using System;
using System.Collections.Generic;
using System.Text;

namespace arboljerarquiacomposite.clases
{
    public abstract class Componente
        /*El patrón propone implementar el máximo número de operaciones en la clase Componente,
         * de esta manera, tanto las Ramas como las Hojas que heredan de
         * Componente ya tienen un comportamiento determinado. Esto en la práctica 
         * significa que la clase Componente tiene que ser abstracta y 
         * que además tendría que implementar el máximo número de operaciones comunes de todos los tipos de componentes. */
    {
        protected Componente (string nombreComponente)
        {
            Nombre = nombreComponente;
        }

        protected string Nombre { get; }
        //Crear una estructura de tipo árbol

        public abstract void Brotar(Componente componente);
        public abstract void Cortar(Componente componente);
        //Puede  aplicar las mismas operaciones sobre cada uno de los nodos de la estructura.

        public abstract void Pintar(int nivel);
    }
}
