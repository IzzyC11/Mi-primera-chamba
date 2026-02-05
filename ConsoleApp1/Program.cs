using System;
using System.Collections.Generic;
using System.Linq;
using FrutasyPostres.Application;
using FrutasyPostres.Entities;

Console.WriteLine("--- Consultando Frutas ---");
IConsultarFrutas consultarFrutas = new ConsultarFrutas();
List<Fruta> frutas = consultarFrutas.Ejecutar();

foreach (var fruta in frutas)
{
    Console.WriteLine($"Fruta: {fruta.Nombre}, Tipo: {fruta.Tipo}, Origen: {fruta.PaisDeOrigen}, Sabor: {fruta.Sabor}, Color: {fruta.Color}");
}

Console.WriteLine("\n--- Consultando Postres ---");
IConsultarPostres consultarPostres = new ConsultarPostres();
List<Postre> postres = consultarPostres.Ejecutar();

foreach (var postre in postres)
{
    Console.WriteLine($"Postre: {postre.Nombre}, Descripción: {postre.Descripcion}, Calorías: {postre.Calorias}, Precio: {postre.Precio:C}, Origen: {postre.PaisDeOrigen}");
    if (postre.Frutas != null && postre.Frutas.Any())
    {
        Console.WriteLine("  Frutas asociadas:");
        foreach (var frutaAsociada in postre.Frutas)
        {
            Console.WriteLine($"    - {frutaAsociada.Nombre}");
        }
    }
}

Console.WriteLine("\n--- Consultando Frutas de Noruega ---");
IFrutasdeNoruega consultarFrutasDeNoruega = new ConsultarFrutasDeNoruega();
List<Fruta> frutasNoruega = consultarFrutasDeNoruega.ObtenerTodasLasFrutas();

foreach (var fruta in frutasNoruega)
{
    Console.WriteLine($"Fruta de Noruega: Nombre: {fruta.Nombre}, Tipo: {fruta.Tipo}, Origen: {fruta.PaisDeOrigen}, Sabor: {fruta.Sabor}, Color: {fruta.Color}");
}

Console.WriteLine("\n--- Consultando Postres de Ecuador ---");
IPostresdeEcuador consultarPostresDeEcuador = new ConsultarPostresDeEcuador();
List<Postre> postresEcuador = consultarPostresDeEcuador.ObtenerTodosLosPostres();

foreach (var postre in postresEcuador)
{
    Console.WriteLine($"Postre de Ecuador: Nombre: {postre.Nombre}, Descripción: {postre.Descripcion}, Calorías: {postre.Calorias}, Precio: {postre.Precio:C}, Origen: {postre.PaisDeOrigen}");
    if (postre.Frutas != null && postre.Frutas.Any())
    {
        Console.WriteLine("  Frutas asociadas:");
        foreach (var frutaAsociada in postre.Frutas)
        {
            Console.WriteLine($"    - {frutaAsociada.Nombre}");
        }
    }
} // Added to close the foreach loop

