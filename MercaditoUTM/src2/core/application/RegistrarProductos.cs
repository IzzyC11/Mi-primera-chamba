using System;
using System.Collections.Generic;
using MercaditoUTM.src.core.entities;

namespace MercaditoUTM.src2.core.application
{
    public class RegistrarProductos : IRegistrarProductos
    {
        public List<Articulo> Ejecutar()
        {
            var nuevosProductos = new List<Articulo>();
            var random = new Random();

            for (int i = 1; i <= 5; i++)
            {
                var nuevoProducto = new Articulo
                {
                    Nombre = "Nuevo Producto " + (ProductoRepositorioMemoria.Productos.Count + i),
                    Descripcion = "Descripción del nuevo producto " + (ProductoRepositorioMemoria.Productos.Count + i),
                    Marca = "Nueva Marca " + (char)('A' + random.Next(26)),
                    Modelo = "Nuevo Modelo " + random.Next(1000, 9999),
                    SKU = "SKU" + Guid.NewGuid().ToString().Substring(0, 8).ToUpper(),
                    Precio = (decimal)(random.NextDouble() * 500 + 5),
                    Stock = random.Next(1, 51)
                };
                nuevosProductos.Add(nuevoProducto);
            }
            ProductoRepositorioMemoria.AñadirProductos(nuevosProductos);
            return nuevosProductos;
        }
    }
}
