namespace BurguerApp.Models
{
    public class Combo : Producto
    {
        public double Descuento { get; set; }

        public int CategoriaId_Combo { get; set; }

        public required int EstadoComboId { get; set; }

    }
}
