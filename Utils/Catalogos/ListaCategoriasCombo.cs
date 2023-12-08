using BurguerApp.Models.Catalogos;

namespace BurguerApp.Utils.Catalogos
{
    public class ListaCategoriasCombo
    {
        public List<CategoriaCombo> categoriasCombo = new List<CategoriaCombo>()
        {
            new CategoriaCombo() { CategoriaId_Combo = 1, Nombre = "Combos Familiares"},
            new CategoriaCombo() { CategoriaId_Combo = 2, Nombre = "Combos Individuales"},
            new CategoriaCombo() { CategoriaId_Combo = 3, Nombre = "Combos Infantiles"}
        };
    }
}
