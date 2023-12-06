namespace BurguerApp.Models
{
    public class Comida : Producto
    {
 
        public double? Precio { get; set; }

        public int? CategoriaId_Comida { get; set; }

        public required int EstadoComidaId { get; set; }
    }
}
