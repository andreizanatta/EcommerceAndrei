using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceAndrei2.Models
{
    public class Produto
    {
        public Produto(string nome, double preco, string imagem)
        {
            this.Nome = nome;
            this.Preco = preco;
            this.Imagem = imagem;
        }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public string Imagem { get; set; }
    }
}
