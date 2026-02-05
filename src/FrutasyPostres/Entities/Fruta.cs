namespace FrutasyPostres.Entities
{
    public class Fruta
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public string PaisDeOrigen { get; set; }
        public string Sabor { get; set; }
        public string Color { get; set; }
    }
}