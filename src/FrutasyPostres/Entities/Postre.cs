using System.Collections.Generic;

namespace FrutasyPostres.Entities
{
    public class Postre
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Calorias { get; set; }
        public decimal Precio { get; set; }
        public string PaisDeOrigen { get; set; }
        public List<Fruta> Frutas { get; set; }
    }
}