using MercaditoUTM.src.core.entities;
using System.Collections.Generic;

namespace MercaditoUTM.crs.core.application
{
    public class CargarProductos
    {
        public List<Articulo> Cargar()
        {
            var productos = new List<Articulo>
            {
                new Articulo { Nombre = "Laptop Gamer", Descripcion = "Laptop para juegos de alta gama", Marca = "MarcaA", Modelo = "GamerX", SKU = "LP-GAM-001", Precio = 1500.00m, Stock = 30 },
                new Articulo { Nombre = "Mouse Inalámbrico", Descripcion = "Mouse ergonómico recargable", Marca = "MarcaB", Modelo = "MousePro", SKU = "MS-PRO-002", Precio = 45.50m, Stock = 30 },
                new Articulo { Nombre = "Teclado Mecánico", Descripcion = "Teclado con switches Cherry MX Red", Marca = "MarcaC", Modelo = "KeyMaster", SKU = "KB-MEC-003", Precio = 120.00m, Stock = 30 },
                new Articulo { Nombre = "Monitor 4K", Descripcion = "Monitor de 27 pulgadas con resolución 4K", Marca = "MarcaA", Modelo = "UltraView", SKU = "MN-4K-004", Precio = 750.00m, Stock = 30 },
                new Articulo { Nombre = "Audífonos con Micrófono", Descripcion = "Audífonos para conferencias y música", Marca = "MarcaB", Modelo = "SoundWave", SKU = "AU-MIC-005", Precio = 80.00m, Stock = 30 }
            };
            return productos;
        }
    }
}
