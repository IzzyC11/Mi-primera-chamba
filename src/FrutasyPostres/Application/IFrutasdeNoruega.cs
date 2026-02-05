using FrutasyPostres.Entities;
using System.Collections.Generic;

namespace FrutasyPostres.Application
{
    public interface IFrutasdeNoruega
    {
        List<Fruta> ObtenerTodasLasFrutas();
    }
}