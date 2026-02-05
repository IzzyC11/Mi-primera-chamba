using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrutasyPostres.Entities; // Assuming Postre is in the Entities namespace

namespace FrutasyPostres.Application
{
    public interface IConsultarPostres
    {
        List<Postre> Ejecutar(); // Returns a list of Postre and takes no parameters
    }
}