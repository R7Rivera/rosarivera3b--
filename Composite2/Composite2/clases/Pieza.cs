using System;
using System.Collections.Generic;
using System.Text;

namespace Composite2.clases
{
    // clase pieza hereda de la clase componente 
    public class Pieza : Componente
    {
        private readonly Referencia _referencia;

        public Pieza(Referencia referencia)
        {
            _referencia = referencia;
        }

        public override string Nombre => _referencia.Nombre;
        //componentes hijos
        public override void Añadir(Componente componente)
        {
            throw new NotImplementedException();
        }

        public override void Quitar(Componente componente)
        {
            throw new NotImplementedException();
        }
       /* metodo que calcula el costo de los productos indicando cada pieza y 
        * retornando de manera jararquica cumplindo asi una estructura de arbol */
        public override decimal CalcularCoste(int nivel)
        {
            
            Console.WriteLine(new String('-', nivel) + " Pieza: " + Nombre + " - Costo:" + _referencia.Costo);

            return _referencia.Costo;
        }
    }

}
