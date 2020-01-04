using System;
using arboljerarquiacomposite.clases;
namespace arboljerarquiacomposite
{
    /*El patrón tiene dos responsabilidades:

Poder crear una estructura jerárquica de tipo árbol. 
Poder aplicar las mismas operaciones sobre cada uno de los
nodos de la estructura, independientemente de que sea una rama 
o una hoja.
Si estamos hablando de este patrón hay que tener muy claro 
que ambos aspectos van ligados: crear una estructura jerárquica y operar 
sobre cualquier punto de la estructura.*/
    class Program
    {
        static void Main(string[] args)
        {
              var troncoArbol = new Rama("Tronco");

                var ramaPrincipal = new Rama("Rama principal");
                ramaPrincipal.Brotar(new Hoja("Hoja1"));

                var ramaSecundaria = new Rama("Rama secundaria");
                ramaSecundaria.Brotar(new Hoja("Hoja1"));
                ramaSecundaria.Brotar(new Hoja("Hoja2"));

                var ramaConMuchasHojas = new Rama("Rama con muchas hojas");
                ramaConMuchasHojas.Brotar(new Hoja("Hoja1"));
                ramaConMuchasHojas.Brotar(new Hoja("Hoja2"));
                ramaConMuchasHojas.Brotar(new Hoja("Hoja3"));

                troncoArbol.Brotar(ramaPrincipal);
                troncoArbol.Brotar(ramaSecundaria);
                troncoArbol.Brotar(ramaConMuchasHojas);

                troncoArbol.Pintar(1);
                Console.ReadLine();
            }
        }
    }

