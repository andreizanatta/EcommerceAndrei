using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceAndrei2.Models
{
    public class Cesta
    {
        public Cesta(){}

        public List<Produto> Produtos { get; set; }
        public double PrecoTotal { get; set; }
        public string QuantidadeTotal { get; set; }
    }
}
