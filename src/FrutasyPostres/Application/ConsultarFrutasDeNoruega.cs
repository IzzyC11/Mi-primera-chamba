using FrutasyPostres.Entities;
using System.Collections.Generic;

namespace FrutasyPostres.Application
{
    public class ConsultarFrutasDeNoruega : IFrutasdeNoruega
    {
        public List<Fruta> ObtenerTodasLasFrutas()
        {
            return new List<Fruta>
            {
                new Fruta { Id = 1, Nombre = "Manzana Nordica", Tipo = "Fruta de Hueso", PaisDeOrigen = "Noruega", Sabor = "Dulce", Color = "Rojo" },
                new Fruta { Id = 2, Nombre = "Arandano Artico", Tipo = "Baya", PaisDeOrigen = "Noruega", Sabor = "Acido", Color = "Azul" }
            };
        }
    }
}