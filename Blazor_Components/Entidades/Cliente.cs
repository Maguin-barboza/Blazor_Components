using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_Components.Entidades
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public static List<Cliente> clientes = new List<Cliente>();

        public void Inserir()
        {
            //TODO: Terminar Inserir
            this.Id = Cliente.clientes.Count + 1;
            Cliente.clientes.Add(this);
        }

        public void Remover()
        {
            //TODO: Terminar Remover
            Cliente.clientes.Remove(this);
        }
    }
}
