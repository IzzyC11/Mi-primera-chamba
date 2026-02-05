using MercaditoUTM.src2.core.application;
using MercaditoUTM.src.core.entities;
using System;
using System.Collections.Generic;

// Clear the repository initially to ensure a clean state for this run
ProductoRepositorioMemoria.Clear();

// Add initial 25 products
var random = new Random();
for (int i = 1; i <= 25; i++)
{
    ProductoRepositorioMemoria.AñadirProducto(new Articulo
    {
        Nombre = "Producto Inicial " + i,
        Descripcion = "Descripción del producto inicial " + i,
        Marca = "Marca " + (char)('A' + random.Next(26)),
        Modelo = "Modelo " + random.Next(1000, 9999),
        SKU = "SKU" + Guid.NewGuid().ToString().Substring(0, 8).ToUpper(),
        Precio = (decimal)(random.NextDouble() * 1000 + 10),
        Stock = random.Next(0, 101)
    });
}

// 1. Instanciar el caso de uso para registrar 5 nuevos productos
IRegistrarProductos registrarProductos = new RegistrarProductos();
List<Articulo> nuevosProductosRegistrados = registrarProductos.Ejecutar();

Console.WriteLine($"Se han registrado {nuevosProductosRegistrados.Count} nuevos productos.");

// 2. Instanciar el caso de uso para consultar todos los productos
IConsultarProductos consultarProductos = new ConsultarProductos();
List<Articulo> productos = consultarProductos.Ejecutar();

// 3. Desplegar los productos en la consola
Console.WriteLine("----------- Listado de TODOS los Productos Registrados (" + productos.Count + ") -----------");
Console.WriteLine();

foreach (var producto in productos)
{
    Console.WriteLine($"Nombre:      {producto.Nombre}");
    Console.WriteLine($"Descripción: {producto.Descripcion}");
    Console.WriteLine($"Marca:       {producto.Marca}");
    Console.WriteLine($"Modelo:      {producto.Modelo}");
    Console.WriteLine($"SKU:         {producto.SKU}");
    Console.WriteLine($"Precio:      {producto.Precio:C}");
    Console.WriteLine($"Stock:       {producto.Stock}");
    Console.WriteLine("------------------------------------------------------");
}

