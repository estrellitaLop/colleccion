string[] colores = { "Magenta", "Rojo", "Blanco", "Azul","Cyan" };
string[] eliminar = { "Rojo", "Blanco", "Azul" };

List<string> lista = new List<string>();    
foreach (var color in colores)
{
    lista.Add(color);
}

List<string> eliminarLista = new List<string>(eliminar);

MostrarInformacion(lista);

EliminarLista(lista, eliminar);

void EliminarLista(List<string> lista, string[] eliminar)
{
  for(int i = 0; i < eliminar.Length; i++)
    {
        lista.Remove(eliminar[i]);
    }
}
MostrarInformacion(lista);

void MostrarInformacion(List<string> lista)
{
    foreach (var item in lista)
    {
        Console.WriteLine($"{item}");
    }

    //tamaño de la lista y capacidad de la lista
    Console.WriteLine($"\nTamaño = {lista.Count}" + $"{lista.Capacity}");

    int index = lista.IndexOf("Azul");
    if (index != -1)
    {
        Console.WriteLine($"la lista contiene azul en el indice {index}");

    }
    else
        Console.WriteLine("La lista no contiene Azul");
   //elimine de primera lista los colores especificados en la segunda lista 


}