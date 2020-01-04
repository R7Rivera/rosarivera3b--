using System;
using Composite2.clases;

namespace Composite2
{
   // Una empresa fabrica ejes y engranajes a los que llaman referencias.Cada referencia tiene un costo de fabricación.Por ejemplo:
 /*Uno de los puntos clave del problema es que el conjunto B está formado por una referencia B2 que a su vez 
    * es un conjunto formado por otras referencias. 
   este módulo es capaz de calcular los costes de cualquier referencia    
Referencia	Costo
ProductoB	$4 
ProductoB1	$1 
ProductoB2	$2 
ProductoB21	$1 
ProductoB22	$2
CONJUNTO B
Cantidad	Referencia
1	         B
5	        B1
3	        B2 (es un conjunto)
CONJUNTO B2
Cantidad	Referencia
1	          B2
4	          B21
2	          B22
*/
    public class Program
    {
        static void Main(string[] args)
        {
            /*producto total de b es cuatro  y se compone de subproductos  b1 , b2 , b21,b22, que a la vez se componenten de otros*/
            // Intanciar la refenrecia  y los componente para que forme la jerarquia
            Referencia referenciaB = new Referencia(" PRODUCTO", costo: 4);
            Conjunto conjuntoB = new Conjunto(referenciaB);

            Referencia referenciaB1 = new Referencia("producto B1", costo: 1);
            Pieza piezaB1 = new Pieza(referenciaB1);

            Referencia referenciaB2 = new Referencia("producto B2", costo: 2);
            Conjunto conjuntoB2 = new Conjunto(referenciaB2);

            Referencia referenciaB21 = new Referencia("producto B21", costo: 1);
            Pieza piezaB21 = new Pieza(referenciaB21);

            Referencia referenciaB22 = new Referencia(" producto B22", costo: 2);
            Pieza piezaB22 = new Pieza(referenciaB22);

            conjuntoB2.Añadir(3, piezaB21);
            conjuntoB2.Añadir(2, piezaB22);

            conjuntoB.Añadir(5, piezaB1);
            conjuntoB.Añadir(3, conjuntoB2);

            //imprime el total del costo de producto b y subproductos que a su vez componente a b en una jerarquia de arbol 


            Console.WriteLine("****fabrica de ejes y engranajes**********" );
            Console.WriteLine("Coste de " + conjuntoB.Nombre + ":");
           Console.WriteLine(conjuntoB.CalcularCoste(1));
        }
    }
}