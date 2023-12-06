using BurguerApp.Models.Catalogos;

namespace BurguerApp.Utils
{
    public class ListaGenerosCliente
    {
        public List<GeneroCliente> generos = new List<GeneroCliente>()
        {
            new GeneroCliente { GeneroId = 1, Genero = "Masculino" },
            new GeneroCliente { GeneroId = 2, Genero = "Femenino" }
        };
    }
}
