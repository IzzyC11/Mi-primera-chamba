using FrutasyPostres.Entities;
using System.Collections.Generic;

namespace FrutasyPostres.Application
{
    public interface IPostresdeEcuador
    {
        List<Postre> ObtenerTodosLosPostres();
    }
}