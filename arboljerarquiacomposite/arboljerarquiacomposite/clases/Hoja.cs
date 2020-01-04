using System;
using System.Collections.Generic;
using System.Text;

namespace arboljerarquiacomposite.clases
{

    //la clase Hoja ya no tendría que implementar estos métodos y quedaría simplificada  de esta manera 
    public class Hoja : Componente
    {
        public Hoja(string nombre) : base(nombre)
        {
        }

        public override void Brotar(Componente componente)
        {
            throw new NotImplementedException();
        }

        public override void Cortar(Componente  componente)
        {
            throw new NotImplementedException();
        }

        public override void Pintar(int nivel)
        {
            Console.WriteLine(new String('-', nivel) + " " + Nombre);
        }
    }
}
