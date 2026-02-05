using System;
using System.Collections.Generic;
using System.Linq;
using FrutasyPostres.Entities; // Assuming Postre and Fruta are in the Entities namespace

namespace FrutasyPostres.Application
{
    public class ConsultarPostres : IConsultarPostres
    {
        public List<Postre> Ejecutar()
        {
            var random = new Random();

            var postres = new List<Postre>
            {
                new Postre
                {
                    Nombre = "Tarta de Manzana",
                    Descripcion = "Deliciosa tarta casera con manzanas frescas",
                    Calorias = 350,
                    Precio = 4.50m,
                    PaisDeOrigen = "Estados Unidos",
                    Frutas = new List<Fruta> {
                        new Fruta { Nombre = "Manzana", Tipo = "Fruta de árbol", PaisDeOrigen = "China", Sabor = "Dulce", Color = "Roja" }
                    }
                },
                new Postre
                {
                    Nombre = "Mousse de Chocolate",
                    Descripcion = "Ligero y cremoso mousse de chocolate oscuro",
                    Calorias = 280,
                    Precio = 3.75m,
                    PaisDeOrigen = "Francia",
                    Frutas = new List<Fruta>()
                },
                new Postre
                {
                    Nombre = "Ensalada de Frutas",
                    Descripcion = "Variedad de frutas frescas de temporada",
                    Calorias = 180,
                    Precio = 5.00m,
                    PaisDeOrigen = "México",
                    Frutas = new List<Fruta> {
                        new Fruta { Nombre = "Manzana", Tipo = "Fruta de árbol", PaisDeOrigen = "China", Sabor = "Dulce", Color = "Roja" },
                        new Fruta { Nombre = "Plátano", Tipo = "Baya", PaisDeOrigen = "Ecuador", Sabor = "Dulce", Color = "Amarillo" },
                        new Fruta { Nombre = "Naranja", Tipo = "Cítrico", PaisDeOrigen = "España", Sabor = "Ácido", Color = "Naranja" }
                    }
                },
                new Postre
                {
                    Nombre = "Flan",
                    Descripcion = "Postre tradicional a base de huevo y leche con caramelo",
                    Calorias = 220,
                    Precio = 3.00m,
                    PaisDeOrigen = "España",
                    Frutas = new List<Fruta>()
                }
            };

            return postres.OrderBy(x => random.Next()).Take(random.Next(1, postres.Count + 1)).ToList();
        }
    }
}