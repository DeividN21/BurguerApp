namespace BurguerApp.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public DateTime? FechaNacimiento { get; set; }

        public int GeneroId_Cliente { get; set; }

    }
}
