using FrutasyPostres.Entities;
using System.Collections.Generic;

namespace FrutasyPostres.Application
{
    public class ConsultarPostresDeEcuador : IPostresdeEcuador
    {
        public List<Postre> ObtenerTodosLosPostres()
        {
            return new List<Postre>
            {
                new Postre { Id = 1, Nombre = "Espumilla", Descripcion = "Merengue tradicional ecuatoriano", Calorias = 200, Precio = 1.50M, PaisDeOrigen = "Ecuador", Frutas = new List<Fruta> { new Fruta { Nombre = "Guayaba" } } },
                new Postre { Id = 2, Nombre = "Come y Bebe", Descripcion = "Postre de frutas con jugo de naranja", Calorias = 150, Precio = 2.00M, PaisDeOrigen = "Ecuador", Frutas = new List<Fruta> { new Fruta { Nombre = "Papaya" }, new Fruta { Nombre = "Banana" } } }
            };
        }
    }
}