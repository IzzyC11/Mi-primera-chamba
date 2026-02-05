using System;
using System.Collections.Generic;
using System.Linq;
using FrutasyPostres.Entities; // Assuming Fruta is in the Entities namespace

namespace FrutasyPostres.Application
{
    public class ConsultarFrutas : IConsultarFrutas
    {
        public List<Fruta> Ejecutar()
        {
            var frutas = new List<Fruta>
            {
                new Fruta { Nombre = "Manzana", Tipo = "Fruta de árbol", PaisDeOrigen = "China", Sabor = "Dulce", Color = "Roja" },
                new Fruta { Nombre = "Plátano", Tipo = "Baya", PaisDeOrigen = "Ecuador", Sabor = "Dulce", Color = "Amarillo" },
                new Fruta { Nombre = "Naranja", Tipo = "Cítrico", PaisDeOrigen = "España", Sabor = "Ácido", Color = "Naranja" },
                new Fruta { Nombre = "Fresa", Tipo = "Fruto del bosque", PaisDeOrigen = "Estados Unidos", Sabor = "Dulce-ácido", Color = "Roja" },
                new Fruta { Nombre = "Uva", Tipo = "Baya", PaisDeOrigen = "Italia", Sabor = "Dulce", Color = "Morada" }
            };

            // Shuffle the list to make it "random" for each execution
            var random = new Random();
            return frutas.OrderBy(x => random.Next()).Take(random.Next(2, frutas.Count + 1)).ToList();
        }
    }
}