using System;
using System.Collections.Generic;
using System.Text;

namespace arboljerarquiacomposite.clases
{
    /*La clase Rama no sufriría ningún cambio.
    Este patrón propone que la clase Componente sea abstracta, 
    pero también sería válido utilizar una interfaz para definir Componente*/

    public class Rama : Componente
    {
        private readonly List<Componente> _componentes;

        public Rama(string nombre) : base(nombre)
        {
            _componentes = new List<Componente>();
        }

        public override void Brotar(Componente componente)
        {
            _componentes.Add(componente);
        }

        public override void Cortar(Componente componente)
        {
            _componentes.Remove(componente);
        }

        public override void Pintar(int nivel)
        {
            Console.WriteLine(new String('-', nivel) + " " + Nombre);

            foreach (Componente hojaORama in _componentes)
            {
                hojaORama.Pintar(nivel + 1);
            }
        }
    }
}
