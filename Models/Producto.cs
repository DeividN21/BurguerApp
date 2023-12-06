namespace BurguerApp.Models
{
    public class Producto
    {
        public int ProductoId { get; set; }

        public required string Nombre { get; set; }

        public required string Descripcion { get; set; }
    }
}
