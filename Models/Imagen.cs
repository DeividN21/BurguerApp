namespace BurguerApp.Models
{
    public class Imagen
    {
        public int ImagenId { get; set; }

        public required string Titulo { get; set; }

        public required byte[] Datos { get; set; }
    }
}
