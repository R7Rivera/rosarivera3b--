using System;
using System.Collections.Generic;
using System.Text;

namespace Composite2.clases
{

    public class Conjunto : Componente
    {
        /*implementar el máximo número de operaciones en la clase Componente*/
        private readonly Referencia _referencia;
        private readonly List<Componente> _subComponentes;

        // atributos basada en  una estructura de tipo árbol
        public override string Nombre
        {
            get { return _referencia.Nombre; }
        }

        public override void Añadir(Componente componente)
        {
            _subComponentes.Add(componente);
        }

        public override void Quitar(Componente componente)
        {
            _subComponentes.Remove(componente);
        }

        public Conjunto(Referencia referencia)
        {
            _referencia = referencia;
            _subComponentes = new List<Componente>();
        }

        public void Añadir(int cantidad, Componente componente)
        {
            for (int i = 0; i < cantidad; i++)
            {
                Añadir(componente);
            }
        }

        // como toda jerarquia de aebol retorna  en este caso el costo 

        public override decimal CalcularCoste(int nivel)
        {
            decimal costo = _referencia.Costo;

            Console.WriteLine(new String('-', nivel) + " " + Nombre + ": " + costo);

            foreach (var componenteProducto in _subComponentes)
            {
                costo = costo + componenteProducto.CalcularCoste(nivel + 1);
            }

            return costo;
        }
    }
}
