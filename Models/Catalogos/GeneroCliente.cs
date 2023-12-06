using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurguerApp.Models.Catalogos
{
    public class GeneroCliente
    {
        public int GeneroId { get; set; }
        
        public string Genero { get; set; }
    }
}
