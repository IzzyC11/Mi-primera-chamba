using System.Collections.Generic;
using MercaditoUTM.src.core.entities;

namespace MercaditoUTM.src2.core.application
{
    public class ConsultarProductos : IConsultarProductos
    {
        public List<Articulo> Ejecutar()
        {
            return ProductoRepositorioMemoria.ObtenerTodos();
        }
    }
}
