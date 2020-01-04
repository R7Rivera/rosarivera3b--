
using System;
using System.Collections.Generic;
using System.Text;
using arboljerarquiacomposite.clases;

namespace arboljerarquiacomposite.interfaces
{

   /* Este patrón propone que la clase Componente sea abstracta,
    * pero también sería válido utilizar una interfaz para definir Componente*/
    public interface IComponenteArbol
    {
        void Brotar(Componente componente);
        void Cortar(Componente componente);
        void Pintar(int nivel);
    }
}
