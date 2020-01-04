using System;
using System.Collections.Generic;
using System.Text;

namespace Composite2.clases
{
    public class Referencia
    {

        /* cualquier referencia se puede vender por separado y además en
         cualquier momento puede formar un conjunto y venderlo como tal  en la cual definimos un constructor con 
         los atributos de nombre y costo  .*/
        public Referencia(string nombre, decimal costo)
        {
            /* Como vemos, no hace más que delegar la validación
            * a cada uno de sus “hijos” y recopilar los resultados.
              Lo bueno de esta estructura, es que ¡los hijos 
              pueden ser tanto implementaciones concretas como nuevos Composites!*/
            if (string.IsNullOrEmpty(nombre))
                throw new ArgumentException(nameof(nombre));

            if (costo  < 0)
                throw new ArgumentException(nameof(costo));

            Nombre = nombre;
            Costo = costo;
        }
        public string Nombre { get; }
        public decimal Costo { get; }
    }

}
