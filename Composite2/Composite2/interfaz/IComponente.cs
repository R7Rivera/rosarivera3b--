
using System;
using System.Collections.Generic;
using System.Text;
using Composite2.clases;

namespace Composite2.interfaz

{ 
    //define la interfaz para los objetos de la composicion ,para accedery gestionar los hijos 
     public interface IComponente
    {
        public  string Nombre { get; }

          void Añadir(IComponente componente);

         void Quitar(IComponente componente);

        decimal CalcularCoste(int nivel);
    }
}
