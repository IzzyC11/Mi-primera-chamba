using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrutasyPostres.Entities; // Assuming Fruta is in the Entities namespace

namespace FrutasyPostres.Application
{
    public interface IConsultarFrutas
    {
        List<Fruta> Ejecutar(); // Returns a list of Fruta and takes no parameters
    }
}