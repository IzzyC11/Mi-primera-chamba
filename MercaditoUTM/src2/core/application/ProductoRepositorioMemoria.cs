using System.Collections.Generic;
using MercaditoUTM.src.core.entities;

namespace MercaditoUTM.src2.core.application
{
    public static class ProductoRepositorioMemoria
    {
        public static List<Articulo> Productos { get; private set; }

        static ProductoRepositorioMemoria()
        {
            Productos = new List<Articulo>();
        }

        public static void AñadirProducto(Articulo producto)
        {
            Productos.Add(producto);
        }

        public static void AñadirProductos(IEnumerable<Articulo> productos)
        {
            Productos.AddRange(productos);
        }

        public static List<Articulo> ObtenerTodos()
        {
            return new List<Articulo>(Productos); // Return a copy to prevent external modification
        }

        public static void Clear()
        {
            Productos.Clear();
        }
    }
}
