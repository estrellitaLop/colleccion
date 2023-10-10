using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaColecciones
{
    public  class CollectionTest
    {
     public static void Main()
        {
            // Cree una coleccion de frutas
            Collection<string> Frutas = new Collection<string>();
            Frutas.Add("Mango");
            Frutas.Add("Manzana");
            Frutas.Add("Pera");
            Frutas.Add("Banano");

            //Imprimir la collecion

            Console.WriteLine("{0} Frutas :",Frutas.Count);
            Display(Frutas);

            //Agregar un elemento de la coleccion
            Frutas.Insert(3, "Uva");
            Display(Frutas);

            //Verificar si en la coleccion esta naranja 
            Console.WriteLine($"\nLa coleccion contiene la naranja :\n { Frutas.Contains("Naranja")}");

            // remover en el indice 2 de la coleccion
            Console.WriteLine("Se esta removiendo");

            Frutas.RemoveAt(2);
            Display(Frutas);
        }

        private static void Display(Collection<string> frutas)
        {
            Console.WriteLine();
            foreach (string item in frutas)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------");

        }
    }
}
