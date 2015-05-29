using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiron.LojaVirtual.Dominio.Entidades
{
    public class Produto
    {
        public int CodProduto { get; set; }
        public string Descricao { get; set; }
        public string Titulo { get; set; }
        public decimal Preco { get; set; }
        public string Categoria { get; set; }

    }
}
