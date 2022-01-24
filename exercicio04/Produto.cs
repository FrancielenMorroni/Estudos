using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio04
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }
        public double ValorFinalCompra { get; set; }
        public double ValorSemDesconto { get; set; }

        public double ValorTotal()
        {
            var valor = Quantidade * Preco;
            return valor;
        }

        public double Desconto(double valor)
        {
            var valorDesconto = valor * 15 / 100;
            var comDesconto = valor - valorDesconto;
            return comDesconto;
        }

    }
}
