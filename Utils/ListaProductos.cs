using BurguerApp.Models;

namespace BurguerApp.Utils
{
    public class ListaProductos
    {
        public List<Producto> productos = new List<Producto>();

        public ListaProductos()
        {
            productos.AddRange(new ListaComidas().listaComidas);
            productos.AddRange(new ListaCombos().listasCombos);
        }
    }
}
