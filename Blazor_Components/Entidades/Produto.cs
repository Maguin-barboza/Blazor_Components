using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_Components.Entidades
{
    public class Produto
    {
        public int Id { get; set; }
        public string Descrição { get; set; }
        public decimal Preço { get; set; }

        public static List<Produto> Produtos = new List<Produto>();

        public void Inserir()
        {
            this.Id = Produto.Produtos.Count + 1;
            Produto.Produtos.Add(this);
        }

        public void Remover()
        {
            Produto.Produtos.Remove(this);
        }
    }
}
