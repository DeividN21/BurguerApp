using BurguerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurguerApp.Utils
{
    public class ListaClientes
    {
        public List<Cliente> clientes = new List<Cliente>()
        {
            new Cliente
            {
                ClienteId = 1,
                Nombre = "Christian", Apellido = "Jácome",
                FechaNacimiento = new DateTime(2003,9,29),
                GeneroId_Cliente = 1
            },
            new Cliente
            {
                ClienteId = 2,
                Nombre = "Xavier", Apellido = "Jácome",
                FechaNacimiento = new DateTime(2007,6,1),
                GeneroId_Cliente = 1
            }
        };
    }
}
